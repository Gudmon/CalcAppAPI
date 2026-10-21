using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpanstanchionsfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanExtraForwarderStanchion_KrpanExtraForwarderStanchionId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanExtraStanchion_KrpanExtraStanchionId",
                table: "KrpanTrailer");

            migrationBuilder.DropTable(
                name: "KrpanExtraForwarderStanchion");

            migrationBuilder.DropTable(
                name: "KrpanExtraStanchion");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanExtraForwarderStanchionId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanExtraStanchionId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanExtraForwarderStanchionId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanExtraStanchionId",
                table: "KrpanTrailer");

            migrationBuilder.CreateTable(
                name: "KrpanStanchion",
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
                    table.PrimaryKey("PK_KrpanStanchion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanStanchionTrailer",
                columns: table => new
                {
                    KrpanStanchionsId = table.Column<int>(type: "int", nullable: false),
                    KrpanTrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanStanchionTrailer", x => new { x.KrpanStanchionsId, x.KrpanTrailerId });
                    table.ForeignKey(
                        name: "FK_KrpanStanchionTrailer_KrpanStanchion_KrpanStanchionsId",
                        column: x => x.KrpanStanchionsId,
                        principalTable: "KrpanStanchion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KrpanStanchionTrailer_KrpanTrailer_KrpanTrailerId",
                        column: x => x.KrpanTrailerId,
                        principalTable: "KrpanTrailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "KrpanCargoSpaceExtension",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: "479,17");

            migrationBuilder.InsertData(
                table: "KrpanStanchion",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", "3 pár rakonca", "0" },
                    { 2, "300032726", "4 pár rakonca", "711,50" },
                    { 3, "2× 300011090", "4 pár rakonca", "532,50" },
                    { 4, "", "3 pár forwarder rakonca", "995,01" },
                    { 5, "2× 300031886", "4 pár forwarder rakonca", "1859,18" },
                    { 6, "", "3 pár forwarder rakonca", "1417,50" },
                    { 7, "2× 300021851", "4 pár forwarder rakonca", "2422,50" },
                    { 8, "", "4 pár rakonca", "0" },
                    { 9, "", "5 pár rakonca", "532,50" },
                    { 10, "", "4 pár forwarder rakonca", "1890,00" },
                    { 11, "300021851", "5 pár forwarder rakonca", "2895,00" }
                });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 9,
                column: "KrpanCargoSpaceExtensionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "KrpanCargoSpaceExtensionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "KrpanCargoSpaceExtensionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 12,
                column: "KrpanCargoSpaceExtensionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 13,
                column: "KrpanCargoSpaceExtensionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 14,
                column: "KrpanCargoSpaceExtensionId",
                value: 2);

            migrationBuilder.InsertData(
                table: "KrpanStanchionTrailer",
                columns: new[] { "KrpanStanchionsId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
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
                    { 3, 6 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 6 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 6 },
                    { 6, 4 },
                    { 6, 5 },
                    { 7, 4 },
                    { 7, 5 },
                    { 8, 7 },
                    { 8, 8 },
                    { 9, 7 },
                    { 9, 8 },
                    { 10, 7 },
                    { 10, 8 },
                    { 11, 7 },
                    { 11, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KrpanStanchionTrailer_KrpanTrailerId",
                table: "KrpanStanchionTrailer",
                column: "KrpanTrailerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KrpanStanchionTrailer");

            migrationBuilder.DropTable(
                name: "KrpanStanchion");

            migrationBuilder.AddColumn<int>(
                name: "KrpanExtraForwarderStanchionId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanExtraStanchionId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "KrpanExtraForwarderStanchion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanExtraForwarderStanchion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanExtraStanchion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanExtraStanchion", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "KrpanCargoSpaceExtension",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: "490");

            migrationBuilder.InsertData(
                table: "KrpanExtraForwarderStanchion",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "300019196", "Extra forwarder rakonca pár", "1025" });

            migrationBuilder.InsertData(
                table: "KrpanExtraStanchion",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "300011090", "Extra rakonca pár (3 pár széria)", "545" },
                    { 2, "300010875", "Extra rakonca pár (4 pár széria)", "545" }
                });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "KrpanCargoSpaceExtensionId", "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "KrpanCargoSpaceExtensionId", "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "KrpanCargoSpaceExtensionId", "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "KrpanCargoSpaceExtensionId", "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "KrpanCargoSpaceExtensionId", "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "KrpanCargoSpaceExtensionId", "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId" },
                values: new object[] { null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanExtraForwarderStanchionId",
                table: "KrpanTrailer",
                column: "KrpanExtraForwarderStanchionId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanExtraStanchionId",
                table: "KrpanTrailer",
                column: "KrpanExtraStanchionId");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanExtraForwarderStanchion_KrpanExtraForwarderStanchionId",
                table: "KrpanTrailer",
                column: "KrpanExtraForwarderStanchionId",
                principalTable: "KrpanExtraForwarderStanchion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanExtraStanchion_KrpanExtraStanchionId",
                table: "KrpanTrailer",
                column: "KrpanExtraStanchionId",
                principalTable: "KrpanExtraStanchion",
                principalColumn: "Id");
        }
    }
}
