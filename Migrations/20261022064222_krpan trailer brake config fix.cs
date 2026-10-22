using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpantrailerbrakeconfigfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.InsertData(
                table: "KrpanBrakeTrailer",
                columns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 3 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 7, 7 },
                    { 7, 8 },
                    { 8, 1 },
                    { 8, 2 },
                    { 8, 3 },
                    { 8, 4 },
                    { 8, 5 },
                    { 8, 6 },
                    { 8, 7 },
                    { 8, 8 },
                    { 9, 1 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 3 },
                    { 10, 4 },
                    { 10, 5 },
                    { 10, 6 },
                    { 10, 7 },
                    { 10, 8 },
                    { 11, 6 },
                    { 11, 7 },
                    { 11, 8 }
                });

            migrationBuilder.UpdateData(
                table: "KrpanTrailerSupportLeg",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Mechanikus támasztóláb - állítható", "0" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailerSupportLeg",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Hidraulikus támasztóláb", "519,17" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.InsertData(
                table: "KrpanBrakeTrailer",
                columns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 3, 4 },
                    { 3, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 8 }
                });

            migrationBuilder.UpdateData(
                table: "KrpanTrailerSupportLeg",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Hidraulikus támasztóláb", "519,17" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailerSupportLeg",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Mechanikus támasztóláb - állítható", "0" });
        }
    }
}
