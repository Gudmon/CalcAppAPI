using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpancranesandtrailers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LoadingLengthWithExtension",
                table: "KrpanTrailer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TotalLengthWithExtension",
                table: "KrpanTrailer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaxReachWithGrabOpen",
                table: "KrpanCrane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MaxReach", "MaxReachWithGrabOpen", "Price" },
                values: new object[] { "6.6", "7.2", "13715" });

            migrationBuilder.InsertData(
                table: "KrpanCrane",
                columns: new[] { "Id", "BrutLiftingTorque", "Description", "LiftCapacityAtFourMeters", "LiftCapacityAtMaxReach", "MaxReach", "MaxReachWithGrabOpen", "Name", "NetLiftingTorque", "OilQuantityInTank", "Price", "SlewCylinders", "SlewTorque", "SlewingAngle", "SystemPressure", "TelescopicStages", "Weight" },
                values: new object[,]
                {
                    { 2, "80", "", "1860", "850", "7.4", "8.0", "GD 7,4 K", "63", "100", "24475", "4", "22", "380", "230", "1", "1516" },
                    { 3, "49", "", "1020", "500", "7.6", "8.2", "GD 7,6 K", "39", "70", "15335", "4", "16", "375", "220", "1", "930" },
                    { 4, "82", "", "1670", "680", "8.6", "9.2", "GD 8,6 K", "58", "100", "27150", "4", "19", "380", "230", "2", "1706" },
                    { 5, "82", "", "1460", "894", "7.2", "7.8", "GD 7,2 Z", "62", "100", "26000", "4", "22", "370", "230", "1", "1530" },
                    { 6, "84", "", "1427", "760", "8.4", "9.0", "GD 8,4 Z", "60", "100", "29200", "4", "22", "370", "230", "2", "1855" }
                });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LoadCapacity", "LoadingLength", "LoadingLengthWithExtension", "Name", "Price", "TotalLength", "TotalLengthWithExtension", "TotalWidth", "Weight" },
                values: new object[] { "8000", "3582", "4477", "GP 8 DF", "10300", "5919", "6814", "2067", "1690" });

            migrationBuilder.InsertData(
                table: "KrpanTrailer",
                columns: new[] { "Id", "CentralBeams", "Description", "DrawbarAngle", "FrameSteeringCylinders", "LoadCapacity", "LoadingLength", "LoadingLengthWithExtension", "Name", "Price", "TotalLength", "TotalLengthWithExtension", "TotalWidth", "Weight" },
                values: new object[,]
                {
                    { 2, "2/180×100x6", "", "40", "2", "9000", "3582", "4477", "GP 9 DF", "10865", "5919", "6814", "2067", "1690" },
                    { 3, "2/180×100x6", "", "40", "2", "10000", "3582", "4477", "GP 10 DF", "11430", "5919", "6814", "2067", "1690" },
                    { 4, "2/180×100x6", "", "40", "2", "11000", "3707", "4487", "GP 11 D", "13510", "5944", "6724", "2152", "1734" },
                    { 5, "2/180×100x6", "", "40", "2", "12000", "3975", "4755", "GP 12 DF", "13060", "6209", "7100", "2122", "2100" },
                    { 6, "2/200×100x6", "", "40", "2", "13000", "3975", "4755", "GP 13 D", "15310", "6334", "7144", "2200", "2144" },
                    { 7, "2/200×100x8", "", "40", "2", "14000", "4325", "5105", "GP 14 DF", "14915", "6559", "7545", "2222", "2300" },
                    { 8, "2/200×100x8", "", "40", "2", "14800", "4325", "5105", "GP 15 D", "16960", "6686", "6686", "2318", "2352" }
                });

            migrationBuilder.InsertData(
                table: "KrpanCraneTrailer",
                columns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 8 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 },
                    { 5, 8 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 6, 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "LoadingLengthWithExtension",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "TotalLengthWithExtension",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "MaxReachWithGrabOpen",
                table: "KrpanCrane");

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MaxReach", "Price" },
                values: new object[] { "6,6 / 7,2", "13510" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LoadCapacity", "LoadingLength", "Name", "Price", "TotalLength", "TotalWidth", "Weight" },
                values: new object[] { "11000", "3707 / (4487)", "GP 11 D", "13510", "5944 / (6724)", "2152", "1734" });
        }
    }
}
