using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class _11uxnewvideo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 16,
                column: "VideoUrls",
                value: "[\"Wl0s4WdzNDM\",\"kHSq-CN9i3k\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 16,
                column: "VideoUrls",
                value: "[\"Wl0s4WdzNDM\"]");
        }
    }
}
