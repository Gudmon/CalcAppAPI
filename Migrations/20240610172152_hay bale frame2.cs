using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class haybaleframe2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HayBaleFrame",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Szénabála keret (D típushoz)");

            migrationBuilder.UpdateData(
                table: "HayBaleFrame",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Szénabála keret (U típushoz)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HayBaleFrame",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Széna bála keret (D típushoz)");

            migrationBuilder.UpdateData(
                table: "HayBaleFrame",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Széna bála keret (U típushoz)");
        }
    }
}
