using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class moremachines2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brake",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brake", x => x.Id);
                });

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
                name: "Drawbar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drawbar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Propulsion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propulsion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stanchion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stanchion", x => x.Id);
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
                name: "BrakeTrailer",
                columns: table => new
                {
                    BrakeId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrakeTrailer", x => new { x.BrakeId, x.TrailerId });
                    table.ForeignKey(
                        name: "FK_BrakeTrailer_Brake_BrakeId",
                        column: x => x.BrakeId,
                        principalTable: "Brake",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrakeTrailer_Trailer_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "DrawbarTrailer",
                columns: table => new
                {
                    DrawbarId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrawbarTrailer", x => new { x.DrawbarId, x.TrailerId });
                    table.ForeignKey(
                        name: "FK_DrawbarTrailer_Drawbar_DrawbarId",
                        column: x => x.DrawbarId,
                        principalTable: "Drawbar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrawbarTrailer_Trailer_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropulsionTrailer",
                columns: table => new
                {
                    PropulsionId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropulsionTrailer", x => new { x.PropulsionId, x.TrailerId });
                    table.ForeignKey(
                        name: "FK_PropulsionTrailer_Propulsion_PropulsionId",
                        column: x => x.PropulsionId,
                        principalTable: "Propulsion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropulsionTrailer_Trailer_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StanchionTrailer",
                columns: table => new
                {
                    StanchionId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StanchionTrailer", x => new { x.StanchionId, x.TrailerId });
                    table.ForeignKey(
                        name: "FK_StanchionTrailer_Stanchion_StanchionId",
                        column: x => x.StanchionId,
                        principalTable: "Stanchion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StanchionTrailer_Trailer_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brake",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "B0", "Fék nélkül", "0" },
                    { 2, "B1", "2 keréken hidraulikus fék", "960" },
                    { 3, "B2", "4 keréken hidraulikus fék", "1810" },
                    { 4, "B3", "2 keréken légfék", "1615" },
                    { 5, "B4", "4 keréken légfék", "2640" },
                    { 6, "BA-EU", "Légfék", "2095" },
                    { 7, "BH-EU", "Hidraulikus fék", "3450" }
                });

            migrationBuilder.InsertData(
                table: "Crane",
                columns: new[] { "Id", "BrutLiftingTorque190Bar", "BrutLiftingTorque215Bar", "BrutLiftingTorque240Bar", "CraneWeight", "Description", "LiftAtFourMeters190Bar", "LiftAtFourMeters215Bar", "LiftAtFourMeters240Bar", "LiftAtFullReach190Bar", "LiftAtFullReach215Bar", "LiftAtFullReach240Bar", "MaxReach", "Name", "PillarSlewingAngle", "Price", "RecommendedOilFLow", "RotatorMaximumLoad", "Series", "SlewingCylinder", "SlewingTorque", "WorkingPressure" },
                values: new object[,]
                {
                    { 1, "26", "-", "-", "360", "Ideális választás azoknak a vásárlóknak, akik egyszerűséget, könnyűséget és kompakt méretet keresnek. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.", "570", "-", "-", "540", "-", "-", "4.2", "PALMS 2.42", "370", "5165", "20-35", "45", "2", "4", "7.8", "190" },
                    { 2, "26", "29", "-", "400", "Kompakt és könnyű daru, ideális városi parkokhoz és más környezetvédelmi érzékeny területekhez. Rögzíthető különböző platformokra, erdészeti pótkocsiktól és teherautóktól kezdve a mini-forwarderekig. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.", "530", "600", "-", "370", "410", "-", "5.4", "PALMS 2.54", "370", "6285", "20-35", "45", "2", "4", "7.8", "190/215" },
                    { 3, "36", "-", "-", "415", "Kis erdőtulajdonosoknak tervezett daru a tűzifa előkészítésére saját maguk és szomszédos háztartások számára. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.", "355", "-", "-", "-", "-", "-", "6.3", "PALMS 3.63", "370", "6985", "20-35", "45", "3", "4", "9", "190" },
                    { 4, "41", "46", "-", "620", "Egy gazda legjobb társa, kiváló teljesítményt nyújtva tűzifa előkészítésében és általános emelési feladatokban a gazdaságokon. Kompatibilis a PALMS 8SX, 8D, 9SC és 10D pótkocsikkal.", "820", "910", "-", "430", "480", "-", "6.7", "PALMS 3.67", "370", "8260", "30-45", "45", "3", "4", "12", "190/215" },
                    { 5, "48", "54", "-", "710", "Versatile medium-sized crane, used across diverse sectors like arboriculture, farming, and land development. Compatible with the majority of PALMS trailers.", "960", "1040", "-", "480", "535", "-", "7.1", "PALMS 4.71", "370", "9450", "45-70", "45", "4", "4", "15", "190/215" }
                });

            migrationBuilder.InsertData(
                table: "Drawbar",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "C1", "Skandináv típusú forgó vonórúd", "0" },
                    { 2, "C2", "Német típusú magas vonórúd vonószem nélkül", "0" },
                    { 3, "C3", "Osztrák típusú alacsony vonórúd vonószem nélkül", "0" },
                    { 4, "C4", "Német típusú magas vonórúd vonószemmel", "275" },
                    { 5, "C5", "Osztrák típusú magas vonórúd vonószemmel", "275" },
                    { 6, "C6", "Német típusú magas vonórúd vonószemmel", "430" },
                    { 7, "C7", "Magas ráfutófékes vonórúd vonószemmel, kábelekkel és 2 kerék fékkel", "1675" },
                    { 8, "C6", "K-80 típusú alacsony vonórúd vonószemmel", "470" },
                    { 9, "C9", "Osztrák típusú alacsony vonórúd elforduló vonószemmel", "525" }
                });

            migrationBuilder.InsertData(
                table: "Propulsion",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "RWD", "Robson WD dörzshajtás (traktor hidarulikáról)", "5280" },
                    { 2, "RWD+", "Robson WD dörzshajtás elektronikus vezérlőrendszerrel", "7600" }
                });

            migrationBuilder.InsertData(
                table: "Stanchion",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "A3", "Pótkocsi 3 pár rakoncával", "5285" },
                    { 2, "A4", "Pótkocsi 4 pár rakoncával", "5800" },
                    { 3, "A3", "Pótkocsi 3 pár rakoncával", "6930" },
                    { 4, "A4", "Pótkocsi 4 pár rakoncával", "7390" },
                    { 5, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "7700" },
                    { 6, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "8160" },
                    { 7, "A3", "Pótkocsi 3 pár rakoncával", "7340" },
                    { 8, "A4", "Pótkocsi 4 pár rakoncával", "7710" },
                    { 9, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "8330" },
                    { 10, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "8695" }
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
                table: "BrakeTrailer",
                columns: new[] { "BrakeId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 }
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

            migrationBuilder.InsertData(
                table: "DrawbarTrailer",
                columns: new[] { "DrawbarId", "TrailerId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 6, 2 },
                    { 6, 3 },
                    { 7, 2 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 3 }
                });

            migrationBuilder.InsertData(
                table: "PropulsionTrailer",
                columns: new[] { "PropulsionId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "StanchionTrailer",
                columns: new[] { "StanchionId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 3 },
                    { 8, 3 },
                    { 9, 3 },
                    { 10, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrakeTrailer_TrailerId",
                table: "BrakeTrailer",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_CraneTrailer_TrailerId",
                table: "CraneTrailer",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_DrawbarTrailer_TrailerId",
                table: "DrawbarTrailer",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_PropulsionTrailer_TrailerId",
                table: "PropulsionTrailer",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_StanchionTrailer_TrailerId",
                table: "StanchionTrailer",
                column: "TrailerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrakeTrailer");

            migrationBuilder.DropTable(
                name: "CraneTrailer");

            migrationBuilder.DropTable(
                name: "DrawbarTrailer");

            migrationBuilder.DropTable(
                name: "PropulsionTrailer");

            migrationBuilder.DropTable(
                name: "StanchionTrailer");

            migrationBuilder.DropTable(
                name: "Brake");

            migrationBuilder.DropTable(
                name: "Crane");

            migrationBuilder.DropTable(
                name: "Drawbar");

            migrationBuilder.DropTable(
                name: "Propulsion");

            migrationBuilder.DropTable(
                name: "Stanchion");

            migrationBuilder.DropTable(
                name: "Trailer");
        }
    }
}
