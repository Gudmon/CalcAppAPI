using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class changemanytomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrakeTrailer");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Tyre",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "TrailerBrakeJoinEntity",
                columns: table => new
                {
                    TrailerId = table.Column<int>(type: "int", nullable: false),
                    BrakeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrailerBrakeJoinEntity", x => new { x.TrailerId, x.BrakeId });
                    table.ForeignKey(
                        name: "FK_TrailerBrakeJoinEntity_Brake_BrakeId",
                        column: x => x.BrakeId,
                        principalTable: "Brake",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrailerBrakeJoinEntity_Trailer_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TrailerBrakeJoinEntity",
                columns: new[] { "BrakeId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 },
                    { 5, 3 },
                    { 8, 3 },
                    { 9, 3 },
                    { 1, 4 },
                    { 2, 4 },
                    { 3, 4 },
                    { 4, 4 },
                    { 5, 4 },
                    { 6, 4 },
                    { 7, 4 },
                    { 1, 5 },
                    { 2, 5 },
                    { 3, 5 },
                    { 4, 5 },
                    { 5, 5 },
                    { 8, 5 },
                    { 9, 5 },
                    { 1, 6 },
                    { 10, 6 },
                    { 11, 6 },
                    { 12, 6 },
                    { 13, 6 },
                    { 14, 6 },
                    { 15, 6 },
                    { 1, 7 },
                    { 10, 7 },
                    { 11, 7 },
                    { 12, 7 },
                    { 13, 7 },
                    { 14, 7 },
                    { 15, 7 },
                    { 1, 8 },
                    { 2, 8 },
                    { 3, 8 },
                    { 4, 8 },
                    { 5, 8 },
                    { 8, 8 },
                    { 9, 8 },
                    { 1, 9 },
                    { 10, 9 },
                    { 11, 9 },
                    { 12, 9 },
                    { 13, 9 },
                    { 14, 9 },
                    { 15, 9 },
                    { 1, 10 },
                    { 16, 10 },
                    { 17, 10 },
                    { 18, 10 },
                    { 19, 10 },
                    { 20, 10 },
                    { 21, 10 },
                    { 1, 11 },
                    { 10, 11 },
                    { 11, 11 },
                    { 12, 11 },
                    { 13, 11 },
                    { 14, 11 },
                    { 15, 11 },
                    { 1, 12 },
                    { 16, 12 },
                    { 17, 12 },
                    { 18, 12 },
                    { 19, 12 },
                    { 20, 12 },
                    { 21, 12 },
                    { 23, 13 },
                    { 24, 13 },
                    { 23, 14 },
                    { 24, 14 },
                    { 1, 16 },
                    { 10, 16 },
                    { 11, 16 },
                    { 12, 16 },
                    { 13, 16 },
                    { 14, 16 },
                    { 15, 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrailerBrakeJoinEntity_BrakeId",
                table: "TrailerBrakeJoinEntity",
                column: "BrakeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrailerBrakeJoinEntity");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Tyre",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "BrakeTrailer",
                columns: table => new
                {
                    BrakeId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrakeTrailer", x => new { x.BrakeId, x.TrailerId });
                    table.ForeignKey(
                        name: "FK_BrakeTrailer_Brake_BrakeId",
                        column: x => x.BrakeId,
                        principalTable: "Brake",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrakeTrailer_Trailer_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BrakeTrailer",
                columns: new[] { "BrakeId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 1, 16 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 8 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 8 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 8 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 8 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 4 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 4 },
                    { 8, 3 },
                    { 8, 5 },
                    { 8, 8 },
                    { 9, 3 },
                    { 9, 5 },
                    { 9, 8 },
                    { 10, 6 },
                    { 10, 7 },
                    { 10, 9 },
                    { 10, 11 },
                    { 10, 16 },
                    { 11, 6 },
                    { 11, 7 },
                    { 11, 9 },
                    { 11, 11 },
                    { 11, 16 },
                    { 12, 6 },
                    { 12, 7 },
                    { 12, 9 },
                    { 12, 11 },
                    { 12, 16 },
                    { 13, 6 },
                    { 13, 7 },
                    { 13, 9 },
                    { 13, 11 },
                    { 13, 16 },
                    { 14, 6 },
                    { 14, 7 },
                    { 14, 9 },
                    { 14, 11 },
                    { 14, 16 },
                    { 15, 6 },
                    { 15, 7 },
                    { 15, 9 },
                    { 15, 11 },
                    { 15, 16 },
                    { 16, 10 },
                    { 16, 12 },
                    { 17, 10 },
                    { 17, 12 },
                    { 18, 10 },
                    { 18, 12 },
                    { 19, 10 },
                    { 19, 12 },
                    { 20, 10 },
                    { 20, 12 },
                    { 21, 10 },
                    { 21, 12 },
                    { 23, 13 },
                    { 23, 14 },
                    { 24, 13 },
                    { 24, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrakeTrailer_TrailerId",
                table: "BrakeTrailer",
                column: "TrailerId");
        }
    }
}
