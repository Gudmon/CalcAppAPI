using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class utrailerpropulsions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Propulsion",
                columns: new[] { "Id", "Code", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 7, "45WDB", "", "4WD BlackBruin elektronikus teljesítmény szabályozással", "0" },
                    { 8, "45WDB.1", "", "4WD BlackBruin elektronikus teljesítmény szabályozással, ISOBUS-hoz előkészítve", "1135" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
