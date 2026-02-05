using CalcAppAPI.Application.Services.Pdf.Layout;
using CalcAppAPI.Application.Services.Pdf.Mapping;
using CalcAppAPI.Models.Pdf;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

public class DealerPdfLayout : IDealerPdfLayout
{
    private readonly IPropertyDisplayNameResolver _resolver;

    public DealerPdfLayout(IPropertyDisplayNameResolver resolver)
    {
        _resolver = resolver;
    }

    public void ComposeHeader(IContainer container, PdfData model, string name)
    {
        container
            .Background("#a32116")
            .PaddingLeft(20)
            .Text("PALMS")
            .FontColor(Colors.White)
            .Bold();
    }

    public void ComposeContent(IContainer container, PdfData model, string name)
    {
        container.Column(col =>
        {
            col.Item().Row(row =>
            {
                row.RelativeItem(3).Text(name).FontSize(20).Bold();
                row.RelativeItem(2).Text(model?.TrailerName);
                row.RelativeItem(2).Text(model?.Crane?.Name);
                row.RelativeItem(2).Text(DateTime.UtcNow.AddHours(2).ToString("yyyy-MM-dd HH:mm"));
            });

            col.Item().Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(2);
                    columns.RelativeColumn(4);
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

            col.Item().LineHorizontal(1);

            col.Item().Row(row =>
            {
                row.RelativeItem(7).Text("Összesen:").Bold();
                row.RelativeItem(1).Text($"{model.TotalPrice} €").Bold();
            });
        });
    }

    public void ComposeFooter(IContainer container)
    {
        container
            .Background("#8ac73c")
            .Padding(20)
            .AlignRight()
            .Text(text =>
            {
                text.CurrentPageNumber();
                text.Span(" / ");
                text.TotalPages();
            });
    }

    private void AddRow(TableDescriptor table, string propertyName, PdfItem item, PdfData pdf)
    {
        var display = _resolver.Resolve(propertyName);

        table.Cell().PaddingBottom(10).Text(display);

        if (display == "Rakonca")
            table.Cell().PaddingBottom(10).Text($"{pdf.TrailerName} {item.Name}");
        else
            table.Cell().PaddingBottom(10).Text(item.Name);

        table.Cell().PaddingBottom(10).Text(item.Code);
        table.Cell().PaddingBottom(10).Text($"{item.Price} €");
    }
}


