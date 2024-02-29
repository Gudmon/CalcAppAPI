using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixboomguard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoomGuardCrane");

            migrationBuilder.AddColumn<int>(
                name: "BoomGuardId",
                table: "Crane",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 1,
                column: "BoomGuardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 2,
                column: "BoomGuardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                column: "BoomGuardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 4,
                column: "BoomGuardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 5,
                column: "BoomGuardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 6,
                column: "BoomGuardId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 7,
                column: "BoomGuardId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                column: "BoomGuardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 9,
                column: "BoomGuardId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 10,
                column: "BoomGuardId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 11,
                column: "BoomGuardId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 12,
                column: "BoomGuardId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Crane_BoomGuardId",
                table: "Crane",
                column: "BoomGuardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crane_BoomGuard_BoomGuardId",
                table: "Crane",
                column: "BoomGuardId",
                principalTable: "BoomGuard",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crane_BoomGuard_BoomGuardId",
                table: "Crane");

            migrationBuilder.DropIndex(
                name: "IX_Crane_BoomGuardId",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "BoomGuardId",
                table: "Crane");

            migrationBuilder.CreateTable(
                name: "BoomGuardCrane",
                columns: table => new
                {
                    BoomGuardId = table.Column<int>(type: "int", nullable: false),
                    CraneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoomGuardCrane", x => new { x.BoomGuardId, x.CraneId });
                    table.ForeignKey(
                        name: "FK_BoomGuardCrane_BoomGuard_BoomGuardId",
                        column: x => x.BoomGuardId,
                        principalTable: "BoomGuard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoomGuardCrane_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BoomGuardCrane",
                columns: new[] { "BoomGuardId", "CraneId" },
                values: new object[,]
                {
                    { 1, 6 },
                    { 1, 7 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 3, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoomGuardCrane_CraneId",
                table: "BoomGuardCrane",
                column: "CraneId");
        }
    }
}
