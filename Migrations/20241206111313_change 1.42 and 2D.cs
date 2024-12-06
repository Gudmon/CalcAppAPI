using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class change142and2D : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ControlBlockCrane",
                keyColumns: new[] { "ControlBlockId", "CraneId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.InsertData(
                table: "ControlBlocks",
                columns: new[] { "Id", "Code", "Description", "Name", "Price" },
                values: new object[] { 15, "A3.1", "Egyszerű és megbízható szelepblokk kisebb daruk számára", "A3.1 - 6/8 XY vezértömb, BLB BM50 (50 l/min.) 195 bar", "805" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 15,
                column: "MOTId",
                value: null);

            migrationBuilder.InsertData(
                table: "ControlBlockCrane",
                columns: new[] { "ControlBlockId", "CraneId" },
                values: new object[] { 15, 13 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ControlBlockCrane",
                keyColumns: new[] { "ControlBlockId", "CraneId" },
                keyValues: new object[] { 15, 13 });

            migrationBuilder.DeleteData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.InsertData(
                table: "ControlBlockCrane",
                columns: new[] { "ControlBlockId", "CraneId" },
                values: new object[] { 2, 13 });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 15,
                column: "MOTId",
                value: 1);
        }
    }
}
