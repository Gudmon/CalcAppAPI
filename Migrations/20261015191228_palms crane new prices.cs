using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class palmscranenewprices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BBox",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: "1040");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: "890");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: "1535");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: "1535");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: "1515");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: "4430");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: "6050");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: "5900");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: "8275");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: "8275");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: "9240");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: "8935");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: "11735");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: "12695");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: "14550");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LiftAtFourMeters190Bar", "Price", "WorkingPressure" },
                values: new object[] { "-", "6125", "195" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "SlewingTorque" },
                values: new object[] { "7415", "9" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "WorkingPressure" },
                values: new object[] { "7765", "195" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BrutLiftingTorque215Bar", "LiftAtFourMeters215Bar", "LiftAtFullReach215Bar", "Price" },
                values: new object[] { "51", "1040", "520", "8620" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BrutLiftingTorque215Bar", "LiftAtFourMeters215Bar", "LiftAtFullReach215Bar", "Price" },
                values: new object[] { "57", "1115", "580", "10070" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LiftAtFourMeters215Bar", "LiftAtFullReach215Bar", "Price" },
                values: new object[] { "1440", "660", "12760" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BrutLiftingTorque190Bar", "BrutLiftingTorque215Bar", "CraneWeight", "LiftAtFourMeters215Bar", "LiftAtFullReach215Bar", "Price" },
                values: new object[] { "63", "69", "950", "1270", "560", "15005" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BrutLiftingTorque215Bar", "CraneWeight", "Description", "ImageUrls", "LiftAtFourMeters215Bar", "LiftAtFullReach215Bar", "MaxReach", "Name", "PillarSlewingAngle", "Price", "RecommendedOilFlow", "RotatorMaximumLoad", "Series", "VideoUrls" },
                values: new object[] { "71", "1090", "A PALMS 6.83Z daru kompakt szállítási méreteivel és sokoldalúságával tűnik ki, amely nemcsak erdészeti, hanem mezőgazdasági pótkocsikhoz és teherautókhoz is illeszkedik.", "[\"PALMS-6.83Z-1\",\"PALMS-6.83Z-2\",\"PALMS-6.83Z-3\",\"PALMS-6.83Z-4\",\"PALMS-6.83Z-5\",\"PALMS-6.83Z-6\"]", "1190", "560 (8m)", "8.3", "PALMS 6.83Z", "380", "16735", "60-100", "55", "6", "[]" });

            migrationBuilder.InsertData(
                table: "CraneLight",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 3, "L1", "[\"PALMS-crane-light-1\",\"PALMS-crane-light-2\"]", "LED munkalámpák a darugémre, 1 db", "335", null });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "LightId", "Price", "RecommendedOilFlow", "WorkingPressure" },
                values: new object[] { 3, "3465", "10-20", "190" });

            migrationBuilder.UpdateData(
                table: "CraneLight",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: "340");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: "1615");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: "2150");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: "2320");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: "3075");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: "3665");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: "3820");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: "7475");

            migrationBuilder.InsertData(
                table: "FrameType",
                columns: new[] { "Id", "Code", "ImageUrls", "Mass", "Name", "Price", "VideoUrls" },
                values: new object[] { 10, "B13", "[\"PALMS-crane-frame-type-B13-1\",\"PALMS-crane-frame-type-B13-2\",\"PALMS-crane-frame-type-B13-3\"]", "520", "Teleszkópos talpaló Z daruhoz, vezérléssel (csak A14-A36 esetén)", "3645", null });

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: "1120");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: "1430");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: "1785");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: "3465");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: "2675");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: "2285");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: "3805");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: "3090");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: "3540");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: "3200");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: "485");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: "625");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: "955");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: "685");

            migrationBuilder.UpdateData(
                table: "Linkage",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: "980");

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 22,
                column: "Price",
                value: "2250");

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 79,
                column: "Price",
                value: "2785");

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 80,
                column: "Price",
                value: "2910");

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 81,
                column: "Price",
                value: "3035");

            migrationBuilder.UpdateData(
                table: "Winch",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: "0");

            migrationBuilder.UpdateData(
                table: "WoodControl",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: "160");

            migrationBuilder.InsertData(
                table: "FrameTypeCrane",
                columns: new[] { "CraneId", "FrameTypeId" },
                values: new object[] { 8, 10 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "BBox",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: "1000");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: "870");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: "1500");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: "1500");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: "1480");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: "4720");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: "6295");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: "6295");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: "8470");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: "8470");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: "9415");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: "9110");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: "11840");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: "12785");

            migrationBuilder.UpdateData(
                table: "ControlBlocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: "14660");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LiftAtFourMeters190Bar", "Price", "WorkingPressure" },
                values: new object[] { "570", "5870", "190" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "SlewingTorque" },
                values: new object[] { "7215", "7.8" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "WorkingPressure" },
                values: new object[] { "7480", "190" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BrutLiftingTorque215Bar", "LiftAtFourMeters215Bar", "LiftAtFullReach215Bar", "Price" },
                values: new object[] { "46", "910", "480", "8400" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BrutLiftingTorque215Bar", "LiftAtFourMeters215Bar", "LiftAtFullReach215Bar", "Price" },
                values: new object[] { "54", "1040", "535", "9800" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LiftAtFourMeters215Bar", "LiftAtFullReach215Bar", "Price" },
                values: new object[] { "1350", "620", "12445" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BrutLiftingTorque190Bar", "BrutLiftingTorque215Bar", "CraneWeight", "LiftAtFourMeters215Bar", "LiftAtFullReach215Bar", "Price" },
                values: new object[] { "56", "63", "900", "1220", "520", "14595" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BrutLiftingTorque215Bar", "CraneWeight", "Description", "ImageUrls", "LiftAtFourMeters215Bar", "LiftAtFullReach215Bar", "MaxReach", "Name", "PillarSlewingAngle", "Price", "RecommendedOilFlow", "RotatorMaximumLoad", "Series", "VideoUrls" },
                values: new object[] { "63", "995", "A PALMS 5.87Z daru kompakt szállítási méreteivel és sokoldalúságával tűnik ki, amely nemcsak erdészeti, hanem mezőgazdasági pótkocsikhoz és teherautókhoz is illeszkedik.", "[\"PALMS-5.87Z-1\",\"PALMS-5.87Z-2\",\"PALMS-5.87Z-3\",\"PALMS-5.87Z-4\",\"PALMS-5.87Z-5\",\"PALMS-5.87Z-6\"]", "1235", "490 (8,4 m)", "8.7", "PALMS 5.87Z", "340", "16060", "50-90", "60", "5", "[\"pLvH1NAPEzI\"]" });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "LightId", "Price", "RecommendedOilFlow", "WorkingPressure" },
                values: new object[] { 2, "3300", "-", "180" });

            migrationBuilder.DeleteData(
                table: "CraneLight",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "CraneLight",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: "335");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: "1575");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: "2100");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: "2100");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: "3005");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: "3520");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: "3730");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: "7300");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: "1085");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: "1395");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: "1745");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: "3380");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: "2615");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: "2230");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: "3715");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: "3020");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: "3450");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: "3125");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: "475");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: "610");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: "935");

            migrationBuilder.UpdateData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: "660");

            migrationBuilder.UpdateData(
                table: "Linkage",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: "960");

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 22,
                column: "Price",
                value: "2185");

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 79,
                column: "Price",
                value: "2730");

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 80,
                column: "Price",
                value: "2855");

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 81,
                column: "Price",
                value: "2985");

            migrationBuilder.UpdateData(
                table: "Winch",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: "70");

            migrationBuilder.UpdateData(
                table: "WoodControl",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: "150");
        }
    }
}
