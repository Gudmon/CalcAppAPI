using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class haybaleframe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HayBaleFrameId",
                table: "Trailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanDrawHeadId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanDrawbarId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HayBaleFrame",
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
                    table.PrimaryKey("PK_HayBaleFrame", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanDrawbar",
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
                    table.PrimaryKey("PK_KrpanDrawbar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanDrawHead",
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
                    table.PrimaryKey("PK_KrpanDrawHead", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "HayBaleFrame",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "HBF", "Széna bála keret (D típushoz)", "2650" },
                    { 2, "HBF", "Széna bála keret (U típushoz)", "2650" }
                });

            migrationBuilder.InsertData(
                table: "KrpanDrawHead",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "300012588", "Vonófej K80", "340" },
                    { 2, "300012588", "Vonófej K80", "415" }
                });

            migrationBuilder.InsertData(
                table: "KrpanDrawbar",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "300012585", "Rögzített vonószem Ø 50", "150" },
                    { 2, "300012587", "Forgó vonószem Ø 50", "325" },
                    { 3, "300012587", "Forgó vonószem Ø 50", "400" }
                });

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

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "HayBaleFrameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "HayBaleFrameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "HayBaleFrameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "HayBaleFrameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "HayBaleFrameId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "HayBaleFrameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "HayBaleFrameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "HayBaleFrameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9,
                column: "HayBaleFrameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "HayBaleFrameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "HayBaleFrameId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 12,
                column: "HayBaleFrameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 13,
                column: "HayBaleFrameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 14,
                column: "HayBaleFrameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 15,
                column: "HayBaleFrameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 16,
                column: "HayBaleFrameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 17,
                column: "HayBaleFrameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 18,
                column: "HayBaleFrameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 19,
                column: "HayBaleFrameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 20,
                column: "HayBaleFrameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 21,
                column: "HayBaleFrameId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 22,
                column: "HayBaleFrameId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_HayBaleFrameId",
                table: "Trailer",
                column: "HayBaleFrameId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanDrawbarId",
                table: "KrpanTrailer",
                column: "KrpanDrawbarId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanDrawHeadId",
                table: "KrpanTrailer",
                column: "KrpanDrawHeadId");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanDrawHead_KrpanDrawHeadId",
                table: "KrpanTrailer",
                column: "KrpanDrawHeadId",
                principalTable: "KrpanDrawHead",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanDrawbar_KrpanDrawbarId",
                table: "KrpanTrailer",
                column: "KrpanDrawbarId",
                principalTable: "KrpanDrawbar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trailer_HayBaleFrame_HayBaleFrameId",
                table: "Trailer",
                column: "HayBaleFrameId",
                principalTable: "HayBaleFrame",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanDrawHead_KrpanDrawHeadId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanDrawbar_KrpanDrawbarId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_Trailer_HayBaleFrame_HayBaleFrameId",
                table: "Trailer");

            migrationBuilder.DropTable(
                name: "HayBaleFrame");

            migrationBuilder.DropTable(
                name: "KrpanDrawbar");

            migrationBuilder.DropTable(
                name: "KrpanDrawHead");

            migrationBuilder.DropIndex(
                name: "IX_Trailer_HayBaleFrameId",
                table: "Trailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanDrawbarId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanDrawHeadId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "HayBaleFrameId",
                table: "Trailer");

            migrationBuilder.DropColumn(
                name: "KrpanDrawHeadId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanDrawbarId",
                table: "KrpanTrailer");
        }
    }
}
