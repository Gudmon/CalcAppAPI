using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class changecntrolblocks2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CraneControlBlocks",
                columns: new[] { "Id", "ControlBlockId", "CraneId", "FrameTypeId" },
                values: new object[,]
                {
                    { 165, 6, 8, 8 },
                    { 166, 7, 8, 8 },
                    { 167, 8, 8, 8 },
                    { 168, 9, 8, 8 },
                    { 169, 10, 8, 8 },
                    { 170, 11, 8, 8 },
                    { 171, 12, 8, 8 },
                    { 172, 13, 8, 8 },
                    { 173, 6, 9, 5 },
                    { 174, 7, 9, 5 },
                    { 175, 8, 9, 5 },
                    { 176, 9, 9, 5 },
                    { 177, 10, 9, 5 },
                    { 178, 11, 9, 5 },
                    { 179, 12, 9, 5 },
                    { 180, 13, 9, 5 },
                    { 181, 6, 9, 6 },
                    { 182, 7, 9, 6 },
                    { 183, 8, 9, 6 },
                    { 184, 9, 9, 6 },
                    { 185, 10, 9, 6 },
                    { 186, 11, 9, 6 },
                    { 187, 12, 9, 6 },
                    { 188, 13, 9, 6 },
                    { 189, 6, 9, 7 },
                    { 190, 7, 9, 7 },
                    { 191, 8, 9, 7 },
                    { 192, 9, 9, 7 },
                    { 193, 10, 9, 7 },
                    { 194, 11, 9, 7 },
                    { 195, 12, 9, 7 },
                    { 196, 13, 9, 7 },
                    { 197, 8, 9, 9 },
                    { 198, 9, 9, 9 },
                    { 199, 10, 9, 9 },
                    { 200, 11, 9, 9 },
                    { 201, 12, 9, 9 },
                    { 202, 13, 9, 9 },
                    { 203, 8, 9, 10 },
                    { 204, 9, 9, 10 },
                    { 205, 10, 9, 10 },
                    { 206, 11, 9, 10 },
                    { 207, 12, 9, 10 },
                    { 208, 13, 9, 10 },
                    { 209, 6, 10, 5 },
                    { 210, 7, 10, 5 },
                    { 211, 8, 10, 5 },
                    { 212, 9, 10, 5 },
                    { 213, 10, 10, 5 },
                    { 214, 11, 10, 5 },
                    { 215, 12, 10, 5 },
                    { 216, 13, 10, 5 },
                    { 217, 14, 10, 5 },
                    { 218, 6, 10, 6 },
                    { 219, 7, 10, 6 },
                    { 220, 8, 10, 6 },
                    { 221, 9, 10, 6 },
                    { 222, 10, 10, 6 },
                    { 223, 11, 10, 6 },
                    { 224, 12, 10, 6 },
                    { 225, 13, 10, 6 },
                    { 226, 14, 10, 6 },
                    { 227, 6, 10, 7 },
                    { 228, 7, 10, 7 },
                    { 229, 8, 10, 7 },
                    { 230, 9, 10, 7 },
                    { 231, 10, 10, 7 },
                    { 232, 11, 10, 7 },
                    { 233, 12, 10, 7 },
                    { 234, 13, 10, 7 },
                    { 235, 14, 10, 7 },
                    { 236, 8, 10, 9 },
                    { 237, 9, 10, 9 },
                    { 238, 10, 10, 9 },
                    { 239, 11, 10, 9 },
                    { 240, 12, 10, 9 },
                    { 241, 13, 10, 9 },
                    { 242, 14, 10, 9 },
                    { 243, 8, 10, 10 },
                    { 244, 9, 10, 10 },
                    { 245, 10, 10, 10 },
                    { 246, 11, 10, 10 },
                    { 247, 12, 10, 10 },
                    { 248, 13, 10, 10 },
                    { 249, 14, 10, 10 },
                    { 250, 6, 11, 5 },
                    { 251, 7, 11, 5 },
                    { 252, 8, 11, 5 },
                    { 253, 9, 11, 5 },
                    { 254, 10, 11, 5 },
                    { 255, 11, 11, 5 },
                    { 256, 12, 11, 5 },
                    { 257, 13, 11, 5 },
                    { 258, 14, 11, 5 },
                    { 259, 6, 11, 6 },
                    { 260, 7, 11, 6 },
                    { 261, 8, 11, 6 },
                    { 262, 9, 11, 6 },
                    { 263, 10, 11, 6 },
                    { 264, 11, 11, 6 },
                    { 265, 12, 11, 6 },
                    { 266, 13, 11, 6 },
                    { 267, 14, 11, 6 },
                    { 268, 6, 11, 7 },
                    { 269, 7, 11, 7 },
                    { 270, 8, 11, 7 },
                    { 271, 9, 11, 7 },
                    { 272, 10, 11, 7 },
                    { 273, 11, 11, 7 },
                    { 274, 12, 11, 7 },
                    { 275, 13, 11, 7 },
                    { 276, 14, 11, 7 },
                    { 277, 8, 11, 9 },
                    { 278, 9, 11, 9 },
                    { 279, 10, 11, 9 },
                    { 280, 11, 11, 9 },
                    { 281, 12, 11, 9 },
                    { 282, 13, 11, 9 },
                    { 283, 14, 11, 9 },
                    { 284, 8, 11, 10 },
                    { 285, 9, 11, 10 },
                    { 286, 10, 11, 10 },
                    { 287, 11, 11, 10 },
                    { 288, 12, 11, 10 },
                    { 289, 13, 11, 10 },
                    { 290, 14, 11, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "CraneControlBlocks",
                keyColumn: "Id",
                keyValue: 290);
        }
    }
}
