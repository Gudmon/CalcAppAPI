using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class remove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrailerCraneCompatibilities");

            migrationBuilder.AddColumn<bool>(
                name: "Available",
                table: "FrameType",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Recommended",
                table: "FrameType",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Available", "Recommended" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Available", "Recommended" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Available", "Recommended" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Available", "Recommended" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Available", "Recommended" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Available", "Recommended" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Available", "Recommended" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Available", "Recommended" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Available",
                table: "FrameType");

            migrationBuilder.DropColumn(
                name: "Recommended",
                table: "FrameType");

            migrationBuilder.CreateTable(
                name: "TrailerCraneCompatibilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    FrameTypeId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    Recommended = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrailerCraneCompatibilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrailerCraneCompatibilities_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrailerCraneCompatibilities_FrameType_FrameTypeId",
                        column: x => x.FrameTypeId,
                        principalTable: "FrameType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrailerCraneCompatibilities_Trailer_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TrailerCraneCompatibilities",
                columns: new[] { "Id", "Available", "CraneId", "FrameTypeId", "Recommended", "TrailerId" },
                values: new object[,]
                {
                    { 1, true, 1, 1, true, 1 },
                    { 2, true, 2, 1, true, 1 },
                    { 3, true, 3, 1, true, 1 },
                    { 4, true, 4, 1, true, 1 },
                    { 5, true, 5, 1, true, 1 },
                    { 6, true, 4, 3, true, 2 },
                    { 7, true, 4, 4, true, 2 },
                    { 8, true, 4, 5, false, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrailerCraneCompatibilities_CraneId",
                table: "TrailerCraneCompatibilities",
                column: "CraneId");

            migrationBuilder.CreateIndex(
                name: "IX_TrailerCraneCompatibilities_FrameTypeId",
                table: "TrailerCraneCompatibilities",
                column: "FrameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TrailerCraneCompatibilities_TrailerId",
                table: "TrailerCraneCompatibilities",
                column: "TrailerId");
        }
    }
}
