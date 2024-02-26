using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class hoseguards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HoseGuard",
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
                    table.PrimaryKey("PK_HoseGuard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HoseGuardCrane",
                columns: table => new
                {
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    HoseGuardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoseGuardCrane", x => new { x.CraneId, x.HoseGuardId });
                    table.ForeignKey(
                        name: "FK_HoseGuardCrane_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoseGuardCrane_HoseGuard_HoseGuardId",
                        column: x => x.HoseGuardId,
                        principalTable: "HoseGuard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "HoseGuard",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "HG1", "Tömlő védő B3 és B6.1 talpaló esetén", "105" },
                    { 2, "HG2", "Tömlő védő  B09 és B9 talpaló esetén", "105" }
                });

            migrationBuilder.InsertData(
                table: "HoseGuardCrane",
                columns: new[] { "CraneId", "HoseGuardId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 6, 2 },
                    { 7, 1 },
                    { 7, 2 },
                    { 9, 1 },
                    { 9, 2 },
                    { 10, 1 },
                    { 10, 2 },
                    { 11, 1 },
                    { 11, 2 },
                    { 12, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoseGuardCrane_HoseGuardId",
                table: "HoseGuardCrane",
                column: "HoseGuardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoseGuardCrane");

            migrationBuilder.DropTable(
                name: "HoseGuard");
        }
    }
}
