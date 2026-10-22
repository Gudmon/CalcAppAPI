using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class palmselectricoilcoolerkit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CraneElectricOilCoolerKitId",
                table: "Crane",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CraneElectricOilCoolerKit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraneElectricOilCoolerKit", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cover",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 2, "HSBJKK", "[\"PALMS-crane-cover-1\"]", "Védőhuzat bőrből (bal-jobb) joystick-hoz (2db)", "60", null });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 1,
                column: "CraneElectricOilCoolerKitId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 2,
                column: "CraneElectricOilCoolerKitId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                column: "CraneElectricOilCoolerKitId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 4,
                column: "CraneElectricOilCoolerKitId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 5,
                column: "CraneElectricOilCoolerKitId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 6,
                column: "CraneElectricOilCoolerKitId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 7,
                column: "CraneElectricOilCoolerKitId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                column: "CraneElectricOilCoolerKitId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 9,
                column: "CraneElectricOilCoolerKitId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 10,
                column: "CraneElectricOilCoolerKitId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 11,
                column: "CraneElectricOilCoolerKitId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 12,
                column: "CraneElectricOilCoolerKitId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 13,
                column: "CraneElectricOilCoolerKitId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CraneElectricOilCoolerKitId", "Description" },
                values: new object[] { null, "Fedezze fel a PALMS 8.87z nagy teherbírású erdészeti darut! A professzionális rönk- és faanyagmozgatásra tervezett daru nagy emelőkapacitást és hatékony hidraulikus működést biztosít. A Z-alakú kialakításnak köszönhetően szállításkor rendkívül kompakt méretűre csukható össze, így helytakarékos szállítást és praktikus tárolást tesz lehetővé." });

            migrationBuilder.InsertData(
                table: "CraneElectricOilCoolerKit",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "T5", "[\"PALMS-crane-electric-oil-cooler-kit-1\"]", "Nagy olajhűtő csomag elektromos csatlakozással a traktorhoz", "1290", null });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "Ez a könnyű, 4 tonnás rönkszállító pótkocsi kis erdőtulajdonosok, gazdálkodók és területfenntartó szakemberek igényeire készült, akik megbízható megoldást keresnek a rönkfa és a tűzifa szállítására. A robusztus, dupla alvázas szerkezet és az egyszerű, egytengelyes kialakítás kiemelkedő szilárdságot, valamint minimális karbantartási igényt biztosít.");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Ez a 4 tonnás, tandem tengelyes rönkszállító pótkocsi kis erdőtulajdonosok, gazdálkodók és területfenntartó szakemberek számára készült, akiknek megbízható megoldásra van szükségük a rönkfa és a tűzifa nehéz terepen történő szállításához. A nagy teherbírású, dupla alvázas kialakítás kiemelkedő szerkezeti szilárdságot, kiváló stabilitást és hosszú élettartamot biztosít.");

            migrationBuilder.CreateIndex(
                name: "IX_Crane_CraneElectricOilCoolerKitId",
                table: "Crane",
                column: "CraneElectricOilCoolerKitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crane_CraneElectricOilCoolerKit_CraneElectricOilCoolerKitId",
                table: "Crane",
                column: "CraneElectricOilCoolerKitId",
                principalTable: "CraneElectricOilCoolerKit",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crane_CraneElectricOilCoolerKit_CraneElectricOilCoolerKitId",
                table: "Crane");

            migrationBuilder.DropTable(
                name: "CraneElectricOilCoolerKit");

            migrationBuilder.DropIndex(
                name: "IX_Crane_CraneElectricOilCoolerKitId",
                table: "Crane");

            migrationBuilder.DeleteData(
                table: "Cover",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "CraneElectricOilCoolerKitId",
                table: "Crane");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "A PALMS 8.87Z daru nagy teherbírásával és kompakt szállítási méreteivel, valamint sokoldalúságával tűnik ki. Nemcsak erdészeti, hanem mezőgazdasági pótkocsikhoz és teherautókhoz is illeszkedik.");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "");
        }
    }
}
