using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class cranescontrolblocks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ControlBlockCrane",
                columns: table => new
                {
                    ControlBlockId = table.Column<int>(type: "int", nullable: false),
                    CraneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlBlockCrane", x => new { x.ControlBlockId, x.CraneId });
                    table.ForeignKey(
                        name: "FK_ControlBlockCrane_ControlBlocks_ControlBlockId",
                        column: x => x.ControlBlockId,
                        principalTable: "ControlBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ControlBlockCrane_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ControlBlockCrane",
                columns: new[] { "ControlBlockId", "CraneId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 4, 2 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 },
                    { 6, 2 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 6, 8 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 7, 6 },
                    { 7, 7 },
                    { 7, 8 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 11 },
                    { 7, 12 },
                    { 8, 2 },
                    { 8, 4 },
                    { 8, 5 },
                    { 8, 6 },
                    { 8, 7 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 8, 11 },
                    { 8, 12 },
                    { 9, 2 },
                    { 9, 4 },
                    { 9, 5 },
                    { 9, 6 },
                    { 9, 7 },
                    { 9, 8 },
                    { 9, 9 },
                    { 9, 10 },
                    { 9, 11 },
                    { 9, 12 },
                    { 10, 6 },
                    { 10, 7 },
                    { 10, 8 },
                    { 10, 9 },
                    { 10, 10 },
                    { 10, 11 },
                    { 10, 12 },
                    { 11, 2 },
                    { 11, 4 },
                    { 11, 5 },
                    { 11, 6 },
                    { 11, 7 },
                    { 11, 8 },
                    { 11, 9 },
                    { 11, 10 },
                    { 11, 11 },
                    { 11, 12 },
                    { 12, 6 },
                    { 12, 7 },
                    { 12, 8 },
                    { 12, 9 },
                    { 12, 10 },
                    { 12, 11 },
                    { 12, 12 },
                    { 13, 6 },
                    { 13, 7 },
                    { 13, 8 },
                    { 13, 9 },
                    { 13, 10 },
                    { 13, 11 },
                    { 13, 12 },
                    { 14, 10 },
                    { 14, 11 },
                    { 14, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ControlBlockCrane_CraneId",
                table: "ControlBlockCrane",
                column: "CraneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ControlBlockCrane");
        }
    }
}
