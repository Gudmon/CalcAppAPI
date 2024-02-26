using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class operatorseats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OperatorSeatId",
                table: "Crane",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OperatorSeat",
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
                    table.PrimaryKey("PK_OperatorSeat", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 1,
                column: "OperatorSeatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 2,
                column: "OperatorSeatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                column: "OperatorSeatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 4,
                column: "OperatorSeatId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 5,
                column: "OperatorSeatId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 6,
                column: "OperatorSeatId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 7,
                column: "OperatorSeatId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                column: "OperatorSeatId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 9,
                column: "OperatorSeatId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 10,
                column: "OperatorSeatId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 11,
                column: "OperatorSeatId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 12,
                column: "OperatorSeatId",
                value: 1);

            migrationBuilder.InsertData(
                table: "OperatorSeat",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "HSB", "Kezelő ülés a függőleges gém tetejére, csak A12-höz, nem kompatibilis a csörlővel", "1890" });

            migrationBuilder.CreateIndex(
                name: "IX_Crane_OperatorSeatId",
                table: "Crane",
                column: "OperatorSeatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crane_OperatorSeat_OperatorSeatId",
                table: "Crane",
                column: "OperatorSeatId",
                principalTable: "OperatorSeat",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crane_OperatorSeat_OperatorSeatId",
                table: "Crane");

            migrationBuilder.DropTable(
                name: "OperatorSeat");

            migrationBuilder.DropIndex(
                name: "IX_Crane_OperatorSeatId",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "OperatorSeatId",
                table: "Crane");
        }
    }
}
