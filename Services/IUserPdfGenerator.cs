using CalcAppAPI.Models.Pdf;

namespace CalcAppAPI.Services
{
    public interface IUserPdfGenerator
    {
        Task<string> GenerateAndSaveUserPdfAsync(Pdf pdfModel, int pdfId);
        Task<byte[]> GetUserPdfAsync(string id);
    }
}
