using CalcAppAPI.Models.Pdf;

namespace CalcAppAPI.Services.Palms
{
    public interface IUserPdfGenerator
    {
        Task<string> GenerateAndSaveUserPdfAsync(Pdf pdfModel, string blobName);
        Task<byte[]> GenerateCompetitionPdfAsync(CompetitionPdf pdfModel);
        Task<byte[]> GetUserPdfAsync(string id);
    }
}
