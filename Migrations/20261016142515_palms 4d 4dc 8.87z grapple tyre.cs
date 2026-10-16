using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class palms4d4dc887zgrappletyre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "WinchCrane",
                keyColumns: new[] { "CraneId", "WinchId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "WinchCrane",
                keyColumns: new[] { "CraneId", "WinchId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                column: "ValveBlockId",
                value: null);

            migrationBuilder.InsertData(
                table: "Crane",
                columns: new[] { "Id", "BoomGuardId", "BrutLiftingTorque190Bar", "BrutLiftingTorque215Bar", "BrutLiftingTorque240Bar", "CoverId", "CraneOilCoolerId", "CraneWeight", "Description", "ElectricalFloatingId", "ImageUrls", "JoystickHolderId", "LiftAtFourMeters190Bar", "LiftAtFourMeters215Bar", "LiftAtFourMeters240Bar", "LiftAtFullReach190Bar", "LiftAtFullReach215Bar", "LiftAtFullReach240Bar", "LightId", "LinkageId", "MaxReach", "Name", "OperatorSeatId", "PillarSlewingAngle", "Price", "ProtectionSleevesId", "RecommendedOilFlow", "RotatorCapacity", "RotatorConnection", "RotatorMaximumLoad", "RotatorType", "Series", "ShippingId", "SlewingCylinder", "SlewingTorque", "SupportBracketId", "SupportLegCounterPlateId", "TelescopeLength", "TurningDeviceCounterPlateId", "ValveBlockId", "VideoUrls", "WoodControlId", "WorkingPressure" },
                values: new object[] { 14, null, "78", "86", "96", 1, 1, "1430", "A PALMS 8.87Z daru nagy teherbírásával és kompakt szállítási méreteivel, valamint sokoldalúságával tűnik ki. Nemcsak erdészeti, hanem mezőgazdasági pótkocsikhoz és teherautókhoz is illeszkedik.", null, "[\"PALMS-8.87Z-1\",\"PALMS-8.87Z-2\"]", 1, "-", "-", "1690", "-", "-", "970 (8m)", 1, 1, "8.7", "PALMS 8.87Z", 1, "380", "22095", 1, "70-120", "60", "Palms", "60", "FL", "8", 2, "4", "21", null, 1, "3,0", 1, null, "[]", null, "240" });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrls", "Price" },
                values: new object[] { "[\"PALMS-crane-frame-type-B13-1\",\"PALMS-crane-frame-type-B13-2\"]", "4645" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Kanál 0,16 Palms");

            migrationBuilder.InsertData(
                table: "Grapple",
                columns: new[] { "Id", "A", "Area", "B", "C", "Code", "D", "E", "ImageUrls", "Mass", "Name", "Price", "VideoUrls" },
                values: new object[] { 17, "1040", "0.16", "670", "410", "C01", "55", "305", "[\"PALMS-crane-grapple-C02-1\",\"PALMS-crane-grapple-C02-2\"]", "66", "Kanál 0,16 Palms", "1120", null });

            migrationBuilder.UpdateData(
                table: "HayBaleFrame",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-hay-bale-frame-1\",\"PALMS-trailer-hay-bale-frame-2\",\"PALMS-trailer-hay-bale-frame-3\",\"PALMS-trailer-hay-bale-frame-4\",\"PALMS-trailer-hay-bale-frame-5\",\"PALMS-trailer-hay-bale-frame-d\"]");

            migrationBuilder.UpdateData(
                table: "HayBaleFrame",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-hay-bale-frame-1\",\"PALMS-trailer-hay-bale-frame-2\",\"PALMS-trailer-hay-bale-frame-3\",\"PALMS-trailer-hay-bale-frame-4\",\"PALMS-trailer-hay-bale-frame-5\",\"PALMS-trailer-hay-bale-frame-u\"]");

            migrationBuilder.InsertData(
                table: "RotatorBrakeCrane",
                columns: new[] { "CraneId", "RotatorBrakeId" },
                values: new object[,]
                {
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 3 },
                    { 8, 3 },
                    { 9, 3 },
                    { 10, 3 },
                    { 11, 3 },
                    { 12, 3 }
                });

            migrationBuilder.InsertData(
                table: "Stanchion",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 86, "A3", null, "Pótkocsi 3 pár rakoncával", "4150", null },
                    { 87, "A4", null, "Pótkocsi 4 pár rakoncával", "4620", null },
                    { 88, "A3", null, "Pótkocsi 3 pár rakoncával", "4880", null },
                    { 89, "A4", null, "Pótkocsi 4 pár rakoncával", "5355", null }
                });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "BBoxId", "BeamType", "BolsterLockId", "BunkAdapterId", "BunkExtensionId", "ChainsawHolderId", "CurbWeight", "DBoxId", "Description", "DrawbarControlCylinders", "Frame", "FrameExtensionId", "FrameExtensionLength", "GrossWeight", "HandBrakeId", "HayBaleFrameId", "HydropackControlId", "ImageUrls", "LoadingAreaCross", "LoadingAreaLength", "MOTId", "ManualBunkExtensionId", "MaxCraneSize", "Name", "Price", "ShippingId", "StanchionExtensionId", "StandardWheelSize", "ToolboxId", "TotalLength", "TrailerOilCoolerId", "UnderrunProtectionId", "VideoUrls", "WidthWithStandardWheels", "WoodSorterId" },
                values: new object[,]
                {
                    { 17, null, "Dupla alvázas", null, null, null, 1, "610", null, "", "1", "2x120x80x6", null, "-", "5000", null, null, null, "[\"PALMS-4DC-1\",\"PALMS-4DC-2\"]", "1,3", "3000", 1, null, "36", "PALMS 4DC", "", 1, null, "400/60-15,5", 1, "4910", 1, null, "[]", "1639", null },
                    { 18, null, "Dupla alvázas", null, null, null, 1, "625", null, "", "1", "2x120x80x6", null, "-", "5000", null, null, null, "[\"PALMS-4D-1\",\"PALMS-4D-2\"]", "1,3", "3000", 1, null, "36", "PALMS 4D", "", 1, null, "300/60-15,5", 1, "4915", 1, null, "[]", "1639", null }
                });

            migrationBuilder.InsertData(
                table: "Tyre",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 15, "WH2.6e", null, "400/60-15,5 standard felni, 6 lyukas, Starco", "610", null },
                    { 16, "WH2.6", null, "400/60-15,5 RF-felni, 6 lyukas, Starco", "745", null },
                    { 17, "WH2.5", null, "300/65-12 standard felni, 5 lyukas", "905", null },
                    { 18, "WH2.6e", null, "400/60-15,5 standard felni, 6 lyukas, Starco", "1220", null },
                    { 19, "WH2.6", null, "400/60-15,5 RF-felni, 6 lyukas, Starco", "1490", null }
                });

            migrationBuilder.InsertData(
                table: "ControlBlockCrane",
                columns: new[] { "ControlBlockId", "CraneId" },
                values: new object[,]
                {
                    { 5, 14 },
                    { 6, 14 },
                    { 7, 14 },
                    { 8, 14 },
                    { 9, 14 },
                    { 10, 14 },
                    { 11, 14 },
                    { 12, 14 },
                    { 13, 14 }
                });

            migrationBuilder.InsertData(
                table: "DampingCrane",
                columns: new[] { "CraneId", "DampingId" },
                values: new object[,]
                {
                    { 14, 1 },
                    { 14, 2 },
                    { 14, 3 }
                });

            migrationBuilder.InsertData(
                table: "DrawbarTrailer",
                columns: new[] { "DrawbarId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 17 },
                    { 1, 18 },
                    { 2, 17 },
                    { 2, 18 },
                    { 3, 17 },
                    { 3, 18 },
                    { 4, 17 },
                    { 4, 18 },
                    { 5, 17 },
                    { 5, 18 },
                    { 9, 17 },
                    { 9, 18 }
                });

            migrationBuilder.InsertData(
                table: "FrameTypeCrane",
                columns: new[] { "CraneId", "FrameTypeId" },
                values: new object[,]
                {
                    { 14, 7 },
                    { 14, 10 }
                });

            migrationBuilder.InsertData(
                table: "GrappleCrane",
                columns: new[] { "CraneId", "GrappleId" },
                values: new object[,]
                {
                    { 1, 17 },
                    { 2, 17 },
                    { 3, 17 },
                    { 4, 17 },
                    { 5, 17 },
                    { 14, 1 },
                    { 14, 4 },
                    { 14, 5 },
                    { 14, 6 },
                    { 14, 7 },
                    { 14, 8 },
                    { 14, 9 },
                    { 14, 10 },
                    { 14, 11 },
                    { 14, 14 },
                    { 14, 15 }
                });

            migrationBuilder.InsertData(
                table: "HighPerformanceOilFilterCrane",
                columns: new[] { "CraneId", "HighPerformanceOilFilterId" },
                values: new object[,]
                {
                    { 14, 1 },
                    { 14, 2 }
                });

            migrationBuilder.InsertData(
                table: "HoseGuardCrane",
                columns: new[] { "CraneId", "HoseGuardId" },
                values: new object[,]
                {
                    { 14, 1 },
                    { 14, 2 }
                });

            migrationBuilder.InsertData(
                table: "LightTrailer",
                columns: new[] { "LightId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 17 },
                    { 1, 18 }
                });

            migrationBuilder.InsertData(
                table: "PlatformTrailer",
                columns: new[] { "PlatformId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 17 },
                    { 1, 18 },
                    { 2, 17 },
                    { 2, 18 }
                });

            migrationBuilder.InsertData(
                table: "PropulsionTrailer",
                columns: new[] { "PropulsionId", "TrailerId" },
                values: new object[] { 22, 18 });

            migrationBuilder.InsertData(
                table: "RotatorBrakeCrane",
                columns: new[] { "CraneId", "RotatorBrakeId" },
                values: new object[,]
                {
                    { 14, 1 },
                    { 14, 3 },
                    { 14, 5 }
                });

            migrationBuilder.InsertData(
                table: "StanchionTrailer",
                columns: new[] { "StanchionId", "TrailerId" },
                values: new object[,]
                {
                    { 86, 17 },
                    { 87, 17 },
                    { 88, 18 },
                    { 89, 18 }
                });

            migrationBuilder.InsertData(
                table: "TyreTrailer",
                columns: new[] { "TrailerId", "TyreId" },
                values: new object[,]
                {
                    { 17, 15 },
                    { 17, 16 },
                    { 18, 17 },
                    { 18, 18 },
                    { 18, 19 }
                });

            migrationBuilder.InsertData(
                table: "WinchCrane",
                columns: new[] { "CraneId", "WinchId" },
                values: new object[] { 14, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ControlBlockCrane",
                keyColumns: new[] { "ControlBlockId", "CraneId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "ControlBlockCrane",
                keyColumns: new[] { "ControlBlockId", "CraneId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "ControlBlockCrane",
                keyColumns: new[] { "ControlBlockId", "CraneId" },
                keyValues: new object[] { 7, 14 });

            migrationBuilder.DeleteData(
                table: "ControlBlockCrane",
                keyColumns: new[] { "ControlBlockId", "CraneId" },
                keyValues: new object[] { 8, 14 });

            migrationBuilder.DeleteData(
                table: "ControlBlockCrane",
                keyColumns: new[] { "ControlBlockId", "CraneId" },
                keyValues: new object[] { 9, 14 });

            migrationBuilder.DeleteData(
                table: "ControlBlockCrane",
                keyColumns: new[] { "ControlBlockId", "CraneId" },
                keyValues: new object[] { 10, 14 });

            migrationBuilder.DeleteData(
                table: "ControlBlockCrane",
                keyColumns: new[] { "ControlBlockId", "CraneId" },
                keyValues: new object[] { 11, 14 });

            migrationBuilder.DeleteData(
                table: "ControlBlockCrane",
                keyColumns: new[] { "ControlBlockId", "CraneId" },
                keyValues: new object[] { 12, 14 });

            migrationBuilder.DeleteData(
                table: "ControlBlockCrane",
                keyColumns: new[] { "ControlBlockId", "CraneId" },
                keyValues: new object[] { 13, 14 });

            migrationBuilder.DeleteData(
                table: "DampingCrane",
                keyColumns: new[] { "CraneId", "DampingId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "DampingCrane",
                keyColumns: new[] { "CraneId", "DampingId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "DampingCrane",
                keyColumns: new[] { "CraneId", "DampingId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 17 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 18 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 18 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 14, 10 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 5, 17 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 14, 10 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 14, 11 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 14, 14 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 14, 15 });

            migrationBuilder.DeleteData(
                table: "HighPerformanceOilFilterCrane",
                keyColumns: new[] { "CraneId", "HighPerformanceOilFilterId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "HighPerformanceOilFilterCrane",
                keyColumns: new[] { "CraneId", "HighPerformanceOilFilterId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "HoseGuardCrane",
                keyColumns: new[] { "CraneId", "HoseGuardId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "HoseGuardCrane",
                keyColumns: new[] { "CraneId", "HoseGuardId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 22, 18 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "RotatorBrakeCrane",
                keyColumns: new[] { "CraneId", "RotatorBrakeId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 86, 17 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 87, 17 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 88, 18 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 89, 18 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 17, 15 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 17, 16 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 18, 17 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 18, 18 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 18, 19 });

            migrationBuilder.DeleteData(
                table: "WinchCrane",
                keyColumns: new[] { "CraneId", "WinchId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                column: "ValveBlockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrls", "Price" },
                values: new object[] { "[\"PALMS-crane-frame-type-B13-1\",\"PALMS-crane-frame-type-B13-2\",\"PALMS-crane-frame-type-B13-3\"]", "3645" });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Kanál 0,16 Palms (FL)");

            migrationBuilder.UpdateData(
                table: "HayBaleFrame",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-hay-bale-frame-1\",\"PALMS-trailer-hay-bale-frame-2\",\"PALMS-trailer-hay-bale-frame-3\",\"PALMS-trailer-hay-bale-frame-d\"]");

            migrationBuilder.UpdateData(
                table: "HayBaleFrame",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"PALMS-trailer-hay-bale-frame-1\",\"PALMS-trailer-hay-bale-frame-2\",\"PALMS-trailer-hay-bale-frame-3\",\"PALMS-trailer-hay-bale-frame-u\"]");

            migrationBuilder.InsertData(
                table: "RotatorBrakeCrane",
                columns: new[] { "CraneId", "RotatorBrakeId" },
                values: new object[,]
                {
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 2 },
                    { 9, 2 },
                    { 10, 2 },
                    { 11, 2 },
                    { 12, 2 }
                });

            migrationBuilder.InsertData(
                table: "WinchCrane",
                columns: new[] { "CraneId", "WinchId" },
                values: new object[,]
                {
                    { 8, 2 },
                    { 8, 3 }
                });
        }
    }
}
