using CalcAppAPI.Models.Pdf;

namespace CalcAppAPI.Services.Krpan
{
    public interface IKrpanDealerPdfGenerator
    {
        Task<string> GenerateAndSaveDealerPdfAsync(KrpanPdf pdfModel, string blobName);
        Task<byte[]> GetDealerPdfAsync(string id);
    }
}
