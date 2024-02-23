using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class controlblock2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CraneControlBlocks",
                columns: new[] { "Id", "ControlBlockId", "CraneId", "FrameTypeId" },
                values: new object[,]
                {
                    { 321, 1, 1, 1 },
                    { 322, 2, 2, 1 },
                    { 323, 3, 2, 1 },
                    { 324, 4, 2, 1 },
                    { 325, 5, 2, 1 },
                    { 326, 6, 2, 1 },
                    { 327, 8, 2, 1 },
                    { 328, 9, 2, 1 },
                    { 329, 11, 2, 1 },
                    { 330, 2, 3, 1 },
                    { 331, 3, 3, 1 },
                    { 332, 5, 3, 1 },
                    { 333, 2, 4, 1 },
                    { 334, 3, 4, 1 },
                    { 335, 4, 4, 1 },
                    { 336, 5, 4, 1 },
                    { 337, 6, 4, 1 },
                    { 338, 8, 4, 1 },
                    { 339, 9, 4, 1 },
                    { 340, 11, 4, 1 },
                    { 341, 2, 5, 1 },
                    { 342, 3, 5, 1 },
                    { 343, 4, 5, 1 },
                    { 344, 5, 5, 1 },
                    { 345, 6, 5, 1 },
                    { 346, 8, 5, 1 },
                    { 347, 9, 5, 1 },
                    { 348, 11, 5, 1 },
                    { 349, 3, 6, 1 },
                    { 350, 4, 6, 1 },
                    { 351, 5, 6, 1 },
                    { 352, 6, 6, 1 },
                    { 353, 7, 6, 1 },
                    { 354, 8, 6, 1 },
                    { 355, 9, 6, 1 },
                    { 356, 10, 6, 1 },
                    { 357, 11, 6, 1 },
                    { 358, 12, 6, 1 },
                    { 359, 13, 6, 1 },
                    { 360, 3, 7, 1 },
                    { 361, 4, 7, 1 },
                    { 362, 5, 7, 1 },
                    { 363, 6, 7, 1 },
                    { 364, 7, 7, 1 },
                    { 365, 8, 7, 1 },
                    { 366, 9, 7, 1 },
                    { 367, 10, 7, 1 },
                    { 368, 11, 7, 1 },
                    { 369, 12, 7, 1 },
                    { 370, 13, 7, 1 },
                    { 371, 6, 9, 1 },
                    { 372, 7, 9, 1 },
                    { 373, 8, 9, 1 },
                    { 374, 9, 9, 1 },
                    { 375, 10, 9, 1 },
                    { 376, 11, 9, 1 },
                    { 377, 12, 9, 1 },
                    { 378, 13, 9, 1 },
                    { 379, 6, 10, 1 },
                    { 380, 7, 10, 1 },
                    { 381, 8, 10, 1 },
                    { 382, 9, 10, 1 },
                    { 383, 10, 10, 1 },
                    { 384, 11, 10, 1 },
                    { 385, 12, 10, 1 },
                    { 386, 13, 10, 1 },
                    { 387, 14, 10, 1 },
                    { 388, 6, 11, 1 },
                    { 389, 7, 11, 1 },
                    { 390, 8, 11, 1 },
                    { 391, 9, 11, 1 },
                    { 392, 10, 11, 1 },
                    { 393, 11, 11, 1 },
                    { 394, 12, 11, 1 },
                    { 395, 13, 11, 1 },
                    { 396, 14, 11, 1 },
                    { 397, 7, 12, 1 },
                    { 398, 8, 12, 1 },
                    { 399, 9, 12, 1 },
                    { 400, 10, 12, 1 },
                    { 401, 11, 12, 1 },
                    { 402, 12, 12, 1 },
                    { 403, 13, 12, 1 },
                    { 404, 14, 12, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 404);
        }
    }
}
