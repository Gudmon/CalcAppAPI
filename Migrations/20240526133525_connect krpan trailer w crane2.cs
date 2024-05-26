using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class connectkrpantrailerwcrane2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "GD 6,6 K");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "GP 11 D");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Krpan GP 11 D");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Krpan GP 11 D");
        }
    }
}
