using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class counterplates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupportLegCounterPlateId",
                table: "Crane",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TurningDeviceCounterPlateId",
                table: "Crane",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SupportLegCounterPlate",
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
                    table.PrimaryKey("PK_SupportLegCounterPlate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TurningDeviceCounterPlate",
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
                    table.PrimaryKey("PK_TurningDeviceCounterPlate", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "SupportLegCounterPlateId", "TurningDeviceCounterPlateId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "SupportLegCounterPlateId", "TurningDeviceCounterPlateId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "SupportLegCounterPlateId", "TurningDeviceCounterPlateId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "SupportLegCounterPlateId", "TurningDeviceCounterPlateId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "SupportLegCounterPlateId", "TurningDeviceCounterPlateId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "SupportLegCounterPlateId", "TurningDeviceCounterPlateId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "SupportLegCounterPlateId", "TurningDeviceCounterPlateId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "SupportLegCounterPlateId", "TurningDeviceCounterPlateId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "SupportLegCounterPlateId", "TurningDeviceCounterPlateId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "SupportLegCounterPlateId", "TurningDeviceCounterPlateId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "SupportLegCounterPlateId", "TurningDeviceCounterPlateId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "SupportLegCounterPlateId", "TurningDeviceCounterPlateId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "SupportLegCounterPlate",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "PL2", "Fedőlap a Palms talpaló lábhoz", "475" });

            migrationBuilder.InsertData(
                table: "TurningDeviceCounterPlate",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "PL", "Fedőlap a fordító szerkezethez", "340" });

            migrationBuilder.CreateIndex(
                name: "IX_Crane_SupportLegCounterPlateId",
                table: "Crane",
                column: "SupportLegCounterPlateId");

            migrationBuilder.CreateIndex(
                name: "IX_Crane_TurningDeviceCounterPlateId",
                table: "Crane",
                column: "TurningDeviceCounterPlateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crane_SupportLegCounterPlate_SupportLegCounterPlateId",
                table: "Crane",
                column: "SupportLegCounterPlateId",
                principalTable: "SupportLegCounterPlate",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Crane_TurningDeviceCounterPlate_TurningDeviceCounterPlateId",
                table: "Crane",
                column: "TurningDeviceCounterPlateId",
                principalTable: "TurningDeviceCounterPlate",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crane_SupportLegCounterPlate_SupportLegCounterPlateId",
                table: "Crane");

            migrationBuilder.DropForeignKey(
                name: "FK_Crane_TurningDeviceCounterPlate_TurningDeviceCounterPlateId",
                table: "Crane");

            migrationBuilder.DropTable(
                name: "SupportLegCounterPlate");

            migrationBuilder.DropTable(
                name: "TurningDeviceCounterPlate");

            migrationBuilder.DropIndex(
                name: "IX_Crane_SupportLegCounterPlateId",
                table: "Crane");

            migrationBuilder.DropIndex(
                name: "IX_Crane_TurningDeviceCounterPlateId",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "SupportLegCounterPlateId",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "TurningDeviceCounterPlateId",
                table: "Crane");
        }
    }
}
