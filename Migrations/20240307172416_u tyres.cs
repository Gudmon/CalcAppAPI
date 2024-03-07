using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class utyres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LightTrailer",
                columns: new[] { "LightId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 },
                    { 2, 17 },
                    { 2, 18 },
                    { 2, 19 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 3, 19 }
                });

            migrationBuilder.InsertData(
                table: "OilPumpTrailer",
                columns: new[] { "OilPumpId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 2, 12 },
                    { 2, 14 },
                    { 2, 17 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 15 },
                    { 3, 17 },
                    { 3, 18 },
                    { 4, 12 },
                    { 4, 13 },
                    { 4, 14 },
                    { 4, 15 },
                    { 4, 16 },
                    { 4, 17 },
                    { 4, 18 },
                    { 4, 19 },
                    { 5, 12 },
                    { 5, 13 },
                    { 5, 14 },
                    { 5, 15 },
                    { 5, 16 },
                    { 5, 17 },
                    { 5, 18 },
                    { 5, 19 },
                    { 6, 12 },
                    { 6, 13 },
                    { 6, 14 },
                    { 6, 15 },
                    { 6, 16 },
                    { 6, 17 },
                    { 6, 18 },
                    { 6, 19 },
                    { 7, 12 },
                    { 7, 13 },
                    { 7, 14 },
                    { 7, 15 },
                    { 7, 16 },
                    { 7, 17 },
                    { 7, 18 },
                    { 7, 19 }
                });

            migrationBuilder.InsertData(
                table: "OilTank",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 5, "T2+", "95 l-es olajtartály HVLP olajjal", "1295" },
                    { 6, "T2SOV+", "95 l-es olajtartály HVLP olajjal, elzáró csappal, olajszűrővel", "1495" }
                });

            migrationBuilder.InsertData(
                table: "OilTankTrailer",
                columns: new[] { "OilTankId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 3, 19 }
                });

            migrationBuilder.InsertData(
                table: "SupportLegTrailer",
                columns: new[] { "SupportLegId", "TrailerId" },
                values: new object[,]
                {
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 },
                    { 2, 17 },
                    { 2, 18 },
                    { 2, 19 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 3, 19 }
                });

            migrationBuilder.InsertData(
                table: "TyreTrailer",
                columns: new[] { "TrailerId", "TyreId" },
                values: new object[,]
                {
                    { 12, 3 },
                    { 12, 5 },
                    { 12, 7 },
                    { 13, 6 },
                    { 13, 8 },
                    { 13, 9 },
                    { 13, 10 },
                    { 14, 6 },
                    { 14, 8 },
                    { 14, 9 },
                    { 14, 10 },
                    { 14, 11 },
                    { 14, 12 },
                    { 15, 6 },
                    { 15, 8 },
                    { 15, 9 },
                    { 15, 10 },
                    { 15, 11 },
                    { 15, 12 },
                    { 16, 8 },
                    { 16, 9 },
                    { 16, 10 },
                    { 16, 11 },
                    { 16, 12 },
                    { 17, 8 },
                    { 17, 9 },
                    { 17, 10 },
                    { 17, 11 },
                    { 17, 12 },
                    { 18, 8 },
                    { 18, 9 },
                    { 18, 10 },
                    { 18, 11 },
                    { 18, 12 },
                    { 19, 8 },
                    { 19, 9 },
                    { 19, 10 },
                    { 19, 11 },
                    { 19, 12 }
                });

            migrationBuilder.InsertData(
                table: "OilTankTrailer",
                columns: new[] { "OilTankId", "TrailerId" },
                values: new object[,]
                {
                    { 5, 12 },
                    { 5, 13 },
                    { 5, 14 },
                    { 5, 15 },
                    { 5, 16 },
                    { 5, 17 },
                    { 5, 18 },
                    { 5, 19 },
                    { 6, 12 },
                    { 6, 13 },
                    { 6, 14 },
                    { 6, 15 },
                    { 6, 16 },
                    { 6, 17 },
                    { 6, 18 },
                    { 6, 19 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 2, 19 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 4, 15 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 4, 19 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 5, 17 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 5, 18 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 5, 19 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 6, 15 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 6, 17 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 6, 18 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 6, 19 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 7, 14 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 7, 15 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 7, 17 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 7, 18 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 7, 19 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 5, 17 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 5, 18 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 5, 19 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 6, 15 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 6, 17 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 6, 18 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 6, 19 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 2, 19 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 13, 10 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 14, 10 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 14, 11 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 14, 12 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 15, 10 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 15, 11 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 15, 12 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 16, 9 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 16, 11 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 16, 12 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 17, 8 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 17, 9 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 17, 10 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 17, 11 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 17, 12 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 18, 8 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 18, 9 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 18, 10 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 18, 11 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 18, 12 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 19, 8 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 19, 9 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 19, 10 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 19, 11 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 19, 12 });

            migrationBuilder.DeleteData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
