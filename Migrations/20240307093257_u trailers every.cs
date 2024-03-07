using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class utrailersevery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BBox",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 2, "Bbox", "Biomasszás boksz 4 mm-es Strenx acélból", "3150" },
                    { 3, "Bbox", "Biomasszás boksz 4 mm-es Strenx acélból", "3360" }
                });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "BBoxId", "BeamType", "BolsterLockId", "ChainsawHolderId", "CurbWeight", "Description", "DrawbarControlCylinders", "Frame", "FrameExtensionLength", "GrossWeight", "HandBrakeId", "LoadingAreaCross", "LoadingAreaLength", "MaxCraneSize", "Name", "Price", "StandardWheelSize", "TotalLength", "TrailerOilCoolerId", "UnderrunProtectionId", "WidthWithStandardWheels", "WoodSorterId" },
                values: new object[,]
                {
                    { 12, 2, "Unibody (Forwarder)", 1, 1, "2170", "A PALMS 10U egy 10 tonnás névleges teherbírású erdészeti pótkocsi, amely a kihordó típusú unibody sorozatunk bemutatását jelzi. Nagy hasmagassága és ovális kerete csökkenti a csonkokon való elakadás kockázatát. Ezenkívül az összes hidraulikus alkatrész a keret belsejében van elrejtve, miközben könnyű hozzáférést biztosít a karbantartáshoz.", "2", "unibody", "1,085", "15000", 1, "2.4", "3990", "120", "PALMS 10U", "", "500/50-17", "6215", 1, 2, "2245", null },
                    { 13, 2, "Unibody (Forwarder)", 1, 1, "2170", "A PALMS 10UWD egy 10 tonnás névleges teherbírású erdészeti pótkocsi, amely a kihordó típusú unibody sorozatunk bemutatását jelzi. Nagy hasmagassága és ovális kerete csökkenti a csonkokon való elakadás kockázatát. Ezenkívül az összes hidraulikus alkatrész a keret belsejében van elrejtve, miközben könnyű hozzáférést biztosít a karbantartáshoz.", "2", "unibody", "1,085", "15000", 1, "2.4", "3990", "120", "PALMS 10UWD", "", "500/50-17", "6215", 1, 2, "2245", null },
                    { 14, 2, "Unibody (Forwarder)", 1, 1, "2270", "A PALMS 12U egy erdészeti pótkocsi, 12 tonnás névleges teherbírással, melyet kifejezetten mindennapi, szakmai erdészmunkákhoz terveztek. Magas hasmagassága és ovális kerete minimalizálja a csonkokon való elakadás kockázatát. Ráadásul az összes hidraulikus alkatrész a keretben található, biztosítva ezzel mind a rejtettséget, mind az egyszerű hozzáférést a karbantartáshoz.", "2", "unibody", "1,085", "17000", 1, "2.75", "3990", "120", "PALMS 12U", "", "500/50-22,5", "6215", 1, 2, "2245", null },
                    { 15, 2, "Unibody (Forwarder)", 1, 1, "2270", "A PALMS 12UWD egy erdészeti pótkocsi, 12 tonnás névleges teherbírással, melyet kifejezetten mindennapi, szakmai erdészmunkákhoz terveztek. Magas hasmagassága és ovális kerete minimalizálja a csonkokon való elakadás kockázatát. Ráadásul az összes hidraulikus alkatrész a keretben található, biztosítva ezzel mind a rejtettséget, mind az egyszerű hozzáférést a karbantartáshoz.", "2", "unibody", "1,085", "17000", 1, "2.75", "3990", "120", "PALMS 12UWD", "", "500/50-22,5", "6215", 1, 2, "2245", null },
                    { 16, 2, "Unibody (Forwarder)", 1, 1, "2270", "A PALMS 12UAWD egy erdészeti pótkocsi, 12 tonnás névleges teherbírással, melyet kifejezetten mindennapi, szakmai erdészmunkákhoz terveztek. Magas hasmagassága és ovális kerete minimalizálja a csonkokon való elakadás kockázatát. Ráadásul az összes hidraulikus alkatrész a keretben található, biztosítva ezzel mind a rejtettséget, mind az egyszerű hozzáférést a karbantartáshoz.", "2", "unibody", "1,085", "17000", 1, "2.75", "3990", "120", "PALMS 12UAWD", "", "500/50-22,5", "6215", 1, 2, "2245", null },
                    { 17, 3, "Unibody (Forwarder)", 1, 1, "2545", "A PALMS 15U egy erdészeti pótkocsi 15 tonnás névleges teherbírással, és a termékskálánkban engedélyezett legnagyobb össztömegű erdészeti pótkocsit képviseli. Mindennapi szakmai erdészmunkákhoz tervezték, igényes körülmények között. Magas hasmagassága és ovális kerete csökkenti a csonkokon való elakadás kockázatát. Ráadásul az összes hidraulikus és elektronikus alkatrész biztonságosan el van helyezve a keretben.", "2", "unibody", "1,085", "19000", 1, "3.2", "4175", "120", "PALMS 15U", "", "500/50-22,5", "6415", 1, 2, "2450", null },
                    { 18, 3, "Unibody (Forwarder)", 1, 1, "2545", "A PALMS 15UWD egy erdészeti pótkocsi 15 tonnás névleges teherbírással, és a termékskálánkban engedélyezett legnagyobb össztömegű erdészeti pótkocsit képviseli. Mindennapi szakmai erdészmunkákhoz tervezték, igényes körülmények között. Magas hasmagassága és ovális kerete csökkenti a csonkokon való elakadás kockázatát. Ráadásul az összes hidraulikus és elektronikus alkatrész biztonságosan el van helyezve a keretben.", "2", "unibody", "1,085", "19000", 1, "3.2", "4175", "120", "PALMS 15UWD", "", "500/50-22,5", "6415", 1, 2, "2450", null },
                    { 19, 3, "Unibody (Forwarder)", 1, 1, "2545", "A PALMS 15UAWD egy erdészeti pótkocsi 15 tonnás névleges teherbírással, és a termékskálánkban engedélyezett legnagyobb össztömegű erdészeti pótkocsit képviseli. Mindennapi szakmai erdészmunkákhoz tervezték, igényes körülmények között. Magas hasmagassága és ovális kerete csökkenti a csonkokon való elakadás kockázatát. Ráadásul az összes hidraulikus és elektronikus alkatrész biztonságosan el van helyezve a keretben.", "2", "unibody", "1,085", "19000", 1, "3.2", "4175", "120", "PALMS 15UAWD", "", "500/50-22,5", "6415", 1, 2, "2450", null }
                });

            migrationBuilder.InsertData(
                table: "BrakeTrailer",
                columns: new[] { "BrakeId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 2, 12 },
                    { 3, 12 },
                    { 4, 12 },
                    { 5, 12 },
                    { 8, 12 },
                    { 9, 12 },
                    { 10, 13 },
                    { 10, 14 },
                    { 10, 15 },
                    { 10, 17 },
                    { 10, 18 },
                    { 11, 13 },
                    { 11, 15 },
                    { 11, 18 },
                    { 12, 13 },
                    { 12, 15 },
                    { 12, 18 },
                    { 13, 13 },
                    { 13, 15 },
                    { 13, 18 },
                    { 14, 13 },
                    { 14, 15 },
                    { 14, 18 },
                    { 15, 13 },
                    { 15, 15 },
                    { 15, 18 },
                    { 20, 16 },
                    { 20, 19 },
                    { 21, 16 },
                    { 21, 19 },
                    { 22, 16 },
                    { 22, 19 },
                    { 23, 16 },
                    { 23, 19 },
                    { 24, 16 },
                    { 24, 19 },
                    { 25, 16 },
                    { 25, 19 },
                    { 26, 14 },
                    { 26, 17 },
                    { 27, 14 },
                    { 27, 17 },
                    { 28, 14 },
                    { 28, 17 },
                    { 29, 14 },
                    { 29, 17 },
                    { 30, 14 },
                    { 30, 17 }
                });

            migrationBuilder.InsertData(
                table: "StanchionTrailer",
                columns: new[] { "StanchionId", "TrailerId" },
                values: new object[,]
                {
                    { 43, 12 },
                    { 44, 12 },
                    { 45, 12 },
                    { 46, 12 },
                    { 47, 12 },
                    { 48, 12 },
                    { 49, 12 },
                    { 50, 12 },
                    { 51, 13 },
                    { 52, 13 },
                    { 53, 13 },
                    { 54, 13 },
                    { 55, 13 },
                    { 56, 13 },
                    { 57, 13 },
                    { 58, 13 },
                    { 59, 14 },
                    { 60, 14 },
                    { 61, 14 },
                    { 62, 14 },
                    { 63, 14 },
                    { 64, 14 },
                    { 65, 14 },
                    { 66, 14 },
                    { 67, 15 },
                    { 68, 15 },
                    { 69, 15 },
                    { 70, 15 },
                    { 71, 15 },
                    { 72, 15 },
                    { 73, 15 },
                    { 74, 15 },
                    { 75, 16 },
                    { 76, 16 },
                    { 77, 16 },
                    { 78, 16 },
                    { 79, 16 },
                    { 80, 16 },
                    { 81, 16 },
                    { 82, 16 },
                    { 83, 17 },
                    { 84, 17 },
                    { 85, 17 },
                    { 86, 17 },
                    { 87, 17 },
                    { 88, 17 },
                    { 89, 17 },
                    { 90, 17 },
                    { 91, 18 },
                    { 92, 18 },
                    { 93, 18 },
                    { 94, 18 },
                    { 95, 18 },
                    { 96, 18 },
                    { 97, 18 },
                    { 98, 18 },
                    { 99, 19 },
                    { 100, 19 },
                    { 101, 19 },
                    { 102, 19 },
                    { 103, 19 },
                    { 104, 19 },
                    { 105, 19 },
                    { 106, 19 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 8, 12 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 10, 13 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 10, 14 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 10, 15 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 10, 17 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 10, 18 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 11, 15 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 11, 18 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 12, 13 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 12, 15 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 12, 18 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 13, 15 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 13, 18 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 14, 13 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 14, 15 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 14, 18 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 15, 13 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 15, 15 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 15, 18 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 20, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 20, 19 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 21, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 21, 19 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 22, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 22, 19 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 23, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 23, 19 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 24, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 24, 19 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 25, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 25, 19 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 26, 14 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 26, 17 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 27, 14 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 27, 17 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 28, 14 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 28, 17 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 29, 14 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 29, 17 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 30, 14 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 30, 17 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 43, 12 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 44, 12 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 45, 12 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 46, 12 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 47, 12 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 48, 12 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 49, 12 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 50, 12 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 51, 13 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 52, 13 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 53, 13 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 54, 13 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 55, 13 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 56, 13 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 57, 13 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 58, 13 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 59, 14 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 60, 14 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 61, 14 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 62, 14 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 63, 14 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 64, 14 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 65, 14 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 66, 14 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 67, 15 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 68, 15 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 69, 15 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 70, 15 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 71, 15 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 72, 15 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 73, 15 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 74, 15 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 75, 16 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 76, 16 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 77, 16 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 78, 16 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 79, 16 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 80, 16 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 81, 16 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 82, 16 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 83, 17 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 84, 17 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 85, 17 });

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
                keyValues: new object[] { 88, 17 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 89, 17 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 90, 17 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 91, 18 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 92, 18 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 93, 18 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 94, 18 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 95, 18 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 96, 18 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 97, 18 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 98, 18 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 99, 19 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 100, 19 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 101, 19 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 102, 19 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 103, 19 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 104, 19 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 105, 19 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 106, 19 });

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BBox",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BBox",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
