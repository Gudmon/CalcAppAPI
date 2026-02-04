using CalcAppAPI.Models.Pdf;

namespace CalcAppAPI.Application.Services.Palms.Pdf
{
    public interface IDealerPdfGenerator
    {
        Task<string> GenerateAndSaveDealerPdfAsync(PdfData pdfModel, string blobName);
        Task<byte[]> GetDealerPdfAsync(string id);
    }
}
