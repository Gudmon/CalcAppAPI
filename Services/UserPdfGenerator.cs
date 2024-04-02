﻿using Azure.Storage.Blobs;
using CalcAppAPI.Models.Pdf;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CalcAppAPI.Services
{
    public class UserPdfGenerator : IUserPdfGenerator
    {
        private const string _connectionString = "DefaultEndpointsProtocol=https;AccountName=calcappblob;AccountKey=vjEzWkM+hwqSzYInXK3kq60SsFpdgVYV/9dwRsAybnCLDYV81grAQIYGrwBXq6PBA4ZDStAmJF46+AStINh/ag==;EndpointSuffix=core.windows.net";
        private const string _containerName = "pdf";

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
        { "Tyre", "Kerék" },

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
        { "CraneLight", "Pótkocsi világítás" },
        { "OperatorSeat", "Kezelő ülés" },
        { "CraneOilCooler", "Pótkocsi olajhűtő" },
        { "RotatorBrake", "Rotátor fék" },
        { "JoystickHolder", "Joystick tartó" },
        { "HoseGuard", "Tömlő védő" },
        { "TurningDeviceCounterPlate", "Fedőlap fordító szerkezethez" },
        { "SupportLegCounterPlate", "Fedőlap talpaló lábhoz" },
        { "BoomGuard", "Főgém védő" },
        { "Cover", "Védőhuzat" },
        { "WoodControl", "Fás kiegészítő" },
        { "Linkage", "Csatlakozó adapter" },
    };

        public async Task<string> GenerateAndSaveUserPdfAsync(Pdf pdfModel, int pdfId)
        {
            var pdf = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Header().Element(ComposeHeader);
                    page.Content().Padding(20).Element(c => ComposeContent(c, pdfModel, pdfId));
                    page.Footer().Element(ComposeFooter);
                });
            });


            var container = new BlobContainerClient(_connectionString, _containerName);
            var blob = container.GetBlobClient($"{pdfId}.pdf");

            using (var stream = new MemoryStream())
            {

                pdf.GeneratePdf(stream);
                stream.Position = 0;

                await blob.UploadAsync(stream, true);
            }

            return pdfId.ToString();
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
        void ComposeContent(IContainer container, Pdf pdfModel, int pdfId)
        {
            container.Column(col =>
            {
                col.Item().Row(row =>
                {
                    row.Spacing(20);
                    row.RelativeItem(2).PaddingBottom(10).Text(pdfId.ToString()).FontFamily("Cambria").FontSize(20);
                    row.RelativeItem(1).PaddingBottom(10).Text(pdfModel?.TrailerName);
                    row.RelativeItem(1).PaddingBottom(10).Text(pdfModel?.CraneName);
                    row.RelativeItem(1).PaddingBottom(10).Text(DateTime.Now.ToString("yyyy-MM-dd HH:mm"));

                });


                col.Item().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(2);
                        columns.RelativeColumn(6);
                    });
                    table.Header(header =>
                    {
                        header.Cell().BorderBottom(1).Text("Konfiguráció").Bold().FontFamily("Cambria");
                        header.Cell().BorderBottom(1).Text("Megnevezés").Bold().FontFamily("Cambria");
                    });


                    foreach (var property in typeof(Pdf).GetProperties())
                    {
                        var propertyValue = property.GetValue(pdfModel);

                        if (propertyValue is PdfItem pdfItem)
                        {
                            MapAndAddRow(table, property.Name, pdfItem);
                        }
                        else if (propertyValue is IEnumerable<PdfItem> pdfItemList)
                        {
                            foreach (var item in pdfItemList)
                            {
                                MapAndAddRow(table, property.Name, item);
                            }
                        }
                    }

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
        private void MapAndAddRow(TableDescriptor table, string propertyName, PdfItem pdfItem)
        {
            var displayName = PropertyDisplayNameMapping.ContainsKey(propertyName) ? PropertyDisplayNameMapping[propertyName] : propertyName;

            table.Cell().PaddingBottom(15).Text(displayName).FontFamily("Cambria");
            table.Cell().PaddingBottom(15).Text(pdfItem.Name).FontFamily("Cambria");
        }
    }

}
