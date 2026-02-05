using CalcAppAPI.Application.Services.Pdf.Generators;
using CalcAppAPI.Domain.Entities.Email;
using CalcAppAPI.Models.Email;
using CalcAppAPI.Models.Pdf;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Text;

namespace CalcAppAPI.Application.Services.Palms.Email
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailOptions _emailOptions;
        private readonly PhoneOptions _phoneOptions;
        private readonly IDealerPdfGenerator _dealerPdfGenerator;
        private readonly IUserPdfGenerator _userPdfGenerator;

        public EmailSender(IOptions<EmailOptions> emailOptions, IOptions<PhoneOptions> phoneOptions, [FromServices] IDealerPdfGenerator dealerPdfGenerator, IUserPdfGenerator userPdfGenerator)
        {
            _emailOptions = emailOptions.Value;
            _phoneOptions = phoneOptions.Value;
            _dealerPdfGenerator = dealerPdfGenerator;
            _userPdfGenerator = userPdfGenerator;
        }


        public async Task SendEmailAsync(EmailData email)
        {
            string fromMail = _emailOptions.FromEmailAddress;
            //string toMail = _emailOptions.ToEmailAddressTest;
            string toMail = _emailOptions.ToEmailAddress;
            string ccMail = _emailOptions.FromEmailAddress;

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
                var dealerPdfBytes = await _dealerPdfGenerator.GetPdfAsync(email.BlobName);
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

                var userPdfBytes = await _userPdfGenerator.GetPdfAsync(email.BlobName);
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

            try
            {
                using (var smtp = new SmtpClient())
                {
                    smtp.CheckCertificateRevocation = false;

                    await smtp.ConnectAsync(
                        _emailOptions.SmtpHost,
                        _emailOptions.SmtpPort,
                         MailKit.Security.SecureSocketOptions.StartTls);

                    await smtp.AuthenticateAsync(
                        _emailOptions.FromEmailAddress,
                        _emailOptions.FromEmailPw);

                    await smtp.SendAsync(emailToSend);
                    await smtp.DisconnectAsync(true);
                }
            }
            catch (Exception ex)
            {
                var phones = string.Join(" / ", _phoneOptions.PhoneNumbers);

                throw new EmailSendException(
                    header: "E-mail küldési hiba",
                    message: string.Format(
                        "Az e-mail nem került elküldésre. Kérem jelezze a megadott elérhetőségek egyikén az 'Ön azonosítója megadásával': {0} / {1}. Az Ön azonosítója: {2}",
                        _emailOptions.ToEmailAddress,
                        phones,
                        email.BlobName
                    ),
                    blobName: email.BlobName,
                    inner: ex
                );
            }

        }

        public async Task SendEmailAsync(IFormFile file)
        {
            string fromMail = _emailOptions.FromEmailAddress;
            //string toMail = _emailOptions.ToEmailAddressTest;
            string toMail = _emailOptions.ToEmailAddress;
            string ccMail = _emailOptions.FromEmailAddress;

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
                smtp.CheckCertificateRevocation = false;

                await smtp.ConnectAsync(
                    _emailOptions.SmtpHost,
                    _emailOptions.SmtpPort,
                     MailKit.Security.SecureSocketOptions.StartTls);

                await smtp.AuthenticateAsync(
                    _emailOptions.FromEmailAddress,
                    _emailOptions.FromEmailPw);

                await smtp.SendAsync(emailToSend);
                await smtp.DisconnectAsync(true);
            }
        }
    }
}
