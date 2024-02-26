using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class grappleswmassandarea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Grapple",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mass",
                table: "Grapple",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Area", "Mass" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Area", "Mass" },
                values: new object[] { "0.16", "69" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Area", "Mass" },
                values: new object[] { "0.16", "66" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Area", "Mass" },
                values: new object[] { "0.18", "88" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Area", "Mass" },
                values: new object[] { "0.23", "114" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Area", "Mass" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Area", "Mass" },
                values: new object[] { "0.26", "174" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Area", "Mass" },
                values: new object[] { "0.21", "127" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Area", "Mass" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Area", "Mass" },
                values: new object[] { "0.23", "118" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Area", "Mass" },
                values: new object[] { "0.25", "223" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Area", "Mass" },
                values: new object[] { "0.28", "205" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Area", "Mass" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Area", "Mass" },
                values: new object[] { null, "195" });

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "45 kN-os rotátor FL (talpas)");

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "55 kN-os rotátor FL (talpas)");

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "60 kN-os rotátor FL Indexator GV6 (talpas)");

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "100 kN-os rotátor FL Indexator T10 (talpas)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Grapple");

            migrationBuilder.DropColumn(
                name: "Mass",
                table: "Grapple");

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "45 kN-os rotátor FL");

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "55 kN-os rotátor FL");

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "60 kN-os rotátor FL Indexator GV6");

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "100 kN-os rotátor FL Indexator T10");
        }
    }
}
