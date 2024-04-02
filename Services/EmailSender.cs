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
            string toMail = "gudmonmarcellwork@gmail.com";
            string fromPassword = "lwszbrsnccpqunfe";

            var emailToSend = new MimeMessage();

            emailToSend.From.Add(new MailboxAddress("", fromMail));
            emailToSend.To.Add(new MailboxAddress("Receiver Name", toMail));

            emailToSend.Subject = email.Subject;
            emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = email.Body
            };

            var pdfAttachment = new MimePart("application", "pdf")
            {
                Content = new MimeContent(new MemoryStream(await _dealerPdfGenerator.GetDealerPdfAsync($"{email.BlobName}-clear-globe.pdf"))),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = $"{email.BlobName}-clear-globe.pdf"
            };

            var multipart = new Multipart("mixed");
            multipart.Add(emailToSend.Body);
            multipart.Add(pdfAttachment);

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