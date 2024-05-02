using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class changeplatformtext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OperatorSeat",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Kezelő ülés a függőleges gém tetejére, csak A12-es vezértömbhöz, nem kompatibilis a csörlővel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OperatorSeat",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Kezelő ülés a függőleges gém tetejére, csak A12-höz, nem kompatibilis a csörlővel");
        }
    }
}
