using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class talpalók2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TrailerCraneCompatibilities",
                columns: new[] { "Id", "Available", "CraneId", "FrameTypeId", "Recommended", "TrailerId" },
                values: new object[,]
                {
                    { 4, true, 4, 1, true, 1 },
                    { 5, true, 5, 1, true, 1 },
                    { 6, true, 4, 3, true, 2 },
                    { 7, true, 4, 4, true, 2 },
                    { 8, true, 4, 5, false, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrailerCraneCompatibilities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TrailerCraneCompatibilities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TrailerCraneCompatibilities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TrailerCraneCompatibilities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TrailerCraneCompatibilities",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
