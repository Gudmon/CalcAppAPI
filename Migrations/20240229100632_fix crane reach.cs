using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixcranereach : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "A2 5/7 XY vezértömb, 195 bar");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "A3.1 6/8 XY vezértömb, BLB BM50 (50l/perc), 195 bar");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "A4 4/8 XY+2x el.on-off vezértömb, Hydro-control D3M, 195 bar");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "A4.2 4/8 XY+2x el.on-off vezértömb, Bucher HDS16, 215 bar");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "A7 4/8 XYZ vezértömb, Hydro-control, 195 bar (215 bar kérésre)");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "A 12 2/8 Pre-hidraulikus, +2x el.propo, Walvoil DPX100 (max. 120 l/min), 215 bar + HPF");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "A 14 2/8 Pre-hydraulic, +2x el.propo, Parker L90, 215 bar + HPF");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "A23 El.propo 8 szekciós, IQAN LC6, mini joystick-ok, (LS komp.) + Parker L90pro, 215/240 bar + HPF");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "A235 El.propo 8 szekciós, IQAN LC5 joystick-ok, (LS komp) Parker L90pro, 215/240 bar + HPF");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "A25.1 El.propo 8 szekciós (A23) + MD3 kijelző + HPF");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "A26 IMET rádió távirányítás, (LS komp.) Parker L90pro (max. 150 l/min.), 215/240 bar + HPF");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "A36 Combi control (rádió távirányítás+A23),Parker  L90pro, 215/240 bar + HPF");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "A36.1 Combi control (rádió távirányítás+A23),Parker  L90pro, 215/240 bar + MD3 kijelző + HPF");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "A42 Palms Tip Control, IQAN joystickok, MD4 - 7 inch-es kijelző, Parker L90pro, 215/240 bar + HPF");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "5/7 XY vezértömb, 195 bar");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "6/8 XY vezértömb, BLB BM50 (50l/perc), 195 bar");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "4/8 XY+2x el.on-off vezértömb, Hydro-control D3M, 195 bar");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "4/8 XY+2x el.on-off vezértömb, Bucher HDS16, 215 bar");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "4/8 XYZ vezértömb, Hydro-control, 195 bar (215 bar kérésre)");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "2/8 Pre-hidraulikus, +2x el.propo, Walvoil DPX100 (max. 120 l/min), 215 bar + HPF");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "2/8 Pre-hydraulic, +2x el.propo, Parker L90, 215 bar + HPF");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "El.propo 8 szekciós, IQAN LC6, mini joystick-ok, (LS komp.) + Parker L90pro, 215/240 bar + HPF");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "El.propo 8 szekciós, IQAN LC5 joystick-ok, (LS komp) Parker L90pro, 215/240 bar + HPF");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "El.propo 8 szekciós (A23) + MD3 kijelző + HPF");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "IMET rádió távirányítás, (LS komp.) Parker L90pro (max. 150 l/min.), 215/240 bar + HPF");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Combi control (rádió távirányítás+A23),Parker  L90pro, 215/240 bar + HPF");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Combi control (rádió távirányítás+A23),Parker  L90pro, 215/240 bar + MD3 kijelző + HPF");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Palms Tip Control, IQAN joystickok, MD4 - 7 inch-es kijelző, Parker L90pro, 215/240 bar + HPF");
        }
    }
}
