using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpantrailerimages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "KrpanBrake",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"GP-8-DF-1\",\"GP-8-DF-2\"]", "[\"-EOIQ2Sy7M4\"]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"GP-9-DF-1\",\"GP-9-DF-2\"]");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: "[\"GP-10-DF-1\",\"GP-10-DF-2\"]");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: "[\"GP-12-DF-1\",\"GP-12-DF-2\"]");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"GP-14-DF-1\",\"GP-14-DF-2\"]", "[\"6JXpN5oIUA4\"]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrls",
                value: "[\"GP-11-D-1\",\"GP-11-D-2\"]");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrls",
                value: "[\"GP-13-D-1\",\"GP-13-D-2\"]");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrls",
                value: "[\"GP-15-D-1\",\"GP-15-D-2\"]");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"GP-7-XS-1\",\"GP-7-XS-2\"]", "[\"eB66vywCgFs\",\"VJmU9TXSjW8\"]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"GP-8-XS-1\",\"GP-8-XS-2\"]", "[\"eB66vywCgFs\"]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"GP-8-S-1\",\"GP-8-S-2\"]", "[\"RG93RjpyeC4\"]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrls",
                value: "[\"GP-9-S-1\",\"GP-9-S-2\"]");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrls",
                value: "[\"GP-10-S-1\",\"GP-10-S-2\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "KrpanBrake",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[]", "[]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[]", "[]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrls",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrls",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrls",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[]", "[]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[]", "[]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[]", "[]" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrls",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrls",
                value: "[]");
        }
    }
}
