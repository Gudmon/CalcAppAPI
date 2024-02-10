using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crane",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Series = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxReach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiftAtFullReach240Bar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiftAtFullReach215Bar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiftAtFullReach190Bar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiftAtFourMeters240Bar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiftAtFourMeters215Bar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiftAtFourMeters190Bar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrutLiftingTorque240Bar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrutLiftingTorque215Bar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrutLiftingTorque190Bar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SlewingCylinder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SlewingTorque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkingPressure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RotatorMaximumLoad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CraneWeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PillarSlewingAngle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecommendedOilFLow = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crane", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trailer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeamType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadingAreaCross = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadingAreaLength = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Frame = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrameExtensionLength = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrossWeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurbWeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalLength = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WidthWithStandardWheels = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StandardWheelSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxCraneSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrawbarControlCylinders = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trailer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CraneTrailer",
                columns: table => new
                {
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraneTrailer", x => new { x.CraneId, x.TrailerId });
                    table.ForeignKey(
                        name: "FK_CraneTrailer_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CraneTrailer_Trailer_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Crane",
                columns: new[] { "Id", "BrutLiftingTorque190Bar", "BrutLiftingTorque215Bar", "BrutLiftingTorque240Bar", "CraneWeight", "Description", "LiftAtFourMeters190Bar", "LiftAtFourMeters215Bar", "LiftAtFourMeters240Bar", "LiftAtFullReach190Bar", "LiftAtFullReach215Bar", "LiftAtFullReach240Bar", "MaxReach", "Name", "PillarSlewingAngle", "Price", "RecommendedOilFLow", "RotatorMaximumLoad", "Series", "SlewingCylinder", "SlewingTorque", "WorkingPressure" },
                values: new object[,]
                {
                    { 1, "26", "-", "-", "360", "Ideális választás azoknak a vásárlóknak, akik egyszerűséget, könnyűséget és kompakt méretet keresnek. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.", "570", "-", "-", "540", "-", "-", "4.2", "PALMS 2.42", "370", "5165", "20-35", "45", "2", "4", "7.8", "190" },
                    { 2, "26", "29", "-", "400", "Kompakt és könnyű daru, ideális városi parkokhoz és más környezetvédelmi érzékeny területekhez. Rögzíthető különböző platformokra, erdészeti pótkocsiktól és teherautóktól kezdve a mini-forwarderekig. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.", "530", "600", "-", "370", "410", "-", "5.4", "PALMS 2.54", "370", "6285", "20-35", "45", "2", "4", "7.8", "190/215" },
                    { 3, "36", "-", "-", "415", "Kis erdőtulajdonosoknak tervezett daru a tűzifa előkészítésére saját maguk és szomszédos háztartások számára. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.", "355", "-", "-", "-", "-", "-", "6.3", "PALMS 3.63", "370", "6985", "20-35", "45", "3", "4", "9", "190" },
                    { 4, "41", "46", "-", "620", "Egy gazda legjobb társa, kiváló teljesítményt nyújtva tűzifa előkészítésében és általános emelési feladatokban a gazdaságokon. Kompatibilis a PALMS 8SX, 8D, 9SC és 10D pótkocsikkal.", "820", "910", "-", "430", "480", "-", "6.7", "PALMS 3.67", "370", "8260", "30-45", "45", "3", "4", "12", "190/215" }
                });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "BeamType", "CurbWeight", "Description", "DrawbarControlCylinders", "Frame", "FrameExtensionLength", "GrossWeight", "LoadingAreaCross", "LoadingAreaLength", "MaxCraneSize", "Name", "Price", "StandardWheelSize", "TotalLength", "WidthWithStandardWheels" },
                values: new object[,]
                {
                    { 1, "Single", "890", "A PALMS 6S egyetlen gerendás erdészeti pótkocsi, melynek nominális teherbírása 6 tonna. Könnyű és kompakt kialakítása tökéletes választás kisebb traktorokhoz, ideális magán-erdőgazdálkodáshoz és gazdálkodóknak. A PALMS 6S hasonló technológiákat használ, mint nagyobb pótkocsijaink, beleértve a magas minőségű KTL és porfestési bevonatot, ami hosszabb élettartamot és nagyobb újraértékesítési értéket biztosít.", "1", "140x140x6", "-", "8500", "1.5", "3000", "35", "PALMS 6S", "", "400/60-15,5", "4900", "1950" },
                    { 2, "Single", "1180", "PALMS 8SX is a single-beam forest trailer with a nominal load capacity of 8 tons. It stands as a popular choice among many small forest landowners and farmers. The trailer's simple yet robust construction and durability make it a reliable companion for various forestry and agricultural tasks.", "2", "160x160x8", "0.61", "10000", "2", "3550", "47", "PALMS 8SX", "", "400/60-15,5", "5690", "2070" },
                    { 3, "Single", "1425", "PALMS 9SC is our largest single-beam trailer in the product lineup with a nominal load capacity of 9 tons. It is ideal for customers who prefer the simplicity of a single-beam trailer while requiring a longer reach from a forestry crane. This feature makes it a popular choice, for example, among arborists. Additionally, PALMS 9SC stands out in user convenience among other single-beam trailers with its drawbar quick-lock system and patented bolster locks.", "2", "200x200x8", "0.70", "12000", "2.15", "3870", "65", "PALMS 9SC", "", "400/60-15,5", "6095", "2135" }
                });

            migrationBuilder.InsertData(
                table: "CraneTrailer",
                columns: new[] { "CraneId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CraneTrailer_TrailerId",
                table: "CraneTrailer",
                column: "TrailerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CraneTrailer");

            migrationBuilder.DropTable(
                name: "Crane");

            migrationBuilder.DropTable(
                name: "Trailer");
        }
    }
}
