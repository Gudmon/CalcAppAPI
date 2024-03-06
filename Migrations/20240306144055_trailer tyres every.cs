using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class trailertyresevery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price" },
                values: new object[] { "480/45-17 RF-felni, 8 lyukas, Starco", "2310" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Price" },
                values: new object[] { "500/50-17 RF-felni, 6 lyukas, BKT", "2500" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "Name" },
                values: new object[] { "WH3.8", "500/50-17 RF-felni, 8 lyukas, BKT" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH5.6", "400/55-22,5 RF-felni, 6 lyukas, Alliance", "3215" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH8.8", "500/55-22,5 RF-felni, 8 lyukas, BKT", "3770" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH6.8", "550/45-22,5 RF-felni, 8 lyukas, BKT", "4010" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH6.8V", "550/45-22,5 RF-felni, 8 lyukas, BKT - traktor mintás", "4410" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH9.8V", "600/40-22,5 RF-felni, 8 lyukas, BKT - traktor mintás", "6425" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH7.8", "600/50-22,5 RF-felni, 8 lyukas, Alliance", "5410" });

            migrationBuilder.InsertData(
                table: "TyreTrailer",
                columns: new[] { "TrailerId", "TyreId" },
                values: new object[,]
                {
                    { 3, 7 },
                    { 4, 4 },
                    { 4, 6 },
                    { 4, 8 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 5 },
                    { 5, 7 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 5 },
                    { 6, 7 },
                    { 7, 4 },
                    { 7, 6 },
                    { 7, 8 },
                    { 8, 6 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 9, 6 },
                    { 9, 8 },
                    { 9, 9 },
                    { 9, 10 },
                    { 10, 6 },
                    { 10, 8 },
                    { 10, 9 },
                    { 10, 12 },
                    { 11, 6 },
                    { 11, 8 },
                    { 11, 9 },
                    { 11, 10 },
                    { 11, 11 },
                    { 11, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 11, 12 });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price" },
                values: new object[] { "480/45-17 RF-felni, 8 lyukas, Starco (kérésre)", "0" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Price" },
                values: new object[] { "500/50-17 RF-felni, 6 lyukas, BKT (kérésre)", "0" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "Name" },
                values: new object[] { "WH3.6", "500/50-17 RF-felni, 6 lyukas, BKT" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH3.8", "500/50-17 RF-felni, 8 lyukas, BKT", "2500" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH5.6", "400/55-22,5 RF-felni, 6 lyukas, Alliance (kérésre)", "0" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH5.6", "400/55-22,5 RF-felni, 6 lyukas, Alliance", "3215" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH8.8", "500/55-22,5 RF-felni, 8 lyukas, BKT", "3770" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH6.8", "550/45-22,5 RF-felni, 8 lyukas, BKT", "4010" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH6.8V", "550/45-22,5 RF-felni, 8 lyukas, BKT - traktor mintás", "4410" });

            migrationBuilder.InsertData(
                table: "Tyre",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 13, "WH9.8V", "600/40-22,5 RF-felni, 8 lyukas, BKT - traktor mintás", "6425" },
                    { 14, "WH7.8", "600/50-22,5 RF-felni, 8 lyukas, Alliance", "5410" }
                });

            migrationBuilder.InsertData(
                table: "TyreTrailer",
                columns: new[] { "TrailerId", "TyreId" },
                values: new object[] { 3, 8 });
        }
    }
}
