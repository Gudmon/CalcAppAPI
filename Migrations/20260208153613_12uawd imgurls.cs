using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class _12uawdimgurls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrls",
                value: "[\"PALMS-12U-UAWD-1\",\"PALMS-12U-UAWD-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrls",
                value: "[\"PALMS-12U-UAWD-1\",\"PALMS-12U-UAWD-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrls",
                value: "[\"PALMS-15U-UAWD-1\",\"PALMS-15U-UAWD-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrls",
                value: "[\"PALMS-15U-UAWD-1\",\"PALMS-15U-UAWD-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrls",
                value: "[\"PALMS-12U/12UAWD-1\",\"PALMS-12U/12UAWD-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrls",
                value: "[\"PALMS-12U/UAWD-1\",\"PALMS-12U/UAWD-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrls",
                value: "[\"PALMS-15U/UAWD-1\",\"PALMS-15U/UAWD-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrls",
                value: "[\"PALMS-15U/UAWD-1\",\"PALMS-15U/UAWD-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]");
        }
    }
}
