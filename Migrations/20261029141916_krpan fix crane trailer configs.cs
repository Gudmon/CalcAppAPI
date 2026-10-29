using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpanfixcranetrailerconfigs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.InsertData(
                table: "KrpanCraneTrailer",
                columns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 3 },
                    { 10, 6 },
                    { 11, 1 },
                    { 11, 2 },
                    { 11, 3 },
                    { 12, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.InsertData(
                table: "KrpanCraneTrailer",
                columns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 6 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 6 }
                });
        }
    }
}
