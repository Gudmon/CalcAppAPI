using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class boomguards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoomGuard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoomGuard", x => x.Id);
                });

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
                table: "BoomGuard",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "BG5", "Főgém védő az 5-ös szériához", "630" },
                    { 2, "BG7", "Főgém védő a 7-es szériához", "650" },
                    { 3, "BG10", "Főgém védő X100-hoz", "675" }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoomGuardCrane");

            migrationBuilder.DropTable(
                name: "BoomGuard");
        }
    }
}
