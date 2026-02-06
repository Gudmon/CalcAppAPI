using CalcAppAPI.Application.Services.Pdf.Util;
using CalcAppAPI.Models.Pdf;
using CalcAppAPI.Services;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CalcAppAPI.Application.Services.Pdf.Layout
{
    public class UserPdfLayout : IUserPdfLayout
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
                    row.Spacing(20);
                    row.RelativeItem(3).PaddingBottom(10).Text(name).FontFamily("Cambria").FontSize(20).Bold();
                    row.RelativeItem(2).PaddingBottom(10).Text(model?.TrailerName);
                    row.RelativeItem(2).PaddingBottom(10).Text(model?.CraneName);
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

        private void AddRow(TableDescriptor table, OptionGroup group, PdfItem item, PdfData pdf)
        {
            if (item == null)
                return;

            var display = group.GetDisplayName();

            table.Cell().PaddingBottom(15)
                .Text(display)
                .FontFamily("Cambria");

            if (group == OptionGroup.Crane)
            {
                table.Cell().PaddingBottom(15)
                    .Text($"{item?.Name}")
                    .FontFamily("Cambria");

                table.Cell().PaddingBottom(15)
                    .Text($"{item?.Price} €")
                    .FontFamily("Cambria");
            }
            else if (group == OptionGroup.Stanchion)
            {
                table.Cell().PaddingBottom(15)
                    .Text($"{pdf.TrailerName} {item?.Name}")
                    .FontFamily("Cambria");

                table.Cell().PaddingBottom(15)
                    .Text($"{item?.Price} €")
                    .FontFamily("Cambria");
            }
            else
            {
                table.Cell().PaddingBottom(15)
                    .Text($"{item?.Name}")
                    .FontFamily("Cambria");

                table.Cell().PaddingBottom(15)
                    .Text("")
                    .FontFamily("Cambria");
            }
        }
    }
}


