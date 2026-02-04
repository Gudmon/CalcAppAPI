using CalcAppAPI.Models.Pdf;

namespace CalcAppAPI.Application.Services.Krpan.Pdf
{
    public interface IKrpanDealerPdfGenerator
    {
        Task<string> GenerateAndSaveDealerPdfAsync(KrpanPdf pdfModel, string blobName);
        Task<byte[]> GetDealerPdfAsync(string id);
    }
}
