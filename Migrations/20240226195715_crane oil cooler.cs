using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class craneoilcooler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OilTank_OilTankCooler_OilTankCoolerId",
                table: "OilTank");

            migrationBuilder.DropTable(
                name: "OilTankCooler");

            migrationBuilder.RenameColumn(
                name: "OilTankCoolerId",
                table: "OilTank",
                newName: "TrailerOilCoolerId");

            migrationBuilder.RenameIndex(
                name: "IX_OilTank_OilTankCoolerId",
                table: "OilTank",
                newName: "IX_OilTank_TrailerOilCoolerId");

            migrationBuilder.AddColumn<int>(
                name: "CraneOilCoolerId",
                table: "Crane",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CraneOilCooler",
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
                    table.PrimaryKey("PK_CraneOilCooler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrailerOilCooler",
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
                    table.PrimaryKey("PK_TrailerOilCooler", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 1,
                column: "CraneOilCoolerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 2,
                column: "CraneOilCoolerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                column: "CraneOilCoolerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 4,
                column: "CraneOilCoolerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 5,
                column: "CraneOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 6,
                column: "CraneOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 7,
                column: "CraneOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                column: "CraneOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 9,
                column: "CraneOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 10,
                column: "CraneOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 11,
                column: "CraneOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 12,
                column: "CraneOilCoolerId",
                value: 1);

            migrationBuilder.InsertData(
                table: "CraneOilCooler",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "CP1", "Olajhűtő csomag elektromos csatlakozással a traktorhoz", "1035" });

            migrationBuilder.InsertData(
                table: "TrailerOilCooler",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "CP2", "Olajhűtő csomag a tartályhoz rögzítve", "1035" });

            migrationBuilder.CreateIndex(
                name: "IX_Crane_CraneOilCoolerId",
                table: "Crane",
                column: "CraneOilCoolerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crane_CraneOilCooler_CraneOilCoolerId",
                table: "Crane",
                column: "CraneOilCoolerId",
                principalTable: "CraneOilCooler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OilTank_TrailerOilCooler_TrailerOilCoolerId",
                table: "OilTank",
                column: "TrailerOilCoolerId",
                principalTable: "TrailerOilCooler",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crane_CraneOilCooler_CraneOilCoolerId",
                table: "Crane");

            migrationBuilder.DropForeignKey(
                name: "FK_OilTank_TrailerOilCooler_TrailerOilCoolerId",
                table: "OilTank");

            migrationBuilder.DropTable(
                name: "CraneOilCooler");

            migrationBuilder.DropTable(
                name: "TrailerOilCooler");

            migrationBuilder.DropIndex(
                name: "IX_Crane_CraneOilCoolerId",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "CraneOilCoolerId",
                table: "Crane");

            migrationBuilder.RenameColumn(
                name: "TrailerOilCoolerId",
                table: "OilTank",
                newName: "OilTankCoolerId");

            migrationBuilder.RenameIndex(
                name: "IX_OilTank_TrailerOilCoolerId",
                table: "OilTank",
                newName: "IX_OilTank_OilTankCoolerId");

            migrationBuilder.CreateTable(
                name: "OilTankCooler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OilTankCooler", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "OilTankCooler",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "CP2", "Olajhűtő csomag a tartályhoz rögzítve", "1035" });

            migrationBuilder.AddForeignKey(
                name: "FK_OilTank_OilTankCooler_OilTankCoolerId",
                table: "OilTank",
                column: "OilTankCoolerId",
                principalTable: "OilTankCooler",
                principalColumn: "Id");
        }
    }
}
