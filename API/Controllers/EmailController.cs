
using CalcAppAPI.Application.Services.Palms.Email;
using CalcAppAPI.Domain.Entities.Email;
using Microsoft.AspNetCore.Mvc;

namespace CalcAppAPI.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly ILogger<EmailController> _logger;
        private readonly IEmailSender _emailSender;

        public EmailController(ILogger<EmailController> logger, IEmailSender emailSender)
        {
            _logger = logger;
            _emailSender = emailSender;
        }

        [HttpPost]
        public async Task<ActionResult> SendEmail([FromBody] EmailData email, CancellationToken cancellationToken)
        {
            try
            {
                await _emailSender.SendDealerEmailAsync(email, cancellationToken);
                await _emailSender.SendUserEmailAsync(email, cancellationToken);

                return Ok(new { message = "Emails sent successfully" });
            }
            catch (EmailSendException ex)
            {
                _logger.LogError(
                    ex,
                    "Email sending failed. BlobName: {BlobName}",
                    ex.BlobName
                );

                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new
                    {
                        header = ex.Header,
                        message = ex.Message,
                        blobName = ex.BlobName
                    }
                );
            }
        }
    }
}
