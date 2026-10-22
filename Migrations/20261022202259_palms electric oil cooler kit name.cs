using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class palmselectricoilcoolerkitname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CraneElectricOilCoolerKit",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Nagy olajhűtő csomag elektromos csatlakozással a traktorhoz");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CraneElectricOilCoolerKit",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Szabványos olajhűtő csomag elektromos csatlakozással a traktorhoz");
        }
    }
}
