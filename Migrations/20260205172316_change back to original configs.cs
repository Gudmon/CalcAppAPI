using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class changebacktooriginalconfigs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrailerBrakeJoinEntity");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 10, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 11, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 12, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 13, 11 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 13, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 14, 11 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 14, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 15, 11 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 15, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 16, 12 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 17, 10 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 17, 12 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 18, 10 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 18, 12 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 19, 10 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 19, 12 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 20, 10 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 20, 12 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 21, 10 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 21, 12 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 23, 13 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 23, 14 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 24, 13 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 24, 14 });

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
    }
}
