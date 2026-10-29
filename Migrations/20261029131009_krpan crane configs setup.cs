using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpancraneconfigssetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KrpanCraneSlewingDriveId",
                table: "KrpanCrane",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "KrpanCraneControl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanCraneControl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanCraneSlewingDrive",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanCraneSlewingDrive", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanCraneControlsCrane",
                columns: table => new
                {
                    KrpanCraneControlsId = table.Column<int>(type: "int", nullable: false),
                    KrpanCraneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanCraneControlsCrane", x => new { x.KrpanCraneControlsId, x.KrpanCraneId });
                    table.ForeignKey(
                        name: "FK_KrpanCraneControlsCrane_KrpanCraneControl_KrpanCraneControlsId",
                        column: x => x.KrpanCraneControlsId,
                        principalTable: "KrpanCraneControl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KrpanCraneControlsCrane_KrpanCrane_KrpanCraneId",
                        column: x => x.KrpanCraneId,
                        principalTable: "KrpanCrane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KrpanCraneSlewingDriveId", "Price" },
                values: new object[] { null, "14051,77" });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KrpanCraneSlewingDriveId", "Price" },
                values: new object[] { null, "23994,17" });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "KrpanCraneSlewingDriveId", "Price" },
                values: new object[] { null, "15708,96" });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 4,
                column: "KrpanCraneSlewingDriveId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 5,
                column: "KrpanCraneSlewingDriveId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 6,
                column: "KrpanCraneSlewingDriveId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 7,
                column: "KrpanCraneSlewingDriveId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 8,
                column: "KrpanCraneSlewingDriveId",
                value: null);

            migrationBuilder.InsertData(
                table: "KrpanCrane",
                columns: new[] { "Id", "BrutLiftingTorque", "Description", "KrpanCraneSlewingDriveId", "LiftCapacityAtFourMeters", "LiftCapacityAtMaxReach", "MaxReach", "MaxReachWithGrabOpen", "Name", "NetLiftingTorque", "OilQuantityInTank", "Price", "SlewCylinders", "SlewTorque", "SlewingAngle", "SystemPressure", "TelescopicStages", "Weight" },
                values: new object[,]
                {
                    { 9, "50", "", null, "1020", "600", "6.6", "7.2", "GD 6,6 K", "40", "70", "14051,77", "4", "16", "375", "220", "1", "900" },
                    { 10, "50", "", null, "1020", "600", "6.6", "7.2", "GD 6,6 K", "40", "70", "17326,67", "4", "16", "375", "220", "1", "900" },
                    { 11, "49", "", null, "1020", "500", "7.6", "8.2", "GD 7,6 K", "39", "70", "15708,96", "4", "16", "375", "220", "1", "930" },
                    { 12, "49", "", null, "1020", "500", "7.6", "8.2", "GD 7,6 K", "39", "70", "18912,50", "4", "16", "375", "220", "1", "930" }
                });

            migrationBuilder.InsertData(
                table: "KrpanCraneControl",
                columns: new[] { "Id", "Code", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", "", "Mechanikus EURO vezérlés ergonomikus karokkal", "0" },
                    { 2, "", "", "Keresztkaros vezérlés el. ON/OFF funkciókkal", "702,50" },
                    { 3, "", "BASIC csomaggal elérhető", "Proporcionális hidraulikus (alacsony nyomású) Joystick vezérlés", "2469,17" },
                    { 4, "", "BASIC csomaggal elérhető", "Proporcionális elektromos joystick vezérlés", "4022,50" },
                    { 5, "", "PROFI 1 csomaggal elérhető", "LX6 alacsony nyomású szelepek", "4656,67" },
                    { 6, "", "PROFI 1 csomaggal elérhető", "LX6 elektroszelepek", "6210,00" },
                    { 7, "", "PROFI+ csomaggal elérhető", "LX6 alacsony nyomású (LS) szelepek", "4656,67" },
                    { 8, "", "PROFI+ csomaggal elérhető", "LX6 elektro (LS) szelepek", "6210,00" },
                    { 9, "", "PROFI 1 / PROFI 2 csomaggal elérhető", "LX6 alacsony nyomású szelepek", "4656,67" },
                    { 10, "", "PROFI 1 / PROFI 2 csomaggal elérhető", "LX6 elektroszelepek", "6210,00" },
                    { 11, "", "", "Proporcionális hidraulikus (alacsony nyomású) Joystick vezérlés", "0" },
                    { 12, "", "BASIC csomaggal elérhető", "Vezérlés mechanikus EURO karokkal", "-1235,00" },
                    { 13, "", "BASIC csomaggal elérhető", "Keresztkaros vezérlés el. ON/OFF funkciókkal", "-532,50" },
                    { 14, "", "BASIC/ SEMI PROFI csomaggal elérhető", "Proporcionális elektromos joystick vezérlés", "1552,50" },
                    { 15, "", "SEMI PROFI csomaggal elérhető", "Proporcionális hidraulikus (alacsony nyomású) osztott Joystick vezérlés", "1045,00" },
                    { 16, "", "SEMI PROFI csomaggal elérhető", "Proporcionális elektromos osztott joystick vezérlés", "2597,50" },
                    { 17, "", "PROFI 1 / PROFI 2 csomaggal elérhető", "LX6 alacsony nyomású szelepek", "2187,50" },
                    { 18, "", "PROFI 1 / PROFI 2 csomaggal elérhető", "LX6 elektroszelepek", "3740,00" },
                    { 19, "", "PROFI+ csomaggal elérhető", "LX6 alacsony nyomású (LS) szelepek", "1231,67" },
                    { 20, "", "PROFI+ csomaggal elérhető", "LX6 elektro (LS) szelepek", "2784,17" }
                });

            migrationBuilder.InsertData(
                table: "KrpanCraneSlewingDrive",
                columns: new[] { "Id", "Code", "Description", "Name", "Price" },
                values: new object[] { 1, "", "", "Olajfürdős daruforgató hajtómű", "0" });

            migrationBuilder.InsertData(
                table: "KrpanCraneControlsCrane",
                columns: new[] { "KrpanCraneControlsId", "KrpanCraneId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 2, 1 },
                    { 2, 3 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 3, 12 },
                    { 4, 9 },
                    { 4, 10 },
                    { 4, 11 },
                    { 4, 12 },
                    { 5, 9 },
                    { 5, 11 },
                    { 6, 9 },
                    { 6, 11 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 11 },
                    { 7, 12 },
                    { 8, 9 },
                    { 8, 10 },
                    { 8, 11 },
                    { 8, 12 },
                    { 9, 10 },
                    { 9, 12 },
                    { 10, 10 },
                    { 10, 12 },
                    { 11, 2 },
                    { 11, 4 },
                    { 11, 5 },
                    { 11, 6 },
                    { 12, 2 },
                    { 12, 4 },
                    { 12, 5 },
                    { 12, 6 },
                    { 13, 2 },
                    { 13, 4 },
                    { 13, 5 },
                    { 13, 6 },
                    { 14, 2 },
                    { 14, 4 },
                    { 14, 5 },
                    { 14, 6 },
                    { 15, 2 },
                    { 15, 4 },
                    { 15, 5 },
                    { 15, 6 },
                    { 16, 2 },
                    { 16, 4 },
                    { 16, 5 },
                    { 16, 6 },
                    { 17, 2 },
                    { 17, 4 },
                    { 17, 5 },
                    { 17, 6 },
                    { 18, 2 },
                    { 18, 4 },
                    { 18, 5 },
                    { 18, 6 },
                    { 19, 2 },
                    { 19, 4 },
                    { 19, 5 },
                    { 19, 6 },
                    { 20, 2 },
                    { 20, 4 },
                    { 20, 5 },
                    { 20, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KrpanCrane_KrpanCraneSlewingDriveId",
                table: "KrpanCrane",
                column: "KrpanCraneSlewingDriveId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanCraneControlsCrane_KrpanCraneId",
                table: "KrpanCraneControlsCrane",
                column: "KrpanCraneId");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanCrane_KrpanCraneSlewingDrive_KrpanCraneSlewingDriveId",
                table: "KrpanCrane",
                column: "KrpanCraneSlewingDriveId",
                principalTable: "KrpanCraneSlewingDrive",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KrpanCrane_KrpanCraneSlewingDrive_KrpanCraneSlewingDriveId",
                table: "KrpanCrane");

            migrationBuilder.DropTable(
                name: "KrpanCraneControlsCrane");

            migrationBuilder.DropTable(
                name: "KrpanCraneSlewingDrive");

            migrationBuilder.DropTable(
                name: "KrpanCraneControl");

            migrationBuilder.DropIndex(
                name: "IX_KrpanCrane_KrpanCraneSlewingDriveId",
                table: "KrpanCrane");

            migrationBuilder.DeleteData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "KrpanCraneSlewingDriveId",
                table: "KrpanCrane");

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: "13715");

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: "24475");

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: "15335");
        }
    }
}
