using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class frametypesnames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "A12 2/8 Pre-hidraulikus, +2x el.propo, Walvoil DPX100 (max. 120 l/min), 215 bar + HPF");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "A14 2/8 Pre-hydraulic, +2x el.propo, Parker L90, 215 bar + HPF");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "B3, A típusú normál méretű letalpaló, 3 pontos csatlakozással");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "B6.1 FD típusú letalpaló, 3 pontos csatlakozással");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "B09 Különösen erős alap, talpaló lábak nélkül");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "B9 FD típusú, különösen erős letalpaló (HD)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "A típusú normál méretű letalpaló, 3 pontos csatlakozással");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "FD típusú letalpaló, 3 pontos csatlakozással");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Különösen erős alap, talpaló lábak nélkül");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "FD típusú, különösen erős letalpaló (HD)");
        }
    }
}
