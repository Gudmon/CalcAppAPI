using CalcAppAPI.Application.Services.Pdf.Layout;
using CalcAppAPI.Application.Services.Pdf.Util;
using CalcAppAPI.Models.Pdf;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

public class DealerPdfLayout : IDealerPdfLayout
{
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
                row.RelativeItem(2).Text(model?.CraneName);
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

                foreach (var single in model.SingleOptions)
                {
                    AddRow(table, single.Group, single.Option, model);

                }

                foreach (var multi in model.MultipleOptions)
                {
                    foreach (var item in multi.Options)
                    {
                        AddRow(table, multi.Group, item, model);
                    }
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

    private void AddRow(TableDescriptor table, OptionGroup group, PdfItem item, PdfData pdf)
{
    if (item == null)
        return;

    var display = group.GetDisplayName();

    // Konfiguráció
    table.Cell().PaddingBottom(10)
        .AlignTop()
        .Text(display)
        .FontFamily("Cambria");

    // Megnevezés
    table.Cell().PaddingBottom(10)
        .AlignTop()
        .Text(group == OptionGroup.Stanchion
            ? $"{pdf.TrailerName} {item.Name}"
            : item.Name)
        .FontFamily("Cambria");

    // Kód
    table.Cell().PaddingBottom(10)
        .AlignTop()
        .Text(item.Code ?? "")
        .FontFamily("Cambria");

    // Ár
    table.Cell().PaddingBottom(10)
        .AlignTop()
        .Text(group == OptionGroup.Stanchion || group == OptionGroup.Crane
            ? $"{item.Price} €"
            : "")
        .FontFamily("Cambria");
}

}


