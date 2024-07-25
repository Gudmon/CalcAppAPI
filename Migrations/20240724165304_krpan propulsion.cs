using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpanpropulsion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KrpanAdjustableDriveId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "KrpanAdjustableDrive",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanAdjustableDrive", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanPropulsion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanPropulsion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanPropulsionTrailer",
                columns: table => new
                {
                    KrpanPropulsionId = table.Column<int>(type: "int", nullable: false),
                    KrpanTrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanPropulsionTrailer", x => new { x.KrpanPropulsionId, x.KrpanTrailerId });
                    table.ForeignKey(
                        name: "FK_KrpanPropulsionTrailer_KrpanPropulsion_KrpanPropulsionId",
                        column: x => x.KrpanPropulsionId,
                        principalTable: "KrpanPropulsion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KrpanPropulsionTrailer_KrpanTrailer_KrpanTrailerId",
                        column: x => x.KrpanTrailerId,
                        principalTable: "KrpanTrailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "KrpanAdjustableDrive",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Proporcionálisan állítható meghajtás", "2235" });

            migrationBuilder.InsertData(
                table: "KrpanPropulsion",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", "2 WD (BB4, 400/60-15,5 vagy 500/50-17 gumimérethez)", "9875" },
                    { 2, "", "2 WD (BB5, 550/45-22,5 vagy 400/55-22,5 gumimérethez)", "12355" },
                    { 3, "", "4 WD (BB4, 400/60-15,5 vagy 500/50-17 gumimérethez)", "21210" },
                    { 4, "", "4 WD (BB5, 550/45-22,5 vagy 400/55-22,5 gumimérethez)", "26165" }
                });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "KrpanAdjustableDriveId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "KrpanAdjustableDriveId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "KrpanAdjustableDriveId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "KrpanAdjustableDriveId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "KrpanAdjustableDriveId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "KrpanAdjustableDriveId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "KrpanAdjustableDriveId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "KrpanAdjustableDriveId",
                value: 1);

            migrationBuilder.InsertData(
                table: "KrpanPropulsionTrailer",
                columns: new[] { "KrpanPropulsionId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 7 },
                    { 3, 8 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 7 },
                    { 4, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanAdjustableDriveId",
                table: "KrpanTrailer",
                column: "KrpanAdjustableDriveId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanPropulsionTrailer_KrpanTrailerId",
                table: "KrpanPropulsionTrailer",
                column: "KrpanTrailerId");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanAdjustableDrive_KrpanAdjustableDriveId",
                table: "KrpanTrailer",
                column: "KrpanAdjustableDriveId",
                principalTable: "KrpanAdjustableDrive",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanAdjustableDrive_KrpanAdjustableDriveId",
                table: "KrpanTrailer");

            migrationBuilder.DropTable(
                name: "KrpanAdjustableDrive");

            migrationBuilder.DropTable(
                name: "KrpanPropulsionTrailer");

            migrationBuilder.DropTable(
                name: "KrpanPropulsion");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanAdjustableDriveId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanAdjustableDriveId",
                table: "KrpanTrailer");
        }
    }
}
