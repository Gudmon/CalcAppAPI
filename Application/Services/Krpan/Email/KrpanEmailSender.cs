using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using CalcAppAPI.Domain.Entities.Email;
using CalcAppAPI.Application.Services.Krpan.Pdf;

namespace CalcAppAPI.Application.Services.Krpan.Email
{
    public class KrpanEmailSender : IKrpanEmailSender
    {
        private readonly IKrpanDealerPdfGenerator _dealerPdfGenerator;
        private readonly IKrpanUserPdfGenerator _userPdfGenerator;

        public KrpanEmailSender([FromServices] IKrpanDealerPdfGenerator dealerPdfGenerator, IKrpanUserPdfGenerator userPdfGenerator)
        {
            _dealerPdfGenerator = dealerPdfGenerator;
            _userPdfGenerator = userPdfGenerator;
        }

        public async Task SendEmailAsync(EmailData email)
        {
            string fromMail = "clearglobecalculator@gmail.com";
            string toMail = "gudmonmarcellwork@gmail.com";
            //string toMail = "info@clear-globe.com";
            string ccMail = "clearglobecalculator@gmail.com";
            string fromPassword = "lwszbrsnccpqunfe";

            var emailToSend = new MimeMessage();

            emailToSend.From.Add(new MailboxAddress("", fromMail));
            emailToSend.To.Add(new MailboxAddress("Receiver Name", toMail));
            emailToSend.Cc.Add(new MailboxAddress("", ccMail));

            emailToSend.Subject = "KRPAN" + " " + email.Subject + " - " + email.FromEmail + " - " + email.Name;

            string formattedBody = $"{email.Body}" +
                $"<br/><br/>Név: {email.Name}" +
                $"<br/><br/>Telefonszám: {email.CountryCode}{email.PhoneNumber}" +
                $"<br/><br/>Email: {email.FromEmail}";

            var multipart = new Multipart("mixed");
            multipart.Add(new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = formattedBody
            });

            if (!string.IsNullOrEmpty(email.BlobName))
            {
                var dealerPdfBytes = await _dealerPdfGenerator.GetDealerPdfAsync(email.BlobName);
                if (dealerPdfBytes != null)
                {
                    var dealerPdfAttachment = new MimePart("application", "pdf")
                    {
                        Content = new MimeContent(new MemoryStream(dealerPdfBytes)),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = $"{email.BlobName}-clear-globe.pdf"
                    };
                    multipart.Add(dealerPdfAttachment);
                }

                var userPdfBytes = await _userPdfGenerator.GetUserPdfAsync(email.BlobName);
                if (userPdfBytes != null)
                {
                    var userPdfAttachment = new MimePart("application", "pdf")
                    {
                        Content = new MimeContent(new MemoryStream(userPdfBytes)),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = $"{email.BlobName}.pdf"
                    };
                    multipart.Add(userPdfAttachment);
                }
            }

            emailToSend.Body = multipart;

            using (var smtp = new SmtpClient())
            {
                await smtp.ConnectAsync("smtp.gmail.com", 587, false);
                await smtp.AuthenticateAsync(fromMail, fromPassword);

                await smtp.SendAsync(emailToSend);
                await smtp.DisconnectAsync(true);
            }
        }

        public async Task SendEmailAsync(IFormFile file)
        {
            string fromMail = "clearglobecalculator@gmail.com";
            string toMail = "gudmonmarcellwork@gmail.com";
            //string toMail = "info@clear-globe.com";
            string ccMail = "clearglobecalculator@gmail.com";
            string fromPassword = "lwszbrsnccpqunfe";

            var emailToSend = new MimeMessage();

            emailToSend.From.Add(new MailboxAddress("", fromMail));
            emailToSend.To.Add(new MailboxAddress("Receiver Name", toMail));
            emailToSend.Cc.Add(new MailboxAddress("", ccMail));

            emailToSend.Subject = "ÁTK e-mail";

            var multipart = new Multipart("mixed");
            multipart.Add(new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = ""
            });

            if (file != null && file.Length > 0)
            {
                var memoryStream = new MemoryStream();
                await file.CopyToAsync(memoryStream);
                memoryStream.Position = 0;

                var fileAttachment = new MimePart(file.ContentType)
                {
                    Content = new MimeContent(memoryStream),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = file.FileName
                };
                multipart.Add(fileAttachment);
            }

            emailToSend.Body = multipart;

            using (var smtp = new SmtpClient())
            {
                await smtp.ConnectAsync("smtp.gmail.com", 587, false);
                await smtp.AuthenticateAsync(fromMail, fromPassword);
                await smtp.SendAsync(emailToSend);
                await smtp.DisconnectAsync(true);
            }
        }
    }
}
