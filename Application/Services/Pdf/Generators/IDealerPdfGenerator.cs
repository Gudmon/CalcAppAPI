using CalcAppAPI.Models.Pdf;

namespace CalcAppAPI.Application.Services.Pdf.Generators
{
    public interface IDealerPdfGenerator
    {
        Task<string> GenerateAndSavePdfAsync(PdfData pdfModel, string blobName);
        Task<byte[]> GetPdfAsync(string id);
    }
}
