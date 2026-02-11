
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
                await _emailSender.SendEmailAsync(email, cancellationToken);
                return Ok(new { message = "Email sent succesfully" });
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
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error during email sending");
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new
                    {
                        header = "Ismeretlen hiba",
                        message = "Váratlan hiba történt. Kérjük, próbálja meg később."
                    }
                );
            }
        }
    }
}
