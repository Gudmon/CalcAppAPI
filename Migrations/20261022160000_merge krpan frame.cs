using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    public partial class mergekrpanframe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanChassis_KrpanChassisId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanMechanicalAdjustableFrame_KrpanMechanicalAdjustableFrameId",
                table: "KrpanTrailer");

            migrationBuilder.Sql(
                "UPDATE [KrpanTrailer] SET [KrpanChassisId] = 3 WHERE [KrpanMechanicalAdjustableFrameId] = 1");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanMechanicalAdjustableFrameId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanMechanicalAdjustableFrameId",
                table: "KrpanTrailer");

            migrationBuilder.DropTable(
                name: "KrpanMechanicalAdjustableFrame");

            migrationBuilder.RenameTable(
                name: "KrpanChassis",
                newName: "KrpanFrame");

            migrationBuilder.RenameColumn(
                name: "KrpanChassisId",
                table: "KrpanTrailer",
                newName: "KrpanFrameId");

            migrationBuilder.RenameIndex(
                name: "IX_KrpanTrailer_KrpanChassisId",
                table: "KrpanTrailer",
                newName: "IX_KrpanTrailer_KrpanFrameId");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanFrame_KrpanFrameId",
                table: "KrpanTrailer",
                column: "KrpanFrameId",
                principalTable: "KrpanFrame",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanFrame_KrpanFrameId",
                table: "KrpanTrailer");

            migrationBuilder.RenameIndex(
                name: "IX_KrpanTrailer_KrpanFrameId",
                table: "KrpanTrailer",
                newName: "IX_KrpanTrailer_KrpanChassisId");

            migrationBuilder.RenameColumn(
                name: "KrpanFrameId",
                table: "KrpanTrailer",
                newName: "KrpanChassisId");

            migrationBuilder.RenameTable(
                name: "KrpanFrame",
                newName: "KrpanChassis");

            migrationBuilder.CreateTable(
                name: "KrpanMechanicalAdjustableFrame",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanMechanicalAdjustableFrame", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "KrpanMechanicalAdjustableFrame",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Mechanikusan állítható keret", "0" });

            migrationBuilder.AddColumn<int>(
                name: "KrpanMechanicalAdjustableFrameId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanMechanicalAdjustableFrameId",
                table: "KrpanTrailer",
                column: "KrpanMechanicalAdjustableFrameId");

            migrationBuilder.Sql(
                "UPDATE [KrpanTrailer] SET [KrpanMechanicalAdjustableFrameId] = 1 WHERE [KrpanChassisId] = 3");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanChassis_KrpanChassisId",
                table: "KrpanTrailer",
                column: "KrpanChassisId",
                principalTable: "KrpanChassis",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanMechanicalAdjustableFrame_KrpanMechanicalAdjustableFrameId",
                table: "KrpanTrailer",
                column: "KrpanMechanicalAdjustableFrameId",
                principalTable: "KrpanMechanicalAdjustableFrame",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
