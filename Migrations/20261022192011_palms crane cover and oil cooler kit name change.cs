using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class palmscranecoverandoilcoolerkitnamechange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cover",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-crane-cover-2\"]");

            migrationBuilder.UpdateData(
                table: "CraneElectricOilCoolerKit",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Szabványos olajhűtő csomag elektromos csatlakozással a traktorhoz");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cover",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-crane-cover-1\"]");

            migrationBuilder.UpdateData(
                table: "CraneElectricOilCoolerKit",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Nagy olajhűtő csomag elektromos csatlakozással a traktorhoz");
        }
    }
}
