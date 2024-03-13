using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class trailercranesforeverytrailer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CraneTrailer",
                columns: new[] { "CraneId", "TrailerId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 4, 8 },
                    { 4, 9 },
                    { 5, 2 },
                    { 5, 12 },
                    { 5, 13 },
                    { 5, 14 },
                    { 5, 15 },
                    { 5, 16 },
                    { 6, 12 },
                    { 6, 13 },
                    { 6, 14 },
                    { 6, 15 },
                    { 6, 16 },
                    { 6, 17 },
                    { 6, 18 },
                    { 6, 19 },
                    { 7, 12 },
                    { 7, 13 },
                    { 7, 14 },
                    { 7, 15 },
                    { 7, 16 },
                    { 7, 17 },
                    { 7, 18 },
                    { 7, 19 },
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
                    { 9, 19 },
                    { 10, 3 },
                    { 10, 4 },
                    { 10, 12 },
                    { 10, 13 },
                    { 10, 14 },
                    { 10, 15 },
                    { 10, 16 },
                    { 10, 17 },
                    { 10, 18 },
                    { 10, 19 },
                    { 11, 12 },
                    { 11, 13 },
                    { 11, 14 },
                    { 11, 15 },
                    { 11, 16 },
                    { 11, 17 },
                    { 11, 18 },
                    { 11, 19 },
                    { 12, 12 },
                    { 12, 13 },
                    { 12, 14 },
                    { 12, 15 },
                    { 12, 16 },
                    { 12, 17 },
                    { 12, 18 },
                    { 12, 19 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 15 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 17 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 18 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 19 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 14 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 15 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 17 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 18 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 19 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 8, 12 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 8, 13 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 8, 14 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 8, 15 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 8, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 8, 17 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 8, 18 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 8, 19 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 13 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 14 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 15 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 18 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 19 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 13 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 14 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 15 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 17 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 18 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 19 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 12 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 14 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 15 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 17 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 18 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 19 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 12, 13 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 12, 14 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 12, 15 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 12, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 12, 17 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 12, 18 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 12, 19 });
        }
    }
}
