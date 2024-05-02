using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class changecovertext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cover",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Védőhuzat bőrből A2-A7-es, A11-es, A12-es és A14-es vezértömbökhöz");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cover",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Védőhuzat bőrből A2-A7-hez, A11-hez, A12-höz és A14-hez");
        }
    }
}
