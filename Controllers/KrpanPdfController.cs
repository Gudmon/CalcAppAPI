using CalcAppAPI.Models.Pdf;
using CalcAppAPI.Services;
using CalcAppAPI.Services.Krpan;
using CalcAppAPI.Services.Palms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalcAppAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KrpanPdfController : ControllerBase
    {
        private readonly ILogger<PdfController> _logger;
        private readonly IKrpanDealerPdfGenerator _dealerPdfGenerator;
        private readonly IKrpanUserPdfGenerator _userPdfGenerator;

        public KrpanPdfController(ILogger<PdfController> logger, [FromServices] IKrpanDealerPdfGenerator dealerPdfGenerator, [FromServices] IKrpanUserPdfGenerator userPdfGenerator)
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
        public async Task<ActionResult> AddPdf([FromBody] KrpanPdf pdfModel)
        {
            string pdfId = Util.RandomId();
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
