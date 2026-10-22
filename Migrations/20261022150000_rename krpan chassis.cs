using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    public partial class renamekrpanhydraulicadjustablechassistokrpanchassis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanHydraulicAdjustableChassis_KrpanHydraulicAdjustableChassisId",
                table: "KrpanTrailer");

            migrationBuilder.RenameTable(
                name: "KrpanHydraulicAdjustableChassis",
                newName: "KrpanChassis");

            migrationBuilder.RenameColumn(
                name: "KrpanHydraulicAdjustableChassisId",
                table: "KrpanTrailer",
                newName: "KrpanChassisId");

            migrationBuilder.RenameIndex(
                name: "IX_KrpanTrailer_KrpanHydraulicAdjustableChassisId",
                table: "KrpanTrailer",
                newName: "IX_KrpanTrailer_KrpanChassisId");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanChassis_KrpanChassisId",
                table: "KrpanTrailer",
                column: "KrpanChassisId",
                principalTable: "KrpanChassis",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanChassis_KrpanChassisId",
                table: "KrpanTrailer");

            migrationBuilder.RenameIndex(
                name: "IX_KrpanTrailer_KrpanChassisId",
                table: "KrpanTrailer",
                newName: "IX_KrpanTrailer_KrpanHydraulicAdjustableChassisId");

            migrationBuilder.RenameColumn(
                name: "KrpanChassisId",
                table: "KrpanTrailer",
                newName: "KrpanHydraulicAdjustableChassisId");

            migrationBuilder.RenameTable(
                name: "KrpanChassis",
                newName: "KrpanHydraulicAdjustableChassis");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanHydraulicAdjustableChassis_KrpanHydraulicAdjustableChassisId",
                table: "KrpanTrailer",
                column: "KrpanHydraulicAdjustableChassisId",
                principalTable: "KrpanHydraulicAdjustableChassis",
                principalColumn: "Id");
        }
    }
}
