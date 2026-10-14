using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpannewmachines : Migration
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BolsterLock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoomGuard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoomGuard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brake",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brake", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BunkAdapter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BunkAdapter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BunkExtension",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BunkExtension", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChainsawHolder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChainsawHolder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ControlBlocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlBlocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cover",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cover", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CraneLight",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraneLight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CraneOilCooler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraneOilCooler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Damping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Damping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DBox",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBox", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drawbar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drawbar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElectricalFloating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalFloating", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FrameExtension",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameExtension", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FrameType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grapple",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    A = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grapple", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HandBrake",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HandBrake", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HayBaleFrame",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HayBaleFrame", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HighPerformanceOilFilter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HighPerformanceOilFilter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HoseGuard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoseGuard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HydroPack",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HydroPack", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HydroPackControl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HydroPackControl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JoystickHolder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoystickHolder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanAdjustableDrive",
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
                    table.PrimaryKey("PK_KrpanAdjustableDrive", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanAxeHolder",
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
                    table.PrimaryKey("PK_KrpanAxeHolder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanBaleTransportPlatform",
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
                    table.PrimaryKey("PK_KrpanBaleTransportPlatform", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanBBox",
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
                    table.PrimaryKey("PK_KrpanBBox", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanBrake",
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
                    table.PrimaryKey("PK_KrpanBrake", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanCardanShaft",
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
                    table.PrimaryKey("PK_KrpanCardanShaft", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanCargoSpaceExtension",
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
                    table.PrimaryKey("PK_KrpanCargoSpaceExtension", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanChainsawHolder",
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
                    table.PrimaryKey("PK_KrpanChainsawHolder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanChock",
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
                    table.PrimaryKey("PK_KrpanChock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanClutch",
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
                    table.PrimaryKey("PK_KrpanClutch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanCrane",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxReach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxReachWithGrabOpen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NetLiftingTorque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrutLiftingTorque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiftCapacityAtFourMeters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiftCapacityAtMaxReach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SlewTorque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SlewingAngle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SystemPressure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OilQuantityInTank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SlewCylinders = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelescopicStages = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanCrane", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanDrawbar",
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
                    table.PrimaryKey("PK_KrpanDrawbar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanDrawbarSteering",
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
                    table.PrimaryKey("PK_KrpanDrawbarSteering", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanDrawHead",
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
                    table.PrimaryKey("PK_KrpanDrawHead", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanExtension",
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
                    table.PrimaryKey("PK_KrpanExtension", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanExtraForwarderStanchion",
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
                    table.PrimaryKey("PK_KrpanExtraForwarderStanchion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanExtraStanchion",
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
                    table.PrimaryKey("PK_KrpanExtraStanchion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanFuelTankHolder",
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
                    table.PrimaryKey("PK_KrpanFuelTankHolder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanGrappleLocation",
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
                    table.PrimaryKey("PK_KrpanGrappleLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanHandBrake",
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
                    table.PrimaryKey("PK_KrpanHandBrake", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanHydraulicAdjustableChassis",
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
                    table.PrimaryKey("PK_KrpanHydraulicAdjustableChassis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanHydraulicSupportLeg",
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
                    table.PrimaryKey("PK_KrpanHydraulicSupportLeg", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanPlato",
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
                    table.PrimaryKey("PK_KrpanPlato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanPropulsion",
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
                    table.PrimaryKey("PK_KrpanPropulsion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanToolBox",
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
                    table.PrimaryKey("PK_KrpanToolBox", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanTopConnection",
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
                    table.PrimaryKey("PK_KrpanTopConnection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanTrailerLamp",
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
                    table.PrimaryKey("PK_KrpanTrailerLamp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanTrailerSupportLeg",
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
                    table.PrimaryKey("PK_KrpanTrailerSupportLeg", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanTyre",
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
                    table.PrimaryKey("PK_KrpanTyre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Linkage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linkage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManualBunkExtension",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualBunkExtension", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MOT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OilPump",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OilPump", x => x.Id);
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
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OilTank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperatorSeat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatorSeat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platform",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propulsion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProtectionSleeves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtectionSleeves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rotator",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rotator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RotatorBrake",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RotatorBrake", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shipping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stanchion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stanchion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StanchionExtension",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StanchionExtension", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupplyFormat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyFormat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupportBracket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportBracket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupportLeg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportLeg", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupportLegCounterPlate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportLegCounterPlate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Toolbox",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toolbox", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrailerLight",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrailerLight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrailerOilCooler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrailerOilCooler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TurningDeviceCounterPlate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurningDeviceCounterPlate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tyre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderrunProtection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ValveBlock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValveBlock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Winch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Winch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WoodControl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WoodControl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WoodSorter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WoodSorter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanTrailer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CentralBeams = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadingLength = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadingLengthWithExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalLength = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalLengthWithExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalWidth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrameSteeringCylinders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrawbarAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KrpanHydraulicAdjustableChassisId = table.Column<int>(type: "int", nullable: true),
                    KrpanTrailerLampId = table.Column<int>(type: "int", nullable: true),
                    KrpanChockId = table.Column<int>(type: "int", nullable: true),
                    KrpanDrawbarSteeringId = table.Column<int>(type: "int", nullable: true),
                    KrpanTrailerSupportLegId = table.Column<int>(type: "int", nullable: true),
                    KrpanAdjustableDriveId = table.Column<int>(type: "int", nullable: true),
                    KrpanHandBrakeId = table.Column<int>(type: "int", nullable: true),
                    KrpanDrawHeadId = table.Column<int>(type: "int", nullable: true),
                    KrpanExtraStanchionId = table.Column<int>(type: "int", nullable: true),
                    KrpanExtraForwarderStanchionId = table.Column<int>(type: "int", nullable: true),
                    KrpanTopConnectionId = table.Column<int>(type: "int", nullable: true),
                    KrpanCardanShaftId = table.Column<int>(type: "int", nullable: true),
                    KrpanBBoxId = table.Column<int>(type: "int", nullable: true),
                    KrpanBaleTransportPlatformId = table.Column<int>(type: "int", nullable: true),
                    KrpanCargoSpaceExtensionId = table.Column<int>(type: "int", nullable: true),
                    KrpanAxeHolderId = table.Column<int>(type: "int", nullable: true),
                    KrpanChainsawHolderId = table.Column<int>(type: "int", nullable: true),
                    KrpanFuelTankHolderId = table.Column<int>(type: "int", nullable: true),
                    KrpanToolBoxId = table.Column<int>(type: "int", nullable: true),
                    KrpanPlatoId = table.Column<int>(type: "int", nullable: true),
                    KrpanExtensionId = table.Column<int>(type: "int", nullable: true),
                    KrpanHydraulicSupportLegId = table.Column<int>(type: "int", nullable: true),
                    KrpanGrappleLocationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanTrailer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanAdjustableDrive_KrpanAdjustableDriveId",
                        column: x => x.KrpanAdjustableDriveId,
                        principalTable: "KrpanAdjustableDrive",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanAxeHolder_KrpanAxeHolderId",
                        column: x => x.KrpanAxeHolderId,
                        principalTable: "KrpanAxeHolder",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanBBox_KrpanBBoxId",
                        column: x => x.KrpanBBoxId,
                        principalTable: "KrpanBBox",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanBaleTransportPlatform_KrpanBaleTransportPlatformId",
                        column: x => x.KrpanBaleTransportPlatformId,
                        principalTable: "KrpanBaleTransportPlatform",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanCardanShaft_KrpanCardanShaftId",
                        column: x => x.KrpanCardanShaftId,
                        principalTable: "KrpanCardanShaft",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanCargoSpaceExtension_KrpanCargoSpaceExtensionId",
                        column: x => x.KrpanCargoSpaceExtensionId,
                        principalTable: "KrpanCargoSpaceExtension",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanChainsawHolder_KrpanChainsawHolderId",
                        column: x => x.KrpanChainsawHolderId,
                        principalTable: "KrpanChainsawHolder",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanChock_KrpanChockId",
                        column: x => x.KrpanChockId,
                        principalTable: "KrpanChock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanDrawHead_KrpanDrawHeadId",
                        column: x => x.KrpanDrawHeadId,
                        principalTable: "KrpanDrawHead",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanDrawbarSteering_KrpanDrawbarSteeringId",
                        column: x => x.KrpanDrawbarSteeringId,
                        principalTable: "KrpanDrawbarSteering",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanExtension_KrpanExtensionId",
                        column: x => x.KrpanExtensionId,
                        principalTable: "KrpanExtension",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanExtraForwarderStanchion_KrpanExtraForwarderStanchionId",
                        column: x => x.KrpanExtraForwarderStanchionId,
                        principalTable: "KrpanExtraForwarderStanchion",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanExtraStanchion_KrpanExtraStanchionId",
                        column: x => x.KrpanExtraStanchionId,
                        principalTable: "KrpanExtraStanchion",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanFuelTankHolder_KrpanFuelTankHolderId",
                        column: x => x.KrpanFuelTankHolderId,
                        principalTable: "KrpanFuelTankHolder",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanGrappleLocation_KrpanGrappleLocationId",
                        column: x => x.KrpanGrappleLocationId,
                        principalTable: "KrpanGrappleLocation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanHandBrake_KrpanHandBrakeId",
                        column: x => x.KrpanHandBrakeId,
                        principalTable: "KrpanHandBrake",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanHydraulicAdjustableChassis_KrpanHydraulicAdjustableChassisId",
                        column: x => x.KrpanHydraulicAdjustableChassisId,
                        principalTable: "KrpanHydraulicAdjustableChassis",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanHydraulicSupportLeg_KrpanHydraulicSupportLegId",
                        column: x => x.KrpanHydraulicSupportLegId,
                        principalTable: "KrpanHydraulicSupportLeg",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanPlato_KrpanPlatoId",
                        column: x => x.KrpanPlatoId,
                        principalTable: "KrpanPlato",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanToolBox_KrpanToolBoxId",
                        column: x => x.KrpanToolBoxId,
                        principalTable: "KrpanToolBox",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanTopConnection_KrpanTopConnectionId",
                        column: x => x.KrpanTopConnectionId,
                        principalTable: "KrpanTopConnection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanTrailerLamp_KrpanTrailerLampId",
                        column: x => x.KrpanTrailerLampId,
                        principalTable: "KrpanTrailerLamp",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KrpanTrailer_KrpanTrailerSupportLeg_KrpanTrailerSupportLegId",
                        column: x => x.KrpanTrailerSupportLegId,
                        principalTable: "KrpanTrailerSupportLeg",
                        principalColumn: "Id");
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
                    TelescopeLength = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SlewingCylinder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SlewingTorque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkingPressure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RotatorMaximumLoad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RotatorCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RotatorType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RotatorConnection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CraneWeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PillarSlewingAngle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecommendedOilFlow = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProtectionSleevesId = table.Column<int>(type: "int", nullable: true),
                    ElectricalFloatingId = table.Column<int>(type: "int", nullable: true),
                    ValveBlockId = table.Column<int>(type: "int", nullable: true),
                    LightId = table.Column<int>(type: "int", nullable: true),
                    OperatorSeatId = table.Column<int>(type: "int", nullable: true),
                    CraneOilCoolerId = table.Column<int>(type: "int", nullable: true),
                    JoystickHolderId = table.Column<int>(type: "int", nullable: true),
                    TurningDeviceCounterPlateId = table.Column<int>(type: "int", nullable: true),
                    SupportLegCounterPlateId = table.Column<int>(type: "int", nullable: true),
                    BoomGuardId = table.Column<int>(type: "int", nullable: true),
                    CoverId = table.Column<int>(type: "int", nullable: true),
                    WoodControlId = table.Column<int>(type: "int", nullable: true),
                    LinkageId = table.Column<int>(type: "int", nullable: true),
                    SupportBracketId = table.Column<int>(type: "int", nullable: true),
                    ShippingId = table.Column<int>(type: "int", nullable: true),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crane", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Crane_BoomGuard_BoomGuardId",
                        column: x => x.BoomGuardId,
                        principalTable: "BoomGuard",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Crane_Cover_CoverId",
                        column: x => x.CoverId,
                        principalTable: "Cover",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Crane_CraneLight_LightId",
                        column: x => x.LightId,
                        principalTable: "CraneLight",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Crane_CraneOilCooler_CraneOilCoolerId",
                        column: x => x.CraneOilCoolerId,
                        principalTable: "CraneOilCooler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Crane_ElectricalFloating_ElectricalFloatingId",
                        column: x => x.ElectricalFloatingId,
                        principalTable: "ElectricalFloating",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Crane_JoystickHolder_JoystickHolderId",
                        column: x => x.JoystickHolderId,
                        principalTable: "JoystickHolder",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Crane_Linkage_LinkageId",
                        column: x => x.LinkageId,
                        principalTable: "Linkage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Crane_OperatorSeat_OperatorSeatId",
                        column: x => x.OperatorSeatId,
                        principalTable: "OperatorSeat",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Crane_ProtectionSleeves_ProtectionSleevesId",
                        column: x => x.ProtectionSleevesId,
                        principalTable: "ProtectionSleeves",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Crane_Shipping_ShippingId",
                        column: x => x.ShippingId,
                        principalTable: "Shipping",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Crane_SupportBracket_SupportBracketId",
                        column: x => x.SupportBracketId,
                        principalTable: "SupportBracket",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Crane_SupportLegCounterPlate_SupportLegCounterPlateId",
                        column: x => x.SupportLegCounterPlateId,
                        principalTable: "SupportLegCounterPlate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Crane_TurningDeviceCounterPlate_TurningDeviceCounterPlateId",
                        column: x => x.TurningDeviceCounterPlateId,
                        principalTable: "TurningDeviceCounterPlate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Crane_ValveBlock_ValveBlockId",
                        column: x => x.ValveBlockId,
                        principalTable: "ValveBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Crane_WoodControl_WoodControlId",
                        column: x => x.WoodControlId,
                        principalTable: "WoodControl",
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
                    TrailerOilCoolerId = table.Column<int>(type: "int", nullable: true),
                    BolsterLockId = table.Column<int>(type: "int", nullable: true),
                    BBoxId = table.Column<int>(type: "int", nullable: true),
                    DBoxId = table.Column<int>(type: "int", nullable: true),
                    HayBaleFrameId = table.Column<int>(type: "int", nullable: true),
                    WoodSorterId = table.Column<int>(type: "int", nullable: true),
                    HandBrakeId = table.Column<int>(type: "int", nullable: true),
                    ChainsawHolderId = table.Column<int>(type: "int", nullable: true),
                    UnderrunProtectionId = table.Column<int>(type: "int", nullable: true),
                    BunkAdapterId = table.Column<int>(type: "int", nullable: true),
                    BunkExtensionId = table.Column<int>(type: "int", nullable: true),
                    ManualBunkExtensionId = table.Column<int>(type: "int", nullable: true),
                    FrameExtensionId = table.Column<int>(type: "int", nullable: true),
                    ShippingId = table.Column<int>(type: "int", nullable: true),
                    MOTId = table.Column<int>(type: "int", nullable: true),
                    StanchionExtensionId = table.Column<int>(type: "int", nullable: true),
                    HydropackControlId = table.Column<int>(type: "int", nullable: true),
                    ToolboxId = table.Column<int>(type: "int", nullable: true),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                        name: "FK_Trailer_BunkAdapter_BunkAdapterId",
                        column: x => x.BunkAdapterId,
                        principalTable: "BunkAdapter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_BunkExtension_BunkExtensionId",
                        column: x => x.BunkExtensionId,
                        principalTable: "BunkExtension",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_ChainsawHolder_ChainsawHolderId",
                        column: x => x.ChainsawHolderId,
                        principalTable: "ChainsawHolder",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_DBox_DBoxId",
                        column: x => x.DBoxId,
                        principalTable: "DBox",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_FrameExtension_FrameExtensionId",
                        column: x => x.FrameExtensionId,
                        principalTable: "FrameExtension",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_HandBrake_HandBrakeId",
                        column: x => x.HandBrakeId,
                        principalTable: "HandBrake",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_HayBaleFrame_HayBaleFrameId",
                        column: x => x.HayBaleFrameId,
                        principalTable: "HayBaleFrame",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_HydroPackControl_HydropackControlId",
                        column: x => x.HydropackControlId,
                        principalTable: "HydroPackControl",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_MOT_MOTId",
                        column: x => x.MOTId,
                        principalTable: "MOT",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_ManualBunkExtension_ManualBunkExtensionId",
                        column: x => x.ManualBunkExtensionId,
                        principalTable: "ManualBunkExtension",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_Shipping_ShippingId",
                        column: x => x.ShippingId,
                        principalTable: "Shipping",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_StanchionExtension_StanchionExtensionId",
                        column: x => x.StanchionExtensionId,
                        principalTable: "StanchionExtension",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_Toolbox_ToolboxId",
                        column: x => x.ToolboxId,
                        principalTable: "Toolbox",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_TrailerOilCooler_TrailerOilCoolerId",
                        column: x => x.TrailerOilCoolerId,
                        principalTable: "TrailerOilCooler",
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
                name: "KrpanBrakeTrailer",
                columns: table => new
                {
                    KrpanBrakeId = table.Column<int>(type: "int", nullable: false),
                    KrpanTrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanBrakeTrailer", x => new { x.KrpanBrakeId, x.KrpanTrailerId });
                    table.ForeignKey(
                        name: "FK_KrpanBrakeTrailer_KrpanBrake_KrpanBrakeId",
                        column: x => x.KrpanBrakeId,
                        principalTable: "KrpanBrake",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KrpanBrakeTrailer_KrpanTrailer_KrpanTrailerId",
                        column: x => x.KrpanTrailerId,
                        principalTable: "KrpanTrailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KrpanClutchTrailer",
                columns: table => new
                {
                    KrpanClutchId = table.Column<int>(type: "int", nullable: false),
                    KrpanTrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanClutchTrailer", x => new { x.KrpanClutchId, x.KrpanTrailerId });
                    table.ForeignKey(
                        name: "FK_KrpanClutchTrailer_KrpanClutch_KrpanClutchId",
                        column: x => x.KrpanClutchId,
                        principalTable: "KrpanClutch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KrpanClutchTrailer_KrpanTrailer_KrpanTrailerId",
                        column: x => x.KrpanTrailerId,
                        principalTable: "KrpanTrailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KrpanCraneTrailer",
                columns: table => new
                {
                    KrpanCraneId = table.Column<int>(type: "int", nullable: false),
                    KrpanTrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanCraneTrailer", x => new { x.KrpanCraneId, x.KrpanTrailerId });
                    table.ForeignKey(
                        name: "FK_KrpanCraneTrailer_KrpanCrane_KrpanCraneId",
                        column: x => x.KrpanCraneId,
                        principalTable: "KrpanCrane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KrpanCraneTrailer_KrpanTrailer_KrpanTrailerId",
                        column: x => x.KrpanTrailerId,
                        principalTable: "KrpanTrailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KrpanDrawbarTrailer",
                columns: table => new
                {
                    KrpanDrawbarId = table.Column<int>(type: "int", nullable: false),
                    KrpanTrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanDrawbarTrailer", x => new { x.KrpanDrawbarId, x.KrpanTrailerId });
                    table.ForeignKey(
                        name: "FK_KrpanDrawbarTrailer_KrpanDrawbar_KrpanDrawbarId",
                        column: x => x.KrpanDrawbarId,
                        principalTable: "KrpanDrawbar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KrpanDrawbarTrailer_KrpanTrailer_KrpanTrailerId",
                        column: x => x.KrpanTrailerId,
                        principalTable: "KrpanTrailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KrpanPropulsionTrailer",
                columns: table => new
                {
                    KrpanPropulsionId = table.Column<int>(type: "int", nullable: false),
                    KrpanTrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanPropulsionTrailer", x => new { x.KrpanPropulsionId, x.KrpanTrailerId });
                    table.ForeignKey(
                        name: "FK_KrpanPropulsionTrailer_KrpanPropulsion_KrpanPropulsionId",
                        column: x => x.KrpanPropulsionId,
                        principalTable: "KrpanPropulsion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KrpanPropulsionTrailer_KrpanTrailer_KrpanTrailerId",
                        column: x => x.KrpanTrailerId,
                        principalTable: "KrpanTrailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KrpanTyreTrailer",
                columns: table => new
                {
                    KrpanTrailerId = table.Column<int>(type: "int", nullable: false),
                    KrpanTyreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanTyreTrailer", x => new { x.KrpanTrailerId, x.KrpanTyreId });
                    table.ForeignKey(
                        name: "FK_KrpanTyreTrailer_KrpanTrailer_KrpanTrailerId",
                        column: x => x.KrpanTrailerId,
                        principalTable: "KrpanTrailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KrpanTyreTrailer_KrpanTyre_KrpanTyreId",
                        column: x => x.KrpanTyreId,
                        principalTable: "KrpanTyre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ControlBlockCrane",
                columns: table => new
                {
                    ControlBlockId = table.Column<int>(type: "int", nullable: false),
                    CraneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlBlockCrane", x => new { x.ControlBlockId, x.CraneId });
                    table.ForeignKey(
                        name: "FK_ControlBlockCrane_ControlBlocks_ControlBlockId",
                        column: x => x.ControlBlockId,
                        principalTable: "ControlBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ControlBlockCrane_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DampingCrane",
                columns: table => new
                {
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    DampingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DampingCrane", x => new { x.CraneId, x.DampingId });
                    table.ForeignKey(
                        name: "FK_DampingCrane_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DampingCrane_Damping_DampingId",
                        column: x => x.DampingId,
                        principalTable: "Damping",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FrameTypeCrane",
                columns: table => new
                {
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    FrameTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameTypeCrane", x => new { x.CraneId, x.FrameTypeId });
                    table.ForeignKey(
                        name: "FK_FrameTypeCrane_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FrameTypeCrane_FrameType_FrameTypeId",
                        column: x => x.FrameTypeId,
                        principalTable: "FrameType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GrappleCrane",
                columns: table => new
                {
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    GrappleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrappleCrane", x => new { x.CraneId, x.GrappleId });
                    table.ForeignKey(
                        name: "FK_GrappleCrane_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrappleCrane_Grapple_GrappleId",
                        column: x => x.GrappleId,
                        principalTable: "Grapple",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HighPerformanceOilFilterCrane",
                columns: table => new
                {
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    HighPerformanceOilFilterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HighPerformanceOilFilterCrane", x => new { x.CraneId, x.HighPerformanceOilFilterId });
                    table.ForeignKey(
                        name: "FK_HighPerformanceOilFilterCrane_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HighPerformanceOilFilterCrane_HighPerformanceOilFilter_HighPerformanceOilFilterId",
                        column: x => x.HighPerformanceOilFilterId,
                        principalTable: "HighPerformanceOilFilter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoseGuardCrane",
                columns: table => new
                {
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    HoseGuardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoseGuardCrane", x => new { x.CraneId, x.HoseGuardId });
                    table.ForeignKey(
                        name: "FK_HoseGuardCrane_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoseGuardCrane_HoseGuard_HoseGuardId",
                        column: x => x.HoseGuardId,
                        principalTable: "HoseGuard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RotatorBrakeCrane",
                columns: table => new
                {
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    RotatorBrakeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RotatorBrakeCrane", x => new { x.CraneId, x.RotatorBrakeId });
                    table.ForeignKey(
                        name: "FK_RotatorBrakeCrane_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RotatorBrakeCrane_RotatorBrake_RotatorBrakeId",
                        column: x => x.RotatorBrakeId,
                        principalTable: "RotatorBrake",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RotatorCrane",
                columns: table => new
                {
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    RotatorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RotatorCrane", x => new { x.CraneId, x.RotatorId });
                    table.ForeignKey(
                        name: "FK_RotatorCrane_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RotatorCrane_Rotator_RotatorId",
                        column: x => x.RotatorId,
                        principalTable: "Rotator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WinchCrane",
                columns: table => new
                {
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    WinchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinchCrane", x => new { x.CraneId, x.WinchId });
                    table.ForeignKey(
                        name: "FK_WinchCrane_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WinchCrane_Winch_WinchId",
                        column: x => x.WinchId,
                        principalTable: "Winch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "HydroPackTrailer",
                columns: table => new
                {
                    HydroPackId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HydroPackTrailer", x => new { x.HydroPackId, x.TrailerId });
                    table.ForeignKey(
                        name: "FK_HydroPackTrailer_HydroPack_HydroPackId",
                        column: x => x.HydroPackId,
                        principalTable: "HydroPack",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HydroPackTrailer_Trailer_TrailerId",
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
                        name: "FK_LightTrailer_TrailerLight_LightId",
                        column: x => x.LightId,
                        principalTable: "TrailerLight",
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
                name: "SupplyFormatTrailer",
                columns: table => new
                {
                    SupplyFormatId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyFormatTrailer", x => new { x.SupplyFormatId, x.TrailerId });
                    table.ForeignKey(
                        name: "FK_SupplyFormatTrailer_SupplyFormat_SupplyFormatId",
                        column: x => x.SupplyFormatId,
                        principalTable: "SupplyFormat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyFormatTrailer_Trailer_TrailerId",
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
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "Bbox", "[\"PALMS-trailer-bbox-1\",\"PALMS-trailer-bbox-2\",\"PALMS-trailer-bbox-3\",\"PALMS-trailer-bbox-4\",\"PALMS-trailer-bbox-5\",\"PALMS-trailer-bbox-6\"]", "Biomasszás boksz 4 mm-es Strenx acélból", "2825", "[\"4irHQzQZYHM\"]" },
                    { 2, "Bbox", "[\"PALMS-trailer-bbox-1\",\"PALMS-trailer-bbox-2\",\"PALMS-trailer-bbox-3\",\"PALMS-trailer-bbox-4\",\"PALMS-trailer-bbox-5\",\"PALMS-trailer-bbox-6\"]", "Biomasszás boksz 4 mm-es Strenx acélból", "3150", "[\"4irHQzQZYHM\"]" },
                    { 3, "Bbox", "[\"PALMS-trailer-bbox-1\",\"PALMS-trailer-bbox-2\",\"PALMS-trailer-bbox-3\",\"PALMS-trailer-bbox-4\",\"PALMS-trailer-bbox-5\",\"PALMS-trailer-bbox-6\"]", "Biomasszás boksz 4 mm-es Strenx acélból", "3360", "[\"4irHQzQZYHM\"]" },
                    { 4, "Bbox", "[\"PALMS-trailer-bbox-1\",\"PALMS-trailer-bbox-2\",\"PALMS-trailer-bbox-3\",\"PALMS-trailer-bbox-4\",\"PALMS-trailer-bbox-5\",\"PALMS-trailer-bbox-6\"]", "Biomasszás boksz 4 mm-es Strenx acélból", "3200", "[\"4irHQzQZYHM\"]" },
                    { 5, "Bbox", "[\"PALMS-trailer-bbox-1\",\"PALMS-trailer-bbox-2\",\"PALMS-trailer-bbox-3\",\"PALMS-trailer-bbox-4\",\"PALMS-trailer-bbox-5\",\"PALMS-trailer-bbox-6\"]", "Biomasszás boksz 2mm HARDOX", "1000", "[\"4irHQzQZYHM\"]" }
                });

            migrationBuilder.InsertData(
                table: "BolsterLock",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "BL", "[\"PALMS-trailer-bolster-lock-1\",\"PALMS-trailer-bolster-lock-2\",\"PALMS-trailer-bolster-lock-3\"]", "Rakonca rögzítő az első pár rakoncához", "0", null });

            migrationBuilder.InsertData(
                table: "BoomGuard",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "BG5", "[\"PALMS-crane-boom-guard-BG5-BG7-1\",\"PALMS-crane-boom-guard-BG5-BG7-2\"]", "Főgém védő az 5-ös szériához", "630", null },
                    { 2, "BG7", "[\"PALMS-crane-boom-guard-BG5-BG7-1\",\"PALMS-crane-boom-guard-BG5-BG7-2\"]", "Főgém védő a 7-es szériához", "650", null },
                    { 3, "BG10", "[\"PALMS-crane-boom-guard-BG10\"]", "Főgém védő X100-hoz", "675", "[\"LfALbXK_8F4\\u0026t\"]" }
                });

            migrationBuilder.InsertData(
                table: "Brake",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "B0", null, "Fék nélkül", "0", null },
                    { 2, "B1", "[\"PALMS-trailer-brake-1\"]", "2 keréken hidraulikus fék", "960", null },
                    { 3, "B2", "[\"PALMS-trailer-brake-2\"]", "4 keréken hidraulikus fék", "1870", null },
                    { 4, "B3", "[\"PALMS-trailer-brake-3\"]", "2 keréken légfék", "1620", null },
                    { 5, "B4", "[\"PALMS-trailer-brake-4\"]", "4 keréken légfék", "2710", null },
                    { 6, "BA-EU", null, "EU jóváhagyott szett, légfék 2 keréken, PB1", "2100", null },
                    { 7, "BH-EU", null, "EU jóváhagyott szett, hidraulikus fék, PB1", "3450", null },
                    { 8, "BA-EU", null, "EU jóváhagyott szett, légfék 4 keréken, PB1", "3195", null },
                    { 9, "BH-EU", null, "EU jóváhagyott szett, hidraulikus fék, PB1", "4360", null },
                    { 10, "B1", "[\"PALMS-trailer-brake-1\"]", "2 keréken hidraulikus fék", "1155", null },
                    { 11, "B2", "[\"PALMS-trailer-brake-2\"]", "4 keréken hidraulikus fék", "2205", null },
                    { 12, "B3", "[\"PALMS-trailer-brake-3\"]", "2 keréken légfék", "1815", null },
                    { 13, "B4", "[\"PALMS-trailer-brake-4\"]", "4 keréken légfék", "3045", null },
                    { 14, "BA-EU", null, "EU jóváhagyott szett, légfék 4 keréken, PB1", "3530", null },
                    { 15, "BH-EU", null, "EU jóváhagyott szett, hidraulikus fék, PB1", "4695", null },
                    { 16, "B1", "[\"PALMS-trailer-brake-1\"]", "2 keréken hidraulikus fék", "3150", null },
                    { 17, "B2", "[\"PALMS-trailer-brake-2\"]", "4 keréken hidraulikus fék", "6195", null },
                    { 18, "B3", "[\"PALMS-trailer-brake-3\"]", "2 keréken légfék", "3810", null },
                    { 19, "B4", "[\"PALMS-trailer-brake-4\"]", "4 keréken légfék", "7035", null },
                    { 20, "BA-EU", null, "EU jóváhagyott szett, légfék 4 keréken, PB1", "7520", null },
                    { 21, "BH-EU", null, "EU jóváhagyott szett, hidraulikus fék, PB1", "8685", null },
                    { 22, "B3", "[\"PALMS-trailer-brake-3\"]", "2 keréken légfék", "3625", null },
                    { 23, "B2", "[\"PALMS-trailer-brake-2\"]", "4 keréken hidraulikus többtárcsás fék (sebességváltón keresztül)", "250", null },
                    { 24, "B4", "[\"PALMS-trailer-brake-4\"]", "4 kerék légfék (hidraulikusan működtetett, többtárcsás, sebességváltón keresztül)", "3035", null }
                });

            migrationBuilder.InsertData(
                table: "BunkAdapter",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "PA", "[\"PALMS-trailer-bunk-adapter-1\",\"PALMS-trailer-bunk-adapter-2\",\"PALMS-trailer-bunk-adapter-3\"]", "Forwarder típusú bunk adapter a raktér szélesítéshez 300 mm - 1 db", "150", null },
                    { 2, "PA", "[\"PALMS-trailer-bunk-adapter-1\",\"PALMS-trailer-bunk-adapter-2\",\"PALMS-trailer-bunk-adapter-3\"]", "Forwarder típusú bunk adapter a raktér szélesítéshez 300 mm - 1 db", "140", null }
                });

            migrationBuilder.InsertData(
                table: "BunkExtension",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "PA-H", "[\"PALMS-trailer-bunk-extension-1\",\"PALMS-trailer-bunk-extension-2\"]", "Forwarder típusú hidraulikus bunk szélesítés - 1 db", "1250", "[\"d8Ivy0QkSVU\"]" },
                    { 2, "PA-H", "[\"PALMS-trailer-bunk-extension-1\",\"PALMS-trailer-bunk-extension-2\"]", "Forwarder típusú hidraulikus bunk szélesítés - 1 db", "595", "[\"d8Ivy0QkSVU\"]" }
                });

            migrationBuilder.InsertData(
                table: "ChainsawHolder",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "MSH", "[\"PALMS-trailer-chainsawholder-1\",\"PALMS-trailer-chainsawholder-2\"]", "Láncfűrész tartó", "65", null });

            migrationBuilder.InsertData(
                table: "ControlBlocks",
                columns: new[] { "Id", "Code", "Description", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "A3.1", "Egyszerű és megbízható szelepblokk kisebb daruk számára", "[\"PALMS-crane-control-block-A3.1\"]", "A3.1 6/8 XY vezértömb, BLB BM50 (50l/perc), 195 bar", "870", null },
                    { 2, "A4", "Szelepblokk az egyszerűbb daruvezérlést kedvelő ügyfelek számára", "[\"PALMS-crane-control-block-A4-A4.2\"]", "A4 4/8 XY+2x el.on-off vezértömb, Hydro-control D3M, 195 bar", "1500", null },
                    { 3, "A4.2", "Szelepblokk az egyszerűbb daruvezérlést kedvelő ügyfelek számára", "[\"PALMS-crane-control-block-A4-A4.2\"]", "A4.2 4/8 XY+2x el.on-off vezértömb, Bucher HDS16, 215 bar", "1500", null },
                    { 4, "A7", "Szelepblokk az egyszerűbb daruvezérlést kedvelő ügyfelek számára", "[\"PALMS-crane-control-block-A7\"]", "A7 4/8 XYZ vezértömb, Hydro-control, 195 bar (215 bar kérésre)", "1480", null },
                    { 5, "A12", "Leginkább a PALMS 5. és 7. sorozatú darukkal használható", "[\"PALMS-crane-control-block-A12-A14\"]", "A12 2/8 Pre-hidraulikus, +2x el.propo, Walvoil DPX100 (max. 120 l/min), 215 bar + HPF", "4720", null },
                    { 6, "A14", "Leginkább a PALMS 5. és 7. sorozatú darukkal használható", "[\"PALMS-crane-control-block-A12-A14\"]", "A14 2/8 Pre-hydraulic, +2x el.propo, Parker L90, 215 bar + HPF", "6295", null },
                    { 7, "A19", "Leginkább a PALMS 5. és 7. sorozatú darukkal használható", "[\"PALMS-crane-control-block-A19\"]", "A19 El.propo 8 szekciós, Walvoil DPX100, joystick, 215 bar + HPF", "6295", null },
                    { 8, "A23", "Parker LC6 mini joystickek. Leginkább PALMS 5., 7. és X-sorozatú darukhoz használják", "[\"PALMS-crane-control-block-A23\"]", "A23 El.propo 8 szekciós, IQAN LC6, mini joystick-ok, (LS komp.) + Parker L90pro, 215/240 bar + HPF", "8470", null },
                    { 9, "A235", "Leginkább a PALMS 5. és 7. sorozatú darukkal használható", "[\"PALMS-crane-control-block-A235\"]", "A235 El.propo 8 szekciós, IQAN LC5 joystick-ok, (LS komp) Parker L90pro, 215/240 bar + HPF", "8470", null },
                    { 10, "A25.1", "Parker LC6 mini joystick kijelzővel", "[\"PALMS-crane-control-block-A25.1\"]", "A25.1 El.propo 8 szekciós (A23) + MD3 kijelző + HPF", "9415", null },
                    { 11, "A26", "IMET rádió vezérlés PALMS erdészeti daruhoz", "[\"PALMS-crane-control-block-A26\"]", "A26 IMET rádió távirányítás, (LS komp.) Parker L90pro (max. 150 l/min.), 215/240 bar + HPF", "9110", null },
                    { 12, "A36", "IMET rádióvezérlés Parker LC6 mini joystickekkel", "[\"PALMS-crane-control-block-A36\"]", "A36 Combi control (rádió távirányítás+A23),Parker  L90pro, 215/240 bar + HPF", "11840", null },
                    { 13, "A36.1", "IMET rádióvezérlés és Parker LC6 mini joystick kijelzővel", "[\"PALMS-crane-control-block-A36.1\"]", "A36.1 Combi control (rádió távirányítás+A23),Parker  L90pro, 215/240 bar + MD3 kijelző + HPF", "12785", null },
                    { 14, "A42", "Standard üzemmód, ahol a fő emelőhenger, a hosszabbító gém hengere és a teleszkóp hengere külön vezérelhető.\r\nPTC mód, ahol a markoló lineárisan mozgatható X, Y és Z irányban.", "[\"PALMS-crane-control-block-A42\"]", "A42 Palms Tip Control, IQAN joystickok, MD4 - 7 inch-es kijelző, Parker L90pro, 215/240 bar + HPF", "14660", null },
                    { 15, "A3.1", "Egyszerű és megbízható szelepblokk kisebb daruk számára", "[\"PALMS-crane-control-block-A3.1\"]", "A3.1 - 6/8 XY vezértömb, BLB BM50 (50 l/min.) 195 bar", "870", null },
                    { 16, "A3.1", "Egyszerű és megbízható szelepblokk kisebb daruk számára", "[\"PALMS-crane-control-block-A3.1\"]", "A3.1 - 6/8 XY vezértömb, BLB BM50 (50 l/min.) 180 bar", "870", null }
                });

            migrationBuilder.InsertData(
                table: "Cover",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "JKK", "[\"PALMS-crane-cover-1\"]", "Védőhuzat bőrből A2-A7-es, A11-es, A12-es és A14-es vezértömbökhöz", "60", null });

            migrationBuilder.InsertData(
                table: "CraneLight",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "L1", "[\"PALMS-crane-light-1\",\"PALMS-crane-light-2\"]", "LED munkalámpák a darugémre, 2 db", "510", null },
                    { 2, "L1", "[\"PALMS-crane-light-1\",\"PALMS-crane-light-2\"]", "LED munkalámpák a darugémre, 1 db", "335", null }
                });

            migrationBuilder.InsertData(
                table: "CraneOilCooler",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "CP1", "[\"PALMS-crane-oil-cooler-1\"]", "Olajhűtő csomag elektromos csatlakozással a traktorhoz", "1035", null });

            migrationBuilder.InsertData(
                table: "DBox",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "Dbox", "[\"PALMS-trailer-dbox-1\"]", "Billenős boksz HARDOX", "2615", null });

            migrationBuilder.InsertData(
                table: "Damping",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "D1", "[\"PALMS-crane-damping-1\",\"PALMS-crane-damping-2\"]", "Csillapító a munkahenger elforgatáshoz", "945", null },
                    { 2, "D2", "[\"PALMS-crane-damping-1\",\"PALMS-crane-damping-2\"]", "Csillapító a munkahenger elforgatáshoz és emeléshez", "1610", null },
                    { 3, "D3", "[\"PALMS-crane-damping-1\",\"PALMS-crane-damping-2\"]", "Csillapító emeléshez", "665", null }
                });

            migrationBuilder.InsertData(
                table: "Drawbar",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "C1", "[\"PALMS-trailer-drawbar-C1\"]", "Skandináv típusú forgó vonórúd", "0", null },
                    { 2, "C2", "[\"PALMS-trailer-drawbar-C2\"]", "Német típusú magas vonórúd vonószem nélkül", "0", null },
                    { 3, "C3", "[\"PALMS-trailer-drawbar-C3\"]", "Osztrák típusú alacsony vonórúd vonószem nélkül", "0", null },
                    { 4, "C4", "[\"PALMS-trailer-drawbar-C4\"]", "Német típusú magas vonórúd vonószemmel", "275", null },
                    { 5, "C5", "[\"PALMS-trailer-drawbar-C5\"]", "Osztrák típusú alacsony vonórúd vonószemmel", "275", null },
                    { 6, "C6", "[\"PALMS-trailer-drawbar-C6\"]", "Német típusú magas vonórúd vonószemmel (P1-P3 szivattyúhoz)", "430", null },
                    { 7, "C7", "[\"PALMS-trailer-drawbar-C7\"]", "Magas ráfutófékes vonórúd vonószemmel, kábelekkel és 2 kerék fékkel", "1675", null },
                    { 8, "C8", "[\"PALMS-trailer-drawbar-C8\"]", "K-80 típusú alacsony vonórúd vonószemmel", "470", null },
                    { 9, "C9", "[\"PALMS-trailer-drawbar-C9\"]", "Osztrák típusú alacsony vonórúd elforduló vonószemmel", "525", null },
                    { 10, "C5", "[\"PALMS-trailer-drawbar-C5\"]", "Osztrák típusú alacsony vonórúd vonószemmel", "315", null },
                    { 11, "C8", "[\"PALMS-trailer-drawbar-C8\"]", "K-80 típusú alacsony vonórúd vonószemmel", "535", null },
                    { 12, "C9", "[\"PALMS-trailer-drawbar-C9\"]", "Osztrák típusú alacsony vonórúd elforduló vonószemmel", "500", null },
                    { 13, "CY", "[\"PALMS-trailer-drawbar-CY\"]", "Y vonórúd Jake rögzítő csatlakozókkal (Valtra-hoz, egyéb traktorokhoz igény szerint) elektromos vezérléssel", "8500", null },
                    { 14, "C1", "[\"PALMS-trailer-drawbar-C1\"]", "Normál típusú vonórúd K50-es vonófejjel", "0", null },
                    { 15, "C1.1", null, "Normál típusú vonórúd D35-ös vonófejjel", "0", null }
                });

            migrationBuilder.InsertData(
                table: "ElectricalFloating",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "FP", "[\"PALMS-crane-electrical-floating-1\"]", "Elektromos úszó pozíció emelő és fordító funkcióhoz (A11-A41 vezértömbhöz)", "1065", null });

            migrationBuilder.InsertData(
                table: "FrameExtension",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "HEX", "[\"PALMS-trailer-frame-extension-1\"]", "Hidraulikus henger a keret meghosszabbításához", "210", null },
                    { 2, "LF", null, "Raktér hosszabbítás (100mm-enként)", "0", null }
                });

            migrationBuilder.InsertData(
                table: "FrameType",
                columns: new[] { "Id", "Code", "ImageUrls", "Mass", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "B0", null, "", "Talpaló nélkül", "0", null },
                    { 2, "B2.1", "[\"PALMS-crane-frame-type-B2.1-1\",\"PALMS-crane-frame-type-B2.1-2\",\"PALMS-crane-frame-type-B2.1-3\"]", "174", "A típusú kis letalpaló, 3 pontos csatlakozással", "1575", null },
                    { 3, "B3", "[\"PALMS-crane-frame-type-B3-1\",\"PALMS-crane-frame-type-B3-2\",\"PALMS-crane-frame-type-B3-3\"]", "313", "B3, A típusú normál méretű letalpaló, 3 pontos csatlakozással", "2100", null },
                    { 4, "B4", "[\"PALMS-crane-frame-type-B4-1\",\"PALMS-crane-frame-type-B4-2\",\"PALMS-crane-frame-type-B4-3\"]", "237", "FD típusú economy talpaló (csak 7SX, 8SX és 9SC pótkocsikhoz)", "2100", null },
                    { 5, "B6", "[\"PALMS-crane-frame-type-B6-1\",\"PALMS-crane-frame-type-B6-2\",\"PALMS-crane-frame-type-B6-3\"]", "449", "B6, FD típusú letalpaló, 3 pontos csatlakozással", "3005", null },
                    { 6, "B9", "[\"PALMS-crane-frame-type-B9-1\",\"PALMS-crane-frame-type-B9-2\",\"PALMS-crane-frame-type-B9-3\"]", "474", "B9, FD típusú, különösen erős letalpaló (HD)", "3520", null },
                    { 7, "B10", "[\"PALMS-crane-frame-type-B10-1\",\"PALMS-crane-frame-type-B10-2\",\"PALMS-crane-frame-type-B10-3\"]", "520", "Talpaló Z daruhoz", "3730", null },
                    { 8, "B11", "[\"PALMS-crane-frame-type-B11-1\",\"PALMS-crane-frame-type-B11-2\",\"PALMS-crane-frame-type-B11-3\"]", "772", "Különösen erős talp daru billentéssel, vezérléssel, talpaló lábakkal (csak A21-A42 vezértömbhöz)", "7300", "[\"ybEUttbOiMU\"]" },
                    { 9, "B1", "[\"PALMS-crane-frame-type-B1-1\",\"PALMS-crane-frame-type-B1-2\",\"PALMS-crane-frame-type-B1-3\"]", "50", "FD talpaló", "725", null }
                });

            migrationBuilder.InsertData(
                table: "Grapple",
                columns: new[] { "Id", "A", "Area", "B", "C", "Code", "D", "E", "ImageUrls", "Mass", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, null, null, null, null, "C0", null, null, null, null, "Rönkfogó kanál nélkül", "0", null },
                    { 2, "1040", "0.16", "670", "410", "C02", "55", "305", "[\"PALMS-crane-grapple-C02-1\",\"PALMS-crane-grapple-C02-2\"]", "66", "Kanál 0,16 Palms (FL)", "1085", null },
                    { 3, "1230", "0.18", "690", "480", "C1", "80", "315", "[\"PALMS-crane-grapple-C1-1\",\"PALMS-crane-grapple-C2-2\"]", "88", "Kanál 0,18 Palms (FL)", "1395", null },
                    { 4, "1465", "0.23", "760", "500", "C3", "69", "340", "[\"PALMS-crane-grapple-C3-1\",\"PALMS-crane-grapple-C3-2\",\"PALMS-crane-grapple-C3-3\",\"PALMS-crane-grapple-C3-4\"]", "114", "Kanál 0,23 Palms (FL)", "1745", null },
                    { 5, null, "0.25", null, null, "C5.1", null, null, null, null, "Kanál 0,25 Grippen (FL)", "3380", null },
                    { 6, "1530", "0.26", "870", "525", "C5.2", "70", "430", "[\"PALMS-crane-grapple-C5.2-1\",\"PALMS-crane-grapple-C5.2-2\"]", "174", "Kanál 0,26 Palms (FL)", "2615", null },
                    { 7, "1475", "0.21", "760", "500", "C36", "60", "370", "[\"PALMS-crane-grapple-C36-1\",\"PALMS-crane-grapple-C36-2\",\"PALMS-crane-grapple-C36-3\"]", "127", "Biomasszás kanál 0,21 Palms (FL)", "2230", null },
                    { 8, null, "0.25", null, null, "C7.1", null, null, null, null, "Biomasszás kanál 0,25 Grippen (FL)", "3715", null },
                    { 9, "1550", "0.23", "870", "525", "C7.2", "70", "455", "[\"PALMS-crane-grapple-C7.2-1\",\"PALMS-crane-grapple-C7.2-2\"]", "118", "Biomasszás kanál 0,23 Palms (FL)", "3020", null },
                    { 10, "1635", "0.25", "895", "570", "C11", "85", "505", "[\"PALMS-crane-grapple-C11-1\",\"PALMS-crane-grapple-C11-2\"]", "223", "Biomasszás kanál 0,25 Palms (FL)", "3450", null },
                    { 11, "1615", "0.28", "895", "570", "C10", "85", "475", "[\"PALMS-crane-grapple-C10-1\",\"PALMS-crane-grapple-C10-2\",\"PALMS-crane-grapple-C10-3\"]", "205", "Palms 0,28-as kanál (FL)", "3125", null },
                    { 12, null, null, null, null, "C175", null, null, null, null, "Palms vágó kanál a Nisula-tól", "6500", null },
                    { 13, null, null, null, null, "GB16", null, null, "[\"PALMS-crane-grapple-GB16-1\",\"PALMS-crane-grapple-GB16-2\",\"PALMS-crane-grapple-GB\"]", "99", "Aprítékos kiegészítő 0,16 Palms (FL) kanálhoz", "475", "[\"Ff3LQ7rCo0E\"]" },
                    { 14, null, null, null, null, "GB18", null, null, "[\"PALMS-crane-grapple-GB18-1\",\"PALMS-crane-grapple-GB\"]", "130", "Aprítékos kiegészítő 0,18 Palms (FL) kanálhoz", "610", "[\"Ff3LQ7rCo0E\"]" },
                    { 15, null, null, null, null, "GB3", null, null, "[\"PALMS-crane-grapple-GB3-1\",\"PALMS-crane-grapple-GB\"]", "195", "Aprítékos kiegészítő 0,23 Palms (FL) kanálhoz", "935", "[\"JbYq1cykdEc\"]" },
                    { 16, "870", "0.09", "540", "315", "C009", "40", "265", "[\"PALMS-crane-grapple-C009-1\",\"PALMS-crane-grapple-C009-2\",\"PALMS-crane-grapple-C009-3\"]", "36", "Palms 0,09 kanál", "660", null }
                });

            migrationBuilder.InsertData(
                table: "HandBrake",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "PB1", null, "Kézifék, kerékről működtethető", "105", null });

            migrationBuilder.InsertData(
                table: "HayBaleFrame",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "HBF", "[\"PALMS-trailer-hay-bale-frame-1\",\"PALMS-trailer-hay-bale-frame-2\",\"PALMS-trailer-hay-bale-frame-3\",\"PALMS-trailer-hay-bale-frame-d\"]", "Szénabála keret (D típushoz)", "2785", null },
                    { 2, "HBF", "[\"PALMS-trailer-hay-bale-frame-1\",\"PALMS-trailer-hay-bale-frame-2\",\"PALMS-trailer-hay-bale-frame-3\",\"PALMS-trailer-hay-bale-frame-u\"]", "Szénabála keret (U típushoz)", "2785", null }
                });

            migrationBuilder.InsertData(
                table: "HighPerformanceOilFilter",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "HPF", "[\"PALMS-crane-high-performance-filter-1\",\"PALMS-crane-high-performance-filter-2\"]", "Nagynyomású olajszűrő", "0", null },
                    { 2, "HPF", "[\"PALMS-crane-high-performance-filter-1\",\"PALMS-crane-high-performance-filter-2\"]", "Nagynyomású olajszűrő", "395", null }
                });

            migrationBuilder.InsertData(
                table: "HoseGuard",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "HG1", "[\"PALMS_crane-hose-guard-1\"]", "Tömlő védő B3 és B6 talpaló esetén", "105", null },
                    { 2, "HG2", "[\"PALMS_crane-hose-guard-1\"]", "Tömlő védő B9 talpaló esetén", "105", null }
                });

            migrationBuilder.InsertData(
                table: "HydroPack",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "HyP1", "[\"PALMS-trailer-hydropack-HyP1-1\",\"PALMS-trailer-hydropack-HyP1-1\"]", "Hydropack 6,5 lóerő - 12 l/min, 1 szekciós", "1575", null },
                    { 2, "HyP4", "[\"PALMS-trailer-hydropack-HyP4-1\"]", "Hydropack 6,5 lóerő - 12 l/min, 4 szekciós", "2365", null },
                    { 3, "HyP4+", "[\"PALMS-trailer-hydropack-HyP4\\u002B-1\"]", "Hydropack 6,5 lóerő - 12 l/min, 4 szekciós + elektronikus indítás és akkumulátor", "2510", null }
                });

            migrationBuilder.InsertData(
                table: "HydroPackControl",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "ETC", null, "Elektronikus pótkocsi kontrol (dörzshajtáshoz és vonórúdhoz) + csörlő control", "410", null });

            migrationBuilder.InsertData(
                table: "JoystickHolder",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "JL", "[\"PALMS-crane-joystick-holder-1\"]", "Joystick tartó A11-A42 vezértömbhöz", "370", null });

            migrationBuilder.InsertData(
                table: "KrpanAdjustableDrive",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Proporcionálisan állítható meghajtás (BB5 esetén kötelező)", "2235" });

            migrationBuilder.InsertData(
                table: "KrpanAxeHolder",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "300015366", "Csákány és fejsze tartó", "0" },
                    { 2, "300015366", "Csákány és fejsze tartó", "40" }
                });

            migrationBuilder.InsertData(
                table: "KrpanBBox",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "300014957", "Biomasszás vájú", "3450" },
                    { 2, "300010813", "Biomasszás vájú", "3450" },
                    { 3, "300011065", "Biomasszás vájú", "3450" },
                    { 4, "300006476", "Biomasszás vájú", "3450" }
                });

            migrationBuilder.InsertData(
                table: "KrpanBaleTransportPlatform",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "300014965", "Platform bálaszállításhoz", "1935" },
                    { 2, "300011152", "Platform bálaszállításhoz", "1935" },
                    { 3, "300011151", "Platform bálaszállításhoz", "1935" },
                    { 4, "300011149", "Platform bálaszállításhoz", "1935" }
                });

            migrationBuilder.InsertData(
                table: "KrpanBrake",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", "Hidraulikus fék 2 keréken", "0" },
                    { 2, "", "Hidraulikus fék 4 keréken", "0" },
                    { 3, "", "Hidraulikus fék (mind a 4 keréken)", "383,33" },
                    { 4, "", "Hidraulikus fék vészfék funkcióval", "620,00" },
                    { 5, "", "Hidraulikus + ráfutófék (mind a 4 keréken)", "1620,00" },
                    { 6, "", "Pneumatikus fék(mind a 4 keréken)", "1620,00" },
                    { 7, "", "Hidraulikus fék vészfék funkcióval", "562,50" },
                    { 8, "", "Kétkörös hidraulikus fékrendszer", "2884,00" },
                    { 9, "", "Ráfutófék", "2118,33" },
                    { 10, "", "Pneumatikus fék (mind a 4 keréken)", "1722,00" },
                    { 11, "", "Kombinált fék (mind a 4 keréken - hidraulikus + pneumatikus)", "3166,00" }
                });

            migrationBuilder.InsertData(
                table: "KrpanCardanShaft",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "200004712", "Kardántengely Walterscheid WWE 2480-SDF25-910 (egyik oldalon nagy hajlásszögű)", "540" });

            migrationBuilder.InsertData(
                table: "KrpanCargoSpaceExtension",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "300014961", "Raktér hosszabbítás (80 cm)", "0" },
                    { 2, "300014961", "Raktér hosszabbítás (80 cm)", "490" }
                });

            migrationBuilder.InsertData(
                table: "KrpanChainsawHolder",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "300015821", "Motorfűrész tartó", "0" },
                    { 2, "300015821", "Motorfűrész tartó", "45" }
                });

            migrationBuilder.InsertData(
                table: "KrpanChock",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Ékek", "0" });

            migrationBuilder.InsertData(
                table: "KrpanClutch",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", "Alsó tengelykapcsoló", "0" },
                    { 2, "", "Felső tengelykapcsoló (a felső tengelykapcsoló és a kétkörös öntöttvas tandem szivattyú kombinációja nem lehetséges)", "145" }
                });

            migrationBuilder.InsertData(
                table: "KrpanCrane",
                columns: new[] { "Id", "BrutLiftingTorque", "Description", "LiftCapacityAtFourMeters", "LiftCapacityAtMaxReach", "MaxReach", "MaxReachWithGrabOpen", "Name", "NetLiftingTorque", "OilQuantityInTank", "Price", "SlewCylinders", "SlewTorque", "SlewingAngle", "SystemPressure", "TelescopicStages", "Weight" },
                values: new object[,]
                {
                    { 1, "50", "", "1020", "600", "6.6", "7.2", "GD 6,6 K", "40", "70", "13715", "4", "16", "375", "220", "1", "900" },
                    { 2, "80", "", "1860", "850", "7.4", "8.0", "GD 7,4 K", "63", "100", "24475", "4", "22", "380", "230", "1", "1516" },
                    { 3, "49", "", "1020", "500", "7.6", "8.2", "GD 7,6 K", "39", "70", "15335", "4", "16", "375", "220", "1", "930" },
                    { 4, "82", "", "1670", "680", "8.6", "9.2", "GD 8,6 K", "58", "100", "27150", "4", "19", "380", "230", "2", "1706" },
                    { 5, "82", "", "1460", "894", "7.2", "7.8", "GD 7,2 Z", "62", "100", "26000", "4", "22", "370", "230", "1", "1530" },
                    { 6, "84", "", "1427", "760", "8.4", "9.0", "GD 8,4 Z", "60", "100", "29200", "4", "22", "370", "230", "2", "1855" },
                    { 7, "", "", "", "", "", "", "GD 5,6 K", "", "", "10149,47", "", "", "", "", "", "" },
                    { 8, "", "", "", "", "", "", "GD 6,2 K", "", "", "11735,30", "", "", "", "", "", "" }
                });

            migrationBuilder.InsertData(
                table: "KrpanDrawHead",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "300012588", "Vonófej K80", "340" },
                    { 2, "300012588", "Vonófej K80", "415" }
                });

            migrationBuilder.InsertData(
                table: "KrpanDrawbar",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "300012585", "Rögzített vonószem Ø 50", "150" },
                    { 2, "300012587", "Forgó vonószem Ø 50", "325" },
                    { 3, "300012587", "Forgó vonószem Ø 50", "400" }
                });

            migrationBuilder.InsertData(
                table: "KrpanDrawbarSteering",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Vonórúd kormányzás + 40°", "0" });

            migrationBuilder.InsertData(
                table: "KrpanExtension",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "300015365", "Hosszabbítás (GP15D pótkocsihoz 1,8 m)", "675" });

            migrationBuilder.InsertData(
                table: "KrpanExtraForwarderStanchion",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "300019196", "Extra forwarder rakonca pár", "1025" });

            migrationBuilder.InsertData(
                table: "KrpanExtraStanchion",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "300011090", "Extra rakonca pár (3 pár széria)", "545" },
                    { 2, "300010875", "Extra rakonca pár (4 pár széria)", "545" }
                });

            migrationBuilder.InsertData(
                table: "KrpanFuelTankHolder",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "300007925", "Üzemanyagtartály tartó", "0" },
                    { 2, "300007925", "Üzemanyagtartály tartó", "40" }
                });

            migrationBuilder.InsertData(
                table: "KrpanGrappleLocation",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Kanál lerakási helyének megerősítése", "180" });

            migrationBuilder.InsertData(
                table: "KrpanHandBrake",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Kézifék", "0" });

            migrationBuilder.InsertData(
                table: "KrpanHydraulicAdjustableChassis",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Hidraulikusan állítható futómű", "0" });

            migrationBuilder.InsertData(
                table: "KrpanHydraulicSupportLeg",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "300013635", "Hidraulikus támasztóláb GP pótkocsihoz (Z darunál kötelező)", "530" });

            migrationBuilder.InsertData(
                table: "KrpanPlato",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "300015209", "Plató (GP 15 D pótkocsihoz)", "6185" });

            migrationBuilder.InsertData(
                table: "KrpanPropulsion",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", "2 WD (BB4, 400/60-15,5 vagy 500/50-17 gumimérethez)", "9875" },
                    { 2, "", "2 WD (BB5, 550/45-22,5 vagy 400/55-22,5 gumimérethez)", "12355" },
                    { 3, "", "4 WD (BB4, 400/60-15,5 vagy 500/50-17 gumimérethez)", "21210" },
                    { 4, "", "4 WD (BB5, 550/45-22,5 vagy 400/55-22,5 gumimérethez)", "26165" }
                });

            migrationBuilder.InsertData(
                table: "KrpanToolBox",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "300015651", "Szerszámos láda", "0" },
                    { 2, "300015651", "Szerszámos láda", "145" }
                });

            migrationBuilder.InsertData(
                table: "KrpanTopConnection",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Felső csatlakozás", "145" });

            migrationBuilder.InsertData(
                table: "KrpanTrailerLamp",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Lámpa", "0" });

            migrationBuilder.InsertData(
                table: "KrpanTrailerSupportLeg",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Kitámasztó láb", "0" });

            migrationBuilder.InsertData(
                table: "KrpanTyre",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", "300/80-15,3”; 14 rétegű", "0" },
                    { 2, "", "400/60-15,5”; 16 rétegű", "0" },
                    { 3, "", "400/60-15,5”; 18 rétegű (BKT)", "214,00" },
                    { 4, "", "400/60-15,5”; 18 rétegű (BKT)", "883,00" },
                    { 5, "", "400/55-22,5”; 16 rétegű (BKT)", "2347,00" },
                    { 6, "", "480/45-17”; 14 rétegű", "1097,00" },
                    { 7, "", "480/45-17”; 14 rétegű", "1084,23" },
                    { 8, "", "500/50-17”; 18 rétegű", "1403,33" },
                    { 9, "", "500/50-17”; 18 rétegű (BKT)", "1616,33" },
                    { 10, "", "550/45-22,5”; 20 rétegű", "2989,17" },
                    { 11, "", "550/45-22,5”; Traktorprofilú", "4014,29" },
                    { 12, "", "600/50-22,5”; 16 rétegű", "3460,99" }
                });

            migrationBuilder.InsertData(
                table: "Linkage",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "3PL", "[\"PALMS-crane-linkage-1\"]", "3 pontos csatlakozó adapter (csak a B9 és B10 talpalóval kompatibilis)", "960", null });

            migrationBuilder.InsertData(
                table: "MOT",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "", null, "Pótkocsi műszaki vizsga", "500", null });

            migrationBuilder.InsertData(
                table: "ManualBunkExtension",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "PA-M", null, "Forwarder típusú manuális bunk szélesítés - 1 db", "160", null });

            migrationBuilder.InsertData(
                table: "OilPump",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "P01", "[\"PALMS-trailer-oil-pump-1\",\"PALMS-trailer-oil-pump-2\"]", "Szivattyú adapter a vonórúdon", "60", null },
                    { 2, "P1", null, "P1 101 cm3 dugattyús olajmpumpa a vonórúdon, 650 p/min - 65 l/min", "1155", null },
                    { 3, "P2", null, "P2 130 cm3 dugattyús olajmpuma a vonórúdon, 650 p/min - 82 l/min", "1575", null },
                    { 4, "P4", null, "61 cm3 dugattyús olajpumpa multiplikátorral a vonórúdon, 650 p/min - 98 l/min", "1995", null },
                    { 5, "P4PTO", null, "P4 olajmpumla PTO-val 650 p/min - 98 l/min (rögzítő konzol nélkül)", "1995", null },
                    { 6, "P6", null, "LS fajtájú olajmpumpa multiplikátorral, 650 p/min - 120 l/min", "4305", null },
                    { 7, "P6PTO", null, "P6 olajpumpa PTO-val 650 p/min - 120 l/min (rögzítő konzol nélkül)", "4305", null },
                    { 8, "P6", null, "LS fajtájú olajpumpa multiplikátorral, 500 p/min - 118 l/min", "5190", null }
                });

            migrationBuilder.InsertData(
                table: "OilTank",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "T2", "[\"PALMS-trailer-oiltank-T2-T2\\u002B-T4\\u002B\"]", "95 l-es olajtartály", "1000", null },
                    { 2, "T2+", "[\"PALMS-trailer-oiltank-T2-T2\\u002B-T4\\u002B\"]", "95 l-es olajtartály HVLP olajjal", "1290", null },
                    { 3, "T2SOV", "[\"PALMS-trailer-oiltank-T2SOV-T2SOV\\u002B\"]", "95 l-es olajtartály elzáró csappal", "1200", null },
                    { 4, "T2SOV+", "[\"PALMS-trailer-oiltank-T2SOV-T2SOV\\u002B\"]", "95 l-es olajtartály HVLP olajjal, elzáró csappal, olajszűrővel", "1490", null },
                    { 5, "T2+", "[\"PALMS-trailer-oiltank-T2-T2\\u002B-T4\\u002B\"]", "95 l-es olajtartály HVLP olajjal", "1295", null },
                    { 6, "T2SOV+", "[\"PALMS-trailer-oiltank-T2SOV-T2SOV\\u002B\"]", "95 l-es olajtartály HVLP olajjal, elzáró csappal, olajszűrővel", "1490", null },
                    { 7, "T4+", "[\"PALMS-trailer-oiltank-T2-T2\\u002B-T4\\u002B\"]", "100 l-es olajtartály HVLP olajjal", "1610", null }
                });

            migrationBuilder.InsertData(
                table: "OperatorSeat",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "HSB", "[\"PALMS-crane-operator-seat-1\",\"PALMS-crane-operator-seat-2\"]", "Kezelő ülés a függőleges gém tetejére, csak A12-es vezértömbhöz, nem kompatibilis a csörlővel", "1955", null });

            migrationBuilder.InsertData(
                table: "Platform",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "D1", "[\"PALMS-trailer-platform-1\",\"PALMS-trailer-platform-2\",\"PALMS-trailer-platform-3\",\"PALMS-trailer-platform-4\"]", "Kezelő platform háttámlával a vonórúdon", "600", null },
                    { 2, "D2", "[\"PALMS-trailer-platform-1\",\"PALMS-trailer-platform-2\",\"PALMS-trailer-platform-3\",\"PALMS-trailer-platform-4\"]", "Kezelő platform háttámlával a vonórúdon túlfutásgátlós vonórúddal", "600", null }
                });

            migrationBuilder.InsertData(
                table: "Propulsion",
                columns: new[] { "Id", "Code", "Description", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "RWD", "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további pótkocsi-hajtásra van szükségük. A rendszer működtetése a traktor hidraulikájáról történik. Előnyei az RWD+ rendszerhez képest a jobb manőverezhetőség és a műszaki egyszerűség.", "[\"PALMS-trailer-propulsion-RWD-RWD\\u002B-1\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-2\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-3\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-4\"]", "Robson WD dörzshajtás (traktor hidarulikáról)", "5280", null },
                    { 2, "RWD+", "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további vontatásra van szükségük pótkocsijukhoz. Előnyei a hagyományos RWD rendszerekhez képest a jobb tapadás és a sebesség állíthatósága.", "[\"PALMS-trailer-propulsion-RWD-RWD\\u002B-1\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-2\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-3\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-4\",\"PALMS-trailer-propulsion-electronic\"]", "Robson WD dörzshajtás elektronikus vezérlőrendszerrel", "7600", null },
                    { 3, "24WDF", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.", "[\"PALMS-trailer-propulsion-2WDF\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "2WD hajtás (BB240 az első tengelyen elektronikus vezérléssel, fékhez előkészítve)", "13200", "[\"LKj7YS_M13E\"]" },
                    { 4, "24WDRe", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.", "[\"PALMS-trailer-propulsion-2WDR\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "2WD hajtás (BB240 a hátsó tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)", "11445", "[\"LKj7YS_M13E\"]" },
                    { 5, "RWD", "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további pótkocsi-hajtásra van szükségük. A rendszer működtetése a traktor hidraulikájáról történik. Előnyei az RWD+ rendszerhez képest a jobb manőverezhetőség és a műszaki egyszerűség.", "[\"PALMS-trailer-propulsion-RWD-RWD\\u002B-1\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-2\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-3\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-4\"]", "Robson WD dörzshajtás (traktor hidarulikáról)", "4845", null },
                    { 6, "RWD+", "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további vontatásra van szükségük pótkocsijukhoz. Előnyei a hagyományos RWD rendszerekhez képest a jobb tapadás és a sebesség állíthatósága.", "[\"PALMS-trailer-propulsion-RWD-RWD\\u002B-1\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-2\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-3\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-4\",\"PALMS-trailer-propulsion-electronic\"]", "Robson WD dörzshajtás elektronikus vezérlőrendszerrel", "7170", null },
                    { 7, "25WDF", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.", "[\"PALMS-trailer-propulsion-2WDF\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "2WD agyhajtás (BB250 az első tengelyen elektronikus vezérléssel, fékhez előkészítve)", "15585", "[\"LKj7YS_M13E\"]" },
                    { 8, "25WDR", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.", "[\"PALMS-trailer-propulsion-2WDR\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "2WD agyhajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, fékhez előkészítve)", "15585", "[\"LKj7YS_M13E\"]" },
                    { 9, "25WDFe", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.", "[\"PALMS-trailer-propulsion-2WDF\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "2WD hajtás (BB250 az első tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)", "13590", "[\"LKj7YS_M13E\"]" },
                    { 10, "25WDRe", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.", "[\"PALMS-trailer-propulsion-2WDR\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "2WD hajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)", "13590", "[\"LKj7YS_M13E\"]" },
                    { 11, "45WDB.1", "", "[\"PALMS-trailer-propulsion-4WD\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "4WD BlackBruin hajtás elektronikus vezérléssel ISOBUS-hoz", "0", null },
                    { 12, "25WDF", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.", "[\"PALMS-trailer-propulsion-2WDF\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "2WD agyhajtás (BB250 az első tengelyen elektronikus vezérléssel, fékhez előkészítve)", "15015", "[\"LKj7YS_M13E\"]" },
                    { 13, "25WDR", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.", "[\"PALMS-trailer-propulsion-2WDR\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "2WD agyhajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, fékhez előkészítve)", "15015", "[\"LKj7YS_M13E\"]" },
                    { 14, "25WDFe", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.", "[\"PALMS-trailer-propulsion-2WDF\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "2WD hajtás (BB250 az első tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)", "13020", "[\"LKj7YS_M13E\"]" },
                    { 15, "25WDRe", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.", "[\"PALMS-trailer-propulsion-2WDR\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "2WD hajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)", "13020", "[\"LKj7YS_M13E\"]" },
                    { 16, "25WDF", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.", "[\"PALMS-trailer-propulsion-2WDF\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "2WD agyhajtás (BB250 az első tengelyen elektronikus vezérléssel, fékhez előkészítve)", "14660", "[\"LKj7YS_M13E\"]" },
                    { 17, "25WDR", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.", "[\"PALMS-trailer-propulsion-2WDR\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "2WD agyhajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, fékhez előkészítve)", "14660", "[\"LKj7YS_M13E\"]" },
                    { 18, "25WDFe", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.", "[\"PALMS-trailer-propulsion-2WDF\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "2WD hajtás (BB250 az első tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)", "12665", "[\"LKj7YS_M13E\"]" },
                    { 19, "25WDRe", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.", "[\"PALMS-trailer-propulsion-2WDR\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "2WD hajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)", "12665", "[\"LKj7YS_M13E\"]" },
                    { 20, "45WDB", "", "[\"PALMS-trailer-propulsion-4WD\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "4WD BlackBruin hajtás elektronikus vezérléssel", "0", null },
                    { 21, "45WDB.1", "", "[\"PALMS-trailer-propulsion-4WD\",\"PALMS-trailer-propulsion-2WD-4WD-1\",\"PALMS-trailer-propulsion-2WD-4WD-2\"]", "4WD BlackBruin hajtás elektronikus vezérléssel ISOBUS-hoz", "1135", null },
                    { 22, "RWD", "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további pótkocsi-hajtásra van szükségük. A rendszer működtetése a traktor hidraulikájáról történik. Előnyei az RWD+ rendszerhez képest a jobb manőverezhetőség és a műszaki egyszerűség.", "[\"PALMS-trailer-propulsion-RWD-RWD\\u002B-1\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-2\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-3\",\"PALMS-trailer-propulsion-RWD-RWD\\u002B-4\"]", "Robson WD dörzshajtás (traktor hidarulikáról)", "2185", null }
                });

            migrationBuilder.InsertData(
                table: "ProtectionSleeves",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "PSH", "[\"PALMS-crane-protection-sleeves-1\"]", "Védőhüvely a tömlőhöz", "105", null },
                    { 2, "PSH", "[\"PALMS-crane-protection-sleeves-1\"]", "Védőhüvely a tömlőhöz", "55", null }
                });

            migrationBuilder.InsertData(
                table: "Rotator",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "R0", null, "Rotátor nélkül", "0", null },
                    { 2, "R30", null, "30 kN-os rotátor (csapos)", "300", null },
                    { 3, "R31", null, "30 kN-os rotátor FL (talpas)", "430", null },
                    { 4, "R45", null, "45 kN-os rotátor FL (talpas)", "620", null },
                    { 5, "R55", null, "55 kN-os rotátor FL (talpas)", "915", null },
                    { 6, "R60", null, "60 kN-os rotátor FL Indexator GV6 (talpas)", "1600", null },
                    { 7, "R90", null, "100 kN-os rotátor FL Indexator T10 (talpas)", "1880", null },
                    { 8, "R10", "[\"PALMS-crane-rotator-1\",\"PALMS-crane-rotator-2\"]", "10 kN-os csapos rotátor, Finrotor", "265", null }
                });

            migrationBuilder.InsertData(
                table: "RotatorBrake",
                columns: new[] { "Id", "Code", "Description", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "Br0", null, null, "Rotátorfék  nélkül", "0", null },
                    { 2, "Br1", "Fék az oldalirányú mozgáshoz. A fékek terheletlen módon vannak beállítva.", "[\"PALMS-crane-rotator-brake-BR1-1\",\"PALMS-crane-rotator-brake-BR1-2\",\"PALMS-crane-rotator-brake-BR1-3\"]", "Rotátor fék", "85", null },
                    { 3, "Br1", "Fék az oldalirányú mozgáshoz. A fékek terheletlen módon vannak beállítva.", "[\"PALMS-crane-rotator-brake-BR1-1\",\"PALMS-crane-rotator-brake-BR1-2\",\"PALMS-crane-rotator-brake-BR1-3\"]", "Rotátor fék", "55", null },
                    { 4, "Br2", "Fékek az oldalirányú és előre-hátra mozgáshoz. A fékek terheletlen módon vannak beállítva.", "[\"PALMS-crane-rotator-brake-BR2-1\",\"PALMS-crane-rotator-brake-BR2-2\",\"PALMS-crane-rotator-brake-BR2-3\"]", "Dupla rotátor fék", "125", null },
                    { 5, "Br2", "Fékek az oldalirányú és előre-hátra mozgáshoz. A fékek terheletlen módon vannak beállítva.", "[\"PALMS-crane-rotator-brake-BR2-1\",\"PALMS-crane-rotator-brake-BR2-2\",\"PALMS-crane-rotator-brake-BR2-3\"]", "Dupla rotátor fék", "220", null }
                });

            migrationBuilder.InsertData(
                table: "Shipping",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "", null, "Pótkocsi szállítása Észtországból Magyarországra", "750", null },
                    { 2, "", null, "Daru szállítása Észtországból Magyarországra", "750", null }
                });

            migrationBuilder.InsertData(
                table: "Stanchion",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "A3", null, "Pótkocsi 3 pár rakoncával", "5460", null },
                    { 2, "A4", null, "Pótkocsi 4 pár rakoncával", "5975", null },
                    { 3, "A3", null, "Pótkocsi 3 pár rakoncával", "6995", null },
                    { 4, "A4", null, "Pótkocsi 4 pár rakoncával", "7515", null },
                    { 5, "A4Ex", null, "Pótkocsi 4 pár rakoncával és raktérhosszabbítással", "7850", null },
                    { 6, "A5Ex", null, "Pótkocsi 5 pár rakoncával és raktérhosszabbítással ", "8370", null },
                    { 7, "A3", null, "Pótkocsi 3 pár rakoncával", "7245", null },
                    { 8, "A3F", null, "Pótkocsi 3 pár forwarder rakoncával", "7245", null },
                    { 9, "A4", null, "Pótkocsi 4 pár rakoncával", "7655", null },
                    { 10, "A4F", null, "Pótkocsi 4 pár forwarder rakoncával", "7655", null },
                    { 11, "A4Ex", null, "Pótkocsi 4 pár rakoncával és raktérhosszabbítással", "8245", null },
                    { 12, "A4FEx", null, "Pótkocsi 4 pár forwarder rakoncával és raktérhosszabbítással", "8245", null },
                    { 13, "A5Ex", null, "Pótkocsi 5 pár rakoncával és raktérhosszabbítással", "8650", null },
                    { 14, "A5FEx", null, "Pótkocsi 5 pár forwarder rakoncával és raktérhosszabbítással", "8650", null },
                    { 15, "A3", null, "Pótkocsi 3 pár rakoncával", "8065", null },
                    { 16, "A4", null, "Pótkocsi 4 pár rakoncával", "8610", null },
                    { 17, "A4Ex", null, "Pótkocsi 4 pár rakoncával és raktérhosszabbítással", "9065", null },
                    { 18, "A5Ex", null, "Pótkocsi 5 pár rakoncával és raktérhosszabbítással", "9615", null },
                    { 19, "A3", null, "Pótkocsi 3 pár rakoncával", "8505", null },
                    { 20, "A4", null, "Pótkocsi 4 pár rakoncával", "8900", null },
                    { 21, "A4Ex", null, "Pótkocsi 4 pár rakoncával és raktérhosszabbítással", "9520", null },
                    { 22, "A5Ex", null, "Pótkocsi 5 pár rakoncával és raktérhosszabbítással", "9915", null },
                    { 23, "A3", null, "Pótkocsi 3 pár rakoncával", "10700", null },
                    { 24, "A4", null, "Pótkocsi 4 pár rakoncával", "11095", null },
                    { 25, "A4Ex", null, "Pótkocsi 4 pár rakoncával és raktérhosszabbítással", "11715", null },
                    { 26, "A5Ex", null, "Pótkocsi 5 pár rakoncával és raktérhosszabbítással", "12105", null },
                    { 27, "A3", null, "Pótkocsi 3 pár rakoncával", "12245", null },
                    { 28, "A4", null, "Pótkocsi 4 pár rakoncával", "12745", null },
                    { 29, "A4Ex", null, "Pótkocsi 4 pár rakoncával és raktérhosszabbítással", "13515", null },
                    { 30, "A5Ex", null, "Pótkocsi 5 pár rakoncával és raktérhosszabbítással", "14015", null },
                    { 31, "A3", null, "Pótkocsi 3 pár rakoncával", "10495", null },
                    { 32, "A3F", null, "Pótkocsi 3 pár forwarder rakoncával", "9680", null },
                    { 33, "A4", null, "Pótkocsi 4 pár rakoncával", "11125", null },
                    { 34, "A4F", null, "Pótkocsi 4 pár forwarder rakoncával", "10240", null },
                    { 35, "A4Ex", null, "Pótkocsi 4 pár rakoncával és raktérhosszabbítással", "11850", null },
                    { 36, "A4FEx", null, "Pótkocsi 4 pár forwarder rakoncával és raktérhosszabbítással", "10920", null },
                    { 37, "A5Ex", null, "Pótkocsi 5 pár rakoncával és raktérhosszabbítással", "12480", null },
                    { 38, "A5FEx", null, "Pótkocsi 5 pár forwarder rakoncával és raktérhosszabbítással", "11475", null },
                    { 39, "A3", null, "Pótkocsi 3 pár rakoncával", "12285", null },
                    { 40, "A3F", null, "Pótkocsi 3 pár forwarder rakoncával", "12285", null },
                    { 41, "A4", null, "Pótkocsi 4 pár rakoncával", "112950", null },
                    { 42, "A4F", null, "Pótkocsi 4 pár forwarder rakoncával", "112950", null },
                    { 43, "A4Ex", null, "Pótkocsi 4 pár rakoncával és raktérhosszabbítással", "13675", null },
                    { 44, "A4FEx", null, "Pótkocsi 4 pár forwarder rakoncával és raktérhosszabbítással", "13675", null },
                    { 45, "A5Ex", null, "Pótkocsi 5 pár rakoncával és raktérhosszabbítással", "14345", null },
                    { 46, "A5FEx", null, "Pótkocsi 5 pár forwarder rakoncával és raktérhosszabbítással", "14345", null },
                    { 47, "A3", null, "Pótkocsi 3 pár rakoncával", "38075", null },
                    { 48, "A3F", null, "Pótkocsi 3 pár forwarder rakoncával", "38075", null },
                    { 49, "A4", null, "Pótkocsi 4 pár rakoncával", "38740", null },
                    { 50, "A4F", null, "Pótkocsi 4 pár forwarder rakoncával", "38740", null },
                    { 51, "A4Ex", null, "Pótkocsi 4 pár rakoncával és raktérhosszabbítással", "39465", null },
                    { 52, "A4FEx", null, "Pótkocsi 4 pár forwarder rakoncával és raktérhosszabbítással", "39465", null },
                    { 53, "A5Ex", null, "Pótkocsi 5 pár rakoncával és raktérhosszabbítással", "40130", null },
                    { 54, "A5FEx", null, "Pótkocsi 5 pár forwarder rakoncával és raktérhosszabbítással", "40130", null },
                    { 55, "A3", null, "Pótkocsi 3 pár rakoncával", "14660", null },
                    { 56, "A3F", null, "Pótkocsi 3 pár forwarder rakoncával", "14660", null },
                    { 57, "A4", null, "Pótkocsi 4 pár rakoncával", "15575", null },
                    { 58, "A4F", null, "Pótkocsi 4 pár forwarder rakoncával", "15575", null },
                    { 59, "A4Ex", null, "Pótkocsi 4 pár rakoncával és raktérhosszabbítással", "16300", null },
                    { 60, "A4FEx", null, "Pótkocsi 4 pár forwarder rakoncával és raktérhosszabbítással", "16300", null },
                    { 61, "A5Ex", null, "Pótkocsi 5 pár rakoncával és raktérhosszabbítással", "17220", null },
                    { 62, "A5FEx", null, "Pótkocsi 5 pár forwarder rakoncával és raktérhosszabbítással", "17220", null },
                    { 63, "A3", null, "Pótkocsi 3 pár rakoncával", "40445", null },
                    { 64, "A3F", null, "Pótkocsi 3 pár forwarder rakoncával", "40445", null },
                    { 65, "A4", null, "Pótkocsi 4 pár rakoncával", "41365", null },
                    { 66, "A4F", null, "Pótkocsi 4 pár forwarder rakoncával", "41365", null },
                    { 67, "A4Ex", null, "Pótkocsi 4 pár rakoncával és raktérhosszabbítással", "42090", null },
                    { 68, "A4FEx", null, "Pótkocsi 4 pár forwarder rakoncával és raktérhosszabbítással", "42090", null },
                    { 69, "A5Ex", null, "Pótkocsi 5 pár rakoncával és raktérhosszabbítással", "43010", null },
                    { 70, "A5FEx", null, "Pótkocsi 5 pár forwarder rakoncával és raktérhosszabbítással", "43010", null },
                    { 71, "A4F", null, "Pótkocsi 4 pár forwarder típusú rakoncával", "52325", null },
                    { 72, "A5F", null, "Pótkocsi 5 pár forwarder típusú rakoncával", "53455", null },
                    { 73, "A4FHEx", null, "Pótkocsi hidraulikus raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "55025", null },
                    { 74, "A5FHEx", null, "Pótkocsi hidraulikus raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "56155", null },
                    { 75, "A4F", null, "Pótkocsi 4 pár forwarder típusú rakoncával", "56815", null },
                    { 76, "A5F", null, "Pótkocsi 5 pár forwarder típusú rakoncával", "57945", null },
                    { 77, "A4FHEx", null, "Pótkocsi hidraulikus raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "59515", null },
                    { 78, "A5FHEx", null, "Pótkocsi hidraulikus raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "60645", null },
                    { 79, "A3", null, "Pótkocsi 3 pár rakoncával", "2730", null },
                    { 80, "A4", null, "Pótkocsi 4 pár rakoncával", "2855", null },
                    { 81, "A5", null, "Pótkocsi 5 pár rakoncával", "2985", null },
                    { 82, "A3F", null, "Pótkocsi 3 pár forwarder rakoncával", "10710", null },
                    { 83, "A4F", null, "Pótkocsi 4 pár forwarder rakoncával", "11335", null },
                    { 84, "A4FEx", null, "Pótkocsi 4 pár forwarder rakoncával és raktérhosszabbítással", "12020", null },
                    { 85, "A5FEx", null, "Pótkocsi 5 pár forwarder rakoncával és raktérhosszabbítással", "12645", null }
                });

            migrationBuilder.InsertData(
                table: "StanchionExtension",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "PE", null, "Rakonca hosszabbítás (az ár 1 db-ra vonatkozik)", "55", null });

            migrationBuilder.InsertData(
                table: "SupplyFormat",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "POP", null, "Raklapra csomagolva", "0", null },
                    { 2, "FA", null, "Teljesen összeszerelve", "195", null }
                });

            migrationBuilder.InsertData(
                table: "SupportBracket",
                columns: new[] { "Id", "Code", "Description", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "BOB", "csavarozható a keretre a védőburkolat és az első rakoncapár között", null, "Támasztókonzol", "125", null });

            migrationBuilder.InsertData(
                table: "SupportLeg",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "SL", "[\"PALMS-trailer-support-leg-SL\"]", "Csapszeggel állítható kitámasztó láb a vonórúdon", "0", null },
                    { 2, "SL", "[\"PALMS-trailer-support-leg-SL\"]", "Csapszeggel állítható kitámasztó láb a vonórúdon", "75", null },
                    { 3, "SJ", "[\"PALMS-trailer-support-leg-SJ\"]", "Tekerővel állítható kitámasztó láb a vonórúdon", "420", null }
                });

            migrationBuilder.InsertData(
                table: "SupportLegCounterPlate",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "PL2", "[\"PALMS-crane-support-leg-counter-plate-1\"]", "Fedőlap a Palms talpaló lábhoz", "475", null });

            migrationBuilder.InsertData(
                table: "Toolbox",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "TB1", "[\"PALMS-trailer-toolbox-1\",\"PALMS-trailer-toolbox-2\",\"PALMS-trailer-toolbox-3\",\"PALMS-trailer-toolbox-4\",\"PALMS-trailer-toolbox-5\",\"PALMS-trailer-toolbox-6\",\"PALMS-trailer-toolbox-7\"]", "Palms szerszámláda", "185", null });

            migrationBuilder.InsertData(
                table: "TrailerLight",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "L1", "[\"PALMS-trailer-light-L1-1\",\"PALMS-trailer-light-L1-2\"]", "Összecsukható hátsó lámpák", "420", null },
                    { 2, "L2", "[\"PALMS-trailer-light-L2-1\",\"PALMS-trailer-light-L2-2\"]", "Hátsó LED lámpa flexibilis Kilpi karokkal", "465", null },
                    { 3, "L4", "[\"PALMS-trailer-light-L4-1\",\"PALMS-trailer-light-L4-2\"]", "Fix hátsó LED lámpák", "420", null },
                    { 4, "L1", "[\"PALMS-trailer-light-L1-1\",\"PALMS-trailer-light-L1-2\"]", "Összecsukható hátsó lámpák", "340", null },
                    { 5, "L2", "[\"PALMS-trailer-light-L2-1\",\"PALMS-trailer-light-L2-2\"]", "Hátsó LED lámpa flexibilis Kilpi karokkal", "440", null }
                });

            migrationBuilder.InsertData(
                table: "TrailerOilCooler",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "CP2", "[\"PALMS-trailer-oil-cooler-1\"]", "Olajhűtő csomag a tartályhoz rögzítve", "1035", "[\"5u9NDzvA0gk\"]" },
                    { 2, "CP4", "[\"PALMS-trailer-oil-cooler-1\"]", "Olajhűtő csomag a tartályhoz rögzítve", "1190", "[\"5u9NDzvA0gk\"]" }
                });

            migrationBuilder.InsertData(
                table: "TurningDeviceCounterPlate",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "PL", "[\"PALMS-crane-turning-device-counter-plate-1\"]", "Fedőlap a fordító szerkezethez", "340", null });

            migrationBuilder.InsertData(
                table: "Tyre",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "WH2.6e", null, "400/60-15,5 standard felni, 6 lyukas, Starco", "1220", null },
                    { 2, "WH2.6", null, "400/60-15,5 RF-felni, 6 lyukas, Starco", "1490", null },
                    { 3, "WH4.6", null, "480/45-17 RF-felni, 6 lyukas, Starco", "2310", null },
                    { 4, "WH3.6", null, "500/50-17 RF-felni, 6 lyukas, BKT", "2500", null },
                    { 5, "WH3.8", null, "500/50-17 RF-felni, 8 lyukas, BKT", "2500", null },
                    { 6, "WH5.6", null, "400/55-22,5 RF-felni, 6 lyukas, Alliance", "3215", null },
                    { 7, "WH8.8", null, "500/50-22,5 RF-felni, 8 lyukas, BKT", "3770", null },
                    { 8, "WH6.8", null, "550/45-22,5 RF-felni, 8 lyukas, BKT", "4010", null },
                    { 9, "WH6.8V", null, "550/45-22,5 RF-felni, 8 lyukas, BKT - traktor mintás", "4410", null },
                    { 10, "WH9.8V", null, "600/40-22,5 RF-felni, 8 lyukas, BKT - traktor mintás", "6425", null },
                    { 11, "WH7.8", null, "600/50-22,5 RF-felni, 8 lyukas, Alliance", "5410", null },
                    { 12, "WH7.10", null, "600/50-22,5 RF-felni, 10 lyukas, Nokian", "11020", null },
                    { 13, "WH9.10", null, "710/40-22,5 RF-felni, 10 lyukas, Nokian", "11150", null },
                    { 14, "WH2.4", null, "300/65-12", "885", null }
                });

            migrationBuilder.InsertData(
                table: "UnderrunProtection",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "RUP1", "[\"PALMS-trailer-underrun-protection-1\",\"PALMS-trailer-underrun-protection-2\"]", "Aláfutásgátló D-típushoz, hátsó lámpa és rendszámtartó", "1040", null },
                    { 2, "RUP2", "[\"PALMS-trailer-underrun-protection-1\",\"PALMS-trailer-underrun-protection-2\"]", "Aláfutásgátló S és U-típushoz, hátsó lámpa és rendszámtartó", "1040", null }
                });

            migrationBuilder.InsertData(
                table: "ValveBlock",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "AH", "[\"PALMS-crane-valve-block-1\",\"PALMS-crane-valve-block-2\"]", "A21-A42 vezértömb a főgémhez erősítve", "0", null });

            migrationBuilder.InsertData(
                table: "Winch",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[,]
                {
                    { 1, "W0", null, "Csörlő előkészítés a főgémen", "70", null },
                    { 2, "W1", "[\"PALMS-crane-winch-1\",\"PALMS-crane-winch-2\",\"PALMS-crane-winch-3\"]", "Rádió távvezérlésű 1400-as csörlő (A11-A41 vezértömbhöz)", "2415", null },
                    { 3, "W2", "[\"PALMS-crane-winch-1\",\"PALMS-crane-winch-2\",\"PALMS-crane-winch-3\"]", "Rádió távvezérlésű 2200-as csörlő (A11-A41 vezértömbhöz)", "2930", null },
                    { 4, "W3", "[\"PALMS-crane-winch-1\",\"PALMS-crane-winch-2\",\"PALMS-crane-winch-3\"]", "Csörlő", "1555", null }
                });

            migrationBuilder.InsertData(
                table: "WoodControl",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "LWS", "[\"PALMS-crane-wood-control-1\",\"PALMS-crane-wood-control-2\"]", "Hosszú fás kiegészítő a főgémhez", "150", null });

            migrationBuilder.InsertData(
                table: "WoodSorter",
                columns: new[] { "Id", "Code", "ImageUrls", "Name", "Price", "VideoUrls" },
                values: new object[] { 1, "WS", "[\"PALMS-trailer-wood-sorter-1\",\"PALMS-trailer-wood-sorter-2\",\"PALMS-trailer-wood-sorter-3\"]", "Faosztályozó rövidebb fához (1db/rakonca, az ár 1 db-ra vonatkozik)", "65", null });

            migrationBuilder.InsertData(
                table: "Crane",
                columns: new[] { "Id", "BoomGuardId", "BrutLiftingTorque190Bar", "BrutLiftingTorque215Bar", "BrutLiftingTorque240Bar", "CoverId", "CraneOilCoolerId", "CraneWeight", "Description", "ElectricalFloatingId", "ImageUrls", "JoystickHolderId", "LiftAtFourMeters190Bar", "LiftAtFourMeters215Bar", "LiftAtFourMeters240Bar", "LiftAtFullReach190Bar", "LiftAtFullReach215Bar", "LiftAtFullReach240Bar", "LightId", "LinkageId", "MaxReach", "Name", "OperatorSeatId", "PillarSlewingAngle", "Price", "ProtectionSleevesId", "RecommendedOilFlow", "RotatorCapacity", "RotatorConnection", "RotatorMaximumLoad", "RotatorType", "Series", "ShippingId", "SlewingCylinder", "SlewingTorque", "SupportBracketId", "SupportLegCounterPlateId", "TelescopeLength", "TurningDeviceCounterPlateId", "ValveBlockId", "VideoUrls", "WoodControlId", "WorkingPressure" },
                values: new object[,]
                {
                    { 1, null, "26", "-", "-", 1, null, "360", "Ideális választás azoknak a vásárlóknak, akik egyszerűséget, könnyűséget és kompakt méretet keresnek. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.", null, "[\"PALMS-2.42-1\",\"PALMS-2.42-2\"]", null, "570", "-", "-", "540", "-", "-", null, 1, "4.2", "PALMS 2.42", null, "370", "5870", 1, "20-35", "30", "FR", "45", "FL", "2", 2, "4", "7.8", null, 1, "-", 1, null, "[\"fEDDjo_K3E8\"]", 1, "190" },
                    { 2, null, "26", "29", "-", 1, null, "400", "Kompakt és könnyű daru, ideális városi parkokhoz és más környezetvédelmi érzékeny területekhez. Rögzíthető különböző platformokra, erdészeti pótkocsiktól és teherautóktól kezdve a mini-forwarderekig. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.", 1, "[\"PALMS-2.54-1\",\"PALMS-2.54-2\",\"PALMS-2.54-3\",\"PALMS-2.54-4\",\"PALMS-2.54-5\"]", 1, "530", "600", "-", "370", "410", "-", null, 1, "5.4", "PALMS 2.54", null, "370", "7215", 1, "20-35", "30", "FR", "45", "FL", "2", 2, "4", "7.8", null, 1, "1,33", 1, 1, "[\"fEDDjo_K3E8\",\"OUXj3T4seD0\"]", 1, "190/215" },
                    { 3, null, "36", "-", "-", 1, null, "415", "Kis erdőtulajdonosoknak tervezett daru a tűzifa előkészítésére saját maguk és szomszédos háztartások számára. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.", null, "[\"PALMS-3.63-1\",\"PALMS-3.63-2\",\"PALMS-3.63-3\"]", null, "655", "-", "-", "355", "-", "-", null, 1, "6.3", "PALMS 3.63", null, "370", "7480", 1, "20-35", "30", "FR", "45", "FL", "3", 2, "4", "9", null, 1, "1,85", 1, null, "[\"z9VS2BuQwvM\"]", 1, "190" },
                    { 4, null, "41", "46", "-", 1, null, "620", "Egy gazda legjobb társa, kiváló teljesítményt nyújtva tűzifa előkészítésében és általános emelési feladatokban a gazdaságokon. Kompatibilis a PALMS 8SX, 8D, 9SC és 10D pótkocsikkal.", 1, "[\"PALMS-3.67-1\",\"PALMS-3.67-2\",\"PALMS-3.67-3\",\"PALMS-3.67-4\",\"PALMS-3.67-5\",\"PALMS-3.67-6\"]", 1, "820", "910", "-", "430", "480", "-", 1, 1, "6.7", "PALMS 3.67", null, "370", "8400", 1, "30-45", "30", "FR", "45", "FL", "3", 2, "4", "12", null, 1, "1,85", 1, 1, "[\"z9VS2BuQwvM\"]", 1, "190/215" },
                    { 5, null, "48", "54", "-", 1, 1, "710", "Sokoldalú közepes méretű daru, különféle ágazatokban, például fakitermelésben és mezőgazdaságban. Kompatibilis a legtöbb PALMS pótkocsival", 1, "[\"PALMS-4.71-1\",\"PALMS-4.71-2\",\"PALMS-4.71-3\",\"PALMS-4.71-4\",\"PALMS-4.71-5\"]", 1, "960", "1040", "-", "480", "535", "-", 1, 1, "7.1", "PALMS 4.71", 1, "370", "9800", 1, "45-70", "45", "Palms", "45", "FL", "4", 2, "4", "15", null, 1, "1,95", 1, 1, "[\"NYLCfmf-Nfc\"]", 1, "190/215" },
                    { 6, 1, "63", "69", "-", 1, 1, "940", "Professzionális erdészeti műveletekre tervezett daru, közepes méretű traktorokhoz optimalizálva. Kompatibilis a PALMS pótkocsik többségével.", 1, "[\"PALMS-5.75-1\",\"PALMS-5.75-2\",\"PALMS-5.75-3\"]", 1, "1150", "1350", "-", "540", "620", "-", 1, 1, "7.5", "PALMS 5.75", 1, "380", "12445", 1, "50-90", "55", "Palms", "60", "FL", "5", 2, "4", "17", null, 1, "2,0", 1, 1, "[\"-f0tPn8V78g\"]", 1, "190/215" },
                    { 7, 1, "56", "63", "-", 1, 1, "900", "Professzionális erdészeti daru, dupla teleszkópos gémmel felszerelve. Kifejezetten a mindennapi erdészeti műveletekhez tervezve. Optimalizálva a közepes méretű traktorokhoz. Kompatibilis a PALMS pótkocsik többségével.", 1, "[\"PALMS-5.85-1\",\"PALMS-5.85-2\",\"PALMS-5.85-3\",\"PALMS-5.85-4\",\"PALMS-5.85-5\"]", 1, "1050", "1220", "-", "450", "520", "-", 1, 1, "8.5", "PALMS 5.85", 1, "380", "14595", 1, "50-90", "55", "Palms", "60", "FL", "5", 2, "4", "17", null, 1, "3,3", 1, 1, "[\"-f0tPn8V78g\"]", 1, "190/215" },
                    { 8, null, "-", "63", "-", 1, 1, "995", "A PALMS 5.87Z daru kompakt szállítási méreteivel és sokoldalúságával tűnik ki, amely nemcsak erdészeti, hanem mezőgazdasági pótkocsikhoz és teherautókhoz is illeszkedik.", null, "[\"PALMS-5.87Z-1\",\"PALMS-5.87Z-2\",\"PALMS-5.87Z-3\",\"PALMS-5.87Z-4\",\"PALMS-5.87Z-5\",\"PALMS-5.87Z-6\"]", 1, "-", "1235", "-", "-", "490 (8,4 m)", "-", 1, 1, "8.7", "PALMS 5.87Z", 1, "340", "16060", 1, "50-90", "55", "Palms", "60", "FL", "5", 2, "4", "17", null, 1, "3,3", 1, 1, "[\"pLvH1NAPEzI\"]", null, "215" },
                    { 9, 2, "78", "86", "96", 1, 1, "1220", "Nagy teljesítményű erdészeti daru, amelyet a mindennapos profi erdészeti munkákra terveztek. Magasabb emelőkapacitása és forgatónyomatéka miatt is alkalmas vágófejjel való munkavégzésre is. Kompatibilis a Palms egyalvázas és duplaalvázat pótkocsijaval is.", 1, "[\"PALMS-7.78-1\",\"PALMS-7.78-2\",\"PALMS-7.78-3\",\"PALMS-7.78-4\"]", 1, "1380", "1580", "-", "580", "670", "-", 1, 1, "7.8", "PALMS 7.78", 1, "380", "15855", 1, "60-120", "60", "Palms", "60", "FL (Indexator-tól)", "7", 2, "4", "21", null, 1, "2,15", 1, 1, "[\"z55HswaDwSA\"]", 1, "190/215" },
                    { 10, 2, "78", "86", "96", 1, 1, "1280", "Nagy teherbírású erdészeti daru, két teleszkóppal, amelyet a mindennapos profi erdészeti munkákhoz terveztek. Magasabb emelőkapacítása és forgatónyomatéka miatt alkalmas vágókanállal történő munkavégzéshez is. Egyaránt kompatibilis a Palms egyalvázas és duplaalvázas kivitelű pótkocsijaival.", 1, "[\"PALMS-7.87-1\",\"PALMS-7.87-2\",\"PALMS-7.87-3\",\"PALMS-7.87-4\",\"PALMS-7.87-5\",\"PALMS-7.87-6\"]", 1, "1250", "1480", "-", "530", "630", "-", 1, 1, "8.7", "PALMS 7.87", 1, "380", "19835", 1, "60-120", "60", "Palms", "60", "FL (Indexator-tól)", "7", 2, "4", "21", null, 1, "3,8", 1, 1, "[\"z55HswaDwSA\"]", 1, "190/215" },
                    { 11, 2, "78", "86", "96", 1, 1, "1310", "Nagy teherbírású erdészeti daru, két, kitolható teleszkóppal ellátva, a mindennapos erdészeti munkákra tervezve, profi szinten. Magas emelőkapacitással és forgatónyomatékkal rendelkezik, akár vágókanállal, biokanállal is használható. Kompatibilis a nagyobb Palms pótkocsikkal, akár egy, akár duplaalvázas kivitelű.", 1, "[\"PALMS-7.94-1\",\"PALMS-7.94-2\",\"PALMS-7.94-3\"]", 1, "-", "1410", "-", "-", "540", "-", 1, 1, "9.4", "PALMS 7.94", 1, "380", "20675", 1, "60-120", "60", "Palms", "60", "FL (Indexator-tól)", "7", 2, "4", "21", null, 1, "3,8", 1, 1, "[\"z55HswaDwSA\"]", 1, "215" },
                    { 12, 3, "-", "102", "112", 1, 1, "1760", "A Palms X100-as daruja a kínálatunkban a legnagyobb kinyúlással és emelőkapacitással rendelkezik. Dupla teleszkópos kivitelű, a hidraulikus alkatrészek a teleszkópokban rejtve, mégis könnyen hozzáférhetően vannak elhelyezve, biztosítva ezzel, hogy a munkálatok során ezek az alkatrészek ne sérüljenek, mégis a folyamatos üzemelés, nagy munkabírás biztosítva van.", null, "[\"PALMS-X100-1\",\"PALMS-X100-2\",\"PALMS-X100-3\",\"PALMS-X100-4\",\"PALMS-X100-5\",\"PALMS-X100-6\",\"PALMS-X100-7\"]", 1, "-", "-", "2000", "-", "-", "680", 1, 1, "10.1", "PALMS X100", 1, "380", "31235", 1, "120", "100", "Palms", "100", "FL (Indexator-tól)", "X", 2, "4", "30", null, 1, "4,2", 1, 1, "[\"x9GnpJnvNVU\"]", 1, "240" },
                    { 13, null, "11,5", "-", "-", null, null, "185", "", null, "[\"PALMS-1.42-1\",\"PALMS-1.42-2\",\"PALMS-1.42-3\",\"PALMS-1.42-4\"]", null, "-", "-", "-", "-", "-", "-", 2, null, "4.2", "PALMS 1.42", null, "330", "3300", 2, "-", "10", "csapos", "10", "Finrotor", "1", 2, "2", "2.1", 1, null, "1,2", null, null, "[\"25Y2HRXtohQ\",\"2r7Po4NpYHw\"]", null, "180" }
                });

            migrationBuilder.InsertData(
                table: "KrpanTrailer",
                columns: new[] { "Id", "CentralBeams", "Description", "DrawbarAngle", "FrameSteeringCylinders", "KrpanAdjustableDriveId", "KrpanAxeHolderId", "KrpanBBoxId", "KrpanBaleTransportPlatformId", "KrpanCardanShaftId", "KrpanCargoSpaceExtensionId", "KrpanChainsawHolderId", "KrpanChockId", "KrpanDrawHeadId", "KrpanDrawbarSteeringId", "KrpanExtensionId", "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId", "KrpanFuelTankHolderId", "KrpanGrappleLocationId", "KrpanHandBrakeId", "KrpanHydraulicAdjustableChassisId", "KrpanHydraulicSupportLegId", "KrpanPlatoId", "KrpanToolBoxId", "KrpanTopConnectionId", "KrpanTrailerLampId", "KrpanTrailerSupportLegId", "LoadCapacity", "LoadingLength", "LoadingLengthWithExtension", "Name", "Price", "TotalLength", "TotalLengthWithExtension", "TotalWidth", "Weight" },
                values: new object[,]
                {
                    { 1, "2/180×100x6", "", "40", "2", 1, 2, 1, 1, 1, 2, 2, 1, 1, 1, null, null, 1, 2, 1, 1, null, null, null, 2, 1, 1, 1, "8000", "3582", "4477", "GP 8 DF", "10904,40", "5919", "6814", "2067", "1690" },
                    { 2, "2/180×100x6", "", "40", "2", 1, 2, 1, 1, 1, 2, 2, 1, 1, 1, null, null, 1, 2, 1, 1, null, null, null, 2, 1, 1, 1, "9000", "3582", "4477", "GP 9 DF", "11502,00", "5919", "6814", "2067", "1690" },
                    { 3, "2/180×100x6", "", "40", "2", 1, 2, 1, 1, 1, 2, 2, 1, 1, 1, null, null, 1, 2, 1, 1, null, null, null, 2, 1, 1, 1, "10000", "3582", "4477", "GP 10 DF", "12177,08", "5919", "6814", "2067", "1690" },
                    { 4, "2/180×100x6", "", "40", "2", 1, 2, 1, 1, 1, 2, 2, 1, 1, 1, null, 1, 1, 2, 1, 1, null, null, null, 2, 1, 1, 1, "12000", "3975", "4755", "GP 12 DF", "13127,08", "6209", "7100", "2122", "2100" },
                    { 5, "2/200×100x8", "", "40", "2", 1, 2, 1, 1, 1, 2, 2, 1, 1, 1, null, 1, 1, 2, 1, 1, null, null, null, 2, 1, 1, 1, "14000", "4325", "5105", "GP 14 DF", "14619,17", "6559", "7545", "2222", "2300" },
                    { 6, "2/180×100x6", "", "40", "2", 1, 1, 2, 2, 1, 1, 1, 1, 2, 1, null, null, 2, 1, 1, 1, 1, null, null, 1, null, 1, 1, "11000", "3707", "4487", "GP 11 D", "13241,67", "5944", "6724", "2152", "1734" },
                    { 7, "2/200×100x6", "", "40", "2", 1, 1, 3, 3, 1, 1, 1, 1, 2, 1, null, 1, 2, 1, 1, 1, 1, null, 1, 1, null, 1, 1, "13000", "3975", "4755", "GP 13 D", "15010,00", "6334", "7144", "2200", "2144" },
                    { 8, "2/200×100x8", "", "40", "2", 1, 1, 4, 4, 1, 1, 1, 1, 2, 1, 1, 1, 2, 1, 1, 1, 1, null, 1, 1, null, 1, 1, "14800", "4325", "5105", "GP 15 D", "16625,83", "6686", "6686", "2318", "2352" },
                    { 9, "140x8", "", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1, null, null, null, null, null, null, null, "6000", "3407", "4007", "GP 6 XS", "6243,72", "5583", "6259", "1824", "1090" },
                    { 10, "140x8", "", "35", "1", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1, null, null, null, null, null, null, null, "7000", "3407", "4007", "GP 7 XS", "6882,00", "5620", "6284", "1824", "1115" },
                    { 11, "140x8", "", "35", "1", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1, null, null, null, null, null, null, null, "8000", "3407", "4007", "GP 8 XS", "7022,00", "5620", "6284", "1824", "1115" },
                    { 12, "160x6", "", "40", "2", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1, null, null, null, null, null, null, null, "8000", "3600", "4400", "GP 8 S", "8353,33", "5939", "6723", "2050", "1190" },
                    { 13, "160x6", "", "+40", "2", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1, null, null, null, null, null, null, null, "9000", "3600", "4400", "GP 9 S", "9193,33", "5939", "6723", "2050", "1220" },
                    { 14, "160x6", "", "40", "2", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1, null, null, null, null, null, null, null, "10000", "3600", "4400", "GP 10 S", "10043,33", "5939", "6723", "2050", "1240" }
                });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "BBoxId", "BeamType", "BolsterLockId", "BunkAdapterId", "BunkExtensionId", "ChainsawHolderId", "CurbWeight", "DBoxId", "Description", "DrawbarControlCylinders", "Frame", "FrameExtensionId", "FrameExtensionLength", "GrossWeight", "HandBrakeId", "HayBaleFrameId", "HydropackControlId", "ImageUrls", "LoadingAreaCross", "LoadingAreaLength", "MOTId", "ManualBunkExtensionId", "MaxCraneSize", "Name", "Price", "ShippingId", "StanchionExtensionId", "StandardWheelSize", "ToolboxId", "TotalLength", "TrailerOilCoolerId", "UnderrunProtectionId", "VideoUrls", "WidthWithStandardWheels", "WoodSorterId" },
                values: new object[,]
                {
                    { 1, null, "Egyalvázas", null, null, null, 1, "890", null, "A PALMS 6S egy egyalvázas erdészeti pótkocsi, melynek össztömege 8500 kg. Könnyű és kompakt kialakítása tökéletes választás kisebb traktorokhoz, ideális erdőgazdálkodáshoz és gazdálkodóknak. A PALMS 6S hasonló technológiákat használ, mint nagyobb pótkocsijaink, beleértve a magas minőségű KTL és porfestési bevonatot, ami hosszabb élettartamot és magasabb maradványértéket biztosít.", "1", "140x140x6", null, "-", "8500", null, null, null, "[\"PALMS-6S-1\",\"PALMS-6S-2\",\"PALMS-6S-3\",\"PALMS-6S-4\"]", "1,5", "3000", 1, null, "35", "PALMS 6S", "", 1, null, "400/60-15,5", 1, "4900", 1, null, "[\"5-tqIrDOU0I\",\"OUXj3T4seD0\"]", "1950", null },
                    { 2, 1, "Egyalvázas", 1, null, null, 1, "1180", null, "A PALMS 8SX egy egyalvázas erdészeti pótkocsi, amelynek össztömege 10.000 kg. Ez a modell népszerű választás számos kis erdőbirtokos és gazdálkodó körében. A pótkocsi egyszerű, mégis robusztus kialakítása és tartóssága megbízható társává teszi különböző erdészeti és mezőgazdasági feladatokban.", "2", "160x160x8", null, "0,61", "10000", 1, null, null, "[\"PALMS-8SX-1\",\"PALMS-8SX-2\"]", "2", "3550", 1, null, "58", "PALMS 8SX", "", 1, null, "400/60-15,5", 1, "5690", 1, 2, "[\"VEvGOG-aFyM\"]", "2070", 1 },
                    { 3, 1, "Dupla alvázas", 1, null, null, 1, "1510", null, "A PALMS 8D erdészeti pótkocsi, melynek össztömege 10000 kg. Ez a modell már duplaalvázas kivitelű, a legkompaktabb pótkocsi a kínálatunkban. Azoknak a felhasználóknak ajánljuk, akik könnyebb pótkocsit keresnek, de mégis már egy duplaalvázas kivitel nagyobb szilárdságát és merevségét szeretnék kihasználni.", "2", "2x200x100x8", null, "0,85", "10000", 1, 1, null, "[\"PALMS-8D-1\",\"PALMS-8D-2\",\"PALMS-8D-3\",\"PALMS-8D-4\",\"PALMS-8D-5\"]", "2", "3975", 1, null, "65", "PALMS 8D", "", 1, null, "400/60-15,5", 1, "6200", 1, 1, "[\"cdz1OF0USqI\",\"PEdgbkWowyQ\"]", "2095", 1 },
                    { 4, 1, "Egyalvázas", 1, null, null, 1, "1425", null, "A PALMS 9SC a termékpalettánk legnagyobb egyalvázas pótkocsija, össztömege 12000 kg. Ideális választás azoknak, akik preferálják az egyalvázas pótkocsi egyszerűségét, miközben hosszabb kinyúlást igényelnek egy erdészeti darutól. Emellett a Palms 9SC kiemelkedik a felhasználói kényelem terén más, szintén egyalvázas pótkocsik közül a csapszeges vonórúd zár megoldásával és a szabadalmaztatott rakonca rögzítéssel.", "2", "200x200x6", null, "0,70", "12000", 1, null, null, "[\"PALMS-9SC-1\",\"PALMS-9SC-2\",\"Patented-Bolster-Lock\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Lightweight-Frame\"]", "2,15", "3870", 1, null, "65", "PALMS 9SC", "", 1, null, "400/60-15,5", 1, "6095", 1, 2, "[\"4ZeFp4Yofak\"]", "2135", 1 },
                    { 5, 1, "Dupla alvázas", 1, null, null, 1, "1765", null, "A PALMS 10D duplaalvázas pótkocsi, melynek össztömege 13000 kg, az egyik legkeresettebb erdészeti pótkocsi a PALMS terméksorozatában. Kiválóan párosítható a legtöbb Palms daruval és egyéb kiegészítőkkel, lehetővé téve az egyéni igény szerinti felszereltséget, hogy olyan konstrukciót alkosson, amely pontosan megfelel az elvárásainak.", "2", "2x200x100x8", null, "0,85", "13000", 1, 1, null, "[\"PALMS-10D-1\",\"PALMS-10D-2\",\"PALMS-10D-3\",\"PALMS-10D-4\",\"PALMS-10D-5\",\"Patented-Bolster-Lock\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Durable-Double-Frame\",\"Protected\"]", "2,4", "3975", 1, null, "85", "PALMS 10D", "", 1, null, "400/60-15,5", 1, "6200", 1, 1, "[\"0u8VqxRevL4\"]", "2165", 1 },
                    { 6, 1, "Dupla alvázas", 1, null, null, 1, "2030", null, "A PALMS 12D duplaalvázas erdészeti pótkocsi, melynek összetömege 15000 kg. Akár mindennapi, akár nagyobb munkálatok elvégzésére is kiválóan alkalmas, nagyszerű kompatibilitás nyújtva a Palms 5-ös és 7-es szériás daruival.  ", "2", "2x200x100x8", null, "0,85", "15000", 1, 1, null, "[\"PALMS-12D-1\",\"PALMS-12D-2\",\"Patented-Bolster-Lock\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Durable-Double-Frame\",\"Protected\"]", "2,7", "3975", 1, null, "85", "PALMS 12D", "", 1, null, "500/50-17", 1, "6200", 1, 1, "[]", "2350", 1 },
                    { 7, 1, "Dupla alvázas", 1, null, null, 1, "2375", null, "A PALMS 14D a Palms gyár termékkínálatának legnagyobb dupla alvázas pótkocsija, jelentős, 18000 kg össztömegével. Nemcsak a legnagyobb rakfelülettel rendelkezik, hanem kiterjesztett rakfelületet kínál más dupla alvázas pótkocsikhoz képest. További előnye, hogy kompatibilis a Palms legnagyobb, legprofibb erdészeti darujával, az X100-sal is. ", "2", "2x200x120x10", null, "0,86", "18000", 1, 1, null, "[\"PALMS-14D-1\",\"PALMS-14D-2\",\"PALMS-14D-3\",\"PALMS-14D-4\",\"Patented-Bolster-Lock\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Durable-Double-Frame\",\"Protected\"]", "3,0", "4080", 1, null, "112", "PALMS 14D", "", 1, null, "500/50-17", 1, "6300", 1, 1, "[]", "2450", 1 },
                    { 8, 2, "Unibody (Forwarder)", 1, 1, null, 1, "2170", null, "A PALMS 10UX erdészeti pótkocsi az U-sorozat legkisebb változata, mely a duplaalvázas kivitel mellett az úgynevezett unibody típusú rakoncákkal van szerelve. Össztömege 13000 kg. Nagy hasmagassága és az unibody keret csökkenti az elakadás kockázatát. A hidraulikus alkatrészek az unibody keretben vannak elhelyezve, védve ezzel azokat, mégis könnyű hozzáférést biztosít a karbantartáshoz. ", "2", "unibody", 1, "1,085", "13000", 1, 2, null, "[\"PALMS-10UX-1\",\"PALMS-10UX-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]", "2.4", "3990", 1, 1, "90", "PALMS 10UX", "", 1, null, "500/50-17", 1, "6215", 1, 2, "[]", "2245", null },
                    { 9, 2, "Unibody (Forwarder)", 1, 1, null, 1, "2270", null, "A PALMS 12U pótkocsi össztömege 17000 kg, unibody típusú erdészeti pótkocsi, melyet kifejezetten a mindennapi, szakmai erdészeti munkákhoz terveztek. Magas hasmagassággal rendelkezik, ez és a forwarder típusú keret elősegíti, hogy az elakadás kockázata minél kisebb legyen. Mivel az összes hidraulikus alkatrész ebben a keretben került elhelyezésre, így azok védve vannak, ugyanakkor viszont könnyű hozzáférhetőség biztosítja a karbantartás elvégzését.", "2", "unibody", 1, "1,085", "17000", 1, 2, null, "[\"PALMS-12U-UAWD-1\",\"PALMS-12U-UAWD-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]", "2.75", "3990", 1, null, "120", "PALMS 12U", "", 1, null, "500/50-22,5", 1, "6215", 1, 2, "[\"akmzrXf3EnU\"]", "2245", null },
                    { 10, 2, "Unibody (Forwarder)", 1, 1, null, 1, "2270", null, "A PALMS 12UAWD pótkocsi össztömege 17000 kg, unibody típusú erdészeti pótkocsi, melyet kifejezetten a mindennapi, szakmai erdészeti munkákhoz terveztek. Magas hasmagassággal rendelkezik, ez és a forwarder típusú keret elősegíti, hogy az elakadás kockázata minél kisebb legyen. Mivel az összes hidraulikus alkatrész ebben a keretben került elhelyezésre, így azok védve vannak, ugyanakkor viszont könnyű hozzáférhetőség biztosítja a karbantartás elvégzését. Ennek a típusnak további előnye, hogy négykerék hajtással rendelkezik, amely alkalmassá teszi arra, hogy akár extrém talajviszonyok között is megállja a helyét. ", "2", "unibody", 1, "1,085", "17000", 1, 2, null, "[\"PALMS-12U-UAWD-1\",\"PALMS-12U-UAWD-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]", "2.75", "3990", 1, null, "120", "PALMS 12UAWD", "", 1, null, "500/50-22,5", 1, "6215", 1, 2, "[\"akmzrXf3EnU\"]", "2245", null },
                    { 11, 3, "Unibody (Forwarder)", 1, 1, 1, 1, "2545", null, "A PALMS 15U pótkocsi a legnagyobb a Palms U típusú pótkocsi kínálatában, össztömege 19000 kg. Az U pótkocsikat nehéz fakitermelésre tervezték, a kialakításának köszönhetően tartósak és igazán nagy terheket képesek vinni. Ez a pótkocsi nagysága ellenére igen könnyen mozog, gumikerekes kivitele környezetkímélő. Nagyobb mennyiségű fa kitermelésére alkalmas, megkönnyíti az erdészeti munkát. Nagy hasmagassággal rendelkezik, ez és a forwarder típusú keret az elakadás kockázatát csökkentik. A hidraulikus alkatrészek a keretben kerültek elhelyezésre, hogy védettek legyenek a külső behatás ellen, ugyanakkor karbantartásilag könnyen elérhetők. ", "2", "unibody", 1, "1,085", "19000", 1, 2, null, "[\"PALMS-15U-UAWD-1\",\"PALMS-15U-UAWD-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]", "3.2", "4175", 1, null, "120", "PALMS 15U", "", 1, null, "500/50-22,5", 1, "6415", 1, 2, "[\"cH3t306elVs\"]", "2450", null },
                    { 12, 3, "Unibody (Forwarder)", 1, 1, 1, 1, "2545", null, "A PALMS 15U pótkocsi a legnagyobb a Palms U típusú pótkocsi kínálatában, össztömege 19000 kg. Az U pótkocsikat nehéz fakitermelésre tervezték, a kialakításának köszönhetően tartósak és igazán nagy terheket képesek vinni. Ez a pótkocsi nagysága ellenére igen könnyen mozog, gumikerekes kivitele környezetkímélő. Nagyobb mennyiségű fa kitermelésére alkalmas, megkönnyíti az erdészeti munkát. Nagy hasmagassággal rendelkezik, ez és a forwarder típusú keret az elakadás kockázatát csökkentik. A hidraulikus alkatrészek a keretben kerültek elhelyezésre, hogy védettek legyenek a külső behatás ellen, ugyanakkor karbantartásilag könnyen elérhetők. Ez a típus már négykerék hajtással rendelkezik, ezáltal bármilyen tereppel könnyedén megbirkózik.", "2", "unibody", 1, "1,085", "19000", 1, 2, null, "[\"PALMS-15U-UAWD-1\",\"PALMS-15U-UAWD-2\",\"Fast-Drawbar-Locking\",\"Extended-Product-Lifespan\",\"Easy-Access\",\"Reduced-Weight\",\"Easily-Replaceable\",\"Stronger-And-Stiffer\",\"Multiple-Bolster\",\"Uniform-Frame-Bottom\",\"Available-With\",\"Centralized-Greasing\"]", "3.2", "4175", 1, null, "120", "PALMS 15UAWD", "", 1, null, "500/50-22,5", 1, "6415", 1, 2, "[\"cH3t306elVs\"]", "2450", null },
                    { 13, 4, "Unibody (Forwarder)", null, 2, 2, null, "4700", null, "Ismerje meg a PALMS MWD sorozatú forwarder típusú pótkocsit, amelyet a legnehezebb terepek legyőzésére terveztek. Az összes MWD pótkocsi mechanikus áttétele egyedileg lesz testre szabva minden ügyfelünk traktorához.", "2", "unibody", null, "1.085", "18000", null, 2, null, "[\"PALMS-MWD3.2-1\",\"PALMS-MWD3.2-2\",\"PALMS-MWD\"]", "3.2", "4235", 1, null, "120", "PALMS MWD 3.2", "", 1, 1, "600/50x22.5", 1, "6430", null, null, "[\"hxtfyL4ONy0\"]", "2470", null },
                    { 14, 4, "Unibody (Forwarder)", null, 2, 2, null, "4920", null, "Ismerje meg a PALMS hidromechanikus meghajtású pótkocsiját, amelyet a legnehezebb terepek legyőzésére terveztek. A hidromechanikus 4x4 rendszer alkalmas minden méretű traktorhoz, amelynek TLT hajtása van.", "2", "unibody", null, "1.085", "18000", null, 2, null, "[\"PALMS-HMWD3.2-1\",\"PALMS-HMWD3.2-2\",\"PALMS-HMWD3.2-3\",\"PALMS-HMWD3.2-4\",\"PALMS-MWD\"]", "3.2", "4185", 1, null, "120", "PALMS HMWD 3.2", "", 1, 1, "600/50x22.5", 1, "6430", 2, null, "[]", "2470", null },
                    { 15, 5, "Dupla alvázas", null, null, null, 1, "260", 1, "Tökéletes kompakt traktorokhoz és terepjárókhoz. Strenx Performance acélból készült strapabíró duplaalvázzal, fokozott korrózióállósággal (KTL+por bevonatt), valamint 1500 kg névleges teherbírással rendelkezik.", "1", "2x4 mm C-alváz", 2, "-", "1500", null, null, 1, "[\"PALMS-2D-1\",\"PALMS-2D-2\",\"PALMS-2D-3\",\"PALMS-2D-4\",\"PALMS-2D-5\",\"PALMS-2D-6\",\"PALMS-2D-7\",\"PALMS-2D-8\"]", "0,6", "2450", null, null, "12", "PALMS 2D", "", 1, null, "22/11-8", null, "3865", null, null, "[\"n6LnRTycDZM\",\"2r7Po4NpYHw\",\"25Y2HRXtohQ\"]", "1285", null },
                    { 16, 2, "Unibody (Forwarder)", null, null, null, 1, "2320", null, "A PALMS 11UX az önhordó váz szerkezeti előnyeit – mint például a fokozott szilárdság, a kiváló terepjáró képességek és az egyszerű karbantartás – kínálja, a D-szériás pótkocsik árkategóriájában. Ezenkívül számos új fejlesztést is tartalmaz, beleértve a teljesen védett, vázba integrált opcionális légtartályt; az újonnan tervezett, könnyen kihúzható, forwarder-típusú szélesítést, valamint az új vonórudat.", "2", "unibody", 1, "1,138", "15000", 1, 1, null, "[\"PALMS-11UX-1\",\"PALMS-11UX-2\",\"PALMS-11UX-3\",\"PALMS-11UX-4\",\"PALMS-11UX-5\",\"PALMS-11UX-6\",\"PALMS-11UX-7\",\"PALMS-11UX-8\"]", "2.4-2.9", "3976", 1, 1, "90", "PALMS 11UX", "", 1, null, "500/50-17", 1, "6285", 1, null, "[\"Wl0s4WdzNDM\",\"kHSq-CN9i3k\"]", "2312", null }
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
                    { 1, 12 },
                    { 1, 16 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 8 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 8 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 8 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 8 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 4 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 4 },
                    { 8, 3 },
                    { 8, 5 },
                    { 8, 8 },
                    { 9, 3 },
                    { 9, 5 },
                    { 9, 8 },
                    { 10, 6 },
                    { 10, 7 },
                    { 10, 9 },
                    { 10, 11 },
                    { 10, 16 },
                    { 11, 6 },
                    { 11, 7 },
                    { 11, 9 },
                    { 11, 11 },
                    { 11, 16 },
                    { 12, 6 },
                    { 12, 7 },
                    { 12, 9 },
                    { 12, 11 },
                    { 12, 16 },
                    { 13, 6 },
                    { 13, 7 },
                    { 13, 9 },
                    { 13, 11 },
                    { 13, 16 },
                    { 14, 6 },
                    { 14, 7 },
                    { 14, 9 },
                    { 14, 11 },
                    { 14, 16 },
                    { 15, 6 },
                    { 15, 7 },
                    { 15, 9 },
                    { 15, 11 },
                    { 15, 16 },
                    { 16, 10 },
                    { 16, 12 },
                    { 17, 10 },
                    { 17, 12 },
                    { 18, 10 },
                    { 18, 12 },
                    { 19, 10 },
                    { 19, 12 },
                    { 20, 10 },
                    { 20, 12 },
                    { 21, 10 },
                    { 21, 12 },
                    { 23, 13 },
                    { 23, 14 },
                    { 24, 13 },
                    { 24, 14 }
                });

            migrationBuilder.InsertData(
                table: "ControlBlockCrane",
                columns: new[] { "ControlBlockId", "CraneId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 13 },
                    { 3, 2 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 8 },
                    { 5, 2 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 },
                    { 5, 8 },
                    { 5, 9 },
                    { 5, 10 },
                    { 5, 11 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 6, 8 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 6, 12 },
                    { 7, 2 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 7, 7 },
                    { 7, 8 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 11 },
                    { 8, 5 },
                    { 8, 6 },
                    { 8, 7 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 8, 11 },
                    { 8, 12 },
                    { 9, 5 },
                    { 9, 6 },
                    { 9, 7 },
                    { 9, 8 },
                    { 9, 9 },
                    { 9, 10 },
                    { 9, 11 },
                    { 9, 12 },
                    { 10, 5 },
                    { 10, 6 },
                    { 10, 7 },
                    { 10, 8 },
                    { 10, 9 },
                    { 10, 10 },
                    { 10, 11 },
                    { 10, 12 },
                    { 11, 4 },
                    { 11, 5 },
                    { 11, 6 },
                    { 11, 7 },
                    { 11, 8 },
                    { 11, 9 },
                    { 11, 10 },
                    { 11, 11 },
                    { 11, 12 },
                    { 12, 5 },
                    { 12, 6 },
                    { 12, 7 },
                    { 12, 8 },
                    { 12, 9 },
                    { 12, 10 },
                    { 12, 11 },
                    { 12, 12 },
                    { 13, 5 },
                    { 13, 6 },
                    { 13, 7 },
                    { 13, 8 },
                    { 13, 9 },
                    { 13, 10 },
                    { 13, 11 },
                    { 13, 12 },
                    { 14, 10 },
                    { 14, 11 },
                    { 14, 12 },
                    { 16, 13 }
                });

            migrationBuilder.InsertData(
                table: "CraneTrailer",
                columns: new[] { "CraneId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 8 },
                    { 1, 16 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 8 },
                    { 2, 16 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 8 },
                    { 3, 16 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 8 },
                    { 4, 16 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 },
                    { 5, 8 },
                    { 5, 9 },
                    { 5, 10 },
                    { 5, 16 },
                    { 6, 3 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 6, 8 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 6, 12 },
                    { 6, 16 },
                    { 7, 3 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 7, 7 },
                    { 7, 8 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 11 },
                    { 7, 12 },
                    { 7, 16 },
                    { 8, 3 },
                    { 8, 5 },
                    { 8, 6 },
                    { 8, 7 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 8, 11 },
                    { 8, 12 },
                    { 8, 16 },
                    { 9, 3 },
                    { 9, 5 },
                    { 9, 6 },
                    { 9, 7 },
                    { 9, 9 },
                    { 9, 10 },
                    { 9, 11 },
                    { 9, 12 },
                    { 9, 13 },
                    { 9, 14 },
                    { 9, 16 },
                    { 10, 3 },
                    { 10, 5 },
                    { 10, 6 },
                    { 10, 7 },
                    { 10, 9 },
                    { 10, 10 },
                    { 10, 11 },
                    { 10, 12 },
                    { 10, 13 },
                    { 10, 14 },
                    { 10, 16 },
                    { 11, 6 },
                    { 11, 7 },
                    { 11, 9 },
                    { 11, 10 },
                    { 11, 11 },
                    { 11, 12 },
                    { 11, 13 },
                    { 11, 14 },
                    { 11, 16 },
                    { 12, 7 },
                    { 12, 9 },
                    { 12, 10 },
                    { 12, 11 },
                    { 12, 12 },
                    { 12, 13 },
                    { 12, 14 },
                    { 13, 15 }
                });

            migrationBuilder.InsertData(
                table: "DampingCrane",
                columns: new[] { "CraneId", "DampingId" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 3 },
                    { 8, 1 },
                    { 8, 2 },
                    { 8, 3 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 3 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 3 },
                    { 11, 1 },
                    { 11, 2 },
                    { 11, 3 },
                    { 12, 1 },
                    { 12, 2 },
                    { 12, 3 }
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
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 16 },
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
                    { 2, 12 },
                    { 2, 16 },
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
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 16 },
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
                    { 4, 12 },
                    { 4, 16 },
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
                    { 5, 12 },
                    { 5, 16 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 6, 12 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 3 },
                    { 8, 6 },
                    { 8, 7 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 8, 11 },
                    { 8, 12 },
                    { 8, 16 },
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
                    { 9, 11 },
                    { 9, 12 },
                    { 9, 16 },
                    { 10, 13 },
                    { 10, 14 },
                    { 11, 13 },
                    { 11, 14 },
                    { 12, 13 },
                    { 12, 14 },
                    { 13, 8 },
                    { 13, 9 },
                    { 13, 10 },
                    { 13, 11 },
                    { 13, 13 },
                    { 13, 14 },
                    { 13, 16 },
                    { 14, 15 },
                    { 15, 15 }
                });

            migrationBuilder.InsertData(
                table: "FrameTypeCrane",
                columns: new[] { "CraneId", "FrameTypeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 1 },
                    { 3, 2 },
                    { 4, 1 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 5, 1 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 6, 1 },
                    { 6, 3 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 8 },
                    { 7, 1 },
                    { 7, 3 },
                    { 7, 5 },
                    { 7, 6 },
                    { 7, 8 },
                    { 8, 7 },
                    { 9, 1 },
                    { 9, 5 },
                    { 9, 6 },
                    { 9, 8 },
                    { 10, 1 },
                    { 10, 5 },
                    { 10, 6 },
                    { 10, 8 },
                    { 11, 1 },
                    { 11, 6 },
                    { 11, 8 },
                    { 12, 1 },
                    { 12, 6 },
                    { 12, 8 },
                    { 13, 9 }
                });

            migrationBuilder.InsertData(
                table: "GrappleCrane",
                columns: new[] { "CraneId", "GrappleId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 13 },
                    { 1, 14 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 13 },
                    { 2, 14 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 13 },
                    { 3, 14 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 7 },
                    { 4, 13 },
                    { 4, 14 },
                    { 4, 15 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 7 },
                    { 5, 12 },
                    { 5, 13 },
                    { 5, 14 },
                    { 5, 15 },
                    { 6, 1 },
                    { 6, 3 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 6, 8 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 6, 12 },
                    { 6, 14 },
                    { 6, 15 },
                    { 7, 1 },
                    { 7, 3 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 7, 7 },
                    { 7, 8 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 11 },
                    { 7, 12 },
                    { 7, 14 },
                    { 7, 15 },
                    { 8, 1 },
                    { 8, 3 },
                    { 8, 4 },
                    { 8, 5 },
                    { 8, 6 },
                    { 8, 7 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 8, 11 },
                    { 8, 14 },
                    { 8, 15 },
                    { 9, 1 },
                    { 9, 4 },
                    { 9, 5 },
                    { 9, 6 },
                    { 9, 7 },
                    { 9, 8 },
                    { 9, 9 },
                    { 9, 10 },
                    { 9, 11 },
                    { 9, 15 },
                    { 10, 1 },
                    { 10, 4 },
                    { 10, 5 },
                    { 10, 6 },
                    { 10, 7 },
                    { 10, 8 },
                    { 10, 9 },
                    { 10, 10 },
                    { 10, 11 },
                    { 10, 15 },
                    { 11, 1 },
                    { 11, 4 },
                    { 11, 5 },
                    { 11, 6 },
                    { 11, 7 },
                    { 11, 8 },
                    { 11, 9 },
                    { 11, 10 },
                    { 11, 11 },
                    { 11, 15 },
                    { 12, 1 },
                    { 12, 4 },
                    { 12, 5 },
                    { 12, 6 },
                    { 12, 7 },
                    { 12, 8 },
                    { 12, 9 },
                    { 12, 10 },
                    { 12, 11 },
                    { 12, 15 },
                    { 13, 16 }
                });

            migrationBuilder.InsertData(
                table: "HighPerformanceOilFilterCrane",
                columns: new[] { "CraneId", "HighPerformanceOilFilterId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 1 },
                    { 3, 2 },
                    { 4, 1 },
                    { 4, 2 },
                    { 5, 1 },
                    { 5, 2 },
                    { 6, 1 },
                    { 6, 2 },
                    { 7, 1 },
                    { 7, 2 },
                    { 8, 1 },
                    { 8, 2 },
                    { 9, 1 },
                    { 9, 2 },
                    { 10, 1 },
                    { 10, 2 },
                    { 11, 1 },
                    { 11, 2 },
                    { 12, 1 },
                    { 12, 2 }
                });

            migrationBuilder.InsertData(
                table: "HoseGuardCrane",
                columns: new[] { "CraneId", "HoseGuardId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 6, 2 },
                    { 7, 1 },
                    { 7, 2 },
                    { 9, 1 },
                    { 9, 2 },
                    { 10, 1 },
                    { 10, 2 },
                    { 11, 2 },
                    { 12, 2 }
                });

            migrationBuilder.InsertData(
                table: "HydroPackTrailer",
                columns: new[] { "HydroPackId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 15 },
                    { 2, 15 },
                    { 3, 15 }
                });

            migrationBuilder.InsertData(
                table: "KrpanBrakeTrailer",
                columns: new[] { "KrpanBrakeId", "KrpanTrailerId" },
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
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 3, 4 },
                    { 3, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 8 }
                });

            migrationBuilder.InsertData(
                table: "KrpanClutchTrailer",
                columns: new[] { "KrpanClutchId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 }
                });

            migrationBuilder.InsertData(
                table: "KrpanCraneTrailer",
                columns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 6 },
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 6 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 7 },
                    { 4, 8 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 7 },
                    { 5, 8 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 7 },
                    { 6, 8 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 11 },
                    { 7, 12 },
                    { 7, 13 },
                    { 7, 14 },
                    { 8, 9 },
                    { 8, 10 },
                    { 8, 11 },
                    { 8, 12 },
                    { 8, 13 },
                    { 8, 14 }
                });

            migrationBuilder.InsertData(
                table: "KrpanDrawbarTrailer",
                columns: new[] { "KrpanDrawbarId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 }
                });

            migrationBuilder.InsertData(
                table: "KrpanPropulsionTrailer",
                columns: new[] { "KrpanPropulsionId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 7 },
                    { 3, 8 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 7 },
                    { 4, 8 }
                });

            migrationBuilder.InsertData(
                table: "KrpanTyreTrailer",
                columns: new[] { "KrpanTrailerId", "KrpanTyreId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 7 },
                    { 1, 8 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 7 },
                    { 2, 8 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 7 },
                    { 3, 8 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 5 },
                    { 4, 8 },
                    { 4, 10 },
                    { 4, 11 },
                    { 4, 12 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 5 },
                    { 5, 8 },
                    { 5, 10 },
                    { 5, 11 },
                    { 5, 12 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 7 },
                    { 6, 8 },
                    { 7, 2 },
                    { 7, 3 },
                    { 7, 5 },
                    { 7, 8 },
                    { 7, 10 },
                    { 7, 11 },
                    { 8, 2 },
                    { 8, 3 },
                    { 8, 5 },
                    { 8, 8 },
                    { 8, 10 },
                    { 8, 11 },
                    { 9, 1 },
                    { 9, 4 },
                    { 10, 1 },
                    { 10, 4 },
                    { 11, 1 },
                    { 11, 4 },
                    { 12, 2 },
                    { 12, 4 },
                    { 12, 6 },
                    { 12, 8 },
                    { 12, 9 },
                    { 13, 2 },
                    { 13, 4 },
                    { 13, 6 },
                    { 13, 8 },
                    { 13, 9 },
                    { 14, 2 },
                    { 14, 4 },
                    { 14, 6 },
                    { 14, 8 },
                    { 14, 9 }
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
                    { 1, 12 },
                    { 1, 16 },
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
                    { 2, 12 },
                    { 2, 16 },
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
                    { 3, 12 },
                    { 3, 15 },
                    { 3, 16 },
                    { 4, 13 },
                    { 4, 14 },
                    { 5, 13 },
                    { 5, 14 }
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
                    { 1, 12 },
                    { 1, 16 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 11 },
                    { 2, 16 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 11 },
                    { 3, 16 },
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
                    { 4, 12 },
                    { 4, 16 },
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
                    { 5, 12 },
                    { 5, 16 },
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
                    { 6, 12 },
                    { 6, 16 },
                    { 7, 2 },
                    { 7, 3 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 7, 7 },
                    { 7, 8 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 11 },
                    { 7, 12 },
                    { 7, 16 },
                    { 8, 14 }
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
                    { 1, 12 },
                    { 1, 16 },
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
                    { 2, 12 },
                    { 2, 16 },
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
                    { 3, 12 },
                    { 3, 16 },
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
                    { 4, 12 },
                    { 4, 16 },
                    { 7, 14 }
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
                    { 1, 12 },
                    { 1, 16 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "PropulsionTrailer",
                columns: new[] { "PropulsionId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 4 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 },
                    { 5, 16 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 6, 16 },
                    { 7, 5 },
                    { 7, 8 },
                    { 8, 5 },
                    { 8, 8 },
                    { 9, 5 },
                    { 9, 8 },
                    { 10, 5 },
                    { 10, 8 },
                    { 12, 6 },
                    { 12, 7 },
                    { 12, 16 },
                    { 13, 6 },
                    { 13, 7 },
                    { 13, 16 },
                    { 14, 6 },
                    { 14, 7 },
                    { 14, 16 },
                    { 15, 6 },
                    { 15, 7 },
                    { 15, 16 },
                    { 16, 9 },
                    { 16, 11 },
                    { 17, 9 },
                    { 17, 11 },
                    { 18, 9 },
                    { 18, 11 },
                    { 19, 9 },
                    { 19, 11 },
                    { 20, 10 },
                    { 20, 12 },
                    { 21, 10 },
                    { 21, 12 },
                    { 22, 15 }
                });

            migrationBuilder.InsertData(
                table: "RotatorBrakeCrane",
                columns: new[] { "CraneId", "RotatorBrakeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 4 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 4 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 4 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 4 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 5 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 5 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 5 },
                    { 8, 1 },
                    { 8, 2 },
                    { 8, 5 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 5 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 5 },
                    { 11, 1 },
                    { 11, 2 },
                    { 11, 5 },
                    { 12, 1 },
                    { 12, 2 },
                    { 12, 5 }
                });

            migrationBuilder.InsertData(
                table: "RotatorCrane",
                columns: new[] { "CraneId", "RotatorId" },
                values: new object[,]
                {
                    { 13, 1 },
                    { 13, 8 }
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
                    { 11, 3 },
                    { 12, 3 },
                    { 13, 3 },
                    { 14, 3 },
                    { 15, 4 },
                    { 16, 4 },
                    { 17, 4 },
                    { 18, 4 },
                    { 19, 5 },
                    { 20, 5 },
                    { 21, 5 },
                    { 22, 5 },
                    { 23, 6 },
                    { 24, 6 },
                    { 25, 6 },
                    { 26, 6 },
                    { 27, 7 },
                    { 28, 7 },
                    { 29, 7 },
                    { 30, 7 },
                    { 32, 8 },
                    { 34, 8 },
                    { 36, 8 },
                    { 38, 8 },
                    { 39, 9 },
                    { 40, 9 },
                    { 41, 9 },
                    { 42, 9 },
                    { 43, 9 },
                    { 44, 9 },
                    { 45, 9 },
                    { 46, 9 },
                    { 47, 10 },
                    { 48, 10 },
                    { 49, 10 },
                    { 50, 10 },
                    { 51, 10 },
                    { 52, 10 },
                    { 53, 10 },
                    { 54, 10 },
                    { 55, 11 },
                    { 56, 11 },
                    { 57, 11 },
                    { 58, 11 },
                    { 59, 11 },
                    { 60, 11 },
                    { 61, 11 },
                    { 62, 11 },
                    { 63, 12 },
                    { 64, 12 },
                    { 65, 12 },
                    { 66, 12 },
                    { 67, 12 },
                    { 68, 12 },
                    { 69, 12 },
                    { 70, 12 },
                    { 71, 13 },
                    { 72, 13 },
                    { 73, 13 },
                    { 74, 13 },
                    { 75, 14 },
                    { 76, 14 },
                    { 77, 14 },
                    { 78, 14 },
                    { 79, 15 },
                    { 80, 15 },
                    { 81, 15 },
                    { 82, 16 },
                    { 83, 16 },
                    { 84, 16 },
                    { 85, 16 }
                });

            migrationBuilder.InsertData(
                table: "SupplyFormatTrailer",
                columns: new[] { "SupplyFormatId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 15 },
                    { 2, 15 }
                });

            migrationBuilder.InsertData(
                table: "SupportLegTrailer",
                columns: new[] { "SupportLegId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 15 },
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
                    { 2, 12 },
                    { 2, 16 },
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
                    { 3, 12 },
                    { 3, 16 }
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
                    { 3, 4 },
                    { 3, 6 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 6 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 },
                    { 5, 8 },
                    { 5, 9 },
                    { 6, 5 },
                    { 6, 7 },
                    { 6, 8 },
                    { 6, 9 },
                    { 7, 5 },
                    { 7, 7 },
                    { 7, 8 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 11 },
                    { 8, 3 },
                    { 8, 4 },
                    { 8, 5 },
                    { 8, 6 },
                    { 8, 7 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 9, 5 },
                    { 9, 7 },
                    { 9, 8 },
                    { 9, 9 },
                    { 9, 10 },
                    { 9, 11 },
                    { 10, 5 },
                    { 10, 7 },
                    { 10, 8 },
                    { 10, 9 },
                    { 10, 10 },
                    { 10, 11 },
                    { 11, 5 },
                    { 11, 7 },
                    { 11, 8 },
                    { 11, 9 },
                    { 11, 10 },
                    { 11, 11 },
                    { 12, 5 },
                    { 12, 7 },
                    { 12, 8 },
                    { 12, 9 },
                    { 12, 10 },
                    { 12, 11 },
                    { 13, 12 },
                    { 13, 13 },
                    { 14, 12 },
                    { 14, 13 },
                    { 15, 14 },
                    { 16, 5 },
                    { 16, 7 },
                    { 16, 8 },
                    { 16, 9 }
                });

            migrationBuilder.InsertData(
                table: "WinchCrane",
                columns: new[] { "CraneId", "WinchId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 1 },
                    { 3, 2 },
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
                    { 7, 3 },
                    { 8, 1 },
                    { 8, 2 },
                    { 8, 3 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 3 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 3 },
                    { 11, 1 },
                    { 11, 2 },
                    { 11, 3 },
                    { 12, 1 },
                    { 12, 2 },
                    { 12, 3 },
                    { 13, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrakeTrailer_TrailerId",
                table: "BrakeTrailer",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlBlockCrane_CraneId",
                table: "ControlBlockCrane",
                column: "CraneId");

            migrationBuilder.CreateIndex(
                name: "IX_Crane_BoomGuardId",
                table: "Crane",
                column: "BoomGuardId");

            migrationBuilder.CreateIndex(
                name: "IX_Crane_CoverId",
                table: "Crane",
                column: "CoverId");

            migrationBuilder.CreateIndex(
                name: "IX_Crane_CraneOilCoolerId",
                table: "Crane",
                column: "CraneOilCoolerId");

            migrationBuilder.CreateIndex(
                name: "IX_Crane_ElectricalFloatingId",
                table: "Crane",
                column: "ElectricalFloatingId");

            migrationBuilder.CreateIndex(
                name: "IX_Crane_JoystickHolderId",
                table: "Crane",
                column: "JoystickHolderId");

            migrationBuilder.CreateIndex(
                name: "IX_Crane_LightId",
                table: "Crane",
                column: "LightId");

            migrationBuilder.CreateIndex(
                name: "IX_Crane_LinkageId",
                table: "Crane",
                column: "LinkageId");

            migrationBuilder.CreateIndex(
                name: "IX_Crane_OperatorSeatId",
                table: "Crane",
                column: "OperatorSeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Crane_ProtectionSleevesId",
                table: "Crane",
                column: "ProtectionSleevesId");

            migrationBuilder.CreateIndex(
                name: "IX_Crane_ShippingId",
                table: "Crane",
                column: "ShippingId");

            migrationBuilder.CreateIndex(
                name: "IX_Crane_SupportBracketId",
                table: "Crane",
                column: "SupportBracketId");

            migrationBuilder.CreateIndex(
                name: "IX_Crane_SupportLegCounterPlateId",
                table: "Crane",
                column: "SupportLegCounterPlateId");

            migrationBuilder.CreateIndex(
                name: "IX_Crane_TurningDeviceCounterPlateId",
                table: "Crane",
                column: "TurningDeviceCounterPlateId");

            migrationBuilder.CreateIndex(
                name: "IX_Crane_ValveBlockId",
                table: "Crane",
                column: "ValveBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Crane_WoodControlId",
                table: "Crane",
                column: "WoodControlId");

            migrationBuilder.CreateIndex(
                name: "IX_CraneTrailer_TrailerId",
                table: "CraneTrailer",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_DampingCrane_DampingId",
                table: "DampingCrane",
                column: "DampingId");

            migrationBuilder.CreateIndex(
                name: "IX_DrawbarTrailer_TrailerId",
                table: "DrawbarTrailer",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_FrameTypeCrane_FrameTypeId",
                table: "FrameTypeCrane",
                column: "FrameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GrappleCrane_GrappleId",
                table: "GrappleCrane",
                column: "GrappleId");

            migrationBuilder.CreateIndex(
                name: "IX_HighPerformanceOilFilterCrane_HighPerformanceOilFilterId",
                table: "HighPerformanceOilFilterCrane",
                column: "HighPerformanceOilFilterId");

            migrationBuilder.CreateIndex(
                name: "IX_HoseGuardCrane_HoseGuardId",
                table: "HoseGuardCrane",
                column: "HoseGuardId");

            migrationBuilder.CreateIndex(
                name: "IX_HydroPackTrailer_TrailerId",
                table: "HydroPackTrailer",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanBrakeTrailer_KrpanTrailerId",
                table: "KrpanBrakeTrailer",
                column: "KrpanTrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanClutchTrailer_KrpanTrailerId",
                table: "KrpanClutchTrailer",
                column: "KrpanTrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanCraneTrailer_KrpanTrailerId",
                table: "KrpanCraneTrailer",
                column: "KrpanTrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanDrawbarTrailer_KrpanTrailerId",
                table: "KrpanDrawbarTrailer",
                column: "KrpanTrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanPropulsionTrailer_KrpanTrailerId",
                table: "KrpanPropulsionTrailer",
                column: "KrpanTrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanAdjustableDriveId",
                table: "KrpanTrailer",
                column: "KrpanAdjustableDriveId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanAxeHolderId",
                table: "KrpanTrailer",
                column: "KrpanAxeHolderId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanBaleTransportPlatformId",
                table: "KrpanTrailer",
                column: "KrpanBaleTransportPlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanBBoxId",
                table: "KrpanTrailer",
                column: "KrpanBBoxId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanCardanShaftId",
                table: "KrpanTrailer",
                column: "KrpanCardanShaftId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanCargoSpaceExtensionId",
                table: "KrpanTrailer",
                column: "KrpanCargoSpaceExtensionId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanChainsawHolderId",
                table: "KrpanTrailer",
                column: "KrpanChainsawHolderId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanChockId",
                table: "KrpanTrailer",
                column: "KrpanChockId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanDrawbarSteeringId",
                table: "KrpanTrailer",
                column: "KrpanDrawbarSteeringId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanDrawHeadId",
                table: "KrpanTrailer",
                column: "KrpanDrawHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanExtensionId",
                table: "KrpanTrailer",
                column: "KrpanExtensionId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanExtraForwarderStanchionId",
                table: "KrpanTrailer",
                column: "KrpanExtraForwarderStanchionId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanExtraStanchionId",
                table: "KrpanTrailer",
                column: "KrpanExtraStanchionId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanFuelTankHolderId",
                table: "KrpanTrailer",
                column: "KrpanFuelTankHolderId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanGrappleLocationId",
                table: "KrpanTrailer",
                column: "KrpanGrappleLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanHandBrakeId",
                table: "KrpanTrailer",
                column: "KrpanHandBrakeId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanHydraulicAdjustableChassisId",
                table: "KrpanTrailer",
                column: "KrpanHydraulicAdjustableChassisId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanHydraulicSupportLegId",
                table: "KrpanTrailer",
                column: "KrpanHydraulicSupportLegId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanPlatoId",
                table: "KrpanTrailer",
                column: "KrpanPlatoId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanToolBoxId",
                table: "KrpanTrailer",
                column: "KrpanToolBoxId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanTopConnectionId",
                table: "KrpanTrailer",
                column: "KrpanTopConnectionId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanTrailerLampId",
                table: "KrpanTrailer",
                column: "KrpanTrailerLampId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanTrailerSupportLegId",
                table: "KrpanTrailer",
                column: "KrpanTrailerSupportLegId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTyreTrailer_KrpanTyreId",
                table: "KrpanTyreTrailer",
                column: "KrpanTyreId");

            migrationBuilder.CreateIndex(
                name: "IX_LightTrailer_TrailerId",
                table: "LightTrailer",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_OilPumpTrailer_TrailerId",
                table: "OilPumpTrailer",
                column: "TrailerId");

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
                name: "IX_RotatorBrakeCrane_RotatorBrakeId",
                table: "RotatorBrakeCrane",
                column: "RotatorBrakeId");

            migrationBuilder.CreateIndex(
                name: "IX_RotatorCrane_RotatorId",
                table: "RotatorCrane",
                column: "RotatorId");

            migrationBuilder.CreateIndex(
                name: "IX_StanchionTrailer_TrailerId",
                table: "StanchionTrailer",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyFormatTrailer_TrailerId",
                table: "SupplyFormatTrailer",
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
                name: "IX_Trailer_BunkAdapterId",
                table: "Trailer",
                column: "BunkAdapterId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_BunkExtensionId",
                table: "Trailer",
                column: "BunkExtensionId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_ChainsawHolderId",
                table: "Trailer",
                column: "ChainsawHolderId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_DBoxId",
                table: "Trailer",
                column: "DBoxId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_FrameExtensionId",
                table: "Trailer",
                column: "FrameExtensionId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_HandBrakeId",
                table: "Trailer",
                column: "HandBrakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_HayBaleFrameId",
                table: "Trailer",
                column: "HayBaleFrameId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_HydropackControlId",
                table: "Trailer",
                column: "HydropackControlId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_ManualBunkExtensionId",
                table: "Trailer",
                column: "ManualBunkExtensionId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_MOTId",
                table: "Trailer",
                column: "MOTId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_ShippingId",
                table: "Trailer",
                column: "ShippingId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_StanchionExtensionId",
                table: "Trailer",
                column: "StanchionExtensionId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_ToolboxId",
                table: "Trailer",
                column: "ToolboxId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_TrailerOilCoolerId",
                table: "Trailer",
                column: "TrailerOilCoolerId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_UnderrunProtectionId",
                table: "Trailer",
                column: "UnderrunProtectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_WoodSorterId",
                table: "Trailer",
                column: "WoodSorterId");

            migrationBuilder.CreateIndex(
                name: "IX_TyreTrailer_TyreId",
                table: "TyreTrailer",
                column: "TyreId");

            migrationBuilder.CreateIndex(
                name: "IX_WinchCrane_WinchId",
                table: "WinchCrane",
                column: "WinchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrakeTrailer");

            migrationBuilder.DropTable(
                name: "ControlBlockCrane");

            migrationBuilder.DropTable(
                name: "CraneTrailer");

            migrationBuilder.DropTable(
                name: "DampingCrane");

            migrationBuilder.DropTable(
                name: "DrawbarTrailer");

            migrationBuilder.DropTable(
                name: "FrameTypeCrane");

            migrationBuilder.DropTable(
                name: "GrappleCrane");

            migrationBuilder.DropTable(
                name: "HighPerformanceOilFilterCrane");

            migrationBuilder.DropTable(
                name: "HoseGuardCrane");

            migrationBuilder.DropTable(
                name: "HydroPackTrailer");

            migrationBuilder.DropTable(
                name: "KrpanBrakeTrailer");

            migrationBuilder.DropTable(
                name: "KrpanClutchTrailer");

            migrationBuilder.DropTable(
                name: "KrpanCraneTrailer");

            migrationBuilder.DropTable(
                name: "KrpanDrawbarTrailer");

            migrationBuilder.DropTable(
                name: "KrpanPropulsionTrailer");

            migrationBuilder.DropTable(
                name: "KrpanTyreTrailer");

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
                name: "RotatorBrakeCrane");

            migrationBuilder.DropTable(
                name: "RotatorCrane");

            migrationBuilder.DropTable(
                name: "StanchionTrailer");

            migrationBuilder.DropTable(
                name: "SupplyFormatTrailer");

            migrationBuilder.DropTable(
                name: "SupportLegTrailer");

            migrationBuilder.DropTable(
                name: "TyreTrailer");

            migrationBuilder.DropTable(
                name: "WinchCrane");

            migrationBuilder.DropTable(
                name: "Brake");

            migrationBuilder.DropTable(
                name: "ControlBlocks");

            migrationBuilder.DropTable(
                name: "Damping");

            migrationBuilder.DropTable(
                name: "Drawbar");

            migrationBuilder.DropTable(
                name: "FrameType");

            migrationBuilder.DropTable(
                name: "Grapple");

            migrationBuilder.DropTable(
                name: "HighPerformanceOilFilter");

            migrationBuilder.DropTable(
                name: "HoseGuard");

            migrationBuilder.DropTable(
                name: "HydroPack");

            migrationBuilder.DropTable(
                name: "KrpanBrake");

            migrationBuilder.DropTable(
                name: "KrpanClutch");

            migrationBuilder.DropTable(
                name: "KrpanCrane");

            migrationBuilder.DropTable(
                name: "KrpanDrawbar");

            migrationBuilder.DropTable(
                name: "KrpanPropulsion");

            migrationBuilder.DropTable(
                name: "KrpanTrailer");

            migrationBuilder.DropTable(
                name: "KrpanTyre");

            migrationBuilder.DropTable(
                name: "TrailerLight");

            migrationBuilder.DropTable(
                name: "OilPump");

            migrationBuilder.DropTable(
                name: "OilTank");

            migrationBuilder.DropTable(
                name: "Platform");

            migrationBuilder.DropTable(
                name: "Propulsion");

            migrationBuilder.DropTable(
                name: "RotatorBrake");

            migrationBuilder.DropTable(
                name: "Rotator");

            migrationBuilder.DropTable(
                name: "Stanchion");

            migrationBuilder.DropTable(
                name: "SupplyFormat");

            migrationBuilder.DropTable(
                name: "SupportLeg");

            migrationBuilder.DropTable(
                name: "Trailer");

            migrationBuilder.DropTable(
                name: "Tyre");

            migrationBuilder.DropTable(
                name: "Crane");

            migrationBuilder.DropTable(
                name: "Winch");

            migrationBuilder.DropTable(
                name: "KrpanAdjustableDrive");

            migrationBuilder.DropTable(
                name: "KrpanAxeHolder");

            migrationBuilder.DropTable(
                name: "KrpanBBox");

            migrationBuilder.DropTable(
                name: "KrpanBaleTransportPlatform");

            migrationBuilder.DropTable(
                name: "KrpanCardanShaft");

            migrationBuilder.DropTable(
                name: "KrpanCargoSpaceExtension");

            migrationBuilder.DropTable(
                name: "KrpanChainsawHolder");

            migrationBuilder.DropTable(
                name: "KrpanChock");

            migrationBuilder.DropTable(
                name: "KrpanDrawHead");

            migrationBuilder.DropTable(
                name: "KrpanDrawbarSteering");

            migrationBuilder.DropTable(
                name: "KrpanExtension");

            migrationBuilder.DropTable(
                name: "KrpanExtraForwarderStanchion");

            migrationBuilder.DropTable(
                name: "KrpanExtraStanchion");

            migrationBuilder.DropTable(
                name: "KrpanFuelTankHolder");

            migrationBuilder.DropTable(
                name: "KrpanGrappleLocation");

            migrationBuilder.DropTable(
                name: "KrpanHandBrake");

            migrationBuilder.DropTable(
                name: "KrpanHydraulicAdjustableChassis");

            migrationBuilder.DropTable(
                name: "KrpanHydraulicSupportLeg");

            migrationBuilder.DropTable(
                name: "KrpanPlato");

            migrationBuilder.DropTable(
                name: "KrpanToolBox");

            migrationBuilder.DropTable(
                name: "KrpanTopConnection");

            migrationBuilder.DropTable(
                name: "KrpanTrailerLamp");

            migrationBuilder.DropTable(
                name: "KrpanTrailerSupportLeg");

            migrationBuilder.DropTable(
                name: "BBox");

            migrationBuilder.DropTable(
                name: "BolsterLock");

            migrationBuilder.DropTable(
                name: "BunkAdapter");

            migrationBuilder.DropTable(
                name: "BunkExtension");

            migrationBuilder.DropTable(
                name: "ChainsawHolder");

            migrationBuilder.DropTable(
                name: "DBox");

            migrationBuilder.DropTable(
                name: "FrameExtension");

            migrationBuilder.DropTable(
                name: "HandBrake");

            migrationBuilder.DropTable(
                name: "HayBaleFrame");

            migrationBuilder.DropTable(
                name: "HydroPackControl");

            migrationBuilder.DropTable(
                name: "MOT");

            migrationBuilder.DropTable(
                name: "ManualBunkExtension");

            migrationBuilder.DropTable(
                name: "StanchionExtension");

            migrationBuilder.DropTable(
                name: "Toolbox");

            migrationBuilder.DropTable(
                name: "TrailerOilCooler");

            migrationBuilder.DropTable(
                name: "UnderrunProtection");

            migrationBuilder.DropTable(
                name: "WoodSorter");

            migrationBuilder.DropTable(
                name: "BoomGuard");

            migrationBuilder.DropTable(
                name: "Cover");

            migrationBuilder.DropTable(
                name: "CraneLight");

            migrationBuilder.DropTable(
                name: "CraneOilCooler");

            migrationBuilder.DropTable(
                name: "ElectricalFloating");

            migrationBuilder.DropTable(
                name: "JoystickHolder");

            migrationBuilder.DropTable(
                name: "Linkage");

            migrationBuilder.DropTable(
                name: "OperatorSeat");

            migrationBuilder.DropTable(
                name: "ProtectionSleeves");

            migrationBuilder.DropTable(
                name: "Shipping");

            migrationBuilder.DropTable(
                name: "SupportBracket");

            migrationBuilder.DropTable(
                name: "SupportLegCounterPlate");

            migrationBuilder.DropTable(
                name: "TurningDeviceCounterPlate");

            migrationBuilder.DropTable(
                name: "ValveBlock");

            migrationBuilder.DropTable(
                name: "WoodControl");
        }
    }
}
