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

        public EmailSender([FromServices] IDealerPdfGenerator dealerPdfGenerator)
        {
            _dealerPdfGenerator = dealerPdfGenerator;
        }
        public async Task SendEmailAsync(Email email)
        {
            string fromMail = "clearglobecalculator@gmail.com";
            //string toMail = "info@clear-globe.com";
            string toMail = "gudmonmarcellwork@gmail.com";
            string ccMail = "clearglobecalculator@gmail.com";
            string fromPassword = "lwszbrsnccpqunfe";

            var emailToSend = new MimeMessage();

            emailToSend.From.Add(new MailboxAddress("", fromMail));
            emailToSend.To.Add(new MailboxAddress("Receiver Name", toMail));
            emailToSend.Cc.Add(new MimeKit.MailboxAddress("", ccMail));

            emailToSend.Subject = email.Subject + " - " + email.FromEmail;

            string formattedBody = $"{email.Body}<br/><br/>Név: {email.Name}";
            emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = formattedBody
            };

            var multipart = new Multipart("mixed");
            multipart.Add(emailToSend.Body);

            if (!string.IsNullOrEmpty(email.BlobName))
            {
                var pdfBytes = await _dealerPdfGenerator.GetDealerPdfAsync(email.BlobName);
                if (pdfBytes != null)
                {
                    var pdfAttachment = new MimePart("application", "pdf")
                    {
                        Content = new MimeContent(new MemoryStream(pdfBytes)),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = $"{email.BlobName}-clear-globe.pdf"
                    };
                    multipart.Add(pdfAttachment);
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