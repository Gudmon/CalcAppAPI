using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class udrawbars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DrawbarTrailer",
                columns: new[] { "DrawbarId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 },
                    { 2, 17 },
                    { 2, 18 },
                    { 2, 19 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 3, 19 },
                    { 4, 12 },
                    { 4, 13 },
                    { 4, 14 },
                    { 4, 15 },
                    { 4, 16 },
                    { 4, 17 },
                    { 4, 18 },
                    { 4, 19 },
                    { 5, 12 },
                    { 5, 13 },
                    { 5, 14 },
                    { 5, 15 },
                    { 5, 16 },
                    { 5, 17 },
                    { 5, 18 },
                    { 5, 19 },
                    { 6, 12 },
                    { 6, 13 },
                    { 6, 14 },
                    { 6, 15 },
                    { 6, 16 },
                    { 6, 17 },
                    { 6, 18 },
                    { 6, 19 },
                    { 8, 12 },
                    { 8, 13 },
                    { 8, 14 },
                    { 8, 15 },
                    { 8, 16 },
                    { 8, 17 },
                    { 8, 18 },
                    { 8, 19 },
                    { 9, 12 },
                    { 9, 13 },
                    { 9, 14 },
                    { 9, 15 },
                    { 9, 16 },
                    { 9, 17 },
                    { 9, 18 },
                    { 9, 19 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 19 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 15 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 19 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 17 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 18 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 19 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 6, 15 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 6, 17 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 6, 18 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 6, 19 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 8, 12 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 8, 13 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 8, 14 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 8, 15 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 8, 16 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 8, 17 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 8, 18 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 8, 19 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 13 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 14 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 15 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 16 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 18 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 19 });
        }
    }
}
