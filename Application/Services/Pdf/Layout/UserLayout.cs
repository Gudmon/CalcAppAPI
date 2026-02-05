using CalcAppAPI.Application.Services.Pdf.Mapping;
using CalcAppAPI.Models.Pdf;
using CalcAppAPI.Services;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CalcAppAPI.Application.Services.Pdf.Layout
{
    public class UserPdfLayout : IUserPdfLayout
    {
        private readonly IPropertyDisplayNameResolver _resolver;

        public UserPdfLayout(IPropertyDisplayNameResolver resolver)
        {
            _resolver = resolver;
        }

        public void ComposeHeader(IContainer container, PdfData model, string name)
        {
            container.Background("#a32116").PaddingLeft(20).Row(row =>
            {
                row.RelativeItem().Padding(2).Column(col =>
                {
                    col.Item()
                        .Hyperlink("https://www.palmsmagyarorszag.hu")
                        .Text("PALMS").ApplyCommonTextStyle();
                });
            });
        }

        public void ComposeContent(IContainer container, PdfData model, string name)
        {
            container.Column(col =>
            {
                col.Item().Row(row =>
                {
                    row.Spacing(20);
                    row.RelativeItem(3).PaddingBottom(10).Text(name).FontFamily("Cambria").FontSize(20).Bold();
                    row.RelativeItem(2).PaddingBottom(10).Text(model?.TrailerName);
                    row.RelativeItem(2).PaddingBottom(10).Text(model?.Crane?.Name);
                    row.RelativeItem(2).PaddingBottom(10).Text(DateTime.UtcNow.AddHours(2).ToString("yyyy-MM-dd HH:mm"));
                });

                col.Item().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(2);
                        columns.RelativeColumn(5);
                        columns.RelativeColumn(1);
                    });
                    table.Header(header =>
                    {
                        header.Cell().BorderBottom(1).Text("Konfiguráció").Bold().FontFamily("Cambria");
                        header.Cell().BorderBottom(1).Text("Megnevezés").Bold().FontFamily("Cambria");
                        header.Cell().BorderBottom(1).Text("Ár").Bold().FontFamily("Cambria");
                    });

                    foreach (var property in typeof(PdfData).GetProperties())
                    {
                        var value = property.GetValue(model);

                        if (value is PdfItem item)
                            AddRow(table, property.Name, item, model);

                        if (value is IEnumerable<PdfItem> list)
                            foreach (var i in list)
                                AddRow(table, property.Name, i, model);
                    }
                });

                col.Item().PaddingVertical(5).LineHorizontal(1).LineColor(Colors.Black);

                col.Item().Row(row =>
                {
                    row.Spacing(20);
                    row.RelativeItem(3).PaddingBottom(10).Text("Összesen:").ExtraBold().FontSize(14);
                    row.RelativeItem(4).PaddingBottom(10).Text("");
                    row.RelativeItem(4).PaddingBottom(10).Text("");
                    row.RelativeItem(2).PaddingBottom(10).Text(model.TotalPrice + " €").FontFamily("Cambria").Bold().FontSize(14);
                });
            });
        }

        public void ComposeFooter(IContainer container)
        {
            container.Background("#8ac73c").Padding(20).Row(row =>
            {
                row.RelativeItem().Padding(0).Column(col =>
                {
                    col.Item()
                        .Hyperlink("https://www.clear-globe.com")
                        .Text("clear-globe").ApplyCommonTextStyle();
                });
                row.RelativeItem().AlignRight().Text(text =>
                {
                    text.CurrentPageNumber().ApplyCommonTextStyle();
                    text.Span(" / ").ApplyCommonTextStyle();
                    text.TotalPages().ApplyCommonTextStyle();
                });
            });
        }

        private void AddRow(TableDescriptor table, string propertyName, PdfItem item, PdfData pdf)
        {
            if (item == null)
                return;

            var display = _resolver.Resolve(propertyName);

            table.Cell().PaddingBottom(15).Text(display).FontFamily("Cambria");

            if (display == "Daru")
            {
                table.Cell().PaddingBottom(15).Text($"{item?.Name}").FontFamily("Cambria");
                table.Cell().PaddingBottom(15).Text($"{item?.Price} €").FontFamily("Cambria");
            }
            else if (display == "Rakonca")
            {
                table.Cell().PaddingBottom(15).Text($"{pdf.TrailerName} {item?.Name}").FontFamily("Cambria");
                table.Cell().PaddingBottom(15).Text($"{item?.Price} €").FontFamily("Cambria");
            }
            else
            {
                table.Cell().PaddingBottom(15).Text($"{item?.Name}").FontFamily("Cambria");
                table.Cell().PaddingBottom(15).Text("").FontFamily("Cambria");
            }
        }
    }
}


