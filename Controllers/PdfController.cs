using CalcAppAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuestPDF.Fluent;
using Azure.Storage.Blobs;
using System;
using System.IO;
using System.Threading.Tasks;
using QuestPDF.Helpers;
using Azure.Storage.Blobs.Models;

namespace CalcAppAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PdfController : ControllerBase
    {
        private readonly ILogger<PdfController> _logger;
        private readonly DataContext _dbContext;

        public PdfController(ILogger<PdfController> logger, DataContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet("Get")]
        public async Task<ActionResult> DownloadBlobToFileAsync()
        {
            string connectionString = "DefaultEndpointsProtocol=https;AccountName=calcappblob;AccountKey=vjEzWkM+hwqSzYInXK3kq60SsFpdgVYV/9dwRsAybnCLDYV81grAQIYGrwBXq6PBA4ZDStAmJF46+AStINh/ag==;EndpointSuffix=core.windows.net";
            string blobName = "test.pdf";
            string containerName = "pdf";

            BlobClient blobClient = new BlobClient(connectionString, containerName, blobName);
            using(var stream = new MemoryStream())
            {
                await blobClient.DownloadToAsync(stream);
                var contentType = (await blobClient.GetPropertiesAsync()).Value.ContentType;

                return File(stream.ToArray(), contentType, blobClient.Name);
            }

        }

        [HttpPost]
        public async Task<ActionResult> AddEntity([FromBody] object entityRegisterModel)
        {
            var pdf = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);

                    page.Header().Text("test").SemiBold().FontSize(30);
                });
            });

            var connectionString = "DefaultEndpointsProtocol=https;AccountName=calcappblob;AccountKey=vjEzWkM+hwqSzYInXK3kq60SsFpdgVYV/9dwRsAybnCLDYV81grAQIYGrwBXq6PBA4ZDStAmJF46+AStINh/ag==;EndpointSuffix=core.windows.net";
            var containerName = "pdf";

            var container = new BlobContainerClient(connectionString, containerName);
            var blob = container.GetBlobClient("test.pdf");

            using (var stream = new MemoryStream())
            {
                pdf.GeneratePdf(stream);
                stream.Position = 0;

                await blob.UploadAsync(stream, true);
            }

            try
            {
                Console.WriteLine(entityRegisterModel);

                return Ok(new { message = "PDF created and uploaded successfully!" });
            }
            catch (Exception ex)
            {
                // log error
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred: " + ex.Message);
            }
        }
    }
}
