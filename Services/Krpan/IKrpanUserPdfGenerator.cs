using CalcAppAPI.Models.Pdf;

namespace CalcAppAPI.Services.Krpan
{
    public interface IKrpanUserPdfGenerator
    {
        Task<string> GenerateAndSaveUserPdfAsync(KrpanPdf pdfModel, string blobName);
        Task<byte[]> GetUserPdfAsync(string id);
    }
}
