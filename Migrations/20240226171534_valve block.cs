using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class valveblock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ValveBlockId",
                table: "Crane",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ValveBlock",
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
                    table.PrimaryKey("PK_ValveBlock", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 1,
                column: "ValveBlockId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 2,
                column: "ValveBlockId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                column: "ValveBlockId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 4,
                column: "ValveBlockId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 5,
                column: "ValveBlockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 6,
                column: "ValveBlockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 7,
                column: "ValveBlockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                column: "ValveBlockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 9,
                column: "ValveBlockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 10,
                column: "ValveBlockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 11,
                column: "ValveBlockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 12,
                column: "ValveBlockId",
                value: 1);

            migrationBuilder.InsertData(
                table: "ValveBlock",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "AH", "A21-A42 vezértömb a főgémhez erősítve", "0" });

            migrationBuilder.CreateIndex(
                name: "IX_Crane_ValveBlockId",
                table: "Crane",
                column: "ValveBlockId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crane_ValveBlock_ValveBlockId",
                table: "Crane",
                column: "ValveBlockId",
                principalTable: "ValveBlock",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crane_ValveBlock_ValveBlockId",
                table: "Crane");

            migrationBuilder.DropTable(
                name: "ValveBlock");

            migrationBuilder.DropIndex(
                name: "IX_Crane_ValveBlockId",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "ValveBlockId",
                table: "Crane");
        }
    }
}
