using Azure.Storage.Blobs;
using CalcAppAPI.Infrastructure.Options;
using CalcAppAPI.Models.Pdf;
using CalcAppAPI.Services;
using Microsoft.Extensions.Options;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CalcAppAPI.Application.Services.Palms.Pdf
{
    public class UserPdfGenerator : IUserPdfGenerator
    {
        private string _connectionString;
        private const string _containerName = "pdf";

        public UserPdfGenerator(IOptions<BlobOptions> blobOptions)
        {
            _connectionString = blobOptions.Value.ConnectionString;
        }

        private static readonly Dictionary<string, string> PropertyDisplayNameMapping = new Dictionary<string, string>
        {
            { "Stanchion", "Rakonca" },
            { "Brake", "Fék" },
            { "Propulsion", "Hajtás" },
            { "Drawbar", "Vonórúd" },
            { "Platform", "Kezelő platform" },
            { "HydroPack", "Hydropack" },
            { "OilPump", "Olajpumpa" },
            { "OilTank", "Olajtank" },
            { "TrailerOilCooler", "Pótkocsi olajhűtő" },
            { "BolsterLock", "Rakonca rögzítő" },
            { "BBox", "Biomasszás boksz" },
            { "DBox", "Billenős boksz" },
            { "Toolbox", "Szerszámláda" },
            { "HayBaleFrame", "Szénabála keret" },
            { "WoodSorter", "Faosztályozó" },
            { "HandBrake", "Kézifék" },
            { "ChainsawHolder", "Láncfűrész tartó" },
            { "UnderrunProtection", "Aláfutásgátló" },
            { "BunkAdapter", "Bunk adapter" },
            { "BunkExtension", "Bunk kiterjesztés" },
            { "FrameExtension", "Raktér hosszabbítás" },
            { "StanchionExtension", "Rakonca hosszabbítás" },
            { "TrailerLight", "Pótkocsi világítás" },
            { "SupportLeg", "Kitámasztó láb" },
            { "Tyre", "Kerék" },
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
            { "HighPerformanceOilFilter", "Nagynyomású olajszűrő" },
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

        public async Task<string> GenerateAndSaveUserPdfAsync(PdfData pdfModel, string blobName)
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

        void ComposeContent(IContainer container, PdfData pdfModel, string blobName)
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

                    foreach (var property in typeof(PdfData).GetProperties())
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

        private void MapAndAddRow(TableDescriptor table, string propertyName, PdfItem pdfItem, PdfData pdf)
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

        public async Task<byte[]> GenerateCompetitionPdfAsync(CompetitionPdf pdfModel)
        {
            var pdf = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Header().Element(ComposeCompetitionHeader);
                    page.Content().Padding(20).Element(c => ComposeCompetitionContent(c, pdfModel));
                    page.Footer().Element(ComposeCompetitionFooter);
                });
            });

            using (var stream = new MemoryStream())
            {
                pdf.GeneratePdf(stream);
                return stream.ToArray();
            }
        }

        void ComposeCompetitionHeader(IContainer container)
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

        void ComposeCompetitionContent(IContainer container, CompetitionPdf pdfModel)
        {
            var now = DateTime.UtcNow.ToString("yyyy/MM/dd");
            container.Column(col =>
            {
                col.Item().Row(row =>
                {
                    row.Spacing(20);
                    row.RelativeItem(7).PaddingBottom(10).Text("Ginop plusz 1.2.4-24").FontFamily("Cambria").FontSize(20).Bold();
                row.RelativeItem(5).PaddingBottom(10).Text($"{now}").FontFamily("Cambria").FontSize(20).Bold();
                });

                col.Item().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(7);
                        columns.RelativeColumn(5);
                    });
                    table.Header(header =>
                    {
                        header.Cell().BorderBottom(1).PaddingBottom(5).Text("Megnevezés").Bold().FontFamily("Cambria");
                        header.Cell().BorderBottom(1).PaddingBottom(5).Text("Érték").Bold().FontFamily("Cambria");
                    });

                    foreach (var property in typeof(CompetitionPdf).GetProperties())
                    {
                        var value = property.GetValue(pdfModel)?.ToString();

                        if (!string.IsNullOrEmpty(value))
                        {
                            var displayName = CompetitionPropertyDisplayNameMapping.ContainsKey(property.Name)
                                                        ? CompetitionPropertyDisplayNameMapping[property.Name]
                                                        : property.Name;

                            table.Cell().Padding(5).Text(displayName).FontFamily("Cambria");
                            table.Cell().Padding(5).Text(value).FontFamily("Cambria");
                        }
                    }
                });
            });
        }


        void ComposeCompetitionFooter(IContainer container)
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

        private static readonly Dictionary<string, string> CompetitionPropertyDisplayNameMapping = new Dictionary<string, string>
        {
            { "FromEmail", "Email" },
            { "Name", "Név" },
            { "CountryCode", "Előhívószám" },
            { "PhoneNumber", "Telefonszám" },
            { "BusinessForm", "Vállalkozási forma" },
            { "Category", "Vállalkozás helye" },
            { "Kata", "KATA" },
            { "BusinessYear", "1 lezárt üzleti év" },
            { "ManPower", "Átlagos statisztikai létszám min. 1 fő" },
            { "Revenue", "Árbevétel mezőgazdasági tevékenységből" },
            { "Message", "Megjegyzés" },
        };

        private void CompetitionMapAndAddRow(TableDescriptor table, string propertyName, CompetitionPdf pdf)
        {
            var displayName = CompetitionPropertyDisplayNameMapping.ContainsKey(propertyName) ? CompetitionPropertyDisplayNameMapping[propertyName] : propertyName;

            table.Cell().PaddingBottom(15).Text(displayName).FontFamily("Cambria");

            table.Cell().PaddingBottom(15).Text("test").FontFamily("Cambria");
            table.Cell().PaddingBottom(15).Text("").FontFamily("Cambria");
        }
    }

}

