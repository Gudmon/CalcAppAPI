using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class trailertyreschange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 11, 12 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 13, 14 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 14, 14 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 15, 15 });

            migrationBuilder.DeleteData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "2WD hajtás (BB240 az első tengelyen elektronikus vezérléssel, fékhez előkészítve)");

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "2WD hajtás (BB240 az hátsó tengelyen elektronikus vezérléssel, fékhez előkészítve)");

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: "1220");

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH3.6", "500/50-17 RF-felni, 6 lyukas, BKT", "2500" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "Name" },
                values: new object[] { "WH3.8", "500/50-17 RF-felni, 8 lyukas, BKT" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH5.6", "400/55-22,5 RF-felni, 6 lyukas, Alliance", "3215" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH8.8", "500/55-22,5 RF-felni, 8 lyukas, BKT", "3770" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH6.8", "550/45-22,5 RF-felni, 8 lyukas, BKT", "4010" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH6.8V", "550/45-22,5 RF-felni, 8 lyukas, BKT - traktor mintás", "4410" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH9.8V", "600/40-22,5 RF-felni, 8 lyukas, BKT - traktor mintás", "6425" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH7.8", "600/50-22,5 RF-felni, 8 lyukas, Alliance", "5410" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH7.10", "600/50-22,5 RF-felni, 10 lyukas, Nokian", "11020" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH9.10", "710/40-22,5 RF-felni, 10 lyukas, Nokian", "11150" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH1.4", "22/11-8", "465" });

            migrationBuilder.InsertData(
                table: "TyreTrailer",
                columns: new[] { "TrailerId", "TyreId" },
                values: new object[,]
                {
                    { 3, 4 },
                    { 3, 6 },
                    { 4, 4 },
                    { 4, 6 },
                    { 5, 4 },
                    { 5, 6 },
                    { 5, 8 },
                    { 5, 9 },
                    { 6, 5 },
                    { 6, 7 },
                    { 7, 5 },
                    { 7, 7 },
                    { 7, 10 },
                    { 7, 11 },
                    { 8, 4 },
                    { 8, 6 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 9, 5 },
                    { 9, 7 },
                    { 10, 5 },
                    { 10, 7 },
                    { 11, 5 },
                    { 11, 7 },
                    { 12, 5 },
                    { 12, 7 },
                    { 13, 12 },
                    { 14, 12 },
                    { 15, 14 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 3, 6 });

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
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 5, 9 });

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
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 7, 11 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 8, 4 });

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
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 13, 12 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 14, 12 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 15, 14 });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "2WD hajtás (BB240 az első tengelyen elektronikus vezérléssel, fékhez előkészítve");

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "2WD hajtás (BB240 az hátsó tengelyen elektronikus vezérléssel, fékhez előkészítve");

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: "1250");

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH4.8", "480/45-17 RF-felni, 8 lyukas, Starco", "2310" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "Name" },
                values: new object[] { "WH3.6", "500/50-17 RF-felni, 6 lyukas, BKT" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH3.8", "500/50-17 RF-felni, 8 lyukas, BKT", "2500" });

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

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH7.10", "600/50-22,5 RF-felni, 10 lyukas, Nokian", "11020" });

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "WH9.10", "710/40-22,5 RF-felni, 10 lyukas, Nokian", "11150" });

            migrationBuilder.InsertData(
                table: "Tyre",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 15, "WH1.4", "22/11-8", "465" });

            migrationBuilder.InsertData(
                table: "TyreTrailer",
                columns: new[] { "TrailerId", "TyreId" },
                values: new object[,]
                {
                    { 3, 5 },
                    { 3, 7 },
                    { 4, 5 },
                    { 4, 7 },
                    { 6, 6 },
                    { 6, 10 },
                    { 7, 6 },
                    { 7, 12 },
                    { 9, 6 },
                    { 9, 12 },
                    { 10, 12 },
                    { 11, 12 },
                    { 12, 12 },
                    { 13, 14 },
                    { 14, 14 },
                    { 15, 15 }
                });
        }
    }
}
