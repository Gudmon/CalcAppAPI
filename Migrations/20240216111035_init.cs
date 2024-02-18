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
                name: "FrameType",
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
                    table.PrimaryKey("PK_FrameType", x => x.Id);
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
                name: "Light",
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
                    table.PrimaryKey("PK_Light", x => x.Id);
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
                name: "SupportLeg",
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
                    table.PrimaryKey("PK_SupportLeg", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tyre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tyre", x => x.Id);
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
                name: "LightTrailer",
                columns: table => new
                {
                    LightId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LightTrailer", x => new { x.LightId, x.TrailerId });
                    table.ForeignKey(
                        name: "FK_LightTrailer_Light_LightId",
                        column: x => x.LightId,
                        principalTable: "Light",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LightTrailer_Trailer_TrailerId",
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

            migrationBuilder.CreateTable(
                name: "SupportLegTrailer",
                columns: table => new
                {
                    SupportLegId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportLegTrailer", x => new { x.SupportLegId, x.TrailerId });
                    table.ForeignKey(
                        name: "FK_SupportLegTrailer_SupportLeg_SupportLegId",
                        column: x => x.SupportLegId,
                        principalTable: "SupportLeg",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupportLegTrailer_Trailer_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrailerCraneCompatibilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrailerId = table.Column<int>(type: "int", nullable: false),
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    FrameTypeId = table.Column<int>(type: "int", nullable: false),
                    Recommended = table.Column<bool>(type: "bit", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrailerCraneCompatibilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrailerCraneCompatibilities_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrailerCraneCompatibilities_FrameType_FrameTypeId",
                        column: x => x.FrameTypeId,
                        principalTable: "FrameType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrailerCraneCompatibilities_Trailer_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TyreTrailer",
                columns: table => new
                {
                    TrailerId = table.Column<int>(type: "int", nullable: false),
                    TyreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TyreTrailer", x => new { x.TrailerId, x.TyreId });
                    table.ForeignKey(
                        name: "FK_TyreTrailer_Trailer_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TyreTrailer_Tyre_TyreId",
                        column: x => x.TyreId,
                        principalTable: "Tyre",
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
                    { 7, "BH-EU", "Hidraulikus fék", "3450" },
                    { 8, "BA-EU", "Légfék", "3125" },
                    { 9, "BH-EU", "Hidraulikus fék", "4295" },
                    { 10, "B1", "2 keréken hidraulikus fék", "1255" },
                    { 11, "B2", "4 keréken hidraulikus fék", "4545" },
                    { 12, "B3", "2 keréken légfék", "1915" },
                    { 13, "B4", "4 keréken légfék", "5385" },
                    { 14, "BA-EU", "Légfék", "5605" },
                    { 15, "BH-EU", "Hidraulikus fék", "6770" },
                    { 16, "B2", "4 keréken hidraulikus fék", "2415" },
                    { 17, "B4", "4 keréken légfék", "3255" },
                    { 18, "BA-EU", "Légfék", "3740" },
                    { 19, "BH-EU", "Hidraulikus fék", "4905" }
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
                table: "FrameType",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "B0", "Talpaló nélkül", "0" });

            migrationBuilder.InsertData(
                table: "HandBrake",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "PB1", "Kézifék, kerékről működtethető", "105" });

            migrationBuilder.InsertData(
                table: "Light",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "L1", "Összecsukható hátsó lámpák", "420" },
                    { 2, "L2", "Hátsó LED lámpa flexibilis Kilpi karokkal", "465" },
                    { 3, "L4", "Fix hátsó LED lámpák", "420" }
                });

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
                    { 2, "RWD+", "Robson WD dörzshajtás elektronikus vezérlőrendszerrel", "7600" },
                    { 3, "25WDF", "2WD agyhajtás (BB 250 az első tengelyen elektronikus vezérléssel", "0" },
                    { 4, "25WDR", "2WD agyhajtás (BB 250 a hátsó tengelyen elektronikus vezérléssel", "0" },
                    { 5, "RWD", "Robson WD dörzshajtás (traktor hidarulikáról)", "4845" },
                    { 6, "RWD+", "Robson WD dörzshajtás elektronikus vezérlőrendszerrel", "7170" }
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
                    { 10, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "8695" },
                    { 11, "A3", "Pótkocsi 3 pár rakoncával", "20215" },
                    { 12, "A4", "Pótkocsi 4 pár rakoncával", "20580" },
                    { 13, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "21200" },
                    { 14, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "21570" },
                    { 15, "A3", "Pótkocsi 3 pár rakoncával", "8080" },
                    { 16, "A4", "Pótkocsi 4 pár rakoncával", "8540" },
                    { 17, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "8755" },
                    { 18, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "9210" },
                    { 19, "A3", "Pótkocsi 3 pár rakoncával", "8830" },
                    { 20, "A4", "Pótkocsi 4 pár rakoncával", "9240" },
                    { 21, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "9860" },
                    { 22, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "10270" },
                    { 23, "A3", "Pótkocsi 3 pár rakoncával", "21315" },
                    { 24, "A4", "Pótkocsi 4 pár rakoncával", "21725" },
                    { 25, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "22345" },
                    { 26, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "22755" },
                    { 27, "A3", "Pótkocsi 3 pár rakoncával", "10880" },
                    { 28, "A4", "Pótkocsi 4 pár rakoncával", "11290" },
                    { 29, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "11910" },
                    { 30, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "12320" },
                    { 31, "A3", "Pótkocsi 3 pár rakoncával", "22955" },
                    { 32, "A4", "Pótkocsi 4 pár rakoncával", "23365" },
                    { 33, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "23985" },
                    { 34, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "24395" },
                    { 35, "A3", "Pótkocsi 3 pár rakoncával", "12665" },
                    { 36, "A4", "Pótkocsi 4 pár rakoncával", "13160" },
                    { 37, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "13810" },
                    { 38, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "14305" },
                    { 39, "A3", "Pótkocsi 3 pár rakoncával", "24740" },
                    { 40, "A4", "Pótkocsi 4 pár rakoncával", "25235" },
                    { 41, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "25885" },
                    { 42, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "26380" }
                });

            migrationBuilder.InsertData(
                table: "SupportLeg",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "SL", "Csapszeggel állítható kitámasztó láb a vonórúdon", "0" },
                    { 2, "SL", "Csapszeggel állítható kitámasztó láb a vonórúdon", "75" },
                    { 3, "SJ", "Tekerővel állítható kitámasztó láb a vonórúdon", "420" }
                });

            migrationBuilder.InsertData(
                table: "Tyre",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "WH2.6e", "400/60-15,5 standard felni, 6 lyukas, Starco", "1250" },
                    { 2, "WH2.6", "400/60-15,5 RF-felni, 6 lyukas, Starco", "1450" },
                    { 3, "WH4.6", "480/45-17 RF-felni, 6 lyukas, Starco", "2310" },
                    { 4, "WH4.8", "480/45-17 RF-felni, 8 lyukas, Starco (kérésre)", "0" },
                    { 5, "WH3.6", "500/50-17 RF-felni, 6 lyukas, BKT (kérésre)", "0" },
                    { 6, "WH3.6", "500/50-17 RF-felni, 6 lyukas, BKT", "2500" },
                    { 7, "WH3.8", "500/50-17 RF-felni, 8 lyukas, BKT", "2500" },
                    { 8, "WH5.6", "400/55-22,5 RF-felni, 6 lyukas, Alliance (kérésre)", "0" },
                    { 9, "WH5.6", "400/55-22,5 RF-felni, 6 lyukas, Alliance", "3215" },
                    { 10, "WH8.8", "500/55-22,5 RF-felni, 8 lyukas, BKT", "3770" },
                    { 11, "WH6.8", "550/45-22,5 RF-felni, 8 lyukas, BKT", "4010" },
                    { 12, "WH6.8V", "550/45-22,5 RF-felni, 8 lyukas, BKT - traktor mintás", "4410" },
                    { 13, "WH9.8V", "600/40-22,5 RF-felni, 8 lyukas, BKT - traktor mintás", "6425" },
                    { 14, "WH7.8", "600/50-22,5 RF-felni, 8 lyukas, Alliance", "5410" }
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
                    { 1, null, "Egy", null, 1, "890", "A PALMS 6S egyetlen gerendás erdészeti pótkocsi, melynek nominális teherbírása 6 tonna. Könnyű és kompakt kialakítása tökéletes választás kisebb traktorokhoz, ideális magán-erdőgazdálkodáshoz és gazdálkodóknak. A PALMS 6S hasonló technológiákat használ, mint nagyobb pótkocsijaink, beleértve a magas minőségű KTL és porfestési bevonatot, ami hosszabb élettartamot és nagyobb újraértékesítési értéket biztosít.", "1", "140x140x6", "-", "8500", null, "1,5", "3000", "35", "PALMS 6S", "", "400/60-15,5", "4900", null, "1950", null },
                    { 2, 1, "Egy", 1, 1, "1180", "A PALMS 8SX egyetlen gerendával rendelkező erdészeti utánfutó, amelynek nominális teherbírása 8 tonna. Ez a modell népszerű választás számos kis erdőbirtokos és gazdálkodó körében. Az utánfutó egyszerű, mégis robosztus kialakítása és tartóssága megbízható társává teszi különböző erdészeti és mezőgazdasági feladatokban.", "2", "160x160x8", "0,61", "10000", 1, "2", "3550", "47", "PALMS 8SX", "", "400/60-15,5", "5690", 2, "2070", 1 },
                    { 3, 1, "Dupla", 1, 1, "1510", "A PALMS 8D, amelynek nominális teherbírása 8 tonna, a legkompaktabb két gerendás utánfutó a termékpalettánkban. Azoknak a felhasználóknak terveztük, akik könnyebb utánfutót keresnek, de mégis szeretnének egy két gerendás utánfutó nagyobb szilárdságát és merevségét.", "2", "2x200x100x8", "0,85", "10000", 1, "1,95", "3975", "85", "PALMS 8D", "", "400/60-15,5", "6200", 1, "2095", 1 },
                    { 4, 1, "Dupla", 1, 1, "1510", "A PALMS 8D, amelynek nominális teherbírása 8 tonna, a legkompaktabb két gerendás utánfutó a termékpalettánkban. Azoknak a felhasználóknak terveztük, akik könnyebb utánfutót keresnek, de mégis szeretnének egy két gerendás utánfutó nagyobb szilárdságát és merevségét.", "2", "2x200x100x8", "0,85", "10000", 1, "1,95", "3975", "85", "PALMS 8DWD", "", "400/60-15,5", "6200", 1, "2095", 1 },
                    { 5, 1, "Egy", 1, 1, "1425", "A PALMS 9SC a termékpalettánk legnagyobb egygerendás utánfutója, 9 tonnás nominális teherbírással. Ideális választás azoknak a vásárlóknak, akik preferálják az egygerendás utánfutó egyszerűségét, miközben hosszabb hatótávot igényelnek egy erdészeti darutól. Ez a jellemző például népszerűvé teszi arboristák körében. Emellett a PALMS 9SC kiemelkedik a felhasználói kényelem terén más egygerendás utánfutók közül, gyorszárú vontatókar rendszerével és szabadalmaztatott tengelyzárjaival.", "2", "200x200x6", "0,70", "12000", 1, "2,15", "3870", "65", "PALMS 9SC", "", "400/60-15,5", "6095", 2, "2135", 1 },
                    { 6, 1, "Dupla", 1, 1, "1765", "A PALMS 10D, dupla gerendás vázú és 10 tonnás nominális teherbírású, az egyik legkelendőbb erdészeti utánfutó a PALMS terméksorozatában. Kiválóan párosítható a legtöbb PALMS daruval és további felszereléssel, lehetővé téve a testreszabást, hogy olyan beállítást hozzon létre, amely pontosan megfelel az elvárásainak.", "2", "2x200x100x8", "0,85", "13000", 1, "2,4", "3975", "85", "PALMS 10D", "", "400/60-15,5", "6200", 1, "2165", 1 },
                    { 7, 1, "Dupla", 1, 1, "1765", "A PALMS 10D, dupla gerendás vázú és 10 tonnás nominális teherbírású, az egyik legkelendőbb erdészeti utánfutó a PALMS terméksorozatában. Kiválóan párosítható a legtöbb PALMS daruval és további felszereléssel, lehetővé téve a testreszabást, hogy olyan beállítást hozzon létre, amely pontosan megfelel az elvárásainak.", "2", "2x200x100x8", "0,85", "12500", 1, "2,4", "3975", "85", "PALMS 10DWD", "", "400/60-15,5", "6200", 1, "2165", 1 },
                    { 8, 1, "Dupla", 1, 1, "2030", "A PALMS 12D egy erdészeti utánfutó, 12 tonnás nominális teherbírással és dupla gerendás vázzal. Kiváló választás mindennapi erdészeti feladatokhoz, nagyszerű kompatibilitást nyújtva a PALMS ötödik és hetedik sorozatú daruival.", "2", "2x200x100x8", "0,85", "15000", 1, "2,7", "3975", "85", "PALMS 12D", "", "500/50-17", "6200", 1, "2350", 1 },
                    { 9, 1, "Dupla", 1, 1, "2030", "A PALMS 12D egy erdészeti utánfutó, 12 tonnás nominális teherbírással és dupla gerendás vázzal. Kiváló választás mindennapi erdészeti feladatokhoz, nagyszerű kompatibilitást nyújtva a PALMS ötödik és hetedik sorozatú daruival.", "2", "2x200x100x8", "0,85", "15000", 1, "2,7", "3975", "85", "PALMS 12DWD", "", "500/50-17", "6200", 1, "2350", 1 },
                    { 10, 1, "Dupla", 1, 1, "2375", "A PALMS 14D a PALMS palettájának legnagyobb dupla gerendás utánfutója, jelentős 14 tonnás nominális teherbírással. A PALMS 14D nemcsak nagyobb terhelési területtel rendelkezik, hanem kiterjesztett terhelési területet is kínál más dupla gerendás utánfutókkal összehasonlítva. Emellett ez az utánfutó kompatibilis a PALMS zászlóshajójával, az X100-as erdészeti daruval.", "2", "2x200x120x10", "0,86", "18000", 1, "3,0", "4080", "112", "PALMS 14D", "", "500/50-17", "6300", 1, "2450", 1 },
                    { 11, 1, "Dupla", 1, 1, "2375", "A PALMS 14D a PALMS palettájának legnagyobb dupla gerendás utánfutója, jelentős 14 tonnás nominális teherbírással. A PALMS 14D nemcsak nagyobb terhelési területtel rendelkezik, hanem kiterjesztett terhelési területet is kínál más dupla gerendás utánfutókkal összehasonlítva. Emellett ez az utánfutó kompatibilis a PALMS zászlóshajójával, az X100-as erdészeti daruval.", "2", "2x200x120x10", "0,86", "18000", 1, "3,0", "4080", "112", "PALMS 14DWD", "", "500/50-17", "6300", 1, "2450", 1 }
                });

            migrationBuilder.InsertData(
                table: "BrakeTrailer",
                columns: new[] { "BrakeId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 5 },
                    { 2, 6 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 5 },
                    { 3, 6 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 5 },
                    { 4, 6 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 5 },
                    { 5, 6 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 5 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 5 },
                    { 8, 3 },
                    { 8, 6 },
                    { 9, 3 },
                    { 9, 6 },
                    { 10, 4 },
                    { 10, 7 },
                    { 10, 8 },
                    { 10, 9 },
                    { 10, 10 },
                    { 10, 11 },
                    { 11, 4 },
                    { 11, 7 },
                    { 11, 9 },
                    { 11, 11 },
                    { 12, 4 },
                    { 12, 7 },
                    { 12, 8 },
                    { 12, 9 },
                    { 12, 10 },
                    { 12, 11 },
                    { 13, 4 },
                    { 13, 7 },
                    { 13, 9 },
                    { 13, 11 },
                    { 14, 4 },
                    { 14, 7 },
                    { 14, 9 },
                    { 14, 11 },
                    { 15, 4 },
                    { 15, 7 },
                    { 15, 9 },
                    { 15, 11 },
                    { 16, 8 },
                    { 16, 10 },
                    { 17, 8 },
                    { 17, 10 },
                    { 18, 8 },
                    { 18, 10 },
                    { 19, 8 },
                    { 19, 10 }
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
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 8 },
                    { 4, 9 },
                    { 4, 10 },
                    { 4, 11 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 },
                    { 5, 8 },
                    { 5, 9 },
                    { 5, 10 },
                    { 5, 11 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 6, 8 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 7, 2 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 8, 11 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 3 },
                    { 9, 4 },
                    { 9, 5 },
                    { 9, 6 },
                    { 9, 7 },
                    { 9, 8 },
                    { 9, 9 },
                    { 9, 10 },
                    { 9, 11 }
                });

            migrationBuilder.InsertData(
                table: "LightTrailer",
                columns: new[] { "LightId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 }
                });

            migrationBuilder.InsertData(
                table: "OilPumpTrailer",
                columns: new[] { "OilPumpId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 8 },
                    { 4, 9 },
                    { 4, 10 },
                    { 4, 11 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 },
                    { 5, 8 },
                    { 5, 9 },
                    { 5, 10 },
                    { 5, 11 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 6, 8 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 7, 2 },
                    { 7, 3 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 7, 7 },
                    { 7, 8 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 11 }
                });

            migrationBuilder.InsertData(
                table: "OilTankTrailer",
                columns: new[] { "OilTankId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 8 },
                    { 4, 9 },
                    { 4, 10 },
                    { 4, 11 }
                });

            migrationBuilder.InsertData(
                table: "PlatformTrailer",
                columns: new[] { "PlatformId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "PropulsionTrailer",
                columns: new[] { "PropulsionId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 5 },
                    { 2, 3 },
                    { 2, 5 },
                    { 3, 4 },
                    { 3, 7 },
                    { 3, 9 },
                    { 3, 11 },
                    { 4, 4 },
                    { 4, 7 },
                    { 4, 9 },
                    { 4, 11 },
                    { 5, 6 },
                    { 5, 8 },
                    { 5, 10 },
                    { 6, 6 },
                    { 6, 8 },
                    { 6, 10 }
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
                    { 10, 3 },
                    { 11, 4 },
                    { 12, 4 },
                    { 13, 4 },
                    { 14, 4 },
                    { 15, 5 },
                    { 16, 5 },
                    { 17, 5 },
                    { 18, 5 },
                    { 19, 6 },
                    { 20, 6 },
                    { 21, 6 },
                    { 22, 6 },
                    { 23, 7 },
                    { 24, 7 },
                    { 25, 7 },
                    { 26, 7 },
                    { 27, 8 },
                    { 28, 8 },
                    { 29, 8 },
                    { 30, 8 },
                    { 31, 9 },
                    { 32, 9 },
                    { 33, 9 },
                    { 34, 9 },
                    { 35, 10 },
                    { 36, 10 },
                    { 37, 10 },
                    { 38, 10 },
                    { 39, 11 },
                    { 40, 11 },
                    { 41, 11 },
                    { 42, 11 }
                });

            migrationBuilder.InsertData(
                table: "SupportLegTrailer",
                columns: new[] { "SupportLegId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 }
                });

            migrationBuilder.InsertData(
                table: "TrailerCraneCompatibilities",
                columns: new[] { "Id", "Available", "CraneId", "FrameTypeId", "Recommended", "TrailerId" },
                values: new object[,]
                {
                    { 1, true, 1, 1, true, 1 },
                    { 2, true, 2, 1, true, 1 },
                    { 3, true, 3, 1, true, 1 }
                });

            migrationBuilder.InsertData(
                table: "TyreTrailer",
                columns: new[] { "TrailerId", "TyreId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 5 },
                    { 3, 8 }
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
                name: "IX_LightTrailer_TrailerId",
                table: "LightTrailer",
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
                name: "IX_SupportLegTrailer_TrailerId",
                table: "SupportLegTrailer",
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

            migrationBuilder.CreateIndex(
                name: "IX_TrailerCraneCompatibilities_CraneId",
                table: "TrailerCraneCompatibilities",
                column: "CraneId");

            migrationBuilder.CreateIndex(
                name: "IX_TrailerCraneCompatibilities_FrameTypeId",
                table: "TrailerCraneCompatibilities",
                column: "FrameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TrailerCraneCompatibilities_TrailerId",
                table: "TrailerCraneCompatibilities",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_TyreTrailer_TyreId",
                table: "TyreTrailer",
                column: "TyreId");
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
                name: "LightTrailer");

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
                name: "SupportLegTrailer");

            migrationBuilder.DropTable(
                name: "TrailerCraneCompatibilities");

            migrationBuilder.DropTable(
                name: "TyreTrailer");

            migrationBuilder.DropTable(
                name: "Brake");

            migrationBuilder.DropTable(
                name: "Drawbar");

            migrationBuilder.DropTable(
                name: "Light");

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
                name: "SupportLeg");

            migrationBuilder.DropTable(
                name: "Crane");

            migrationBuilder.DropTable(
                name: "FrameType");

            migrationBuilder.DropTable(
                name: "Trailer");

            migrationBuilder.DropTable(
                name: "Tyre");

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
