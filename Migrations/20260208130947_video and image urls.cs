using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class videoandimageurls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "Trailer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-2.42-1\",\"PALMS-2.42-2\"]", "[\"fEDDjo_K3E8\"]" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-2.54-1, PALMS-2.54-2, PALMS-2.54-3\",\"PALMS-2.54-4\",\"PALMS-2.54-5\"]", "[\"fEDDjo_K3E8\",\"OUXj3T4seD0\"]" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-3.63-1, PALMS-3.63-2, PALMS-3.63-3\"]", "[\"9VS2BuQwv\"]" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-3.67-1\",\"PALMS-3.67-2\",\"PALMS-3.67-3\",\"PALMS-3.67-4\",\"PALMS-3.67-5\",\"PALMS-3.67-6\"]", "[\"9VS2BuQwv\"]" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-4.71-1\",\"PALMS-4.71-2\",\"PALMS-4.71-3\",\"PALMS-4.71-4\",\"PALMS-4.71-5\"]", "[\"NYLCfmf-Nfc\"]" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-5.75-1\",\"PALMS-5.75-2\",\"PALMS-5.75-3\"]", "[\"-f0tPn8V78g\"]" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-5.85-1\",\"PALMS-5.85-2\",\"PALMS-5.85-3\",\"PALMS-5.85-4\",\"PALMS-5.85-5\"]", "[\"-f0tPn8V78g\"]" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-5.87Z-1\",\"PALMS-5.87Z-2\",\"PALMS-5.87Z-3\",\"PALMS-5.87Z-4\",\"PALMS-5.87Z-5\",\"PALMS-5.87Z-6\"]", "[\"pLvH1NAPEzI\"]" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-7.78-1\",\"PALMS-7.78-2\",\"PALMS-7.78-3\",\"PALMS-7.78-4\"]", "[\"z55HswaDwSA\"]" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-7.87-1\",\"PALMS-7.87-2\",\"PALMS-7.87-3\",\"PALMS-7.87-4\",\"PALMS-7.87-5\",\"PALMS-7.87-6\"]", "[\"z55HswaDwSA\"]" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-7.94-1\",\"PALMS-7.94-2\",\"PALMS-7.94-3\"]", "[\"z55HswaDwSA\"]" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-X100-1\",\"PALMS-X100-2\",\"PALMS-X100-3\",\"PALMS-X100-4\",\"PALMS-X100-5\",\"PALMS-X100-6\",\"PALMS-X100-7\"]", "[\"x9GnpJnvNVU\"]" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-1.42-1\",\"PALMS-1.42-2\",\"PALMS-1.42-3\",\"PALMS-1.42-4\"]", "[\"25Y2HRXtohQ\",\"2r7Po4NpYHw\"]" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-6S-1\",\"PALMS-6S-2\",\"PALMS-6S-3\",\"PALMS-6S-4\"]", "[\"5-tqIrDOU0I\",\"OUXj3T4seD0\"]" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-8SX-1\",\"PALMS-8SX-2\"]", "[\"VEvGOG-aFyM\"]" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-8D-1\",\"PALMS-8D-2\",\"PALMS-8D-3\",\"PALMS-8D-4\",\"PALMS-8D-5\"]", "[\"cdz1OF0USqI\",\"PEdgbkWowyQ\"]" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-9SC-1\",\"PALMS-9SC-2\",\"Patented-Bolster-Lock\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Lightweight-Frame\"]", "[\"4ZeFp4Yofak\"]" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-10D-1\",\"PALMS-10D-2\",\"PALMS-10D-3\",\"PALMS-10D-4\",\"PALMS-10D-5\",\"Patented-Bolster-Lock\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Durable-Double-Frame\",\"Protected\"]", "[\"0u8VqxRevL4\"]" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-12D-1\",\"PALMS-12D-2\",\"Patented-Bolster-Lock\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Durable-Double-Frame\",\"Protected\"]", null });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-14D-1\",\"PALMS-14D-2\",\"PALMS-14D-3\",\"PALMS-14D-4\",\"Patented-Bolster-Lock\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Durable-Double-Frame\",\"Protected\"]", null });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-10UX-1\",\"PALMS-10UX-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]", null });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-12U/12UAWD-1\",\"PALMS-12U/12UAWD-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]", "[\"akmzrXf3EnU\"]" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-12U/UAWD-1\",\"PALMS-12U/UAWD-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]", "[\"akmzrXf3EnU\"]" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-15U/UAWD-1\",\"PALMS-15U/UAWD-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]", "[\"cH3t306elVs\"]" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-15U/UAWD-1\",\"PALMS-15U/UAWD-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]", "[\"cH3t306elVs\"]" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-MWD3.2-1\",\"PALMS-MWD3.2-2\",\"PALMS-MWD\"]", "[\"hxtfyL4ONy0\"]" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-HMWD3.2-1\",\"PALMS-HMWD3.2-2\",\"PALMS-HMWD3.2-3\",\"PALMS-HMWD3.2-4\",\"PALMS-MWD\"]", null });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-2D-1\",\"PALMS-2D-2\",\"PALMS-2D-3\",\"PALMS-2D-4\",\"PALMS-2D-5\",\"PALMS-2D-6\",\"PALMS-2D-7\",\"PALMS-2D-8\"]", "[\"n6LnRTycDZM\",\"2r7Po4NpYHw\",\"25Y2HRXtohQ\"]" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-11UX-1\",\"PALMS-11UX-2\",\"PALMS-11UX-3\",\"PALMS-11UX-4\",\"PALMS-11UX-5\",\"PALMS-11UX-6\",\"PALMS-11UX-7\",\"PALMS-11UX-8\"]", "[\"Wl0s4WdzNDM\"]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "Trailer");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "Crane");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrls",
                value: null);
        }
    }
}
