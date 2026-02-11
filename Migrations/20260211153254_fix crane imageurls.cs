using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixcraneimageurls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-2.54-1\",\"PALMS-2.54-2\",\"PALMS-2.54-3\",\"PALMS-2.54-4\",\"PALMS-2.54-5\"]");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: "[\"PALMS-3.63-1\",\"PALMS-3.63-2\",\"PALMS-3.63-3\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-2.54-1, PALMS-2.54-2, PALMS-2.54-3\",\"PALMS-2.54-4\",\"PALMS-2.54-5\"]");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: "[\"PALMS-3.63-1, PALMS-3.63-2, PALMS-3.63-3\"]");
        }
    }
}
