using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class _142grapple : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Area", "Mass" },
                values: new object[] { "0.09", "36" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Area", "Mass" },
                values: new object[] { null, null });
        }
    }
}
