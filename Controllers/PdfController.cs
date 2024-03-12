using CalcAppAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Azure.Storage.Blobs;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using CalcAppAPI.Models.Pdf;
using System;
using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;
using CalcAppAPI.Services;


namespace CalcAppAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PdfController : ControllerBase
    {
        private readonly ILogger<PdfController> _logger;
        private readonly IPdfGenerator _pdfGenerator;

        public PdfController(ILogger<PdfController> logger, IPdfGenerator pdfGenerator)
        {
            _logger = logger;
            _pdfGenerator = pdfGenerator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetPdf(string id)
        {
            try
            {
                var pdfBytes = await _pdfGenerator.GetPdfAsync(id);
                return File(pdfBytes, "application/pdf", $"{id}.pdf");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred: " + ex.Message);
            }
        }


        [HttpPost]
        public async Task<ActionResult> AddPdf([FromBody] Pdf pdfModel)
        {
            try
            {
                var pdfId = await _pdfGenerator.GenerateAndSavePdfAsync(pdfModel);
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