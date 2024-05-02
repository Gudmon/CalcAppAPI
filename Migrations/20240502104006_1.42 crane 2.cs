using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class _142crane2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 13,
                column: "BrutLiftingTorque190Bar",
                value: "11,5");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 13,
                column: "BrutLiftingTorque190Bar",
                value: "-");
        }
    }
}
