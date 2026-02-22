using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class changetrailerconfigimagesandvideos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "WoodSorter",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "WoodControl",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "Winch",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "ValveBlock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "UnderrunProtection",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "Tyre",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "TurningDeviceCounterPlate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "TrailerOilCooler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "TrailerLight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "Toolbox",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "SupportLegCounterPlate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "SupportLeg",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "SupportBracket",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "SupplyFormat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "StanchionExtension",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "Stanchion",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "Shipping",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "RotatorBrake",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "Rotator",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "ProtectionSleeves",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "Propulsion",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "Platform",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "OperatorSeat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "OilTank",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "OilPump",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "MOT",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "ManualBunkExtension",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "Linkage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "JoystickHolder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "HydroPackControl",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "HydroPack",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "HoseGuard",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "HighPerformanceOilFilter",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "HayBaleFrame",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "HandBrake",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "Grapple",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "FrameType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "FrameExtension",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "ElectricalFloating",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "Drawbar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "DBox",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "Damping",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "CraneOilCooler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "CraneLight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "Cover",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "ControlBlocks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "ChainsawHolder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "BunkExtension",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "BunkAdapter",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "Brake",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "BoomGuard",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "BolsterLock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrls",
                table: "BBox",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BBox",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-bbox-1\",\"PALMS-trailer-bbox-2\",\"PALMS-trailer-bbox-3\",\"PALMS-trailer-bbox-4\",\"PALMS-trailer-bbox-5\",\"PALMS-trailer-bbox-6\"]", "[\"4irHQzQZYHM\"]" });

            migrationBuilder.UpdateData(
                table: "BBox",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-bbox-1\",\"PALMS-trailer-bbox-2\",\"PALMS-trailer-bbox-3\",\"PALMS-trailer-bbox-4\",\"PALMS-trailer-bbox-5\",\"PALMS-trailer-bbox-6\"]", "[\"4irHQzQZYHM\"]" });

            migrationBuilder.UpdateData(
                table: "BBox",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-bbox-1\",\"PALMS-trailer-bbox-2\",\"PALMS-trailer-bbox-3\",\"PALMS-trailer-bbox-4\",\"PALMS-trailer-bbox-5\",\"PALMS-trailer-bbox-6\"]", "[\"4irHQzQZYHM\"]" });

            migrationBuilder.UpdateData(
                table: "BBox",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-bbox-1\",\"PALMS-trailer-bbox-2\",\"PALMS-trailer-bbox-3\",\"PALMS-trailer-bbox-4\",\"PALMS-trailer-bbox-5\",\"PALMS-trailer-bbox-6\"]", "[\"4irHQzQZYHM\"]" });

            migrationBuilder.UpdateData(
                table: "BBox",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-bbox-1\",\"PALMS-trailer-bbox-2\",\"PALMS-trailer-bbox-3\",\"PALMS-trailer-bbox-4\",\"PALMS-trailer-bbox-5\",\"PALMS-trailer-bbox-6\"]", "[\"4irHQzQZYHM\"]" });

            migrationBuilder.UpdateData(
                table: "BolsterLock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-bolster-lock-1\",\"PALMS-trailer-bolster-lock-2\",\"PALMS-trailer-bolster-lock-3\"]", null });

            migrationBuilder.UpdateData(
                table: "BoomGuard",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "BoomGuard",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "BoomGuard",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-brake-1\"]", null });

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-brake-2\"]", null });

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-brake-3\"]", null });

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-brake-4\"]", null });

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 6,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 7,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 8,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 9,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-brake-1\"]", null });

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-brake-2\"]", null });

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-brake-3\"]", null });

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-brake-4\"]", null });

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 14,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 15,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-brake-1\"]", null });

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-brake-2\"]", null });

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-brake-3\"]", null });

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-brake-4\"]", null });

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 20,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 21,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-brake-3\"]", null });

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-brake-2\"]", null });

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-brake-4\"]", null });

            migrationBuilder.UpdateData(
                table: "BunkAdapter",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-bunk-adapter-1\",\"PALMS-trailer-bunk-adapter-2\",\"PALMS-trailer-bunk-adapter-3\"]", null });

            migrationBuilder.UpdateData(
                table: "BunkAdapter",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-bunk-adapter-1\",\"PALMS-trailer-bunk-adapter-2\",\"PALMS-trailer-bunk-adapter-3\"]", null });

            migrationBuilder.UpdateData(
                table: "BunkExtension",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-bunk-extension-1\",\"PALMS-trailer-bunk-extension-2\"]", "[\"d8Ivy0QkSVU\"]" });

            migrationBuilder.UpdateData(
                table: "BunkExtension",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-bunk-extension-1\",\"PALMS-trailer-bunk-extension-2\"]", "[\"d8Ivy0QkSVU\"]" });

            migrationBuilder.UpdateData(
                table: "ChainsawHolder",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-chainsawholder-1\",\"PALMS-trailer-chainsawholder-2\"]", null });

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 15,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 16,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cover",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "CraneLight",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "CraneLight",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "CraneOilCooler",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "DBox",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-dbox-1\"]", null });

            migrationBuilder.UpdateData(
                table: "Damping",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Damping",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Damping",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-drawbar-C1\"]", null });

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-drawbar-C2\"]", null });

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-drawbar-C3\"]", null });

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-drawbar-C4\"]", null });

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-drawbar-C5\"]", null });

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-drawbar-C6\"]", null });

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-drawbar-C7\"]", null });

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-drawbar-C8\"]", null });

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-drawbar-C9\"]", null });

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-drawbar-C5\"]", null });

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-drawbar-C8\"]", null });

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-drawbar-C9\"]", null });

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-drawbar-CY\"]", null });

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-drawbar-C1\"]", null });

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 15,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ElectricalFloating",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameExtension",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-frame-extension-1\"]", null });

            migrationBuilder.UpdateData(
                table: "FrameExtension",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 4,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 5,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 6,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 7,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 8,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 9,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 4,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 5,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 6,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 7,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 8,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 9,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 10,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 11,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 12,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 13,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 14,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 15,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 16,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "HandBrake",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "HayBaleFrame",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-hay-bale-frame-1\",\"PALMS-trailer-hay-bale-frame-2\",\"PALMS-trailer-hay-bale-frame-3\",\"PALMS-trailer-hay-bale-frame-d\"]", null });

            migrationBuilder.UpdateData(
                table: "HayBaleFrame",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-hay-bale-frame-1\",\"PALMS-trailer-hay-bale-frame-2\",\"PALMS-trailer-hay-bale-frame-3\",\"PALMS-trailer-hay-bale-frame-u\"]", null });

            migrationBuilder.UpdateData(
                table: "HighPerformanceOilFilter",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "HighPerformanceOilFilter",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "HoseGuard",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "HoseGuard",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "HydroPack",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-hydropack-HyP1-1\",\"PALMS-trailer-hydropack-HyP1-1\"]", null });

            migrationBuilder.UpdateData(
                table: "HydroPack",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-hydropack-HyP4-1\"]", null });

            migrationBuilder.UpdateData(
                table: "HydroPack",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-hydropack-HyP4\\u002B-1\"]", null });

            migrationBuilder.UpdateData(
                table: "HydroPackControl",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "JoystickHolder",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Linkage",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "MOT",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ManualBunkExtension",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-oil-pump-1\",\"PALMS-trailer-oil-pump-2\"]", null });

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 4,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 5,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 6,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 7,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 8,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-oiltank-T2-T2\\u002B-T4\\u002B\"]", null });

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-oiltank-T2-T2\\u002B-T4\\u002B\"]", null });

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-oiltank-T2SOV-T2SOV\\u002B\"]", null });

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-oiltank-T2SOV-T2SOV\\u002B\"]", null });

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-oiltank-T2-T2\\u002B-T4\\u002B\"]", null });

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-oiltank-T2SOV-T2SOV\\u002B\"]", null });

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-oiltank-T2-T2\\u002B-T4\\u002B\"]", null });

            migrationBuilder.UpdateData(
                table: "OperatorSeat",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-platform-1\",\"PALMS-trailer-platform-2\",\"PALMS-trailer-platform-3\",\"PALMS-trailer-platform-4\"]", null });

            migrationBuilder.UpdateData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-platform-1\",\"PALMS-trailer-platform-2\",\"PALMS-trailer-platform-3\",\"PALMS-trailer-platform-4\"]", null });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 4,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 5,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 6,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 7,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 8,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 9,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 10,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 11,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 12,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 13,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 14,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 15,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 16,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 17,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 18,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 19,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 20,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 21,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 22,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProtectionSleeves",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProtectionSleeves",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 4,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 5,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 6,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 7,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 8,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 4,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "RotatorBrake",
                keyColumn: "Id",
                keyValue: 5,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Shipping",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Shipping",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 4,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 5,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 6,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 7,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 8,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 9,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 10,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 11,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 12,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 13,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 14,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 15,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 16,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 17,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 18,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 19,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 20,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 21,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 22,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 23,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 24,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 25,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 26,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 27,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 28,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 29,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 30,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 31,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 32,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 33,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 34,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 35,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 36,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 37,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 38,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 39,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 40,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 41,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 42,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 43,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 44,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 45,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 46,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 47,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 48,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 49,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 50,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 51,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 52,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 53,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 54,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 55,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 56,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 57,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 58,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 59,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 60,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 61,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 62,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 63,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 64,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 65,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 66,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 67,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 68,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 69,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 70,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 71,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 72,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 73,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 74,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 75,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 76,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 77,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 78,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 79,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 80,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 81,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 82,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 83,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 84,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 85,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "StanchionExtension",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "SupplyFormat",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "SupplyFormat",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "SupportBracket",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "SupportLeg",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "SupportLeg",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "SupportLeg",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "SupportLegCounterPlate",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Toolbox",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrailerLight",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-light-L1-1\",\"PALMS-trailer-light-L1-2\"]", null });

            migrationBuilder.UpdateData(
                table: "TrailerLight",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-light-L2-1\",\"PALMS-trailer-light-L2-2\"]", null });

            migrationBuilder.UpdateData(
                table: "TrailerLight",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-light-L4-1\",\"PALMS-trailer-light-L4-2\"]", null });

            migrationBuilder.UpdateData(
                table: "TrailerLight",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-light-L1-1\",\"PALMS-trailer-light-L1-2\"]", null });

            migrationBuilder.UpdateData(
                table: "TrailerLight",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-light-L2-1\",\"PALMS-trailer-light-L2-2\"]", null });

            migrationBuilder.UpdateData(
                table: "TrailerOilCooler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-oil-cooler-1\"]", "[\"5u9NDzvA0gk\"]" });

            migrationBuilder.UpdateData(
                table: "TrailerOilCooler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrls", "VideoUrls" },
                values: new object[] { "[\"PALMS-trailer-oil-cooler-1\"]", "[\"5u9NDzvA0gk\"]" });

            migrationBuilder.UpdateData(
                table: "TurningDeviceCounterPlate",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 4,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 5,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 6,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 7,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 8,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 9,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 10,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 11,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 12,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 13,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 14,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "UnderrunProtection",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "UnderrunProtection",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ValveBlock",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Winch",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Winch",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Winch",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Winch",
                keyColumn: "Id",
                keyValue: 4,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "WoodControl",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "WoodSorter",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrls",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "WoodSorter");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "WoodControl");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "Winch");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "ValveBlock");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "UnderrunProtection");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "Tyre");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "TurningDeviceCounterPlate");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "TrailerOilCooler");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "TrailerLight");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "Toolbox");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "SupportLegCounterPlate");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "SupportLeg");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "SupportBracket");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "SupplyFormat");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "StanchionExtension");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "Stanchion");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "Shipping");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "RotatorBrake");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "Rotator");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "ProtectionSleeves");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "Propulsion");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "Platform");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "OperatorSeat");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "OilTank");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "OilPump");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "MOT");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "ManualBunkExtension");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "Linkage");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "JoystickHolder");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "HydroPackControl");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "HydroPack");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "HoseGuard");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "HighPerformanceOilFilter");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "HayBaleFrame");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "HandBrake");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "Grapple");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "FrameType");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "FrameExtension");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "ElectricalFloating");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "Drawbar");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "DBox");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "Damping");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "CraneOilCooler");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "CraneLight");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "Cover");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "ControlBlocks");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "ChainsawHolder");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "BunkExtension");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "BunkAdapter");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "Brake");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "BoomGuard");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "BolsterLock");

            migrationBuilder.DropColumn(
                name: "VideoUrls",
                table: "BBox");

            migrationBuilder.UpdateData(
                table: "BBox",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "BBox",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "BBox",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "BBox",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "BBox",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "BolsterLock",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "BunkAdapter",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "BunkAdapter",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "BunkExtension",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "BunkExtension",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ChainsawHolder",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "DBox",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameExtension",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "HayBaleFrame",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "HayBaleFrame",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "HydroPack",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "HydroPack",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "HydroPack",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrailerLight",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrailerLight",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrailerLight",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrailerLight",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrailerLight",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrailerOilCooler",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "TrailerOilCooler",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);
        }
    }
}
