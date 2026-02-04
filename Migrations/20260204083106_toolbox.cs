using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class toolbox : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ToolboxId",
                table: "Trailer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Toolbox",
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
                    table.PrimaryKey("PK_Toolbox", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Toolbox",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "TB1", "Palms szerszámláda", "185" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "ToolboxId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "ToolboxId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "ToolboxId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "ToolboxId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "ToolboxId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "ToolboxId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "ToolboxId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name", "ToolboxId" },
                values: new object[] { "A PALMS 10UX erdészeti pótkocsi az U-sorozat legkisebb változata, mely a duplaalvázas kivitel mellett az úgynevezett unibody típusú rakoncákkal van szerelve. Össztömege 15000 kg. Nagy hasmagassága és az unibody keret csökkenti az elakadás kockázatát. A hidraulikus alkatrészek az unibody keretben vannak elhelyezve, védve ezzel azokat, mégis könnyű hozzáférést biztosít a karbantartáshoz. ", "PALMS 10UX", 1 });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9,
                column: "ToolboxId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "ToolboxId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "ToolboxId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 12,
                column: "ToolboxId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 13,
                column: "ToolboxId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 14,
                column: "ToolboxId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 15,
                column: "ToolboxId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 16,
                column: "ToolboxId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_ToolboxId",
                table: "Trailer",
                column: "ToolboxId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trailer_Toolbox_ToolboxId",
                table: "Trailer",
                column: "ToolboxId",
                principalTable: "Toolbox",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trailer_Toolbox_ToolboxId",
                table: "Trailer");

            migrationBuilder.DropTable(
                name: "Toolbox");

            migrationBuilder.DropIndex(
                name: "IX_Trailer_ToolboxId",
                table: "Trailer");

            migrationBuilder.DropColumn(
                name: "ToolboxId",
                table: "Trailer");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A PALMS 10U erdészeti pótkocsi az U-sorozat legkisebb változata, mely a duplaalvázas kivitel mellett az úgynevezett unibody típusú rakoncákkal van szerelve. Össztömege 15000 kg. Nagy hasmagassága és az unibody keret csökkenti az elakadás kockázatát. A hidraulikus alkatrészek az unibody keretben vannak elhelyezve, védve ezzel azokat, mégis könnyű hozzáférést biztosít a karbantartáshoz. ", "PALMS 10U" });
        }
    }
}
