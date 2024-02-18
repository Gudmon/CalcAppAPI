using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class trailercraneconfig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TrailerCraneConfigurations",
                columns: new[] { "Id", "CraneId", "SelectedFrameTypeId", "TrailerId" },
                values: new object[,]
                {
                    { 3, 4, 1, 2 },
                    { 4, 4, 3, 2 },
                    { 5, 4, 4, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
