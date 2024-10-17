using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixframetypesandhoseguardnames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "B6, FD típusú letalpaló, 3 pontos csatlakozással");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "B9, FD típusú, különösen erős letalpaló (HD)");

            migrationBuilder.UpdateData(
                table: "HoseGuard",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Tömlő védő B3 és B6 talpaló esetén");

            migrationBuilder.UpdateData(
                table: "HoseGuard",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Tömlő védő B9 talpaló esetén");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "FD típusú letalpaló, 3 pontos csatlakozással");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "FD típusú, különösen erős letalpaló (HD)");

            migrationBuilder.UpdateData(
                table: "HoseGuard",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Tömlő védő B3 és B6.1 talpaló esetén");

            migrationBuilder.UpdateData(
                table: "HoseGuard",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Tömlő védő  B09 és B9 talpaló esetén");
        }
    }
}
