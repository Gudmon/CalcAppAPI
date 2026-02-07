using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class changedtos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "WoodSorter",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "WoodControl",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "Winch",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "ValveBlock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "UnderrunProtection",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "Tyre",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "TurningDeviceCounterPlate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "TrailerOilCooler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "TrailerLight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "Trailer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "Toolbox",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "SupportLegCounterPlate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "SupportLeg",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "SupplyFormat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "StanchionExtension",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "Stanchion",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "Shipping",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "RotatorBrake",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "Rotator",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "ProtectionSleeves",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "Propulsion",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "Platform",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "OperatorSeat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "OilTank",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "OilPump",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "MOT",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "Linkage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "JoystickHolder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "HydroPackControl",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "HydroPack",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "HoseGuard",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "HighPerformanceOilFilter",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "HayBaleFrame",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "HandBrake",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "Grapple",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "FrameType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "FrameExtension",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "ElectricalFloating",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "Drawbar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "DBox",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "Damping",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "CraneOilCooler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "CraneLight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "Cover",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "ControlBlocks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "ChainsawHolder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "BunkExtension",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "BunkAdapter",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "Brake",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "BoomGuard",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "BolsterLock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrls",
                table: "BBox",
                type: "nvarchar(max)",
                nullable: true);

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
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
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
                keyValue: 6,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 9,
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
                keyValue: 14,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 15,
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
                keyValue: 20,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 21,
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
                table: "Cover",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

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
                table: "CraneLight",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "CraneOilCooler",
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
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "ElectricalFloating",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameExtension",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameExtension",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
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
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 1,
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
                keyValue: 5,
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
                keyValue: 8,
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
                keyValue: 12,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "HandBrake",
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
                table: "HydroPackControl",
                keyColumn: "Id",
                keyValue: 1,
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
                table: "MOT",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 8,
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
                table: "OperatorSeat",
                keyColumn: "Id",
                keyValue: 1,
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
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: null);

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
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrls",
                value: null);

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
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrls",
                value: null);

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
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 7,
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
                keyValue: 1,
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
                table: "Shipping",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Shipping",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 42,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 43,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 44,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 45,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 46,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 47,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 48,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 49,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 50,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 51,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 52,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 53,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 54,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 55,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 56,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 57,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 58,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 59,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 60,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 61,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 62,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 63,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 64,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 65,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 66,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 67,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 68,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 69,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 70,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 71,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 72,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 73,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 74,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 75,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 76,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 77,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 78,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 79,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 80,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 81,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 82,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 83,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 84,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 85,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "StanchionExtension",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "SupplyFormat",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "SupplyFormat",
                keyColumn: "Id",
                keyValue: 2,
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

            migrationBuilder.UpdateData(
                table: "TurningDeviceCounterPlate",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrls",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 14,
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "WoodSorter");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "WoodControl");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "Winch");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "ValveBlock");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "UnderrunProtection");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "Tyre");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "TurningDeviceCounterPlate");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "TrailerOilCooler");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "TrailerLight");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "Trailer");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "Toolbox");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "SupportLegCounterPlate");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "SupportLeg");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "SupplyFormat");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "StanchionExtension");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "Stanchion");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "Shipping");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "RotatorBrake");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "Rotator");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "ProtectionSleeves");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "Propulsion");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "Platform");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "OperatorSeat");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "OilTank");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "OilPump");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "MOT");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "Linkage");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "JoystickHolder");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "HydroPackControl");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "HydroPack");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "HoseGuard");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "HighPerformanceOilFilter");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "HayBaleFrame");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "HandBrake");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "Grapple");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "FrameType");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "FrameExtension");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "ElectricalFloating");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "Drawbar");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "DBox");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "Damping");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "CraneOilCooler");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "CraneLight");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "Cover");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "ControlBlocks");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "ChainsawHolder");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "BunkExtension");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "BunkAdapter");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "Brake");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "BoomGuard");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "BolsterLock");

            migrationBuilder.DropColumn(
                name: "ImageUrls",
                table: "BBox");
        }
    }
}
