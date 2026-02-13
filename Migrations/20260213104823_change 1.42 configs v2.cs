using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class change142configsv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ControlBlockCrane",
                keyColumns: new[] { "ControlBlockId", "CraneId" },
                keyValues: new object[] { 15, 13 });

            migrationBuilder.AddColumn<int>(
                name: "SupportBracketId",
                table: "Crane",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SupportBracket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportBracket", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ControlBlockCrane",
                columns: new[] { "ControlBlockId", "CraneId" },
                values: new object[] { 2, 13 });

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: "870");

            migrationBuilder.InsertData(
                table: "ControlBlocks",
                columns: new[] { "Id", "Code", "Description", "ImageUrls", "Name", "Price" },
                values: new object[] { 16, "A3.1", "Egyszerű és megbízható szelepblokk kisebb daruk számára", null, "A3.1 - 6/8 XY vezértömb, BLB BM50 (50 l/min.) 180 bar", "870" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 1,
                column: "SupportBracketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 2,
                column: "SupportBracketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                column: "SupportBracketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 4,
                column: "SupportBracketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 5,
                column: "SupportBracketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 6,
                column: "SupportBracketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 7,
                column: "SupportBracketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                column: "SupportBracketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 9,
                column: "SupportBracketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 10,
                column: "SupportBracketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 11,
                column: "SupportBracketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 12,
                column: "SupportBracketId",
                value: null);

            migrationBuilder.InsertData(
                table: "CraneLight",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price" },
                values: new object[] { 2, "L1", null, "LED munkalámpák a darugémre, 1 db", "335" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: "660");

            migrationBuilder.InsertData(
                table: "ProtectionSleeves",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price" },
                values: new object[] { 2, "PSH", null, "Védőhüvely a tömlőhöz", "55" });

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Price" },
                values: new object[] { "10 kN-os csapos rotátor, Finrotor", "265" });

            migrationBuilder.InsertData(
                table: "SupportBracket",
                columns: new[] { "Id", "Code", "Description", "ImageUrls", "Name", "Price" },
                values: new object[] { 1, "BOB", "csavarozható a keretre a védőburkolat és az első rakoncapár között", null, "Támasztókonzol", "125" });

            migrationBuilder.InsertData(
                table: "Winch",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price" },
                values: new object[] { 4, "W3", null, "Csörlő", "1555" });

            migrationBuilder.InsertData(
                table: "ControlBlockCrane",
                columns: new[] { "ControlBlockId", "CraneId" },
                values: new object[] { 16, 13 });

            migrationBuilder.InsertData(
                table: "WinchCrane",
                columns: new[] { "CraneId", "WinchId" },
                values: new object[] { 13, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Crane_SupportBracketId",
                table: "Crane",
                column: "SupportBracketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crane_SupportBracket_SupportBracketId",
                table: "Crane",
                column: "SupportBracketId",
                principalTable: "SupportBracket",
                principalColumn: "Id");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "LightId", "Price", "ProtectionSleevesId", "SupportBracketId" },
                values: new object[] { 2, "3300", 2, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crane_SupportBracket_SupportBracketId",
                table: "Crane");

            migrationBuilder.DropTable(
                name: "SupportBracket");

            migrationBuilder.DropIndex(
                name: "IX_Crane_SupportBracketId",
                table: "Crane");

            migrationBuilder.DeleteData(
                table: "ControlBlockCrane",
                keyColumns: new[] { "ControlBlockId", "CraneId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "ControlBlockCrane",
                keyColumns: new[] { "ControlBlockId", "CraneId" },
                keyValues: new object[] { 16, 13 });

            migrationBuilder.DeleteData(
                table: "CraneLight",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProtectionSleeves",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WinchCrane",
                keyColumns: new[] { "CraneId", "WinchId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Winch",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "SupportBracketId",
                table: "Crane");

            migrationBuilder.InsertData(
                table: "ControlBlockCrane",
                columns: new[] { "ControlBlockId", "CraneId" },
                values: new object[] { 15, 13 });

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: "805");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "LightId", "Price", "ProtectionSleevesId" },
                values: new object[] { null, "3025", null });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: "620");

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Rotátor 1000 kN (csapos - Finrotor)", "245" });
        }
    }
}
