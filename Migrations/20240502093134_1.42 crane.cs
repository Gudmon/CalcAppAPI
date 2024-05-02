using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class _142crane : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Crane",
                columns: new[] { "Id", "BoomGuardId", "BrutLiftingTorque190Bar", "BrutLiftingTorque215Bar", "BrutLiftingTorque240Bar", "CoverId", "CraneOilCoolerId", "CraneWeight", "Description", "ElectricalFloatingId", "JoystickHolderId", "LiftAtFourMeters190Bar", "LiftAtFourMeters215Bar", "LiftAtFourMeters240Bar", "LiftAtFullReach190Bar", "LiftAtFullReach215Bar", "LiftAtFullReach240Bar", "LightId", "LinkageId", "MaxReach", "Name", "OperatorSeatId", "PillarSlewingAngle", "Price", "ProtectionSleevesId", "RecommendedOilFlow", "RotatorMaximumLoad", "Series", "ShippingId", "SlewingCylinder", "SlewingTorque", "SupportLegCounterPlateId", "TelescopeLength", "TurningDeviceCounterPlateId", "ValveBlockId", "WoodControlId", "WorkingPressure" },
                values: new object[] { 13, null, "-", "-", "-", null, null, "185", "", null, null, "-", "-", "-", "-", "-", "-", null, null, "4.2", "PALMS 1.42", null, "330", "3025", null, "-", "10", "1", 2, "2", "2.1", null, "1,2", null, null, null, "180" });

            migrationBuilder.InsertData(
                table: "FrameType",
                columns: new[] { "Id", "Code", "Mass", "Name", "Price" },
                values: new object[] { 11, "B1", "50", "FD talpaló", "695" });

            migrationBuilder.InsertData(
                table: "Grapple",
                columns: new[] { "Id", "Area", "Code", "Mass", "Name", "Price" },
                values: new object[] { 15, null, "C009", null, "Palms 0,09 kanál", "620" });

            migrationBuilder.InsertData(
                table: "Rotator",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 8, "R10", "Rotátor 1000 kN (csapos - Finrotor)", "245" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Frame", "TrailerOilCoolerId" },
                values: new object[] { "2x4 mm C-alváz", null });

            migrationBuilder.InsertData(
                table: "ControlBlockCrane",
                columns: new[] { "ControlBlockId", "CraneId" },
                values: new object[] { 2, 13 });

            migrationBuilder.InsertData(
                table: "CraneTrailer",
                columns: new[] { "CraneId", "TrailerId" },
                values: new object[] { 13, 22 });

            migrationBuilder.InsertData(
                table: "FrameTypeCrane",
                columns: new[] { "CraneId", "FrameTypeId" },
                values: new object[] { 13, 11 });

            migrationBuilder.InsertData(
                table: "GrappleCrane",
                columns: new[] { "CraneId", "GrappleId" },
                values: new object[] { 13, 15 });

            migrationBuilder.InsertData(
                table: "RotatorCrane",
                columns: new[] { "CraneId", "RotatorId" },
                values: new object[] { 13, 8 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ControlBlockCrane",
                keyColumns: new[] { "ControlBlockId", "CraneId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 13, 22 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 13, 11 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 13, 15 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rotator",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Frame", "TrailerOilCoolerId" },
                values: new object[] { "2x4 mm C-beam", 1 });
        }
    }
}
