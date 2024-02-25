using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class controlblockpictures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ControlBlocks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Egyszerű és kompakt szelepblokk darukhoz teleszkópos hosszabbító gémek nélkül");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Egyszerű és megbízható szelepblokk kisebb daruk számára");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Szelepblokk az egyszerűbb daruvezérlést kedvelő ügyfelek számára");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Szelepblokk az egyszerűbb daruvezérlést kedvelő ügyfelek számára");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Szelepblokk az egyszerűbb daruvezérlést kedvelő ügyfelek számára");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Leginkább a PALMS 5. és 7. sorozatú darukkal használható");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Leginkább a PALMS 5. és 7. sorozatú darukkal használható");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Parker LC6 mini joystickek. Leginkább PALMS 5., 7. és X-sorozatú darukhoz használják");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Leginkább a PALMS 5. és 7. sorozatú darukkal használható");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Parker LC6 mini joystick kijelzővel");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "IMET rádió vezérlés PALMS erdészeti daruhoz");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "IMET rádióvezérlés Parker LC6 mini joystickekkel");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "IMET rádióvezérlés és Parker LC6 mini joystick kijelzővel");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Standard üzemmód, ahol a fő emelőhenger, a hosszabbító gém hengere és a teleszkóp hengere külön vezérelhető.\r\nPTC mód, ahol a markoló lineárisan mozgatható X, Y és Z irányban.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ControlBlocks");
        }
    }
}
