using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class _20260422rotatorhydropack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.UpdateData(
                table: "HydroPack",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: "2510");

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Fék az oldalirányú mozgáshoz. A fékek terheletlen módon vannak beállítva.");

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Fék az oldalirányú mozgáshoz. A fékek terheletlen módon vannak beállítva.");

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Fékek az oldalirányú és előre-hátra mozgáshoz. A fékek terheletlen módon vannak beállítva.");

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Fékek az oldalirányú és előre-hátra mozgáshoz. A fékek terheletlen módon vannak beállítva.");

            migrationBuilder.InsertData(
                table: "RotatorBrakeCrane",
                columns: new[] { "CraneId", "RotatorBrakeId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 2 },
                    { 9, 2 },
                    { 10, 2 },
                    { 11, 2 },
                    { 12, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.UpdateData(
                table: "HydroPack",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: "1510");

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Fék az oldalirányú mozgáshoz. A fékek terheletlen markolókhoz vannak beállítva.");

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Fék az oldalirányú mozgáshoz. A fékek terheletlen markolókhoz vannak beállítva.");

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Fékek az oldalirányú és előre-hátra mozgáshoz. A fékek terheletlen markolókhoz vannak beállítva.");

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Fékek az oldalirányú és előre-hátra mozgáshoz. A fékek terheletlen markolókhoz vannak beállítva.");

            migrationBuilder.InsertData(
                table: "RotatorBrakeCrane",
                columns: new[] { "CraneId", "RotatorBrakeId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 3 },
                    { 8, 3 },
                    { 9, 3 },
                    { 10, 3 },
                    { 11, 3 },
                    { 12, 3 }
                });
        }
    }
}
