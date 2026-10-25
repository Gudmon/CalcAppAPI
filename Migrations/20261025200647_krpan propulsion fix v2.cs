using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpanpropulsionfixv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KrpanPropulsionTrailer",
                keyColumns: new[] { "KrpanPropulsionId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "KrpanPropulsionTrailer",
                keyColumns: new[] { "KrpanPropulsionId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "KrpanPropulsionTrailer",
                keyColumns: new[] { "KrpanPropulsionId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "KrpanPropulsionTrailer",
                keyColumns: new[] { "KrpanPropulsionId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 8 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "KrpanPropulsionTrailer",
                columns: new[] { "KrpanPropulsionId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 1, 8 },
                    { 3, 5 },
                    { 3, 8 }
                });
        }
    }
}
