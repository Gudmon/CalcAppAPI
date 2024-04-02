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
        private readonly IPdfGenerator _dealerPdfGenerator;
        private readonly IPdfGenerator _userPdfGenerator;

        public PdfController(ILogger<PdfController> logger, [FromServices] IPdfGenerator dealerPdfGenerator, [FromServices] IPdfGenerator userPdfGenerator)
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
                var pdfBytes = await _userPdfGenerator.GetPdfAsync(id);
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
                var pdfBytes = await _dealerPdfGenerator.GetPdfAsync(id);
                return File(pdfBytes, "application/pdf", $"{id}-clear-globe.pdf");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred: " + ex.Message);
            }
        }


        [HttpPost("user")]
        public async Task<ActionResult> AddUserPdf([FromBody] Pdf pdfModel)
        {
            try
            {
                var pdfId = await _userPdfGenerator.GenerateAndSavePdfAsync(pdfModel);
                return Ok(new { id = pdfId });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error generating and saving PDF");
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while generating and saving the PDF.");
            }
        }

        [HttpPost("dealer")]
        public async Task<ActionResult> AddDealerPdf([FromBody] Pdf pdfModel)
        {
            try
            {
                var pdfId = await _dealerPdfGenerator.GenerateAndSavePdfAsync(pdfModel);
                return Ok(new { id = pdfId });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error generating and saving PDF");
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while generating and saving the PDF.");
            }
        }
    }
}