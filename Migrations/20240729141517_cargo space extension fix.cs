using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class cargospaceextensionfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KrpanDrawbarSteering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Vonórúd kormányzás + 40°");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KrpanDrawbarSteering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "vonórúd kormányzás + 40°");
        }
    }
}
