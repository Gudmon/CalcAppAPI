using CalcAppAPI.Models.Email;
using CalcAppAPI.Services.Krpan;
using Microsoft.AspNetCore.Mvc;

namespace CalcAppAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KrpanEmailController : ControllerBase
    {
        private readonly ILogger<KrpanEmailController> _logger;
        private readonly IKrpanEmailSender _emailSender;

        public KrpanEmailController(ILogger<KrpanEmailController> logger, IKrpanEmailSender emailSender)
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
