using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpandrawbarandcouplingdevice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "KrpanTrailer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "KrpanTrailer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "KrpanTrailerCouplingDevice",
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
                    table.PrimaryKey("PK_KrpanTrailerCouplingDevice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanTrailerCouplingDeviceTrailer",
                columns: table => new
                {
                    KrpanTrailerCouplingDeviceId = table.Column<int>(type: "int", nullable: false),
                    KrpanTrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanTrailerCouplingDeviceTrailer", x => new { x.KrpanTrailerCouplingDeviceId, x.KrpanTrailerId });
                    table.ForeignKey(
                        name: "FK_KrpanTrailerCouplingDeviceTrailer_KrpanTrailerCouplingDevice_KrpanTrailerCouplingDeviceId",
                        column: x => x.KrpanTrailerCouplingDeviceId,
                        principalTable: "KrpanTrailerCouplingDevice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KrpanTrailerCouplingDeviceTrailer_KrpanTrailer_KrpanTrailerId",
                        column: x => x.KrpanTrailerId,
                        principalTable: "KrpanTrailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "KrpanDrawbar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "", "Vonószem Ø 40 fix", "0" });

            migrationBuilder.UpdateData(
                table: "KrpanDrawbar",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "300012585", "Vonószem Ø 50 fix", "76,67" });

            migrationBuilder.UpdateData(
                table: "KrpanDrawbar",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "300018036", "Vonószem Ø 50 forgó", "248,33" });

            migrationBuilder.InsertData(
                table: "KrpanDrawbar",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 4, "300012588", "Gömbfejes vonószerkezet K80", "234,11" });

            migrationBuilder.InsertData(
                table: "KrpanDrawbarTrailer",
                columns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 14 }
                });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[]", "[]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[]", "[]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[]", "[]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[]", "[]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[]", "[]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[]", "[]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[]", "[]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[]", "[]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrls", "KrpanTrailerLampId", "VideoUrls" },
                values: new object[] { "[\"GP-6-XS-1\",\"GP-6-XS-2\"]", 1, "[\"eB66vywCgFs\"]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrls", "KrpanTrailerLampId", "VideoUrls" },
                values: new object[] { "[]", 1, "[]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrls", "KrpanTrailerLampId", "VideoUrls" },
                values: new object[] { "[]", 1, "[]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrls", "KrpanTrailerLampId", "VideoUrls" },
                values: new object[] { "[]", 1, "[]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrls", "KrpanTrailerLampId", "VideoUrls" },
                values: new object[] { "[]", 1, "[]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrls", "KrpanTrailerLampId", "VideoUrls" },
                values: new object[] { "[]", 1, "[]" });

            migrationBuilder.InsertData(
                table: "KrpanTrailerCouplingDevice",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", "Alsó vonórúd", "0" },
                    { 2, "", "Felső vonórúd", "142,50" }
                });

            migrationBuilder.UpdateData(
                table: "KrpanTrailerLamp",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "LED hátsó lámpák");

            migrationBuilder.InsertData(
                table: "KrpanDrawbarTrailer",
                columns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 8 },
                    { 4, 9 },
                    { 4, 10 },
                    { 4, 11 },
                    { 4, 12 },
                    { 4, 13 },
                    { 4, 14 }
                });

            migrationBuilder.InsertData(
                table: "KrpanTrailerCouplingDeviceTrailer",
                columns: new[] { "KrpanTrailerCouplingDeviceId", "KrpanTrailerId" },
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
                    { 1, 13 },
                    { 1, 14 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailerCouplingDeviceTrailer_KrpanTrailerId",
                table: "KrpanTrailerCouplingDeviceTrailer",
                column: "KrpanTrailerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KrpanTrailerCouplingDeviceTrailer");

            migrationBuilder.DropTable(
                name: "KrpanTrailerCouplingDevice");

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbarTrailer",
                keyColumns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "KrpanDrawbar",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "KrpanTrailer");

            migrationBuilder.UpdateData(
                table: "KrpanDrawbar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "300012585", "Rögzített vonószem Ø 50", "150" });

            migrationBuilder.UpdateData(
                table: "KrpanDrawbar",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "300012587", "Forgó vonószem Ø 50", "325" });

            migrationBuilder.UpdateData(
                table: "KrpanDrawbar",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "300012587", "Forgó vonószem Ø 50", "400" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 9,
                column: "KrpanTrailerLampId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "KrpanTrailerLampId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "KrpanTrailerLampId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 12,
                column: "KrpanTrailerLampId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 13,
                column: "KrpanTrailerLampId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 14,
                column: "KrpanTrailerLampId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailerLamp",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Lámpa");
        }
    }
}
