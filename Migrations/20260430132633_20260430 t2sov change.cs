using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class _20260430t2sovchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "95 l-es olajtartály elzáró csappal");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "95 l-es olajtartály HVLP olajjal, elzáró csappal");
        }
    }
}
