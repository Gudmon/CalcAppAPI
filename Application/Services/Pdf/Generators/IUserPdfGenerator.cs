using CalcAppAPI.Models.Pdf;

namespace CalcAppAPI.Application.Services.Pdf.Generators
{
    public interface IUserPdfGenerator
    {
        Task<string> GenerateAndSavePdfAsync(PdfData pdfModel, string blobName);
        Task<byte[]> GetPdfAsync(string id);
    }
}
