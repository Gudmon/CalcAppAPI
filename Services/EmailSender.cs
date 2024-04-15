using System.IO;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using CalcAppAPI.Models.Email;
using Microsoft.AspNetCore.Mvc;

namespace CalcAppAPI.Services
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

            emailToSend.Subject = email.Subject + " - " + email.FromEmail;

            string formattedBody = $"{email.Body}<br/><br/>Név: {email.Name}";

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
    }
}
