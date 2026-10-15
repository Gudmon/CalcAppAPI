using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpanbrakenamefix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KrpanBrake",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Hidraulikus fék 4 keréken");

            migrationBuilder.UpdateData(
                table: "KrpanBrake",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Hidraulikus + ráfutófék 4 keréken");

            migrationBuilder.UpdateData(
                table: "KrpanBrake",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Pneumatikus fék 4 keréken");

            migrationBuilder.UpdateData(
                table: "KrpanBrake",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Pneumatikus fék 4 keréken");

            migrationBuilder.UpdateData(
                table: "KrpanBrake",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Kombinált fék 4 keréken (hidraulikus + pneumatikus)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KrpanBrake",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Hidraulikus fék (mind a 4 keréken)");

            migrationBuilder.UpdateData(
                table: "KrpanBrake",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Hidraulikus + ráfutófék (mind a 4 keréken)");

            migrationBuilder.UpdateData(
                table: "KrpanBrake",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Pneumatikus fék(mind a 4 keréken)");

            migrationBuilder.UpdateData(
                table: "KrpanBrake",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Pneumatikus fék (mind a 4 keréken)");

            migrationBuilder.UpdateData(
                table: "KrpanBrake",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Kombinált fék (mind a 4 keréken - hidraulikus + pneumatikus)");
        }
    }
}
