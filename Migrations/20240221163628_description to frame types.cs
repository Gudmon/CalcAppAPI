using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class descriptiontoframetypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "FrameType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mass",
                table: "FrameType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Mass" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Mass" },
                values: new object[] { "Kisebb PALMS erdészeti darukhoz megfelelő típusú támasztólábak", "174" });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Mass" },
                values: new object[] { "A típusú támasztólábak közepes méretű PALMS darukhoz", "313" });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Mass" },
                values: new object[] { "FD típusú támasztólábak", "237" });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Mass" },
                values: new object[] { "FD típusú támasztólábak", "449" });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Mass" },
                values: new object[] { "Nagy teherbírású talp támasztólábak nélkül", "231" });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Mass" },
                values: new object[] { "FD nagy teherbírású (HD) típusú támaszlábak", "474" });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Mass" },
                values: new object[] { "FD típusú támasztólábak PALMS 5.87Z daruhoz", "520" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "FrameType");

            migrationBuilder.DropColumn(
                name: "Mass",
                table: "FrameType");
        }
    }
}
