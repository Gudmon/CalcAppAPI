using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class trailercraneconfig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TrailerCraneConfigurations",
                columns: new[] { "Id", "CraneId", "SelectedFrameTypeId", "TrailerId" },
                values: new object[,]
                {
                    { 6, 5, 3, 2 },
                    { 7, 5, 4, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TrailerCraneConfigurations",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
