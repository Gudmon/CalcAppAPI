using CalcAppAPI.Models.Pdf;

namespace CalcAppAPI.Services
{
    public interface IPdfGenerator
    {
        Task<string> GenerateAndSavePdfAsync(Pdf pdfModel);
        Task<byte[]> GetPdfAsync(string id);
    }
}
