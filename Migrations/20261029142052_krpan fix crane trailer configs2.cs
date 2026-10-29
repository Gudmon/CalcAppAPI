using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpanfixcranetrailerconfigs2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                    { 3, 11 }
                });
        }
    }
}
