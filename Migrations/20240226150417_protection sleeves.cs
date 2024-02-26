using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class protectionsleeves : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProtectionSleevesId",
                table: "Crane",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProtectionSleeves",
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
                    table.PrimaryKey("PK_ProtectionSleeves", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProtectionSleevesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProtectionSleevesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProtectionSleevesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProtectionSleevesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProtectionSleevesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProtectionSleevesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProtectionSleevesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProtectionSleevesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProtectionSleevesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 10,
                column: "ProtectionSleevesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 11,
                column: "ProtectionSleevesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 12,
                column: "ProtectionSleevesId",
                value: null);

            migrationBuilder.InsertData(
                table: "ProtectionSleeves",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "PSH", "Védőhüvely a tömlőhöz", "70" });

            migrationBuilder.CreateIndex(
                name: "IX_Crane_ProtectionSleevesId",
                table: "Crane",
                column: "ProtectionSleevesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crane_ProtectionSleeves_ProtectionSleevesId",
                table: "Crane",
                column: "ProtectionSleevesId",
                principalTable: "ProtectionSleeves",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crane_ProtectionSleeves_ProtectionSleevesId",
                table: "Crane");

            migrationBuilder.DropTable(
                name: "ProtectionSleeves");

            migrationBuilder.DropIndex(
                name: "IX_Crane_ProtectionSleevesId",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "ProtectionSleevesId",
                table: "Crane");
        }
    }
}
