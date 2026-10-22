using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpantrailerdrawbarsteeringconfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KrpanDrawbarSteering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Vonórúd kormányzási szöge ± 35˚");

            migrationBuilder.InsertData(
                table: "KrpanDrawbarSteering",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 2, "", "Vonórúd kormányzási szöge ± 40˚", "0" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "KrpanDrawbarSteeringId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "KrpanDrawbarSteeringId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "KrpanDrawbarSteeringId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "KrpanDrawbarSteeringId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "KrpanDrawbarSteeringId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "KrpanDrawbarSteeringId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "KrpanDrawbarSteeringId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "KrpanDrawbarSteeringId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "KrpanDrawbarSteeringId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "KrpanDrawbarSteeringId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 12,
                column: "KrpanDrawbarSteeringId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 13,
                column: "KrpanDrawbarSteeringId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 14,
                column: "KrpanDrawbarSteeringId",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KrpanDrawbarSteering",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "KrpanDrawbarSteering",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Vonórúd kormányzás + 40°");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "KrpanDrawbarSteeringId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "KrpanDrawbarSteeringId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "KrpanDrawbarSteeringId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "KrpanDrawbarSteeringId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "KrpanDrawbarSteeringId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "KrpanDrawbarSteeringId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "KrpanDrawbarSteeringId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "KrpanDrawbarSteeringId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "KrpanDrawbarSteeringId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "KrpanDrawbarSteeringId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 12,
                column: "KrpanDrawbarSteeringId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 13,
                column: "KrpanDrawbarSteeringId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 14,
                column: "KrpanDrawbarSteeringId",
                value: null);
        }
    }
}
