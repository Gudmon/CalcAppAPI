using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class changerotators : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RotatorCapacity",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RotatorConnection",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RotatorType",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RotatorCapacity", "RotatorConnection", "RotatorType" },
                values: new object[] { "30", "FR", "FL" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RotatorCapacity", "RotatorConnection", "RotatorType" },
                values: new object[] { "30", "FR", "FL" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RotatorCapacity", "RotatorConnection", "RotatorType" },
                values: new object[] { "30", "FR", "FL" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RotatorCapacity", "RotatorConnection", "RotatorType" },
                values: new object[] { "30", "FR", "FL" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RotatorCapacity", "RotatorConnection", "RotatorType" },
                values: new object[] { "45", "Palms", "FL" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RotatorCapacity", "RotatorConnection", "RotatorType" },
                values: new object[] { "55", "Palms", "FL" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RotatorCapacity", "RotatorConnection", "RotatorType" },
                values: new object[] { "55", "Palms", "FL" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RotatorCapacity", "RotatorConnection", "RotatorType" },
                values: new object[] { "55", "Palms", "FL" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RotatorCapacity", "RotatorConnection", "RotatorType" },
                values: new object[] { "60", "Palms", "FL (Indexator-tól)" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RotatorCapacity", "RotatorConnection", "RotatorType" },
                values: new object[] { "60", "Palms", "FL (Indexator-tól)" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "RotatorCapacity", "RotatorConnection", "RotatorType" },
                values: new object[] { "60", "Palms", "FL (Indexator-tól)" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "RotatorCapacity", "RotatorConnection", "RotatorType" },
                values: new object[] { "100", "Palms", "FL (Indexator-tól)" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "RotatorCapacity", "RotatorConnection", "RotatorType" },
                values: new object[] { "10", "csapos", "Finrotor" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RotatorCapacity",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "RotatorConnection",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "RotatorType",
                table: "Crane");
        }
    }
}
