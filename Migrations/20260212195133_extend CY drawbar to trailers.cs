using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class extendCYdrawbartotrailers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: "8500");

            migrationBuilder.InsertData(
                table: "DrawbarTrailer",
                columns: new[] { "DrawbarId", "TrailerId" },
                values: new object[,]
                {
                    { 13, 8 },
                    { 13, 9 },
                    { 13, 10 },
                    { 13, 11 },
                    { 13, 16 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 13, 10 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 13, 11 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 13, 16 });

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: "8380");
        }
    }
}
