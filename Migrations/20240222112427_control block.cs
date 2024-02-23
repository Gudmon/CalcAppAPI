using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class controlblock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FrameType_ControlBlocks_ControlBlockId",
                table: "FrameType");

            migrationBuilder.DropIndex(
                name: "IX_FrameType_ControlBlockId",
                table: "FrameType");

            migrationBuilder.DropColumn(
                name: "ControlBlockId",
                table: "FrameType");

            migrationBuilder.CreateTable(
                name: "ControlBlockFrameType",
                columns: table => new
                {
                    AvailableForFrameTypesId = table.Column<int>(type: "int", nullable: false),
                    ControlBlockId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlBlockFrameType", x => new { x.AvailableForFrameTypesId, x.ControlBlockId });
                    table.ForeignKey(
                        name: "FK_ControlBlockFrameType_ControlBlocks_ControlBlockId",
                        column: x => x.ControlBlockId,
                        principalTable: "ControlBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ControlBlockFrameType_FrameType_AvailableForFrameTypesId",
                        column: x => x.AvailableForFrameTypesId,
                        principalTable: "FrameType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ControlBlockFrameType_ControlBlockId",
                table: "ControlBlockFrameType",
                column: "ControlBlockId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ControlBlockFrameType");

            migrationBuilder.AddColumn<int>(
                name: "ControlBlockId",
                table: "FrameType",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 1,
                column: "ControlBlockId",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 2,
                column: "ControlBlockId",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 3,
                column: "ControlBlockId",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 4,
                column: "ControlBlockId",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 5,
                column: "ControlBlockId",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 6,
                column: "ControlBlockId",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 7,
                column: "ControlBlockId",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 8,
                column: "ControlBlockId",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 9,
                column: "ControlBlockId",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 10,
                column: "ControlBlockId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_FrameType_ControlBlockId",
                table: "FrameType",
                column: "ControlBlockId");

            migrationBuilder.AddForeignKey(
                name: "FK_FrameType_ControlBlocks_ControlBlockId",
                table: "FrameType",
                column: "ControlBlockId",
                principalTable: "ControlBlocks",
                principalColumn: "Id");
        }
    }
}
