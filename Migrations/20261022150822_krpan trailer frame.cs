using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpantrailerframe : Migration
    {
        /// <inheritdoc />
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

            migrationBuilder.Sql(
                "IF NOT EXISTS (SELECT 1 FROM [KrpanChassis] WHERE [Id] = 2) " +
                "BEGIN " +
                "SET IDENTITY_INSERT [KrpanChassis] ON; " +
                "INSERT INTO [KrpanChassis] ([Id], [Code], [Name], [Price]) VALUES (2, N'', N'Fix keret', N'0'); " +
                "SET IDENTITY_INSERT [KrpanChassis] OFF; " +
                "END");

            migrationBuilder.Sql(
                "IF NOT EXISTS (SELECT 1 FROM [KrpanChassis] WHERE [Id] = 3) " +
                "BEGIN " +
                "SET IDENTITY_INSERT [KrpanChassis] ON; " +
                "INSERT INTO [KrpanChassis] ([Id], [Code], [Name], [Price]) VALUES (3, N'', N'Mechanikusan állítható keret', N'0'); " +
                "SET IDENTITY_INSERT [KrpanChassis] OFF; " +
                "END");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanChassis_KrpanChassisId",
                table: "KrpanTrailer",
                column: "KrpanChassisId",
                principalTable: "KrpanChassis",
                principalColumn: "Id");

            migrationBuilder.Sql(
                "UPDATE [KrpanTrailer] SET [KrpanChassisId] = 2 WHERE [Id] IN (1, 2, 3, 4, 5)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "UPDATE [KrpanTrailer] SET [KrpanFrameId] = NULL WHERE [Id] IN (1, 2, 3, 4, 5)");

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
