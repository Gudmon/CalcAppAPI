using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class electricalfloating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ElectricalFloatingId",
                table: "Crane",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ElectricalFloating",
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
                    table.PrimaryKey("PK_ElectricalFloating", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 1,
                column: "ElectricalFloatingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 2,
                column: "ElectricalFloatingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                column: "ElectricalFloatingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 4,
                column: "ElectricalFloatingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 5,
                column: "ElectricalFloatingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 6,
                column: "ElectricalFloatingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 7,
                column: "ElectricalFloatingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                column: "ElectricalFloatingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 9,
                column: "ElectricalFloatingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 10,
                column: "ElectricalFloatingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 11,
                column: "ElectricalFloatingId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 12,
                column: "ElectricalFloatingId",
                value: null);

            migrationBuilder.InsertData(
                table: "ElectricalFloating",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "FP", "Elektromos úszó pozíció emelő és fordító funkcióhoz (for A11-A41 vezértömbhöz)", "1035" });

            migrationBuilder.CreateIndex(
                name: "IX_Crane_ElectricalFloatingId",
                table: "Crane",
                column: "ElectricalFloatingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crane_ElectricalFloating_ElectricalFloatingId",
                table: "Crane",
                column: "ElectricalFloatingId",
                principalTable: "ElectricalFloating",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crane_ElectricalFloating_ElectricalFloatingId",
                table: "Crane");

            migrationBuilder.DropTable(
                name: "ElectricalFloating");

            migrationBuilder.DropIndex(
                name: "IX_Crane_ElectricalFloatingId",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "ElectricalFloatingId",
                table: "Crane");
        }
    }
}
