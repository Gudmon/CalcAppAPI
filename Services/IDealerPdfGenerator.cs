using CalcAppAPI.Models.Pdf;

namespace CalcAppAPI.Services
{
    public interface IDealerPdfGenerator
    {
        Task<string> GenerateAndSaveDealerPdfAsync(Pdf pdfModel, string blobName);
        Task<byte[]> GetDealerPdfAsync(string id);
    }
}
