using CalcAppAPI.Models.Pdf;

namespace CalcAppAPI.Application.Services.Krpan.Pdf
{
    public interface IKrpanUserPdfGenerator
    {
        Task<string> GenerateAndSaveUserPdfAsync(KrpanPdf pdfModel, string blobName);
        Task<byte[]> GetUserPdfAsync(string id);
    }
}
