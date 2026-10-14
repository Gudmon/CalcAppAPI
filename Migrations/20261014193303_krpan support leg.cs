using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpansupportleg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanHydraulicSupportLeg_KrpanHydraulicSupportLegId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanTrailerSupportLeg_KrpanTrailerSupportLegId",
                table: "KrpanTrailer");

            migrationBuilder.DropTable(
                name: "KrpanHydraulicSupportLeg");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanHydraulicSupportLegId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanHydraulicSupportLegId",
                table: "KrpanTrailer");

            migrationBuilder.RenameColumn(
                name: "KrpanTrailerSupportLegId",
                table: "KrpanTrailer",
                newName: "KrpanMechanicalAdjustableFrameId");

            migrationBuilder.RenameIndex(
                name: "IX_KrpanTrailer_KrpanTrailerSupportLegId",
                table: "KrpanTrailer",
                newName: "IX_KrpanTrailer_KrpanMechanicalAdjustableFrameId");

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

            migrationBuilder.CreateTable(
                name: "KrpanSupportLegsTrailer",
                columns: table => new
                {
                    KrpanTrailerId = table.Column<int>(type: "int", nullable: false),
                    KrpanTrailerSupportLegsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanSupportLegsTrailer", x => new { x.KrpanTrailerId, x.KrpanTrailerSupportLegsId });
                    table.ForeignKey(
                        name: "FK_KrpanSupportLegsTrailer_KrpanTrailerSupportLeg_KrpanTrailerSupportLegsId",
                        column: x => x.KrpanTrailerSupportLegsId,
                        principalTable: "KrpanTrailerSupportLeg",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KrpanSupportLegsTrailer_KrpanTrailer_KrpanTrailerId",
                        column: x => x.KrpanTrailerId,
                        principalTable: "KrpanTrailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "KrpanMechanicalAdjustableFrame",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Mechanikusan állítható keret", "0" });

            migrationBuilder.InsertData(
                table: "KrpanSupportLegsTrailer",
                columns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                values: new object[,]
                {
                    { 6, 1 },
                    { 9, 1 },
                    { 10, 1 },
                    { 11, 1 },
                    { 12, 1 },
                    { 13, 1 },
                    { 14, 1 }
                });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KrpanDrawbarSteeringId", "KrpanMechanicalAdjustableFrameId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "KrpanMechanicalAdjustableFrameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "KrpanMechanicalAdjustableFrameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "KrpanMechanicalAdjustableFrameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "KrpanMechanicalAdjustableFrameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "KrpanMechanicalAdjustableFrameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "KrpanMechanicalAdjustableFrameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "KrpanMechanicalAdjustableFrameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 9,
                column: "KrpanMechanicalAdjustableFrameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "KrpanMechanicalAdjustableFrameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "KrpanMechanicalAdjustableFrameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 12,
                column: "KrpanMechanicalAdjustableFrameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 13,
                column: "KrpanMechanicalAdjustableFrameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 14,
                column: "KrpanMechanicalAdjustableFrameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailerSupportLeg",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Mechanikus támasztóláb - fix");

            migrationBuilder.InsertData(
                table: "KrpanTrailerSupportLeg",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 2, "", "Mechanikus támasztóláb - állítható", "150,00" },
                    { 3, "", "Hidraulikus támasztóláb", "519,17" }
                });

            migrationBuilder.InsertData(
                table: "KrpanSupportLegsTrailer",
                columns: new[] { "KrpanTrailerId", "KrpanTrailerSupportLegsId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 2 },
                    { 3, 3 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 2 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 2 },
                    { 7, 3 },
                    { 8, 2 },
                    { 8, 3 },
                    { 9, 2 },
                    { 10, 2 },
                    { 11, 2 },
                    { 12, 2 },
                    { 13, 2 },
                    { 14, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KrpanSupportLegsTrailer_KrpanTrailerSupportLegsId",
                table: "KrpanSupportLegsTrailer",
                column: "KrpanTrailerSupportLegsId");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanMechanicalAdjustableFrame_KrpanMechanicalAdjustableFrameId",
                table: "KrpanTrailer",
                column: "KrpanMechanicalAdjustableFrameId",
                principalTable: "KrpanMechanicalAdjustableFrame",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanMechanicalAdjustableFrame_KrpanMechanicalAdjustableFrameId",
                table: "KrpanTrailer");

            migrationBuilder.DropTable(
                name: "KrpanMechanicalAdjustableFrame");

            migrationBuilder.DropTable(
                name: "KrpanSupportLegsTrailer");

            migrationBuilder.DeleteData(
                table: "KrpanTrailerSupportLeg",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KrpanTrailerSupportLeg",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "KrpanMechanicalAdjustableFrameId",
                table: "KrpanTrailer",
                newName: "KrpanTrailerSupportLegId");

            migrationBuilder.RenameIndex(
                name: "IX_KrpanTrailer_KrpanMechanicalAdjustableFrameId",
                table: "KrpanTrailer",
                newName: "IX_KrpanTrailer_KrpanTrailerSupportLegId");

            migrationBuilder.AddColumn<int>(
                name: "KrpanHydraulicSupportLegId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "KrpanHydraulicSupportLeg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanHydraulicSupportLeg", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "KrpanHydraulicSupportLeg",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "300013635", "Hidraulikus támasztóláb GP pótkocsihoz (Z darunál kötelező)", "530" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KrpanDrawbarSteeringId", "KrpanHydraulicSupportLegId", "KrpanTrailerSupportLegId" },
                values: new object[] { 1, null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KrpanHydraulicSupportLegId", "KrpanTrailerSupportLegId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "KrpanHydraulicSupportLegId", "KrpanTrailerSupportLegId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "KrpanHydraulicSupportLegId", "KrpanTrailerSupportLegId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "KrpanHydraulicSupportLegId", "KrpanTrailerSupportLegId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "KrpanHydraulicSupportLegId", "KrpanTrailerSupportLegId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "KrpanHydraulicSupportLegId", "KrpanTrailerSupportLegId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "KrpanHydraulicSupportLegId", "KrpanTrailerSupportLegId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "KrpanHydraulicSupportLegId", "KrpanTrailerSupportLegId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "KrpanHydraulicSupportLegId", "KrpanTrailerSupportLegId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "KrpanHydraulicSupportLegId", "KrpanTrailerSupportLegId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "KrpanHydraulicSupportLegId", "KrpanTrailerSupportLegId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "KrpanHydraulicSupportLegId", "KrpanTrailerSupportLegId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "KrpanHydraulicSupportLegId", "KrpanTrailerSupportLegId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailerSupportLeg",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Kitámasztó láb");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanHydraulicSupportLegId",
                table: "KrpanTrailer",
                column: "KrpanHydraulicSupportLegId");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanHydraulicSupportLeg_KrpanHydraulicSupportLegId",
                table: "KrpanTrailer",
                column: "KrpanHydraulicSupportLegId",
                principalTable: "KrpanHydraulicSupportLeg",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanTrailerSupportLeg_KrpanTrailerSupportLegId",
                table: "KrpanTrailer",
                column: "KrpanTrailerSupportLegId",
                principalTable: "KrpanTrailerSupportLeg",
                principalColumn: "Id");
        }
    }
}
