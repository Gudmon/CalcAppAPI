using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixbrakesandpropulsions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "EU jóváhagyott szett, légfék 2 keréken, PB1");

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "EU jóváhagyott szett, hidraulikus fék, PB1");

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "EU jóváhagyott szett, légfék 4 keréken, PB1");

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "EU jóváhagyott szett, hidraulikus fék, PB1");

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "EU jóváhagyott szett, légfék 4 keréken, PB1");

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "EU jóváhagyott szett, hidraulikus fék, PB1");

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "EU jóváhagyott szett, légfék 4 keréken, PB1");

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "EU jóváhagyott szett, hidraulikus fék, PB1");

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "2WD hajtás (BB240 a hátsó tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Légfék");

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Hidraulikus fék");

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Légfék");

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Hidraulikus fék");

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Légfék");

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Hidraulikus fék");

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "Légfék");

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "Hidraulikus fék");

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "2WD hajtás (BB240 az hátsó tengelyen elektronikus vezérléssel, fékhez előkészítve)");
        }
    }
}
