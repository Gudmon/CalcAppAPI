using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class protectionsleeves2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crane_ProtectionSleeves_ProtectionSleevesId",
                table: "Crane");

            migrationBuilder.DropIndex(
                name: "IX_Crane_ProtectionSleevesId",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "ProtectionSleevesId",
                table: "Crane");

            migrationBuilder.CreateTable(
                name: "ProtectionSleevesCrane",
                columns: table => new
                {
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    ProtectionSleevesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtectionSleevesCrane", x => new { x.CraneId, x.ProtectionSleevesId });
                    table.ForeignKey(
                        name: "FK_ProtectionSleevesCrane_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProtectionSleevesCrane_ProtectionSleeves_ProtectionSleevesId",
                        column: x => x.ProtectionSleevesId,
                        principalTable: "ProtectionSleeves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProtectionSleeves",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 2, "PSH", "Védőhüvely a tömlőhöz", "75" },
                    { 3, "PSH", "Védőhüvely a tömlőhöz", "95" },
                    { 4, "PSH", "Védőhüvely a tömlőhöz", "105" }
                });

            migrationBuilder.InsertData(
                table: "ProtectionSleevesCrane",
                columns: new[] { "CraneId", "ProtectionSleevesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 2 },
                    { 6, 3 },
                    { 7, 3 },
                    { 8, 3 },
                    { 9, 3 },
                    { 10, 3 },
                    { 11, 3 },
                    { 12, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProtectionSleevesCrane_ProtectionSleevesId",
                table: "ProtectionSleevesCrane",
                column: "ProtectionSleevesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProtectionSleevesCrane");

            migrationBuilder.DeleteData(
                table: "ProtectionSleeves",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProtectionSleeves",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProtectionSleeves",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AddColumn<int>(
                name: "ProtectionSleevesId",
                table: "Crane",
                type: "int",
                nullable: true);

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
    }
}
