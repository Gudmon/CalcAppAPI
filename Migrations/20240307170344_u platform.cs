using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class uplatform : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlatformTrailer",
                columns: new[] { "PlatformId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 19 });
        }
    }
}
