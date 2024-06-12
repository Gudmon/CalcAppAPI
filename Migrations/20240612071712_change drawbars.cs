using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class changedrawbars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanDrawbar_KrpanDrawbarId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanDrawbarId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanDrawbarId",
                table: "KrpanTrailer");

            migrationBuilder.CreateTable(
                name: "KrpanDrawbarTrailer",
                columns: table => new
                {
                    KrpanDrawbarId = table.Column<int>(type: "int", nullable: false),
                    KrpanTrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanDrawbarTrailer", x => new { x.KrpanDrawbarId, x.KrpanTrailerId });
                    table.ForeignKey(
                        name: "FK_KrpanDrawbarTrailer_KrpanDrawbar_KrpanDrawbarId",
                        column: x => x.KrpanDrawbarId,
                        principalTable: "KrpanDrawbar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KrpanDrawbarTrailer_KrpanTrailer_KrpanTrailerId",
                        column: x => x.KrpanTrailerId,
                        principalTable: "KrpanTrailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "KrpanDrawbarTrailer",
                columns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 }
                });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "KrpanDrawHeadId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "KrpanDrawHeadId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "KrpanDrawHeadId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "KrpanDrawHeadId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "KrpanDrawHeadId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "KrpanDrawHeadId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "KrpanDrawHeadId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "KrpanDrawHeadId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_KrpanDrawbarTrailer_KrpanTrailerId",
                table: "KrpanDrawbarTrailer",
                column: "KrpanTrailerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KrpanDrawbarTrailer");

            migrationBuilder.AddColumn<int>(
                name: "KrpanDrawbarId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KrpanDrawHeadId", "KrpanDrawbarId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KrpanDrawHeadId", "KrpanDrawbarId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "KrpanDrawHeadId", "KrpanDrawbarId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "KrpanDrawHeadId", "KrpanDrawbarId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "KrpanDrawHeadId", "KrpanDrawbarId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "KrpanDrawHeadId", "KrpanDrawbarId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "KrpanDrawHeadId", "KrpanDrawbarId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "KrpanDrawHeadId", "KrpanDrawbarId" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanDrawbarId",
                table: "KrpanTrailer",
                column: "KrpanDrawbarId");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanDrawbar_KrpanDrawbarId",
                table: "KrpanTrailer",
                column: "KrpanDrawbarId",
                principalTable: "KrpanDrawbar",
                principalColumn: "Id");
        }
    }
}
