using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class addmanualbunkextension : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManualBunkExtensionId",
                table: "Trailer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ManualBunkExtension",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualBunkExtension", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "BunkAdapter",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Forwarder típusú bunk adapter a raktér szélesítéshez 300 mm - 1 db");

            migrationBuilder.UpdateData(
                table: "BunkAdapter",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Forwarder típusú bunk adapter a raktér szélesítéshez 300 mm - 1 db");

            migrationBuilder.UpdateData(
                table: "BunkExtension",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Forwarder típusú hidraulikus bunk szélesítés - 1 db", "1250" });

            migrationBuilder.UpdateData(
                table: "BunkExtension",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Forwarder típusú hidraulikus bunk szélesítés - 1 db");

            migrationBuilder.InsertData(
                table: "ManualBunkExtension",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price" },
                values: new object[] { 1, "PA-M", null, "Forwarder típusú manuális bunk szélesítés - 1 db", "160" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "ManualBunkExtensionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "ManualBunkExtensionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "ManualBunkExtensionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "ManualBunkExtensionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "ManualBunkExtensionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "ManualBunkExtensionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "ManualBunkExtensionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "ManualBunkExtensionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9,
                column: "ManualBunkExtensionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "ManualBunkExtensionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "ManualBunkExtensionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 12,
                column: "ManualBunkExtensionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 13,
                column: "ManualBunkExtensionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 14,
                column: "ManualBunkExtensionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 15,
                column: "ManualBunkExtensionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 16,
                column: "ManualBunkExtensionId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_ManualBunkExtensionId",
                table: "Trailer",
                column: "ManualBunkExtensionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trailer_ManualBunkExtension_ManualBunkExtensionId",
                table: "Trailer",
                column: "ManualBunkExtensionId",
                principalTable: "ManualBunkExtension",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trailer_ManualBunkExtension_ManualBunkExtensionId",
                table: "Trailer");

            migrationBuilder.DropTable(
                name: "ManualBunkExtension");

            migrationBuilder.DropIndex(
                name: "IX_Trailer_ManualBunkExtensionId",
                table: "Trailer");

            migrationBuilder.DropColumn(
                name: "ManualBunkExtensionId",
                table: "Trailer");

            migrationBuilder.UpdateData(
                table: "BunkAdapter",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Forwarder típusú bunk adapter a szélesebb rakodó felületért (az ár 1 db-ra vonatkozik)");

            migrationBuilder.UpdateData(
                table: "BunkAdapter",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Forwarder típusú bunk adapter a szélesebb rakodó felületért (az ár 1 db-ra vonatkozik)");

            migrationBuilder.UpdateData(
                table: "BunkExtension",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Forwarder típusú bunk kiterjesztés (az ár 1 db-ra vonatkozik)", "625" });

            migrationBuilder.UpdateData(
                table: "BunkExtension",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Forwarder típusú bunk kiterjesztés (az ár 1 db-ra vonatkozik)");
        }
    }
}
