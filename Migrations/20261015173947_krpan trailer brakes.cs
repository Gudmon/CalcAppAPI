using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpantrailerbrakes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "KrpanBrakeTrailer",
                columns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 3, 12 },
                    { 4, 9 },
                    { 4, 10 },
                    { 4, 11 },
                    { 4, 12 },
                    { 4, 13 },
                    { 4, 14 },
                    { 5, 10 },
                    { 5, 11 },
                    { 5, 12 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 6, 12 },
                    { 6, 13 },
                    { 6, 14 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "KrpanBrakeTrailer",
                keyColumns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
                keyValues: new object[] { 6, 14 });
        }
    }
}
