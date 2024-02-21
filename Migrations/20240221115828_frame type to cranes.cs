using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class frametypetocranes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FrameTypeCrane",
                columns: table => new
                {
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    FrameTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameTypeCrane", x => new { x.CraneId, x.FrameTypeId });
                    table.ForeignKey(
                        name: "FK_FrameTypeCrane_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FrameTypeCrane_FrameType_FrameTypeId",
                        column: x => x.FrameTypeId,
                        principalTable: "FrameType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FrameTypeCrane",
                columns: new[] { "CraneId", "FrameTypeId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_FrameTypeCrane_FrameTypeId",
                table: "FrameTypeCrane",
                column: "FrameTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FrameTypeCrane");
        }
    }
}
