using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class _20260423b4frametype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "FD típusú economy talpaló (csak 7SX, 8SX és 9SC pótkocsikhoz)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "FD típusú economy talpaló");
        }
    }
}
