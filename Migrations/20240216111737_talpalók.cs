using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class talpalók : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FrameType",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 2, "B2.1", "A típusú kis letalpaló, 3 pontos csatlakozással", "1680" },
                    { 3, "B3", "A típusú normál méretű letalpaló, 3 pontos csatlakozással", "2100" },
                    { 4, "B4e", "FD típusú economy letalpaló", "2100" },
                    { 5, "B6.1", "FD típusú letalpaló, 3 pontos csatlakozással", "3090" },
                    { 6, "B09", "Különösen erős alap, talpaló lábak nélkül", "1155" },
                    { 7, "B9", "FD típusú, különösen erős letalpaló (HD)", "3530" },
                    { 8, "B10", "Talpaló Z daruhoz", "3685" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
