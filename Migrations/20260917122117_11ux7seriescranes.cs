using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class _11ux7seriescranes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CraneTrailer",
                columns: new[] { "CraneId", "TrailerId" },
                values: new object[,]
                {
                    { 9, 16 },
                    { 10, 16 },
                    { 11, 16 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 16 });
        }
    }
}
