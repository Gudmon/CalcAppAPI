using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class upropulsions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PropulsionTrailer",
                columns: new[] { "PropulsionId", "TrailerId" },
                values: new object[,]
                {
                    { 3, 13 },
                    { 3, 15 },
                    { 3, 18 },
                    { 4, 13 },
                    { 4, 15 },
                    { 4, 18 },
                    { 7, 16 },
                    { 7, 19 },
                    { 8, 16 },
                    { 8, 19 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 4, 15 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 7, 19 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 8, 16 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 8, 19 });
        }
    }
}
