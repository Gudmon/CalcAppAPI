using CalcAppAPI.Models.Pdf;

namespace CalcAppAPI.Services
{
    public interface IUserPdfGenerator
    {
        Task<string> GenerateAndSaveUserPdfAsync(Pdf pdfModel, string blobName);
        Task<byte[]> GetUserPdfAsync(string id);
    }
}
