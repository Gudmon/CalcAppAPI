using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class videoUrlimgUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VideoUrls",
                table: "Trailer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrls",
                table: "Trailer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VideoUrls",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrls",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "VideoUrls",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "VideoUrls",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "VideoUrls",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 14,
                column: "VideoUrls",
                value: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VideoUrls",
                table: "Trailer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrls",
                table: "Trailer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "VideoUrls",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrls",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 14,
                column: "VideoUrls",
                value: null);
        }
    }
}
