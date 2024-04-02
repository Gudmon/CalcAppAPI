using Microsoft.AspNetCore.Mvc;
using CalcAppAPI.Models.Pdf;
using CalcAppAPI.Services;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace CalcAppAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PdfController : ControllerBase
    {
        private readonly ILogger<PdfController> _logger;
        private readonly IDealerPdfGenerator _dealerPdfGenerator;
        private readonly IUserPdfGenerator _userPdfGenerator;

        public PdfController(ILogger<PdfController> logger, [FromServices] IDealerPdfGenerator dealerPdfGenerator, [FromServices] IUserPdfGenerator userPdfGenerator)
        {
            _logger = logger;
            _dealerPdfGenerator = dealerPdfGenerator;
            _userPdfGenerator = userPdfGenerator;
        }

        [HttpGet("user/{id}")]
        public async Task<ActionResult> GetUserPdf(string id)
        {
            try
            {
                var pdfBytes = await _userPdfGenerator.GetUserPdfAsync(id);
                return File(pdfBytes, "application/pdf", $"{id}.pdf");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred: " + ex.Message);
            }
        }

        [HttpGet("dealer/{id}")]
        public async Task<ActionResult> GetDealerPdf(string id)
        {
            try
            {
                var pdfBytes = await _dealerPdfGenerator.GetDealerPdfAsync(id);
                return File(pdfBytes, "application/pdf", $"{id}-clear-globe.pdf");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred: " + ex.Message);
            }
        }


        [HttpPost]
        public async Task<ActionResult> AddPdf([FromBody] Pdf pdfModel)
        {
            int pdfId = Util.RandomId();
            try
            {
                await _dealerPdfGenerator.GenerateAndSaveDealerPdfAsync(pdfModel, pdfId);
                await _userPdfGenerator.GenerateAndSaveUserPdfAsync(pdfModel, pdfId);
                return Ok(new { id = pdfId });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error generating and saving user PDF");
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while generating and saving the user PDF.");
            }
        }
    }
}