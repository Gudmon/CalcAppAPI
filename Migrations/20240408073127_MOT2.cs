using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class MOT2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MOT",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Pótkocsi Műszaki vizsga");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MOT",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Műszaki vizsga");
        }
    }
}
