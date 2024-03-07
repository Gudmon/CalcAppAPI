using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixpah2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BunkExtension",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Forwarder típusú bunk kiterjesztés (az ár 1 db-ra vonatkozik)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BunkExtension",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "forwarder típusú bunk kiterjesztés (az ár 1 db-ra vonatkozik)");
        }
    }
}
