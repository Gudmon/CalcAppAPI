using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class changecntrolblocks3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CraneControlBlocks",
                columns: new[] { "Id", "ControlBlockId", "CraneId", "FrameTypeId" },
                values: new object[,]
                {
                    { 291, 7, 12, 6 },
                    { 292, 8, 12, 6 },
                    { 293, 9, 12, 6 },
                    { 294, 10, 12, 6 },
                    { 295, 11, 12, 6 },
                    { 296, 12, 12, 6 },
                    { 297, 13, 12, 6 },
                    { 298, 14, 12, 6 },
                    { 299, 7, 12, 7 },
                    { 300, 8, 12, 7 },
                    { 301, 9, 12, 7 },
                    { 302, 10, 12, 7 },
                    { 303, 11, 12, 7 },
                    { 304, 12, 12, 7 },
                    { 305, 13, 12, 7 },
                    { 306, 14, 12, 7 },
                    { 307, 8, 12, 9 },
                    { 308, 9, 12, 9 },
                    { 309, 10, 12, 9 },
                    { 310, 11, 12, 9 },
                    { 311, 12, 12, 9 },
                    { 312, 13, 12, 9 },
                    { 313, 14, 12, 9 },
                    { 314, 8, 12, 10 },
                    { 315, 9, 12, 10 },
                    { 316, 10, 12, 10 },
                    { 317, 11, 12, 10 },
                    { 318, 12, 12, 10 },
                    { 319, 13, 12, 10 },
                    { 320, 14, 12, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 320);
        }
    }
}
