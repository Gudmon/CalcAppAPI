using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class everysdtrailer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BrakeTrailer",
                columns: new[] { "BrakeId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 3 }
                });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "BBoxId", "BeamType", "BolsterLockId", "ChainsawHolderId", "CurbWeight", "Description", "DrawbarControlCylinders", "Frame", "FrameExtensionLength", "GrossWeight", "HandBrakeId", "LoadingAreaCross", "LoadingAreaLength", "MaxCraneSize", "Name", "Price", "StandardWheelSize", "TotalLength", "UnderrunProtectionId", "WidthWithStandardWheels", "WoodSorterId" },
                values: new object[,]
                {
                    { 4, 1, "Double", 1, 1, "1510", "A PALMS 8D, amelynek nominális teherbírása 8 tonna, a legkompaktabb két gerendás utánfutó a termékpalettánkban. Azoknak a felhasználóknak terveztük, akik könnyebb utánfutót keresnek, de mégis szeretnének egy két gerendás utánfutó nagyobb szilárdságát és merevségét.", "2", "2x200x100x8", "0,85", "10000", 1, "1,95", "3975", "85", "PALMS 8DWD", "", "400/60-15,5", "6200", 1, "2095", 1 },
                    { 5, 1, "Single", 1, 1, "1425", "A PALMS 9SC a termékpalettánk legnagyobb egygerendás utánfutója, 9 tonnás nominális teherbírással. Ideális választás azoknak a vásárlóknak, akik preferálják az egygerendás utánfutó egyszerűségét, miközben hosszabb hatótávot igényelnek egy erdészeti darutól. Ez a jellemző például népszerűvé teszi arboristák körében. Emellett a PALMS 9SC kiemelkedik a felhasználói kényelem terén más egygerendás utánfutók közül, gyorszárú vontatókar rendszerével és szabadalmaztatott tengelyzárjaival.", "2", "200x200x6", "0,70", "12000", 1, "2,15", "3870", "65", "PALMS 9SC", "", "400/60-15,5", "6095", 2, "2135", 1 },
                    { 6, 1, "Double", 1, 1, "1765", "A PALMS 10D, dupla gerendás vázú és 10 tonnás nominális teherbírású, az egyik legkelendőbb erdészeti utánfutó a PALMS terméksorozatában. Kiválóan párosítható a legtöbb PALMS daruval és további felszereléssel, lehetővé téve a testreszabást, hogy olyan beállítást hozzon létre, amely pontosan megfelel az elvárásainak.", "2", "2x200x100x8", "0,85", "13000", 1, "2,4", "3975", "85", "PALMS 10D", "", "400/60-15,5", "6200", 1, "2165", 1 },
                    { 7, 1, "Double", 1, 1, "1765", "A PALMS 10D, dupla gerendás vázú és 10 tonnás nominális teherbírású, az egyik legkelendőbb erdészeti utánfutó a PALMS terméksorozatában. Kiválóan párosítható a legtöbb PALMS daruval és további felszereléssel, lehetővé téve a testreszabást, hogy olyan beállítást hozzon létre, amely pontosan megfelel az elvárásainak.", "2", "2x200x100x8", "0,85", "12500", 1, "2,4", "3975", "85", "PALMS 10DWD", "", "400/60-15,5", "6200", 1, "2165", 1 },
                    { 8, 1, "Double", 1, 1, "2030", "A PALMS 12D egy erdészeti utánfutó, 12 tonnás nominális teherbírással és dupla gerendás vázzal. Kiváló választás mindennapi erdészeti feladatokhoz, nagyszerű kompatibilitást nyújtva a PALMS ötödik és hetedik sorozatú daruival.", "2", "2x200x100x8", "0,85", "15000", 1, "2,7", "3975", "85", "PALMS 12D", "", "500/50-17", "6200", 1, "2350", 1 },
                    { 9, 1, "Double", 1, 1, "2030", "A PALMS 12D egy erdészeti utánfutó, 12 tonnás nominális teherbírással és dupla gerendás vázzal. Kiváló választás mindennapi erdészeti feladatokhoz, nagyszerű kompatibilitást nyújtva a PALMS ötödik és hetedik sorozatú daruival.", "2", "2x200x100x8", "0,85", "15000", 1, "2,7", "3975", "85", "PALMS 12DWD", "", "500/50-17", "6200", 1, "2350", 1 },
                    { 10, 1, "Double", 1, 1, "2375", "A PALMS 14D a PALMS palettájának legnagyobb dupla gerendás utánfutója, jelentős 14 tonnás nominális teherbírással. A PALMS 14D nemcsak nagyobb terhelési területtel rendelkezik, hanem kiterjesztett terhelési területet is kínál más dupla gerendás utánfutókkal összehasonlítva. Emellett ez az utánfutó kompatibilis a PALMS zászlóshajójával, az X100-as erdészeti daruval.", "2", "2x200x120x10", "0,86", "18000", 1, "3,0", "4080", "112", "PALMS 14D", "", "500/50-17", "6300", 1, "2450", 1 },
                    { 11, 1, "Double", 1, 1, "2375", "A PALMS 14D a PALMS palettájának legnagyobb dupla gerendás utánfutója, jelentős 14 tonnás nominális teherbírással. A PALMS 14D nemcsak nagyobb terhelési területtel rendelkezik, hanem kiterjesztett terhelési területet is kínál más dupla gerendás utánfutókkal összehasonlítva. Emellett ez az utánfutó kompatibilis a PALMS zászlóshajójával, az X100-as erdészeti daruval.", "2", "2x200x120x10", "0,86", "18000", 1, "3,0", "4080", "112", "PALMS 14DWD", "", "500/50-17", "6300", 1, "2450", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
