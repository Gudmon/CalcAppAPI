using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class trailercraneconfig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Available",
                table: "FrameType");

            migrationBuilder.DropColumn(
                name: "Recommended",
                table: "FrameType");

            migrationBuilder.CreateTable(
                name: "TrailerCraneConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrailerId = table.Column<int>(type: "int", nullable: false),
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    SelectedFrameTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrailerCraneConfigurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrailerCraneConfigurations_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrailerCraneConfigurations_FrameType_SelectedFrameTypeId",
                        column: x => x.SelectedFrameTypeId,
                        principalTable: "FrameType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrailerCraneConfigurations_Trailer_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrailerFrameTypeConfiguration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrailerId = table.Column<int>(type: "int", nullable: false),
                    FrameTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrailerFrameTypeConfiguration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrailerFrameTypeConfiguration_FrameType_FrameTypeId",
                        column: x => x.FrameTypeId,
                        principalTable: "FrameType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrailerFrameTypeConfiguration_Trailer_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TrailerCraneConfigurations",
                columns: new[] { "Id", "CraneId", "SelectedFrameTypeId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 4, 1, 1 },
                    { 2, 4, 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrailerCraneConfigurations_CraneId",
                table: "TrailerCraneConfigurations",
                column: "CraneId");

            migrationBuilder.CreateIndex(
                name: "IX_TrailerCraneConfigurations_SelectedFrameTypeId",
                table: "TrailerCraneConfigurations",
                column: "SelectedFrameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TrailerCraneConfigurations_TrailerId",
                table: "TrailerCraneConfigurations",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrailerFrameTypeConfiguration_FrameTypeId",
                table: "TrailerFrameTypeConfiguration",
                column: "FrameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TrailerFrameTypeConfiguration_TrailerId",
                table: "TrailerFrameTypeConfiguration",
                column: "TrailerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrailerCraneConfigurations");

            migrationBuilder.DropTable(
                name: "TrailerFrameTypeConfiguration");

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
    }
}
