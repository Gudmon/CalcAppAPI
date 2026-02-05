using Azure.Storage.Blobs;
using CalcAppAPI.Models.Pdf;
using CalcAppAPI.Services;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CalcAppAPI.Application.Services.Krpan.Pdf
{
    //TODO: Refactor
    public class KrpanUserPdfGenerator : IKrpanUserPdfGenerator
    {
        private string _connectionString = "";
        private const string _containerName = "krpan";

        private static readonly Dictionary<string, string> PropertyDisplayNameMapping = new Dictionary<string, string>
        {
            { "ExtraStanchion", "Extra rakonca" },
            { "ExtraForwarderStanchion", "Extra forwarder rakonca" },
            { "HydraulicAdjustableChassis", "Hidraulikusan állítható futómű" },
            { "Lamp", "Lámpa" },
            { "Chock", "Ékek" },
            { "DrawbarSteering", "Vonórúd kormányzás" },
            { "SupportLeg", "Kitámasztó láb" },
            { "Tyre", "Kerék" },
            { "Brake", "Fék" },
            { "HandBrake", "Kézifék" },
            { "Propulsion", "Meghajtás" },
            { "AdjustableDrive", "Proporcionálisan állítható meghajtás" },
            { "TopConnection", "Felső csatlakozás" },
            { "Clutch", "Tengelykapcsoló" },
            { "DrawHead", "Vonófej" },
            { "DrawBar", "Vonórúd" },
            { "CardanShaft", "Kardántengely" },
            { "BBox", "Biomasszás vájú" },
            { "BaleTransportPlatform", "Platform bálaszállításhoz" },
            { "CargoSpaceExtension", "Raktér hosszabbítás" },
            { "AxeHolder", "Csákány és fejsze tartó" },
            { "ChainsawHolder", "Motorfűrész tartó" },
            { "FueltankHolder", "Üzemanyagtartály tartó" },
            { "ToolBox", "Szerszámos láda" },
            { "Plato", "Plató" },
            { "Extension", "Hosszabbítás" },
            { "HydraulicSupportLeg", "Hidraulikus támasztóláb" },
            { "GrappleLocation", "Kanál helye" },

            { "TrailerShipping", "Szállítás" },
            { "MOT", "Műszaki vizsga" },


            { "Crane", "Daru" },
            { "ControlBlock", "Vezértömb" },
            { "FrameType", "Talpaló" },
            { "Rotator", "Rotátor" },
            { "Grapple", "Kanál" },
            { "Grapples", "Kanál" },
            { "Winch", "Csörlő" },
            { "ProtectionSleeves", "Védőhüvely" },
            { "ElectricalFloating", "Úszó pozíció" },
            { "ValveBlock", "Vezértömb főgémhez" },
            { "Damping", "Csillapító" },
            { "CraneLight", "LED munkalámpák" },
            { "OperatorSeat", "Kezelő ülés" },
            { "CraneOilCooler", "Olajhűtő eleketromos csatlakozással" },
            { "RotatorBrake", "Rotátor fék" },
            { "JoystickHolder", "Joystick tartó" },
            { "HoseGuard", "Tömlő védő" },
            { "TurningDeviceCounterPlate", "Fedőlap fordító szerkezethez" },
            { "SupportLegCounterPlate", "Fedőlap talpaló lábhoz" },
            { "BoomGuard", "Főgém védő" },
            { "Cover", "Védőhuzat" },
            { "WoodControl", "Fás kiegészítő" },
            { "Linkage", "Csatlakozó adapter" },
            { "CraneShipping", "Szállítás" },
        };

        public async Task<string> GenerateAndSaveUserPdfAsync(KrpanPdf pdfModel, string blobName)
        {
            var pdf = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Header().Element(ComposeHeader);
                    page.Content().Padding(20).Element(c => ComposeContent(c, pdfModel, blobName));
                    page.Footer().Element(ComposeFooter);
                });
            });

            var container = new BlobContainerClient(_connectionString, _containerName);
            var blob = container.GetBlobClient($"{blobName}.pdf");

            using (var stream = new MemoryStream())
            {
                pdf.GeneratePdf(stream);
                stream.Position = 0;

                await blob.UploadAsync(stream, true);
            }

            return blobName;
        }

        public async Task<byte[]> GetUserPdfAsync(string id)
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
            container.Background("#e60005").PaddingLeft(20).Row(row =>
            {
                row.RelativeItem().Padding(2).Column(col =>
                {
                    col.Item()
                        .Hyperlink("https://victorious-island-03de76e03.5.azurestaticapps.net")
                        .Text("KRPAN").ApplyCommonTextStyle();
                });
            });
        }

        void ComposeContent(IContainer container, KrpanPdf pdfModel, string blobName)
        {
            container.Column(col =>
            {
                col.Item().Row(row =>
                {
                    row.Spacing(20);
                    row.RelativeItem(3).PaddingBottom(10).Text(blobName).FontFamily("Cambria").FontSize(20).Bold();
                    row.RelativeItem(2).PaddingBottom(10).Text(pdfModel?.TrailerName);
                    row.RelativeItem(2).PaddingBottom(10).Text(pdfModel?.Crane?.Name);
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

                    foreach (var property in typeof(KrpanPdf).GetProperties())
                    {
                        var propertyValue = property.GetValue(pdfModel);

                        if (propertyValue is PdfItem pdfItem)
                        {
                            MapAndAddRow(table, property.Name, pdfItem, pdfModel);
                        }
                        else if (propertyValue is IEnumerable<PdfItem> pdfItemList)
                        {
                            foreach (var item in pdfItemList)
                            {
                                MapAndAddRow(table, property.Name, item, pdfModel);
                            }
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
                    row.RelativeItem(2).PaddingBottom(10).Text(pdfModel.TotalPrice + " €").FontFamily("Cambria").Bold().FontSize(14);
                });
            });
        }

        void ComposeFooter(IContainer container)
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

        private void MapAndAddRow(TableDescriptor table, string propertyName, PdfItem pdfItem, KrpanPdf pdf)
        {
            var displayName = PropertyDisplayNameMapping.ContainsKey(propertyName) ? PropertyDisplayNameMapping[propertyName] : propertyName;

            table.Cell().PaddingBottom(15).Text(displayName).FontFamily("Cambria");

            if (displayName == "Daru")
            {
                table.Cell().PaddingBottom(15).Text($"{pdfItem?.Name}").FontFamily("Cambria");
                table.Cell().PaddingBottom(15).Text($"{pdfItem?.Price} €").FontFamily("Cambria");
            }
            else if (displayName == "Rakonca")
            {
                table.Cell().PaddingBottom(15).Text($"{pdf.TrailerName} {pdfItem?.Name}").FontFamily("Cambria");
                table.Cell().PaddingBottom(15).Text($"{pdfItem?.Price} €").FontFamily("Cambria");
            }
            else
            {
                table.Cell().PaddingBottom(15).Text($"{pdfItem?.Name}").FontFamily("Cambria");
                table.Cell().PaddingBottom(15).Text("").FontFamily("Cambria");
            }
        }
    }
}
