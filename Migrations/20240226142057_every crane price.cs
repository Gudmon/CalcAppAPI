using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class everycraneprice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: "11435");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: "14265");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: "15385");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: "14780");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: "19940");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: "21105");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: "31460");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 6,
                column: "Area",
                value: "0.25");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 9,
                column: "Area",
                value: "0.25");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: "-");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: "-");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: "-");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: "-");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: "-");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: "-");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: "-");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 6,
                column: "Area",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 9,
                column: "Area",
                value: null);
        }
    }
}
