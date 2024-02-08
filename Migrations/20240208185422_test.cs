using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CraneTrailer_Crane_CraneId",
                table: "CraneTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_CraneTrailer_Trailer_TrailerId",
                table: "CraneTrailer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CraneTrailer",
                table: "CraneTrailer");

            migrationBuilder.RenameTable(
                name: "CraneTrailer",
                newName: "TrailerCrane");

            migrationBuilder.RenameIndex(
                name: "IX_CraneTrailer_TrailerId",
                table: "TrailerCrane",
                newName: "IX_TrailerCrane_TrailerId");

            migrationBuilder.AddColumn<string>(
                name: "StanchionNumber",
                table: "Trailer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BrutLiftingTorque190Bar",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BrutLiftingTorque215Bar",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BrutLiftingTorque240Bar",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CraneWeight",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LiftAtFourMeters190Bar",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LiftAtFourMeters215Bar",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LiftAtFourMeters240Bar",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LiftAtFullReach190Bar",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LiftAtFullReach215Bar",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LiftAtFullReach240Bar",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaxReach",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PillarSlewingAngle",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RecommendedOilFLow",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RotatorMaximumLoad",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Series",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SlewingCylinder",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SlewingTorque",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkingPressure",
                table: "Crane",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrailerCrane",
                table: "TrailerCrane",
                columns: new[] { "CraneId", "TrailerId" });

            migrationBuilder.InsertData(
                table: "Crane",
                columns: new[] { "Id", "BrutLiftingTorque190Bar", "BrutLiftingTorque215Bar", "BrutLiftingTorque240Bar", "CraneWeight", "Description", "LiftAtFourMeters190Bar", "LiftAtFourMeters215Bar", "LiftAtFourMeters240Bar", "LiftAtFullReach190Bar", "LiftAtFullReach215Bar", "LiftAtFullReach240Bar", "MaxReach", "Name", "PillarSlewingAngle", "Price", "RecommendedOilFLow", "RotatorMaximumLoad", "Series", "SlewingCylinder", "SlewingTorque", "WorkingPressure" },
                values: new object[] { 1, "26", "-", "-", "360", "Ideális választás azoknak a vásárlóknak, akik egyszerűséget, könnyűséget és kompakt méretet keresnek. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.", "570", "-", "-", "540", "-", "-", "4.2", "Forest crane PALMS 2.42", "370", "5165", "20-35", "45", "2", "4", "7.8", "190" });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "BeamType", "CurbWeight", "Description", "DrawbarControlCylinders", "Frame", "FrameExtensionLength", "GrossWeight", "LoadingAreaCross", "LoadingAreaLength", "MaxCraneSize", "Name", "Price", "StanchionNumber", "StandardWheelSize", "TotalLength", "WidthWithStandardWheels" },
                values: new object[] { 1, "Single", "890", "A PALMS 6S egyetlen gerendás erdészeti pótkocsi, melynek nominális teherbírása 6 tonna. Könnyű és kompakt kialakítása tökéletes választás kisebb traktorokhoz, ideális magán-erdőgazdálkodáshoz és gazdálkodóknak. A PALMS 6S hasonló technológiákat használ, mint nagyobb pótkocsijaink, beleértve a magas minőségű KTL és porfestési bevonatot, ami hosszabb élettartamot és nagyobb újraértékesítési értéket biztosít.", "1", "140x140x6", "-", "8500", "1.5", "3000", "35", "PALMS 6S", "5285", "3", "400/60-15,5", "4900", "1950" });

            migrationBuilder.InsertData(
                table: "TrailerCrane",
                columns: new[] { "CraneId", "TrailerId" },
                values: new object[] { 1, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_TrailerCrane_Crane_CraneId",
                table: "TrailerCrane",
                column: "CraneId",
                principalTable: "Crane",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrailerCrane_Trailer_TrailerId",
                table: "TrailerCrane",
                column: "TrailerId",
                principalTable: "Trailer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrailerCrane_Crane_CraneId",
                table: "TrailerCrane");

            migrationBuilder.DropForeignKey(
                name: "FK_TrailerCrane_Trailer_TrailerId",
                table: "TrailerCrane");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrailerCrane",
                table: "TrailerCrane");

            migrationBuilder.DeleteData(
                table: "TrailerCrane",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "StanchionNumber",
                table: "Trailer");

            migrationBuilder.DropColumn(
                name: "BrutLiftingTorque190Bar",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "BrutLiftingTorque215Bar",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "BrutLiftingTorque240Bar",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "CraneWeight",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "LiftAtFourMeters190Bar",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "LiftAtFourMeters215Bar",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "LiftAtFourMeters240Bar",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "LiftAtFullReach190Bar",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "LiftAtFullReach215Bar",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "LiftAtFullReach240Bar",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "MaxReach",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "PillarSlewingAngle",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "RecommendedOilFLow",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "RotatorMaximumLoad",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "Series",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "SlewingCylinder",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "SlewingTorque",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "WorkingPressure",
                table: "Crane");

            migrationBuilder.RenameTable(
                name: "TrailerCrane",
                newName: "CraneTrailer");

            migrationBuilder.RenameIndex(
                name: "IX_TrailerCrane_TrailerId",
                table: "CraneTrailer",
                newName: "IX_CraneTrailer_TrailerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CraneTrailer",
                table: "CraneTrailer",
                columns: new[] { "CraneId", "TrailerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CraneTrailer_Crane_CraneId",
                table: "CraneTrailer",
                column: "CraneId",
                principalTable: "Crane",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CraneTrailer_Trailer_TrailerId",
                table: "CraneTrailer",
                column: "TrailerId",
                principalTable: "Trailer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
