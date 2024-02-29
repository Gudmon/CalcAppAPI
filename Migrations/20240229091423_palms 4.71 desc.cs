using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class palms471desc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Sokoldalú közepes méretű daru, különféle ágazatokban, például fakitermelésben és mezőgazdaságban. Kompatibilis a legtöbb PALMS pótkocsival");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Versatile medium-sized crane, used across diverse sectors like arboriculture, farming, and land development. Compatible with the majority of PALMS trailers.");
        }
    }
}
