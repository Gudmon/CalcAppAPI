using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class change143frameprice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: "725");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: "695");
        }
    }
}
