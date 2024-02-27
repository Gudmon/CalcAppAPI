using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ElectricalFloating",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Elektromos úszó pozíció emelő és fordító funkcióhoz (A11-A41 vezértömbhöz)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ElectricalFloating",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Elektromos úszó pozíció emelő és fordító funkcióhoz (for A11-A41 vezértömbhöz)");
        }
    }
}
