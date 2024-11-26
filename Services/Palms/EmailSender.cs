using MimeKit;
using MailKit.Net.Smtp;
using CalcAppAPI.Models.Email;
using Microsoft.AspNetCore.Mvc;
using CalcAppAPI.Models.Pdf;
using System.Text;

namespace CalcAppAPI.Services.Palms
{
    public class EmailSender : IEmailSender
    {
        private readonly IDealerPdfGenerator _dealerPdfGenerator;
        private readonly IUserPdfGenerator _userPdfGenerator;

        public EmailSender([FromServices] IDealerPdfGenerator dealerPdfGenerator, IUserPdfGenerator userPdfGenerator)
        {
            _dealerPdfGenerator = dealerPdfGenerator;
            _userPdfGenerator = userPdfGenerator;
        }

        public async Task SendEmailAsync(CompetitionEmail email)
        {
            string fromMail = "clearglobecalculator@gmail.com";
            string toMail = "gudmonmarcellwork@gmail.com";
            //string toMail = "info@clear-globe.com";
            string ccMail = "clearglobecalculator@gmail.com";
            string fromPassword = "lwszbrsnccpqunfe";
            var now = DateTime.UtcNow.AddHours(2).ToString("yyyy/MM/dd HH:mm");

            var emailToSend = new MimeMessage();

            emailToSend.From.Add(new MailboxAddress("", fromMail));
            emailToSend.To.Add(new MailboxAddress("Receiver Name", toMail));
            emailToSend.Cc.Add(new MailboxAddress("", ccMail));

            emailToSend.Subject = "PALMS" + " - " + email.Subject + " - " + email.FromEmail + " - " + email.Name + " - " + now;

            string formattedBody =
                $"<br/><br/>Név: {email.Name}" +
                $"<br/><br/>Telefonszám: {email.CountryCode}{email.PhoneNumber}" +
                $"<br/><br/>Email: {email.FromEmail}" +
                $"<br/><br/>Vállalkozási forma: {email.BusinessForm}" +
                $"<br/><br/>Vállalkozás helye: {email.Category}" +
                $"<br/><br/>KATA: {email.Kata}" +
                $"<br/><br/>1 lezárt üzleti év: {email.BusinessYear}" +
                $"<br/><br/>Átlagos statisztikai létszám min. 1 fő: {email.ManPower}" +
                $"<br/><br/>Árbevétel mezőgazdasági tevékenységből: {email.Revenue}";

            var multipart = new Multipart("mixed");
            multipart.Add(new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = formattedBody
            });

            var pdfGenerate = new CompetitionPdf()
            {
                BusinessForm = email.BusinessForm,
                BusinessYear = email.BusinessYear,
                Category = email.Category,
                CountryCode = email.CountryCode,
                FromEmail = email.FromEmail,
                Kata = email.Kata,
                ManPower = email.ManPower,
                Name = email.Name,
                PhoneNumber = email.PhoneNumber,
                Revenue = email.Revenue,
            };

            var fileName = email.Subject + " - " + email.Name + " - " + now;

            var pdfBytes = await _userPdfGenerator.GenerateCompetitionPdfAsync(pdfGenerate);

            if (pdfBytes != null && pdfBytes.Length > 0)
            {
                var userPdfAttachment = new MimePart("application", "pdf")
                {
                    Content = new MimeContent(new MemoryStream(pdfBytes)),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = $"{fileName}.pdf"
                };
                multipart.Add(userPdfAttachment);
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

        public async Task SendEmailAsync(Email email)
        {
            string fromMail = "clearglobecalculator@gmail.com";
            //string toMail = "gudmonmarcellwork@gmail.com";
            string toMail = "info@clear-globe.com";
            string ccMail = "clearglobecalculator@gmail.com";
            string fromPassword = "lwszbrsnccpqunfe";

            var emailToSend = new MimeMessage();

            emailToSend.From.Add(new MailboxAddress("", fromMail));
            emailToSend.To.Add(new MailboxAddress("Receiver Name", toMail));
            emailToSend.Cc.Add(new MailboxAddress("", ccMail));

            emailToSend.Subject = "PALMS" + " " + email.Subject + " - " + email.FromEmail + " - " + email.Name;

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
            //string toMail = "gudmonmarcellwork@gmail.com";
            string toMail = "info@clear-globe.com";
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
