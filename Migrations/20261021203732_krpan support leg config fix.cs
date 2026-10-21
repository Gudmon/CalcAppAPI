using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpansupportlegconfigfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.UpdateData(
                table: "KrpanCargoSpaceExtension",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Raktér hosszabbítás");

            migrationBuilder.UpdateData(
                table: "KrpanCargoSpaceExtension",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Raktér hosszabbítás");

            migrationBuilder.InsertData(
                table: "KrpanSupportLegsTrailer",
                columns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                values: new object[] { 6, 2 });

            migrationBuilder.InsertData(
                table: "KrpanTrailerSupportLeg",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 4, "", "Mechanikus támasztóláb - állítható", "0" });

            migrationBuilder.InsertData(
                table: "KrpanSupportLegsTrailer",
                columns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 2, 4 },
                    { 3, 4 },
                    { 4, 4 },
                    { 5, 4 },
                    { 6, 4 },
                    { 7, 4 },
                    { 8, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanTrailerSupportLeg",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "KrpanCargoSpaceExtension",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Raktér hosszabbítás (80 cm)");

            migrationBuilder.UpdateData(
                table: "KrpanCargoSpaceExtension",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Raktér hosszabbítás (80 cm)");

            migrationBuilder.InsertData(
                table: "KrpanSupportLegsTrailer",
                columns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 3 },
                    { 5, 3 },
                    { 6, 1 },
                    { 6, 3 },
                    { 7, 3 },
                    { 8, 3 }
                });
        }
    }
}
