using CalcAppAPI.Models.Email;
using CalcAppAPI.Models.Pdf;
using CalcAppAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalcAppAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly ILogger<PdfController> _logger;
        private readonly IEmailSender _emailSender;

        public EmailController(ILogger<PdfController> logger, IEmailSender emailSender)
        {
            _logger = logger;
            _emailSender = emailSender;
        }

        [HttpPost]
        public async Task<ActionResult> SendEmail([FromBody] Email email)
        {
            try
            {
                await _emailSender.SendEmailAsync(email);
                return Ok(new { message = "Email sent succesfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during sending email");
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while sending the email.");
            }
        }

        [HttpPost("file")]
        public async Task<ActionResult> UploadDocument([FromForm] IFormFile file)
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
