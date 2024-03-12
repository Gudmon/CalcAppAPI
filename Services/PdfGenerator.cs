using Azure.Storage.Blobs;
using CalcAppAPI.Models.Pdf;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace CalcAppAPI.Services
{
    public class PdfGenerator : IPdfGenerator
    {
        private const string _connectionString = "DefaultEndpointsProtocol=https;AccountName=calcappblob;AccountKey=vjEzWkM+hwqSzYInXK3kq60SsFpdgVYV/9dwRsAybnCLDYV81grAQIYGrwBXq6PBA4ZDStAmJF46+AStINh/ag==;EndpointSuffix=core.windows.net";
        private const string _containerName = "pdf";


        public async Task<string> GenerateAndSavePdfAsync(Pdf pdfModel)
        {
            var pdf = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Header().Element(ComposeHeader);
                    page.Content().Padding(20).Element(c => ComposeContent(c, pdfModel));
                    page.Footer().Element(ComposeFooter);
                });
            });

            var container = new BlobContainerClient(_connectionString, _containerName);
            var blobName = $"{ExtensionMethods.RandomId()}";
            var blob = container.GetBlobClient($"{blobName}.pdf");

            using (var stream = new MemoryStream())
            {
                pdf.GeneratePdf(stream);
                stream.Position = 0;

                await blob.UploadAsync(stream, true);
            }

            return blobName;
        }

        public async Task<byte[]> GetPdfAsync(string id)
        {
            var blobClient = new BlobClient(_connectionString, _containerName, $"{id}.pdf");

            using (var stream = new MemoryStream())
            {
                await blobClient.DownloadToAsync(stream);
                return stream.ToArray();
            }
        }

        void ComposeHeader(IContainer container)
        {
            container.Column(col =>
            {
                col.Item().Text("asd");
            });
        }
        void ComposeContent(IContainer container, Pdf pdfModel)
        {
            container.Column(col =>
            {
                col.Item().Text("Some text");
                col.Item().Text("Some text");
                col.Item().Text(string.Empty);
                col.Item().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(1);
                        columns.RelativeColumn(1);
                        columns.RelativeColumn(1);
                        columns.RelativeColumn(1);
                    });
                    table.Header(header =>
                    {
                        header.Cell().BorderBottom(1).Text("Konfiguráció").Bold();
                        header.Cell().BorderBottom(1).Text("Megnevezés").Bold();
                        header.Cell().BorderBottom(1).Text("Kód").Bold();
                        header.Cell().BorderBottom(1).Text("Ár").Bold();
                    });
                    table.Cell().Text("Rakonca");
                    table.Cell().Text($"{pdfModel.Stanchion?.Name}");
                    table.Cell().Text($"{pdfModel.Stanchion?.Code}");
                    table.Cell().Text(pdfModel.Stanchion?.Price != null ? $"{pdfModel.Stanchion.Price} €" : "");

                });
                col.Item().Text(string.Empty);
                col.Item().Text("And more text");
            });
        }
        void ComposeFooter(IContainer container)
        {
            container.Background("#4a8afd").Padding(20).Row(row =>
            {
                row.RelativeItem().Padding(0).Column(col =>
                {
                    col.Item()
                        .Hyperlink("https://bjdejongblog.nl")
                        .Text("bjdejongblog.nl").ApplyCommonTextStyle();
                });
                row.RelativeItem().AlignRight().Text(text =>
                {
                    text.CurrentPageNumber().ApplyCommonTextStyle();
                    text.Span(" / ").ApplyCommonTextStyle();
                    text.TotalPages().ApplyCommonTextStyle();
                });
            });
        }
    }

 }

public static class ExtensionMethods
{
    public static TextSpanDescriptor ApplyCommonTextStyle(this TextSpanDescriptor desc)
    {
        return desc.FontColor("#ffffff").Bold().FontSize(20);
    }
    public static int RandomId()
    {
        Random rand = new Random();
        return rand.Next(100000, 999999);
    }
}
