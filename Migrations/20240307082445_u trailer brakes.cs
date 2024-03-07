using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class utrailerbrakes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brake",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 20, "B1", "2 keréken hidraulikus fék", "3390" },
                    { 21, "B2", "4 keréken hidraulikus fék", "6670" },
                    { 22, "B3", "2 keréken légfék", "4045" },
                    { 23, "B4", "4 keréken légfék", "7510" },
                    { 24, "BA-EU", "Légfék", "7465" },
                    { 25, "BH-EU", "Hidraulikus fék", "8635" },
                    { 26, "B2", "4 keréken hidraulikus fék", "2305" },
                    { 27, "B3", "2 keréken légfék", "1860" },
                    { 28, "B4", "4 keréken légfék", "3145" },
                    { 29, "BA-EU", "Légfék", "3620" },
                    { 30, "BH-EU", "Hidraulikus fék", "4795" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
