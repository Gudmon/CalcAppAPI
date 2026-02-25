using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class changeconfigimagesandvideos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "A",
                table: "Grapple",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "B",
                table: "Grapple",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "C",
                table: "Grapple",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "D",
                table: "Grapple",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "E",
                table: "Grapple",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BoomGuard",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-crane-boom-guard-BG5-BG7-1\",\"PALMS-crane-boom-guard-BG5-BG7-2\"]");

            migrationBuilder.UpdateData(
                table: "BoomGuard",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-crane-boom-guard-BG5-BG7-1\",\"PALMS-crane-boom-guard-BG5-BG7-2\"]");

            migrationBuilder.UpdateData(
                table: "BoomGuard",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-crane-boom-guard-BG10\"]", "[\"LfALbXK_8F4\\u0026t\"]" });

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-crane-control-block-A3.1\"]");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-crane-control-block-A4-A4.2\"]");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: "[\"PALMS-crane-control-block-A4-A4.2\"]");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: "[\"PALMS-crane-control-block-A7\"]");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: "[\"PALMS-crane-control-block-A12-A14\"]");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrls",
                value: "[\"PALMS-crane-control-block-A12-A14\"]");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrls",
                value: "[\"PALMS-crane-control-block-A19\"]");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrls",
                value: "[\"PALMS-crane-control-block-A23\"]");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrls",
                value: "[\"PALMS-crane-control-block-A235\"]");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrls",
                value: "[\"PALMS-crane-control-block-A25.1\"]");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrls",
                value: "[\"PALMS-crane-control-block-A26\"]");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrls",
                value: "[\"PALMS-crane-control-block-A36\"]");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrls",
                value: "[\"PALMS-crane-control-block-A36.1\"]");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrls",
                value: "[\"PALMS-crane-control-block-A42\"]");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrls",
                value: "[\"PALMS-crane-control-block-A3.1\"]");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrls",
                value: "[\"PALMS-crane-control-block-A3.1\"]");

            migrationBuilder.UpdateData(
                table: "Cover",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-crane-cover-1\"]");

            migrationBuilder.UpdateData(
                table: "CraneLight",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-crane-light-1\",\"PALMS-crane-light-2\"]");

            migrationBuilder.UpdateData(
                table: "CraneLight",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-crane-light-1\",\"PALMS-crane-light-2\"]");

            migrationBuilder.UpdateData(
                table: "CraneOilCooler",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-crane-oil-cooler-1\"]");

            migrationBuilder.UpdateData(
                table: "Damping",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-crane-damping-1\",\"PALMS-crane-damping-2\"]");

            migrationBuilder.UpdateData(
                table: "Damping",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-crane-damping-1\",\"PALMS-crane-damping-2\"]");

            migrationBuilder.UpdateData(
                table: "Damping",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: "[\"PALMS-crane-damping-1\",\"PALMS-crane-damping-2\"]");

            migrationBuilder.UpdateData(
                table: "ElectricalFloating",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-crane-electrical-floating-1\"]");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-crane-frame-type-B2.1-1\",\"PALMS-crane-frame-type-B2.1-2\",\"PALMS-crane-frame-type-B2.1-3\"]");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: "[\"PALMS-crane-frame-type-B3-1\",\"PALMS-crane-frame-type-B3-2\",\"PALMS-crane-frame-type-B3-3\"]");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: "[\"PALMS-crane-frame-type-B4-1\",\"PALMS-crane-frame-type-B4-2\",\"PALMS-crane-frame-type-B4-3\"]");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: "[\"PALMS-crane-frame-type-B6-1\",\"PALMS-crane-frame-type-B6-2\",\"PALMS-crane-frame-type-B6-3\"]");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrls",
                value: "[\"PALMS-crane-frame-type-B9-1\",\"PALMS-crane-frame-type-B9-2\",\"PALMS-crane-frame-type-B9-3\"]");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrls",
                value: "[\"PALMS-crane-frame-type-B10-1\",\"PALMS-crane-frame-type-B10-2\",\"PALMS-crane-frame-type-B10-3\"]");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-crane-frame-type-B11-1\",\"PALMS-crane-frame-type-B11-2\",\"PALMS-crane-frame-type-B11-3\"]", "[\"ybEUttbOiMU\"]" });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrls",
                value: "[\"PALMS-crane-frame-type-B1-1\",\"PALMS-crane-frame-type-B1-2\",\"PALMS-crane-frame-type-B1-3\"]");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "A", "B", "C", "D", "E" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "A", "B", "C", "D", "E", "ImageUrls" },
                values: new object[] { "1040", "670", "410", "55", "305", "[\"PALMS-crane-grapple-C02-1\",\"PALMS-crane-grapple-C02-2\"]" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "A", "B", "C", "D", "E", "ImageUrls" },
                values: new object[] { "1230", "690", "480", "80", "315", "[\"PALMS-crane-grapple-C1-1\",\"PALMS-crane-grapple-C2-2\"]" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "A", "B", "C", "D", "E", "ImageUrls" },
                values: new object[] { "1465", "760", "500", "69", "340", "[\"PALMS-crane-grapple-C3-1\",\"PALMS-crane-grapple-C3-2\",\"PALMS-crane-grapple-C3-3\",\"PALMS-crane-grapple-C3-4\"]" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "A", "B", "C", "D", "E" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "A", "B", "C", "D", "E", "ImageUrls" },
                values: new object[] { "1530", "870", "525", "70", "430", "[\"PALMS-crane-grapple-C5.2-1\",\"PALMS-crane-grapple-C5.2-2\"]" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "A", "B", "C", "D", "E", "ImageUrls" },
                values: new object[] { "1475", "760", "500", "60", "370", "[\"PALMS-crane-grapple-C36-1\",\"PALMS-crane-grapple-C36-2\",\"PALMS-crane-grapple-C36-3\"]" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "A", "B", "C", "D", "E" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "A", "B", "C", "D", "E", "ImageUrls" },
                values: new object[] { "1550", "870", "525", "70", "455", "[\"PALMS-crane-grapple-C7.2-1\",\"PALMS-crane-grapple-C7.2-2\"]" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "A", "B", "C", "D", "E", "ImageUrls" },
                values: new object[] { "1635", "895", "570", "85", "505", "[\"PALMS-crane-grapple-C11-1\",\"PALMS-crane-grapple-C11-2\"]" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "A", "B", "C", "D", "E", "ImageUrls" },
                values: new object[] { "1615", "895", "570", "85", "475", "[\"PALMS-crane-grapple-C10-1\",\"PALMS-crane-grapple-C10-2\",\"PALMS-crane-grapple-C10-3\"]" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "A", "B", "C", "D", "E" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "A", "B", "C", "D", "E", "ImageUrls", "VideoUrls" },
                values: new object[] { null, null, null, null, null, "[\"PALMS-crane-grapple-GB16-1\",\"PALMS-crane-grapple-GB16-2\",\"PALMS-crane-grapple-GB\"]", "[\"Ff3LQ7rCo0E\"]" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "A", "B", "C", "D", "E", "ImageUrls", "VideoUrls" },
                values: new object[] { null, null, null, null, null, "[\"PALMS-crane-grapple-GB18-1\",\"PALMS-crane-grapple-GB\"]", "[\"Ff3LQ7rCo0E\"]" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "A", "B", "C", "D", "E", "ImageUrls", "VideoUrls" },
                values: new object[] { null, null, null, null, null, "[\"PALMS-crane-grapple-GB3-1\",\"PALMS-crane-grapple-GB\"]", "[\"JbYq1cykdEc\"]" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "A", "B", "C", "D", "E", "ImageUrls" },
                values: new object[] { "870", "540", "315", "40", "265", "[\"PALMS-crane-grapple-C009-1\",\"PALMS-crane-grapple-C009-2\",\"PALMS-crane-grapple-C009-3\"]" });

            migrationBuilder.UpdateData(
                table: "HighPerformanceOilFilter",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-crane-high-performance-filter-1\",\"PALMS-crane-high-performance-filter-2\"]");

            migrationBuilder.UpdateData(
                table: "HighPerformanceOilFilter",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-crane-high-performance-filter-1\",\"PALMS-crane-high-performance-filter-2\"]");

            migrationBuilder.UpdateData(
                table: "HoseGuard",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS_crane-hose-guard-1\"]");

            migrationBuilder.UpdateData(
                table: "HoseGuard",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS_crane-hose-guard-1\"]");

            migrationBuilder.UpdateData(
                table: "JoystickHolder",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-crane-joystick-holder-1\"]");

            migrationBuilder.UpdateData(
                table: "Linkage",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-crane-linkage-1\"]");

            migrationBuilder.UpdateData(
                table: "OperatorSeat",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-crane-operator-seat-1\",\"PALMS-crane-operator-seat-2\"]");

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-propulsion-RWD-RWD\\u002B-1\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-2\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-3\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-4\"]");

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-propulsion-RWD-RWD\\u002B-1\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-2\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-3\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-4\",\"PALMS-trailer-propulsion-electronic\"]");

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-propulsion-2WDF\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "[\"LKj7YS_M13E\"]" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-propulsion-2WDR\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "[\"LKj7YS_M13E\"]" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-propulsion-RWD-RWD\\u002B-1\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-2\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-3\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-4\"]");

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-propulsion-RWD-RWD\\u002B-1\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-2\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-3\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-4\",\"PALMS-trailer-propulsion-electronic\"]");

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-propulsion-2WDF\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "[\"LKj7YS_M13E\"]" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-propulsion-2WDR\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "[\"LKj7YS_M13E\"]" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-propulsion-2WDF\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "[\"LKj7YS_M13E\"]" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-propulsion-2WDR\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "[\"LKj7YS_M13E\"]" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-propulsion-4WD\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]");

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-propulsion-2WDF\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "[\"LKj7YS_M13E\"]" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-propulsion-2WDR\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "[\"LKj7YS_M13E\"]" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-propulsion-2WDF\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "[\"LKj7YS_M13E\"]" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-propulsion-2WDR\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "[\"LKj7YS_M13E\"]" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-propulsion-2WDF\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "[\"LKj7YS_M13E\"]" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-propulsion-2WDR\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "[\"LKj7YS_M13E\"]" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-propulsion-2WDF\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "[\"LKj7YS_M13E\"]" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-propulsion-2WDR\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "[\"LKj7YS_M13E\"]" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-propulsion-4WD\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]");

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-propulsion-4WD\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]");

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-propulsion-RWD-RWD\\u002B-1\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-2\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-3\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-4\"]");

            migrationBuilder.UpdateData(
                table: "ProtectionSleeves",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-crane-protection-sleeves-1\"]");

            migrationBuilder.UpdateData(
                table: "ProtectionSleeves",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-crane-protection-sleeves-1\"]");

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrls",
                value: "[\"PALMS-crane-rotator-1\",\"PALMS-crane-rotator-2\"]");

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-crane-rotator-brake-BR1-1\",\"PALMS-crane-rotator-brake-BR1-2\",\"PALMS-crane-rotator-brake-BR1-3\"]");

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: "[\"PALMS-crane-rotator-brake-BR1-1\",\"PALMS-crane-rotator-brake-BR1-2\",\"PALMS-crane-rotator-brake-BR1-3\"]");

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: "[\"PALMS-crane-rotator-brake-BR2-1\",\"PALMS-crane-rotator-brake-BR2-2\",\"PALMS-crane-rotator-brake-BR2-3\"]");

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: "[\"PALMS-crane-rotator-brake-BR2-1\",\"PALMS-crane-rotator-brake-BR2-2\",\"PALMS-crane-rotator-brake-BR2-3\"]");

            migrationBuilder.UpdateData(
                table: "SupportLeg",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-support-leg-SL\"]");

            migrationBuilder.UpdateData(
                table: "SupportLeg",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-support-leg-SL\"]");

            migrationBuilder.UpdateData(
                table: "SupportLeg",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-support-leg-SJ\"]");

            migrationBuilder.UpdateData(
                table: "SupportLegCounterPlate",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-crane-support-leg-counter-plate-1\"]");

            migrationBuilder.UpdateData(
                table: "Toolbox",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-toolbox-1\",\"PALMS-trailer-toolbox-2\",\"PALMS-trailer-toolbox-3\",\"PALMS-trailer-toolbox-4\",\"PALMS-trailer-toolbox-5\",\"PALMS-trailer-toolbox-6\",\"PALMS-trailer-toolbox-7\"]");

            migrationBuilder.UpdateData(
                table: "TurningDeviceCounterPlate",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-crane-turning-device-counter-plate-1\"]");

            migrationBuilder.UpdateData(
                table: "UnderrunProtection",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-underrun-protection-1\",\"PALMS-trailer-underrun-protection-2\"]");

            migrationBuilder.UpdateData(
                table: "UnderrunProtection",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-underrun-protection-1\",\"PALMS-trailer-underrun-protection-2\"]");

            migrationBuilder.UpdateData(
                table: "ValveBlock",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-crane-valve-block-1\",\"PALMS-crane-valve-block-2\"]");

            migrationBuilder.UpdateData(
                table: "Winch",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-crane-winch-1\",\"PALMS-crane-winch-2\",\"PALMS-crane-winch-3\"]");

            migrationBuilder.UpdateData(
                table: "Winch",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: "[\"PALMS-crane-winch-1\",\"PALMS-crane-winch-2\",\"PALMS-crane-winch-3\"]");

            migrationBuilder.UpdateData(
                table: "Winch",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: "[\"PALMS-crane-winch-1\",\"PALMS-crane-winch-2\",\"PALMS-crane-winch-3\"]");

            migrationBuilder.UpdateData(
                table: "WoodControl",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-crane-wood-control-1\",\"PALMS-crane-wood-control-2\"]");

            migrationBuilder.UpdateData(
                table: "WoodSorter",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-wood-sorter-1\",\"PALMS-trailer-wood-sorter-2\",\"PALMS-trailer-wood-sorter-3\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "A",
                table: "Grapple");

            migrationBuilder.DropColumn(
                name: "B",
                table: "Grapple");

            migrationBuilder.DropColumn(
                name: "C",
                table: "Grapple");

            migrationBuilder.DropColumn(
                name: "D",
                table: "Grapple");

            migrationBuilder.DropColumn(
                name: "E",
                table: "Grapple");

            migrationBuilder.UpdateData(
                table: "BoomGuard",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "BoomGuard",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "BoomGuard",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cover",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "CraneLight",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "CraneLight",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "CraneOilCooler",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Damping",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Damping",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Damping",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ElectricalFloating",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "HighPerformanceOilFilter",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "HighPerformanceOilFilter",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "HoseGuard",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "HoseGuard",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "JoystickHolder",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Linkage",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OperatorSeat",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProtectionSleeves",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProtectionSleeves",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "SupportLeg",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "SupportLeg",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "SupportLeg",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "SupportLegCounterPlate",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Toolbox",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "TurningDeviceCounterPlate",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "UnderrunProtection",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "UnderrunProtection",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ValveBlock",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Winch",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Winch",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Winch",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "WoodControl",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "WoodSorter",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);
        }
    }
}
