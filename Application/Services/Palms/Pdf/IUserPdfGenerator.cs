using CalcAppAPI.Models.Pdf;

namespace CalcAppAPI.Application.Services.Palms.Pdf
{
    public interface IUserPdfGenerator
    {
        Task<string> GenerateAndSaveUserPdfAsync(PdfData pdfModel, string blobName);
        Task<byte[]> GenerateCompetitionPdfAsync(CompetitionPdf pdfModel);
        Task<byte[]> GetUserPdfAsync(string id);
    }
}
