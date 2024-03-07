using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class utrailerseveryconfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BunkAdapterId",
                table: "Trailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BunkExtensionId",
                table: "Trailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FrameExtensionId",
                table: "Trailer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BunkAdapter",
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
                    table.PrimaryKey("PK_BunkAdapter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BunkExtension",
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
                    table.PrimaryKey("PK_BunkExtension", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FrameExtension",
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
                    table.PrimaryKey("PK_FrameExtension", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BunkAdapter",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "PA", "Forwarder típusú bunk adapter a szélesebb rakodó felületért (az ár 1 db-ra vonatkozik)", "150" });

            migrationBuilder.InsertData(
                table: "BunkExtension",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "PA-H", "forwarder típusú bunk kiterjesztés (az ár 1 db-ra vonatkozik)", "150" });

            migrationBuilder.InsertData(
                table: "FrameExtension",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "Hex", "Hidraulikus működtetésű raktér hosszabbítás ", "210" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { 1, null, 1 });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { 1, null, 1 });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { 1, null, 1 });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { 1, null, 1 });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { 1, null, 1 });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BunkAdapterId", "BunkExtensionId", "FrameExtensionId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_BunkAdapterId",
                table: "Trailer",
                column: "BunkAdapterId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_BunkExtensionId",
                table: "Trailer",
                column: "BunkExtensionId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_FrameExtensionId",
                table: "Trailer",
                column: "FrameExtensionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trailer_BunkAdapter_BunkAdapterId",
                table: "Trailer",
                column: "BunkAdapterId",
                principalTable: "BunkAdapter",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trailer_BunkExtension_BunkExtensionId",
                table: "Trailer",
                column: "BunkExtensionId",
                principalTable: "BunkExtension",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trailer_FrameExtension_FrameExtensionId",
                table: "Trailer",
                column: "FrameExtensionId",
                principalTable: "FrameExtension",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trailer_BunkAdapter_BunkAdapterId",
                table: "Trailer");

            migrationBuilder.DropForeignKey(
                name: "FK_Trailer_BunkExtension_BunkExtensionId",
                table: "Trailer");

            migrationBuilder.DropForeignKey(
                name: "FK_Trailer_FrameExtension_FrameExtensionId",
                table: "Trailer");

            migrationBuilder.DropTable(
                name: "BunkAdapter");

            migrationBuilder.DropTable(
                name: "BunkExtension");

            migrationBuilder.DropTable(
                name: "FrameExtension");

            migrationBuilder.DropIndex(
                name: "IX_Trailer_BunkAdapterId",
                table: "Trailer");

            migrationBuilder.DropIndex(
                name: "IX_Trailer_BunkExtensionId",
                table: "Trailer");

            migrationBuilder.DropIndex(
                name: "IX_Trailer_FrameExtensionId",
                table: "Trailer");

            migrationBuilder.DropColumn(
                name: "BunkAdapterId",
                table: "Trailer");

            migrationBuilder.DropColumn(
                name: "BunkExtensionId",
                table: "Trailer");

            migrationBuilder.DropColumn(
                name: "FrameExtensionId",
                table: "Trailer");
        }
    }
}
