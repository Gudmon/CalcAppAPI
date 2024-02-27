using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class updaterotarorbrakeswdesc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RotatorBrake",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Fék az oldalirányú mozgáshoz. A fékek terheletlen markolókhoz vannak beállítva.");

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Fék az oldalirányú mozgáshoz. A fékek terheletlen markolókhoz vannak beállítva.");

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Fékek az oldalirányú és előre-hátra mozgáshoz. A fékek terheletlen markolókhoz vannak beállítva.");

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Fékek az oldalirányú és előre-hátra mozgáshoz. A fékek terheletlen markolókhoz vannak beállítva.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "RotatorBrake");
        }
    }
}
