﻿using Azure.Storage.Blobs;
using CalcAppAPI.Models;
using CalcAppAPI.Models.Pdf;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MimeKit;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CalcAppAPI.Services
{
    public class UserPdfGenerator : IUserPdfGenerator
    {
        private string _connectionString = "";
        private const string _containerName = "pdf";
        private decimal totalPrice = 0;

        public UserPdfGenerator(IConfiguration configuration)
        {
            _connectionString = configuration["BlobConnection"];

            if (string.IsNullOrEmpty(_connectionString))
            {
                _connectionString = configuration.GetConnectionString("BlobConnection");
            }

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new ApplicationException("Blob Storage connection string is not configured.");
            }
        }

        private static readonly Dictionary<string, string> PropertyDisplayNameMapping = new Dictionary<string, string>
        {       
            { "Stanchion", "Rakonca" },
            { "Brake", "Fék" },
            { "Propulsion", "Hajtás" },
            { "Drawbar", "Vonórúd" },
            { "Platform", "Kezelő platform" },
            { "OilPump", "Olajpumpa" },
            { "OilTank", "Olajtank" },
            { "TrailerOilCooler", "Pótkocsi olajhűtő" },
            { "BolsterLock", "Rakonca rögzítő" },
            { "BBox", "Biomasszás box" },
            { "WoodSorter", "Faosztályozó" },
            { "HandBrake", "Kézifék" },
            { "ChainsawHolder", "Láncfűrész tartó" },
            { "UnderrunProtection", "Aláfutásgátló" },
            { "BunkAdapter", "Bunk adapter" },
            { "BunkExtension", "Bunk kiterjesztés" },
            { "FrameExtension", "Raktér hosszabbítás" },
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
            { "CraneOilCooler", "Olajhűtő eleketromos csatlakozással" },
            { "RotatorBrake", "Rotátor fék" },
            { "JoystickHolder", "Joystick tartó" },
            { "HoseGuard", "Tömlő védő" },
            { "TurningDeviceCounterPlate", "Fedőlap fordító szerkezethez" },
            { "SupportLegCounterPlate", "Fedőlap talpaló lábhoz" },
            { "BoomGuard", "Főgém védő" },
            { "Cover", "Védőhuzat" },
            { "WoodControl", "Fás kiegészítő" },
            { "Linkage", "3 pontos csatlakozó adapter" },
            { "CraneShipping", "Szállítás" },
        };

        public async Task<string> GenerateAndSaveUserPdfAsync(Pdf pdfModel, string blobName)
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
            container.Column(col =>
            {
                col.Item().Text("");
            });
        }

        void ComposeContent(IContainer container, Pdf pdfModel, string blobName)
        {
            container.Column(col =>
            {
                col.Item().Row(row =>
                {
                    row.Spacing(20);
                    row.RelativeItem(3).PaddingBottom(10).Text(blobName).FontFamily("Cambria").FontSize(20).Bold();
                    row.RelativeItem(2).PaddingBottom(10).Text(pdfModel?.TrailerName);
                    row.RelativeItem(2).PaddingBottom(10).Text(pdfModel?.Crane?.Name);
                    row.RelativeItem(2).PaddingBottom(10).Text(DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
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

                    foreach (var property in typeof(Pdf).GetProperties())
                    {
                        var propertyValue = property.GetValue(pdfModel);

                        if (propertyValue is PdfItem pdfItem)
                        {
                            MapAndAddRow(table, property.Name, pdfItem, pdfModel);
                            totalPrice += decimal.Parse(pdfItem.Price);
                        }
                        else if (propertyValue is IEnumerable<PdfItem> pdfItemList)
                        {
                            foreach (var item in pdfItemList)
                            {
                                MapAndAddRow(table, property.Name, item, pdfModel);
                                totalPrice += decimal.Parse(item.Price);
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
                    row.RelativeItem(2).PaddingBottom(10).Text(totalPrice.ToString() + " €").FontFamily("Cambria").Bold().FontSize(14);
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
                        .Hyperlink("https://polite-ocean-00cf7d503.4.azurestaticapps.net")
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

        private void MapAndAddRow(TableDescriptor table, string propertyName, PdfItem pdfItem, Pdf pdf)
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

