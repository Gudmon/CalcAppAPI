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
                name: "BBox",
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
                    table.PrimaryKey("PK_BBox", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BolsterLock",
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
                    table.PrimaryKey("PK_BolsterLock", x => x.Id);
                });

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
                name: "ChainsawHolder",
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
                    table.PrimaryKey("PK_ChainsawHolder", x => x.Id);
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
                name: "HandBrake",
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
                    table.PrimaryKey("PK_HandBrake", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OilPump",
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
                    table.PrimaryKey("PK_OilPump", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OilTankCooler",
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
                    table.PrimaryKey("PK_OilTankCooler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platform",
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
                    table.PrimaryKey("PK_Platform", x => x.Id);
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
                name: "UnderrunProtection",
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
                    table.PrimaryKey("PK_UnderrunProtection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WoodSorter",
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
                    table.PrimaryKey("PK_WoodSorter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OilTank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OilTankCoolerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OilTank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OilTank_OilTankCooler_OilTankCoolerId",
                        column: x => x.OilTankCoolerId,
                        principalTable: "OilTankCooler",
                        principalColumn: "Id");
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
                    DrawbarControlCylinders = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BolsterLockId = table.Column<int>(type: "int", nullable: true),
                    BBoxId = table.Column<int>(type: "int", nullable: true),
                    WoodSorterId = table.Column<int>(type: "int", nullable: true),
                    HandBrakeId = table.Column<int>(type: "int", nullable: true),
                    ChainsawHolderId = table.Column<int>(type: "int", nullable: true),
                    UnderrunProtectionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trailer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trailer_BBox_BBoxId",
                        column: x => x.BBoxId,
                        principalTable: "BBox",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_BolsterLock_BolsterLockId",
                        column: x => x.BolsterLockId,
                        principalTable: "BolsterLock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_ChainsawHolder_ChainsawHolderId",
                        column: x => x.ChainsawHolderId,
                        principalTable: "ChainsawHolder",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_HandBrake_HandBrakeId",
                        column: x => x.HandBrakeId,
                        principalTable: "HandBrake",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_UnderrunProtection_UnderrunProtectionId",
                        column: x => x.UnderrunProtectionId,
                        principalTable: "UnderrunProtection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_WoodSorter_WoodSorterId",
                        column: x => x.WoodSorterId,
                        principalTable: "WoodSorter",
                        principalColumn: "Id");
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
                name: "OilPumpTrailer",
                columns: table => new
                {
                    OilPumpId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OilPumpTrailer", x => new { x.OilPumpId, x.TrailerId });
                    table.ForeignKey(
                        name: "FK_OilPumpTrailer_OilPump_OilPumpId",
                        column: x => x.OilPumpId,
                        principalTable: "OilPump",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OilPumpTrailer_Trailer_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OilTankTrailer",
                columns: table => new
                {
                    OilTankId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OilTankTrailer", x => new { x.OilTankId, x.TrailerId });
                    table.ForeignKey(
                        name: "FK_OilTankTrailer_OilTank_OilTankId",
                        column: x => x.OilTankId,
                        principalTable: "OilTank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OilTankTrailer_Trailer_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlatformTrailer",
                columns: table => new
                {
                    PlatformId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatformTrailer", x => new { x.PlatformId, x.TrailerId });
                    table.ForeignKey(
                        name: "FK_PlatformTrailer_Platform_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platform",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlatformTrailer_Trailer_TrailerId",
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
                table: "BBox",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "Bbox", "Biomasszás boksz 4 mm-es Strenx acélból", "2825" });

            migrationBuilder.InsertData(
                table: "BolsterLock",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "BL", "Rakconca rögzítő az első pár rakoncához", "0" });

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
                table: "ChainsawHolder",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "MSH", "Láncfűrész tartó", "65" });

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
                table: "HandBrake",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "PB1", "Kézifék, kerékről működtethető", "105" });

            migrationBuilder.InsertData(
                table: "OilPump",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "P01", "Szivattyú adapter a vonórúdon", "60" },
                    { 2, "P1", "101 cm3 dugattyús olajmpumpa a vonórúdon, 650 p/min - 65 l/min", "1155" },
                    { 3, "P2", "130 cm3 dugattyús olajmpuma a vonórúdon, 650 p/min - 82 l/min", "1575" },
                    { 4, "P4", "61 cm3 dugattyús olajpumpa multiplikátorral a vonórúdon, 650 p/min - 98 l/min", "1995" },
                    { 5, "P4PTO", "P4 olajmpumla PTO-val 650 p/min - 98 l/min (rögzítő konzol nélkül)", "1995" },
                    { 6, "P6", "LS fajtájú olajmpumpa multiplikátorral, 650 p/min - 120 l/min", "4305" },
                    { 7, "P6PTO", "P6 olajpumpa PTO-val 650 p/min - 120 l/min (rögzítő konzol nélkül)", "4305" }
                });

            migrationBuilder.InsertData(
                table: "OilTank",
                columns: new[] { "Id", "Code", "Name", "OilTankCoolerId", "Price" },
                values: new object[,]
                {
                    { 3, "T2SOV", "95 l-es olajtartály HVLP olajjal, elzáró csappal", null, "1200" },
                    { 4, "T2SOV+", "95 l-es olajtartály HVLP olajjal, elzáró csappal, olajszűrővel", null, "1490" }
                });

            migrationBuilder.InsertData(
                table: "OilTankCooler",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "CP2", "Olajhűtő csomag a tartályhoz rögzítve", "1035" });

            migrationBuilder.InsertData(
                table: "Platform",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "D1", "Kezelő platform háttámlával a vonórúdon", "600" },
                    { 2, "D2", "Kezelő platform háttámlával a vonórúdon túlfutásgátlós vonórúddal", "600" }
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
                table: "UnderrunProtection",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "RUP1", "Aláfutásgátló D-típushoz, hátsó lámpa és rendszámtartó", "1040" },
                    { 2, "RUP2", "Aláfutásgátló S és U-típushoz, hátsó lámpa és rendszámtartó", "1040" }
                });

            migrationBuilder.InsertData(
                table: "WoodSorter",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "WS", "Faosztályozó rövidebb fához (1db/rakonca, az ár 1 db-ra vonatkozik)", "65" });

            migrationBuilder.InsertData(
                table: "OilTank",
                columns: new[] { "Id", "Code", "Name", "OilTankCoolerId", "Price" },
                values: new object[,]
                {
                    { 1, "T2", "95 l-es olajtartály", 1, "1000" },
                    { 2, "T2+", "95 l-es olajtartály HVLP olajjal", 1, "1290" }
                });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "BBoxId", "BeamType", "BolsterLockId", "ChainsawHolderId", "CurbWeight", "Description", "DrawbarControlCylinders", "Frame", "FrameExtensionLength", "GrossWeight", "HandBrakeId", "LoadingAreaCross", "LoadingAreaLength", "MaxCraneSize", "Name", "Price", "StandardWheelSize", "TotalLength", "UnderrunProtectionId", "WidthWithStandardWheels", "WoodSorterId" },
                values: new object[,]
                {
                    { 1, null, "Single", null, 1, "890", "A PALMS 6S egyetlen gerendás erdészeti pótkocsi, melynek nominális teherbírása 6 tonna. Könnyű és kompakt kialakítása tökéletes választás kisebb traktorokhoz, ideális magán-erdőgazdálkodáshoz és gazdálkodóknak. A PALMS 6S hasonló technológiákat használ, mint nagyobb pótkocsijaink, beleértve a magas minőségű KTL és porfestési bevonatot, ami hosszabb élettartamot és nagyobb újraértékesítési értéket biztosít.", "1", "140x140x6", "-", "8500", null, "1,5", "3000", "35", "PALMS 6S", "", "400/60-15,5", "4900", null, "1950", null },
                    { 2, 1, "Single", 1, 1, "1180", "A PALMS 8SX egyetlen gerendával rendelkező erdészeti utánfutó, amelynek nominális teherbírása 8 tonna. Ez a modell népszerű választás számos kis erdőbirtokos és gazdálkodó körében. Az utánfutó egyszerű, mégis robosztus kialakítása és tartóssága megbízható társává teszi különböző erdészeti és mezőgazdasági feladatokban.", "2", "160x160x8", "0,61", "10000", 1, "2", "3550", "47", "PALMS 8SX", "", "400/60-15,5", "5690", 2, "2070", 1 },
                    { 3, 1, "Double", 1, 1, "1510", "A PALMS 8D, amelynek nominális teherbírása 8 tonna, a legkompaktabb két gerendás utánfutó a termékpalettánkban. Azoknak a felhasználóknak terveztük, akik könnyebb utánfutót keresnek, de mégis szeretnének egy két gerendás utánfutó nagyobb szilárdságát és merevségét.", "2", "2x200x100x8", "0,85", "10000", 1, "1,95", "3975", "85", "PALMS 8D", "", "400/60-15,5", "6200", 1, "2095", 1 }
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
                table: "OilPumpTrailer",
                columns: new[] { "OilPumpId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 2 },
                    { 3, 3 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 2 },
                    { 5, 3 },
                    { 6, 2 },
                    { 6, 3 },
                    { 7, 2 },
                    { 7, 3 }
                });

            migrationBuilder.InsertData(
                table: "OilTankTrailer",
                columns: new[] { "OilTankId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 2 },
                    { 3, 3 },
                    { 4, 2 },
                    { 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "PlatformTrailer",
                columns: new[] { "PlatformId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 2 },
                    { 2, 3 }
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
                name: "IX_OilPumpTrailer_TrailerId",
                table: "OilPumpTrailer",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_OilTank_OilTankCoolerId",
                table: "OilTank",
                column: "OilTankCoolerId");

            migrationBuilder.CreateIndex(
                name: "IX_OilTankTrailer_TrailerId",
                table: "OilTankTrailer",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlatformTrailer_TrailerId",
                table: "PlatformTrailer",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_PropulsionTrailer_TrailerId",
                table: "PropulsionTrailer",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_StanchionTrailer_TrailerId",
                table: "StanchionTrailer",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_BBoxId",
                table: "Trailer",
                column: "BBoxId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_BolsterLockId",
                table: "Trailer",
                column: "BolsterLockId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_ChainsawHolderId",
                table: "Trailer",
                column: "ChainsawHolderId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_HandBrakeId",
                table: "Trailer",
                column: "HandBrakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_UnderrunProtectionId",
                table: "Trailer",
                column: "UnderrunProtectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_WoodSorterId",
                table: "Trailer",
                column: "WoodSorterId");
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
                name: "OilPumpTrailer");

            migrationBuilder.DropTable(
                name: "OilTankTrailer");

            migrationBuilder.DropTable(
                name: "PlatformTrailer");

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
                name: "OilPump");

            migrationBuilder.DropTable(
                name: "OilTank");

            migrationBuilder.DropTable(
                name: "Platform");

            migrationBuilder.DropTable(
                name: "Propulsion");

            migrationBuilder.DropTable(
                name: "Stanchion");

            migrationBuilder.DropTable(
                name: "Trailer");

            migrationBuilder.DropTable(
                name: "OilTankCooler");

            migrationBuilder.DropTable(
                name: "BBox");

            migrationBuilder.DropTable(
                name: "BolsterLock");

            migrationBuilder.DropTable(
                name: "ChainsawHolder");

            migrationBuilder.DropTable(
                name: "HandBrake");

            migrationBuilder.DropTable(
                name: "UnderrunProtection");

            migrationBuilder.DropTable(
                name: "WoodSorter");
        }
    }
}
