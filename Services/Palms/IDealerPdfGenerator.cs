using CalcAppAPI.Models.Pdf;

namespace CalcAppAPI.Services.Palms
{
    public interface IDealerPdfGenerator
    {
        Task<string> GenerateAndSaveDealerPdfAsync(Pdf pdfModel, string blobName);
        Task<byte[]> GetDealerPdfAsync(string id);
    }
}
