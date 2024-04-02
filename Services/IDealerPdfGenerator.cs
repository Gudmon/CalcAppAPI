using CalcAppAPI.Models.Pdf;

namespace CalcAppAPI.Services
{
    public interface IDealerPdfGenerator
    {
        Task<string> GenerateAndSaveDealerPdfAsync(Pdf pdfModel, int pdfId);
        Task<byte[]> GetDealerPdfAsync(string id);
    }
}
