using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpancraneleverhydraulic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KrpanCraneControlLeverProtectionId",
                table: "KrpanCrane",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanCraneTractorHydraulicsId",
                table: "KrpanCrane",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "KrpanCraneControlLeverProtection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanCraneControlLeverProtection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanCraneTractorHydraulics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanCraneTractorHydraulics", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KrpanCraneControlLeverProtectionId", "KrpanCraneTractorHydraulicsId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KrpanCraneControlLeverProtectionId", "KrpanCraneTractorHydraulicsId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "KrpanCraneControlLeverProtectionId", "KrpanCraneTractorHydraulicsId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "KrpanCraneControlLeverProtectionId", "KrpanCraneTractorHydraulicsId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "KrpanCraneControlLeverProtectionId", "KrpanCraneTractorHydraulicsId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "KrpanCraneControlLeverProtectionId", "KrpanCraneTractorHydraulicsId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "KrpanCraneControlLeverProtectionId", "KrpanCraneTractorHydraulicsId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "KrpanCraneControlLeverProtectionId", "KrpanCraneTractorHydraulicsId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "KrpanCraneControlLeverProtectionId", "KrpanCraneTractorHydraulicsId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "KrpanCraneControlLeverProtectionId", "KrpanCraneTractorHydraulicsId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "KrpanCraneControlLeverProtectionId", "KrpanCraneTractorHydraulicsId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "KrpanCraneControlLeverProtectionId", "KrpanCraneTractorHydraulicsId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "KrpanCraneControlLeverProtection",
                columns: new[] { "Id", "Code", "Description", "Name", "Price" },
                values: new object[] { 1, "", "", "Vezérlőkar védelem", "0" });

            migrationBuilder.InsertData(
                table: "KrpanCraneTractorHydraulics",
                columns: new[] { "Id", "Code", "Description", "Name", "Price" },
                values: new object[] { 1, "", "", "Traktor hidraulika", "0" });

            migrationBuilder.CreateIndex(
                name: "IX_KrpanCrane_KrpanCraneControlLeverProtectionId",
                table: "KrpanCrane",
                column: "KrpanCraneControlLeverProtectionId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanCrane_KrpanCraneTractorHydraulicsId",
                table: "KrpanCrane",
                column: "KrpanCraneTractorHydraulicsId");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanCrane_KrpanCraneControlLeverProtection_KrpanCraneControlLeverProtectionId",
                table: "KrpanCrane",
                column: "KrpanCraneControlLeverProtectionId",
                principalTable: "KrpanCraneControlLeverProtection",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanCrane_KrpanCraneTractorHydraulics_KrpanCraneTractorHydraulicsId",
                table: "KrpanCrane",
                column: "KrpanCraneTractorHydraulicsId",
                principalTable: "KrpanCraneTractorHydraulics",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KrpanCrane_KrpanCraneControlLeverProtection_KrpanCraneControlLeverProtectionId",
                table: "KrpanCrane");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanCrane_KrpanCraneTractorHydraulics_KrpanCraneTractorHydraulicsId",
                table: "KrpanCrane");

            migrationBuilder.DropTable(
                name: "KrpanCraneControlLeverProtection");

            migrationBuilder.DropTable(
                name: "KrpanCraneTractorHydraulics");

            migrationBuilder.DropIndex(
                name: "IX_KrpanCrane_KrpanCraneControlLeverProtectionId",
                table: "KrpanCrane");

            migrationBuilder.DropIndex(
                name: "IX_KrpanCrane_KrpanCraneTractorHydraulicsId",
                table: "KrpanCrane");

            migrationBuilder.DropColumn(
                name: "KrpanCraneControlLeverProtectionId",
                table: "KrpanCrane");

            migrationBuilder.DropColumn(
                name: "KrpanCraneTractorHydraulicsId",
                table: "KrpanCrane");
        }
    }
}
