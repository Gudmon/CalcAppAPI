
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
        public async Task<ActionResult> SendEmail([FromBody] EmailData email)
        {
            try
            {
                await _emailSender.SendEmailAsync(email);
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

        [HttpPost("file")]
        [Consumes("multipart/form-data")]
        public async Task<ActionResult> UploadDocument(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest(new { message = "The file field is required." });
            }

            try
            {
                await _emailSender.SendEmailAsync(file);
                return Ok(new { message = "Email sent successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during sending email");
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while sending the email.");
            }
        }
    }
}
