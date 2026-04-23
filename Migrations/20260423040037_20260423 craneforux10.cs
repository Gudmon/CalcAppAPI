using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class _20260423craneforux10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.InsertData(
                table: "CraneTrailer",
                columns: new[] { "CraneId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 8 },
                    { 2, 8 },
                    { 3, 8 },
                    { 4, 8 }
                });

            migrationBuilder.InsertData(
                table: "RotatorBrakeCrane",
                columns: new[] { "CraneId", "RotatorBrakeId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.InsertData(
                table: "CraneTrailer",
                columns: new[] { "CraneId", "TrailerId" },
                values: new object[,]
                {
                    { 9, 8 },
                    { 10, 8 },
                    { 11, 8 },
                    { 12, 8 }
                });

            migrationBuilder.InsertData(
                table: "RotatorBrakeCrane",
                columns: new[] { "CraneId", "RotatorBrakeId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 }
                });
        }
    }
}
