using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpantrailerbrakelamps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KrpanTrailerBrakeLamp",
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
                    table.PrimaryKey("PK_KrpanTrailerBrakeLamp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanTrailerBrakeLampTrailer",
                columns: table => new
                {
                    KrpanTrailerBrakeLampsId = table.Column<int>(type: "int", nullable: false),
                    KrpanTrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanTrailerBrakeLampTrailer", x => new { x.KrpanTrailerBrakeLampsId, x.KrpanTrailerId });
                    table.ForeignKey(
                        name: "FK_KrpanTrailerBrakeLampTrailer_KrpanTrailerBrakeLamp_KrpanTrailerBrakeLampsId",
                        column: x => x.KrpanTrailerBrakeLampsId,
                        principalTable: "KrpanTrailerBrakeLamp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KrpanTrailerBrakeLampTrailer_KrpanTrailer_KrpanTrailerId",
                        column: x => x.KrpanTrailerId,
                        principalTable: "KrpanTrailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "KrpanBaleTransportPlatform",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: "1897,50");

            migrationBuilder.UpdateData(
                table: "KrpanBaleTransportPlatform",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: "1897,50");

            migrationBuilder.UpdateData(
                table: "KrpanBaleTransportPlatform",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "Price" },
                values: new object[] { "300023127", "1897,50" });

            migrationBuilder.UpdateData(
                table: "KrpanBaleTransportPlatform",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "Price" },
                values: new object[] { "300023255", "1897,50" });

            migrationBuilder.InsertData(
                table: "KrpanBaleTransportPlatform",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 5, "300011151", "Platform bálaszállításhoz", "1897,50" },
                    { 6, "300011149", "Platform bálaszállításhoz", "1897,50" }
                });

            migrationBuilder.UpdateData(
                table: "KrpanGrappleLocation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "300029549", "A rakfelület-hosszabbítás teherbírásának megerősítése a markoló elhelyezéséhez", "193,27" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "KrpanBaleTransportPlatformId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "KrpanBaleTransportPlatformId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "KrpanBaleTransportPlatformId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "KrpanBaleTransportPlatformId",
                value: 6);

            migrationBuilder.InsertData(
                table: "KrpanTrailerBrakeLamp",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", "LED féklámpák ROM", "0" },
                    { 2, "", "LED féklámpák RIO", "104,16" },
                    { 3, "", "LED féklámpák RIO", "0" }
                });

            migrationBuilder.InsertData(
                table: "KrpanTrailerBrakeLampTrailer",
                columns: new[] { "KrpanTrailerBrakeLampsId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 7 },
                    { 3, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailerBrakeLampTrailer_KrpanTrailerId",
                table: "KrpanTrailerBrakeLampTrailer",
                column: "KrpanTrailerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KrpanTrailerBrakeLampTrailer");

            migrationBuilder.DropTable(
                name: "KrpanTrailerBrakeLamp");

            migrationBuilder.DeleteData(
                table: "KrpanBaleTransportPlatform",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "KrpanBaleTransportPlatform",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "KrpanBaleTransportPlatform",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: "1935");

            migrationBuilder.UpdateData(
                table: "KrpanBaleTransportPlatform",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: "1935");

            migrationBuilder.UpdateData(
                table: "KrpanBaleTransportPlatform",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "Price" },
                values: new object[] { "300011151", "1935" });

            migrationBuilder.UpdateData(
                table: "KrpanBaleTransportPlatform",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "Price" },
                values: new object[] { "300011149", "1935" });

            migrationBuilder.UpdateData(
                table: "KrpanGrappleLocation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "", "Kanál lerakási helyének megerősítése", "180" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "KrpanBaleTransportPlatformId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "KrpanBaleTransportPlatformId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "KrpanBaleTransportPlatformId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "KrpanBaleTransportPlatformId",
                value: 4);
        }
    }
}
