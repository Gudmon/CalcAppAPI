using CalcAppAPI.Application.Services.Pdf;
using CalcAppAPI.Application.Services.Pdf.Generators;
using CalcAppAPI.Application.Services.Pdf.Layout;
using CalcAppAPI.Models.Pdf;
using QuestPDF.Fluent;

public class DealerPdfGenerator : IDealerPdfGenerator
{
    private const string ContainerName = "pdf";

    private readonly IBlobStorageService _blobService;
    private readonly IDealerPdfLayout _layout;

    public DealerPdfGenerator(
        IBlobStorageService blobService,
        IDealerPdfLayout layout)
    {
        _blobService = blobService;
        _layout = layout;
    }

    public async Task<string> GenerateAndSavePdfAsync(PdfData model, string name)
    {
        var document = Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Header().Element(c => _layout.ComposeHeader(c, model, name));
                page.Content().Padding(20).Element(c => _layout.ComposeContent(c, model, name));
                page.Footer().Element(c => _layout.ComposeFooter(c));
            });
        });

        using var stream = new MemoryStream();
        document.GeneratePdf(stream);

        await _blobService.UploadAsync(
            ContainerName,
            $"{name}-clear-globe.pdf",
            stream);

        return name;
    }

    public async Task<byte[]> GetPdfAsync(string id)
    {
        return await _blobService.DownloadAsync(
            ContainerName,
            $"{id}-clear-globe.pdf");
    }
}
