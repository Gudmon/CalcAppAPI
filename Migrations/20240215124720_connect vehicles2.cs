using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class connectvehicles2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LightTrailer",
                columns: new[] { "LightId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 }
                });

            migrationBuilder.InsertData(
                table: "OilPumpTrailer",
                columns: new[] { "OilPumpId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 8 },
                    { 4, 9 },
                    { 4, 10 },
                    { 4, 11 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 },
                    { 5, 8 },
                    { 5, 9 },
                    { 5, 10 },
                    { 5, 11 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 6, 8 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 7, 7 },
                    { 7, 8 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 11 }
                });

            migrationBuilder.InsertData(
                table: "OilTankTrailer",
                columns: new[] { "OilTankId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 8 },
                    { 4, 9 },
                    { 4, 10 },
                    { 4, 11 }
                });

            migrationBuilder.InsertData(
                table: "PlatformTrailer",
                columns: new[] { "PlatformId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "SupportLegTrailer",
                columns: new[] { "SupportLegId", "TrailerId" },
                values: new object[,]
                {
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 7, 11 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 3, 11 });
        }
    }
}
