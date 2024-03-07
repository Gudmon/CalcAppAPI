using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixpah : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BunkExtension",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: "625");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BunkExtension",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: "150");
        }
    }
}
