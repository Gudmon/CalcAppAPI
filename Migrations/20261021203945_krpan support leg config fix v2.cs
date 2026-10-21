using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpansupportlegconfigfixv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.InsertData(
                table: "KrpanSupportLegsTrailer",
                columns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                values: new object[,]
                {
                    { 4, 3 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 3 },
                    { 8, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanSupportLegsTrailer",
                keyColumns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.InsertData(
                table: "KrpanSupportLegsTrailer",
                columns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                values: new object[,]
                {
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 2 }
                });
        }
    }
}
