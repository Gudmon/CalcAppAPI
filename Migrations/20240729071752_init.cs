﻿using Microsoft.EntityFrameworkCore.Migrations;

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
                name: "BoomGuard",
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Damping", x => x.Id);
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
                name: "ElectricalFloating",
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mass = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HayBaleFrame", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HoseGuard",
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HydroPack", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JoystickHolder",
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linkage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MOT",
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StanchionExtension", x => x.Id);
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
                name: "SupportLegCounterPlate",
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
                    table.PrimaryKey("PK_SupportLegCounterPlate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrailerLight",
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "ValveBlock",
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WoodSorter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ControlBlockFrameType",
                columns: table => new
                {
                    AvailableForFrameTypesId = table.Column<int>(type: "int", nullable: false),
                    ControlBlockId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlBlockFrameType", x => new { x.AvailableForFrameTypesId, x.ControlBlockId });
                    table.ForeignKey(
                        name: "FK_ControlBlockFrameType_ControlBlocks_ControlBlockId",
                        column: x => x.ControlBlockId,
                        principalTable: "ControlBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ControlBlockFrameType_FrameType_AvailableForFrameTypesId",
                        column: x => x.AvailableForFrameTypesId,
                        principalTable: "FrameType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    FrameSteeringCylinders = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrawbarAngle = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    ShippingId = table.Column<int>(type: "int", nullable: true)
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
                    HayBaleFrameId = table.Column<int>(type: "int", nullable: true),
                    WoodSorterId = table.Column<int>(type: "int", nullable: true),
                    HandBrakeId = table.Column<int>(type: "int", nullable: true),
                    ChainsawHolderId = table.Column<int>(type: "int", nullable: true),
                    UnderrunProtectionId = table.Column<int>(type: "int", nullable: true),
                    BunkAdapterId = table.Column<int>(type: "int", nullable: true),
                    BunkExtensionId = table.Column<int>(type: "int", nullable: true),
                    FrameExtensionId = table.Column<int>(type: "int", nullable: true),
                    ShippingId = table.Column<int>(type: "int", nullable: true),
                    MOTId = table.Column<int>(type: "int", nullable: true),
                    StanchionExtensionId = table.Column<int>(type: "int", nullable: true),
                    HydroPackId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_Trailer_HydroPack_HydroPackId",
                        column: x => x.HydroPackId,
                        principalTable: "HydroPack",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trailer_MOT_MOTId",
                        column: x => x.MOTId,
                        principalTable: "MOT",
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
                name: "CraneControlBlocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    ControlBlockId = table.Column<int>(type: "int", nullable: false),
                    FrameTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraneControlBlocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CraneControlBlocks_ControlBlocks_ControlBlockId",
                        column: x => x.ControlBlockId,
                        principalTable: "ControlBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CraneControlBlocks_Crane_CraneId",
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
                name: "TrailerCraneConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrailerId = table.Column<int>(type: "int", nullable: false),
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    SelectedFrameTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrailerCraneConfigurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrailerCraneConfigurations_Crane_CraneId",
                        column: x => x.CraneId,
                        principalTable: "Crane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrailerCraneConfigurations_FrameType_SelectedFrameTypeId",
                        column: x => x.SelectedFrameTypeId,
                        principalTable: "FrameType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrailerCraneConfigurations_Trailer_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrailerFrameTypeConfiguration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrailerId = table.Column<int>(type: "int", nullable: false),
                    FrameTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrailerFrameTypeConfiguration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrailerFrameTypeConfiguration_FrameType_FrameTypeId",
                        column: x => x.FrameTypeId,
                        principalTable: "FrameType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrailerFrameTypeConfiguration_Trailer_TrailerId",
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
                values: new object[,]
                {
                    { 1, "Bbox", "Biomasszás boksz 4 mm-es Strenx acélból", "2825" },
                    { 2, "Bbox", "Biomasszás boksz 4 mm-es Strenx acélból", "3150" },
                    { 3, "Bbox", "Biomasszás boksz 4 mm-es Strenx acélból", "3360" },
                    { 4, "Bbox", "Biomasszás boksz 4 mm-es Strenx acélból", "3200" },
                    { 5, "Bbox", "Biomasszás boksz 4 mm-es Strenx acélból", "905" }
                });

            migrationBuilder.InsertData(
                table: "BolsterLock",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "BL", "Rakconca rögzítő az első pár rakoncához", "0" });

            migrationBuilder.InsertData(
                table: "BoomGuard",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "BG5", "Főgém védő az 5-ös szériához", "630" },
                    { 2, "BG7", "Főgém védő a 7-es szériához", "650" },
                    { 3, "BG10", "Főgém védő X100-hoz", "675" }
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
                    { 19, "BH-EU", "Hidraulikus fék", "4905" },
                    { 20, "B1", "2 keréken hidraulikus fék", "3390" },
                    { 21, "B2", "4 keréken hidraulikus fék", "6670" },
                    { 22, "B3", "2 keréken légfék", "4045" },
                    { 23, "B4", "4 keréken légfék", "7510" },
                    { 24, "BA-EU", "Légfék", "7465" },
                    { 25, "BH-EU", "Hidraulikus fék", "8635" },
                    { 26, "B2", "4 keréken hidraulikus fék", "2305" },
                    { 27, "B3", "2 keréken légfék", "1860" },
                    { 28, "B4", "4 keréken légfék", "3145" },
                    { 29, "BA-EU", "Légfék", "3620" },
                    { 30, "BH-EU", "Hidraulikus fék", "4795" },
                    { 31, "B2", "4 keréken hidraulikus többtárcsás fék (sebességváltón keresztül)", "250" },
                    { 32, "B4", "4 kerék légfék (hidraulikusan működtetett, többtárcsás, sebességváltón keresztül)", "3035" }
                });

            migrationBuilder.InsertData(
                table: "BunkAdapter",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "PA", "Forwarder típusú bunk adapter a szélesebb rakodó felületért (az ár 1 db-ra vonatkozik)", "150" },
                    { 2, "PA", "Forwarder típusú bunk adapter a szélesebb rakodó felületért (az ár 1 db-ra vonatkozik)", "140" }
                });

            migrationBuilder.InsertData(
                table: "BunkExtension",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "PA-H", "Forwarder típusú bunk kiterjesztés (az ár 1 db-ra vonatkozik)", "625" },
                    { 2, "PA-H", "Forwarder típusú bunk kiterjesztés (az ár 1 db-ra vonatkozik)", "595" }
                });

            migrationBuilder.InsertData(
                table: "ChainsawHolder",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "MSH", "Láncfűrész tartó", "65" });

            migrationBuilder.InsertData(
                table: "ControlBlocks",
                columns: new[] { "Id", "Code", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "A2", "Egyszerű és kompakt szelepblokk darukhoz teleszkópos hosszabbító gémek nélkül", "A2 5/7 XY vezértömb, 195 bar", "795" },
                    { 2, "A3.1", "Egyszerű és megbízható szelepblokk kisebb daruk számára", "A3.1 6/8 XY vezértömb, BLB BM50 (50l/perc), 195 bar", "805" },
                    { 3, "A4", "Szelepblokk az egyszerűbb daruvezérlést kedvelő ügyfelek számára", "A4 4/8 XY+2x el.on-off vezértömb, Hydro-control D3M, 195 bar", "1390" },
                    { 4, "A4.2", "Szelepblokk az egyszerűbb daruvezérlést kedvelő ügyfelek számára", "A4.2 4/8 XY+2x el.on-off vezértömb, Bucher HDS16, 215 bar", "1500" },
                    { 5, "A7", "Szelepblokk az egyszerűbb daruvezérlést kedvelő ügyfelek számára", "A7 4/8 XYZ vezértömb, Hydro-control, 195 bar (215 bar kérésre)", "1360" },
                    { 6, "A12", "Leginkább a PALMS 5. és 7. sorozatú darukkal használható", "A12 2/8 Pre-hidraulikus, +2x el.propo, Walvoil DPX100 (max. 120 l/min), 215 bar + HPF", "4720" },
                    { 7, "A14", "Leginkább a PALMS 5. és 7. sorozatú darukkal használható", "A14 2/8 Pre-hydraulic, +2x el.propo, Parker L90, 215 bar + HPF", "6635" },
                    { 8, "A23", "Parker LC6 mini joystickek. Leginkább PALMS 5., 7. és X-sorozatú darukhoz használják", "A23 El.propo 8 szekciós, IQAN LC6, mini joystick-ok, (LS komp.) + Parker L90pro, 215/240 bar + HPF", "8470" },
                    { 9, "A235", "Leginkább a PALMS 5. és 7. sorozatú darukkal használható", "A235 El.propo 8 szekciós, IQAN LC5 joystick-ok, (LS komp) Parker L90pro, 215/240 bar + HPF", "8470" },
                    { 10, "A25.1", "Parker LC6 mini joystick kijelzővel", "A25.1 El.propo 8 szekciós (A23) + MD3 kijelző + HPF", "9415" },
                    { 11, "A26", "IMET rádió vezérlés PALMS erdészeti daruhoz", "A26 IMET rádió távirányítás, (LS komp.) Parker L90pro (max. 150 l/min.), 215/240 bar + HPF", "9110" },
                    { 12, "A36", "IMET rádióvezérlés Parker LC6 mini joystickekkel", "A36 Combi control (rádió távirányítás+A23),Parker  L90pro, 215/240 bar + HPF", "11840" },
                    { 13, "A36.1", "IMET rádióvezérlés és Parker LC6 mini joystick kijelzővel", "A36.1 Combi control (rádió távirányítás+A23),Parker  L90pro, 215/240 bar + MD3 kijelző + HPF", "12785" },
                    { 14, "A42", "Standard üzemmód, ahol a fő emelőhenger, a hosszabbító gém hengere és a teleszkóp hengere külön vezérelhető.\r\nPTC mód, ahol a markoló lineárisan mozgatható X, Y és Z irányban.", "A42 Palms Tip Control, IQAN joystickok, MD4 - 7 inch-es kijelző, Parker L90pro, 215/240 bar + HPF", "14660" }
                });

            migrationBuilder.InsertData(
                table: "Cover",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "JKK", "Védőhuzat bőrből A2-A7-es, A11-es, A12-es és A14-es vezértömbökhöz", "50" });

            migrationBuilder.InsertData(
                table: "CraneLight",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "L1", "LED munkalámpák a darugémre, 2 db", "510" });

            migrationBuilder.InsertData(
                table: "CraneOilCooler",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "CP1", "Olajhűtő csomag elektromos csatlakozással a traktorhoz", "1035" });

            migrationBuilder.InsertData(
                table: "Damping",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "D1", "Csillapító a munkahenger elforgatáshoz", "805" },
                    { 2, "D2", "Csillapító a munkahenger elforgatáshoz és emeléshez", "1375" },
                    { 3, "D3", "Csillapító emeléshez", "805" }
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
                    { 5, "C5", "Osztrák típusú alacsony vonórúd vonószemmel", "275" },
                    { 6, "C6", "Német típusú magas vonórúd vonószemmel (P1-P3 szivattyúhoz)", "430" },
                    { 7, "C7", "Magas ráfutófékes vonórúd vonószemmel, kábelekkel és 2 kerék fékkel", "1675" },
                    { 8, "C8", "K-80 típusú alacsony vonórúd vonószemmel", "470" },
                    { 9, "C9", "Osztrák típusú alacsony vonórúd elforduló vonószemmel", "525" },
                    { 10, "C5", "Osztrák típusú alacsony vonórúd vonószemmel", "315" },
                    { 11, "C8", "K-80 típusú alacsony vonórúd vonószemmel", "535" },
                    { 12, "C9", "Osztrák típusú alacsony vonórúd elforduló vonószemmel", "500" },
                    { 13, "CY", "Y vonórúd Jake rögzítő csatlakozókkal (Valtra-hoz, egyéb traktorokhoz igény szerint) elektromos vezérléssel", "8380" }
                });

            migrationBuilder.InsertData(
                table: "ElectricalFloating",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "FP", "Elektromos úszó pozíció emelő és fordító funkcióhoz (A11-A41 vezértömbhöz)", "1035" });

            migrationBuilder.InsertData(
                table: "FrameExtension",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "Hex", "Hidraulikus működtetésű raktér hosszabbítás ", "210" });

            migrationBuilder.InsertData(
                table: "FrameType",
                columns: new[] { "Id", "Code", "Mass", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "B0", "", "Talpaló nélkül", "0" },
                    { 2, "B2.1", "174", "A típusú kis letalpaló, 3 pontos csatlakozással", "1680" },
                    { 3, "B3", "313", "B3, A típusú normál méretű letalpaló, 3 pontos csatlakozással", "2100" },
                    { 4, "B4e", "237", "FD típusú economy letalpaló", "2100" },
                    { 5, "B6.1", "449", "B6.1 FD típusú letalpaló, 3 pontos csatlakozással", "3090" },
                    { 6, "B09", "231", "B09 Különösen erős alap, talpaló lábak nélkül", "1155" },
                    { 7, "B9", "474", "B9 FD típusú, különösen erős letalpaló (HD)", "3530" },
                    { 8, "B10", "520", "Talpaló Z daruhoz", "3685" },
                    { 9, "B011", "440", "Különösen erős talp daru billentéssel, vezérléssel, talpaló lábak nélkül (csak A21-A42 vezértömbhöz)", "4830" },
                    { 10, "B11", "772", "Különösen erős talp daru billentéssel, vezérléssel, talpaló lábakkal (csak A21-A42 vezértömbhöz)", "7300" },
                    { 11, "B1", "50", "FD talpaló", "695" }
                });

            migrationBuilder.InsertData(
                table: "Grapple",
                columns: new[] { "Id", "Area", "Code", "Mass", "Name", "Price" },
                values: new object[,]
                {
                    { 1, null, "C0", null, "Rönkfogó kanál nélkül", "0" },
                    { 2, "0.16", "C01", "69", "Kanál 0,16 Palms (csapos rotátorhoz)", "1105" },
                    { 3, "0.16", "C02", "66", "Kanál 0,16 Palms (FL)", "1085" },
                    { 4, "0.18", "C1", "88", "Kanál 0,18 Palms (FL)", "1395" },
                    { 5, "0.23", "C3", "114", "Kanál 0,23 Palms (FL)", "1745" },
                    { 6, "0.25", "C5.1", null, "Kanál 0,25 Grippen (FL)", "3015" },
                    { 7, "0.26", "C5.2", "174", "Kanál 0,26 Palms (FL)", "3090" },
                    { 8, "0.21", "C36", "127", "Biomasszás kanál 0,21 Palms (FL)", "2230" },
                    { 9, "0.25", "C7.1", null, "Biomasszás kanál 0,25 Grippen (FL)", "3345" },
                    { 10, "0.23", "C7.2", "118", "Biomasszás kanál 0,23 Palms (FL)", "3020" },
                    { 11, "0.25", "C11", "223", "Biomasszás kanál 0,25 Palms (FL)", "3450" },
                    { 12, "0.28", "C10", "205", "Palms 0,28-as kanál (FL)", "3125" },
                    { 13, null, "C175", null, "Palms vágó kanál a Nisula-tól", "6500" },
                    { 14, null, "GB3", "195", "Aprítékos kiegészítő C3-hoz", "910" },
                    { 15, null, "C009", null, "Palms 0,09 kanál", "620" }
                });

            migrationBuilder.InsertData(
                table: "HandBrake",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "PB1", "Kézifék, kerékről működtethető", "105" });

            migrationBuilder.InsertData(
                table: "HayBaleFrame",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "HBF", "Szénabála keret (D típushoz)", "2650" },
                    { 2, "HBF", "Szénabála keret (U típushoz)", "2650" }
                });

            migrationBuilder.InsertData(
                table: "HoseGuard",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "HG1", "Tömlő védő B3 és B6.1 talpaló esetén", "105" },
                    { 2, "HG2", "Tömlő védő  B09 és B9 talpaló esetén", "105" }
                });

            migrationBuilder.InsertData(
                table: "HydroPack",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "HyP", "Hydropack 6,5 lóerő - 12 l/min", "2195" });

            migrationBuilder.InsertData(
                table: "JoystickHolder",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "JL", "Joystick tartó A11-A42 vezértömbhöz", "370" });

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
                    { 1, "", "Hidraulikus fék 4 keréken", "0" },
                    { 2, "", "Pneumatikus fék 4 keréken", "2160" },
                    { 3, "", "Kombinált fék 4 keréken (hidraulikus és ráfutófék)", "2160" },
                    { 4, "", "Kombinált fék 4 keréken (hidraulikus és pneumatikus)", "4140" }
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
                    { 6, "84", "", "1427", "760", "8.4", "9.0", "GD 8,4 Z", "60", "100", "29200", "4", "22", "370", "230", "2", "1855" }
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
                values: new object[] { 1, "", "vonórúd kormányzás + 40°", "0" });

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
                    { 1, "", "400/60-15,5; 14 rétegű", "0" },
                    { 2, "", "400/60-15,5; 18 rétegű", "0" },
                    { 3, "", "480/45-17; 14 rétegű", "1435" },
                    { 4, "", "500/50-17; 18 rétegű", "1435" },
                    { 5, "", "550/45-22,5; 20 rétegű", "3050" },
                    { 6, "", "400/55-22,5; 20 rétegű", "3050" }
                });

            migrationBuilder.InsertData(
                table: "Linkage",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "3PL", "3 pontos csatlakozó adapter (csak a B9 és B10 talpalóval kompatibilis)", "960" });

            migrationBuilder.InsertData(
                table: "MOT",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Pótkocsi műszaki vizsga", "500" });

            migrationBuilder.InsertData(
                table: "OilPump",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "P01", "Szivattyú adapter a vonórúdon", "60" },
                    { 2, "P1", "P1 101 cm3 dugattyús olajmpumpa a vonórúdon, 650 p/min - 65 l/min", "1155" },
                    { 3, "P2", "P2 130 cm3 dugattyús olajmpuma a vonórúdon, 650 p/min - 82 l/min", "1575" },
                    { 4, "P4", "61 cm3 dugattyús olajpumpa multiplikátorral a vonórúdon, 650 p/min - 98 l/min", "1995" },
                    { 5, "P4PTO", "P4 olajmpumla PTO-val 650 p/min - 98 l/min (rögzítő konzol nélkül)", "1995" },
                    { 6, "P6", "LS fajtájú olajmpumpa multiplikátorral, 650 p/min - 120 l/min", "4305" },
                    { 7, "P6PTO", "P6 olajpumpa PTO-val 650 p/min - 120 l/min (rögzítő konzol nélkül)", "4305" },
                    { 8, "P6", "LS fajtájú olajmpumpa multiplikátorral, 500 p/min - 118 l/min", "5190" }
                });

            migrationBuilder.InsertData(
                table: "OilTank",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "T2", "95 l-es olajtartály", "1000" },
                    { 2, "T2+", "95 l-es olajtartály HVLP olajjal", "1290" },
                    { 3, "T2SOV", "95 l-es olajtartály HVLP olajjal, elzáró csappal", "1200" },
                    { 4, "T2SOV+", "95 l-es olajtartály HVLP olajjal, elzáró csappal, olajszűrővel", "1490" },
                    { 5, "T2+", "95 l-es olajtartály HVLP olajjal", "1295" },
                    { 6, "T2SOV+", "95 l-es olajtartály HVLP olajjal, elzáró csappal, olajszűrővel", "1495" },
                    { 7, "T4+", "100 l-es olajtartály HVLP olajjal", "1610" }
                });

            migrationBuilder.InsertData(
                table: "OperatorSeat",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "HSB", "Kezelő ülés a függőleges gém tetejére, csak A12-es vezértömbhöz, nem kompatibilis a csörlővel", "1890" });

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
                columns: new[] { "Id", "Code", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "RWD", "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további pótkocsi-hajtásra van szükségük. A rendszer működtetése a traktor hidraulikájáról történik. Előnyei az RWD+ rendszerhez képest a jobb manőverezhetőség és a műszaki egyszerűség.", "Robson WD dörzshajtás (traktor hidarulikáról)", "5280" },
                    { 2, "RWD+", "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további vontatásra van szükségük pótkocsijukhoz. Előnyei a hagyományos RWD rendszerekhez képest a jobb tapadás és a sebesség állíthatósága.", "Robson WD dörzshajtás elektronikus vezérlőrendszerrel", "7600" },
                    { 3, "25WDF", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.", "2WD agyhajtás (BB 250 az első tengelyen elektronikus vezérléssel)", "0" },
                    { 4, "25WDR", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.", "2WD agyhajtás (BB 250 a hátsó tengelyen elektronikus vezérléssel)", "0" },
                    { 5, "RWD", "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további pótkocsi-hajtásra van szükségük. A rendszer működtetése a traktor hidraulikájáról történik. Előnyei az RWD+ rendszerhez képest a jobb manőverezhetőség és a műszaki egyszerűség.", "Robson WD dörzshajtás (traktor hidarulikáról)", "4845" },
                    { 6, "RWD+", "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további vontatásra van szükségük pótkocsijukhoz. Előnyei a hagyományos RWD rendszerekhez képest a jobb tapadás és a sebesség állíthatósága.", "Robson WD dörzshajtás elektronikus vezérlőrendszerrel", "7170" },
                    { 7, "45WDB", "", "4WD BlackBruin elektronikus teljesítmény szabályozással", "0" },
                    { 8, "45WDB.1", "", "4WD BlackBruin elektronikus teljesítmény szabályozással, ISOBUS-hoz előkészítve", "1135" },
                    { 9, "RWD", "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további pótkocsi-hajtásra van szükségük. A rendszer működtetése a traktor hidraulikájáról történik. Előnyei az RWD+ rendszerhez képest a jobb manőverezhetőség és a műszaki egyszerűség.", "Robson WD dörzshajtás (traktor hidarulikáról)", "2040" }
                });

            migrationBuilder.InsertData(
                table: "ProtectionSleeves",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "PSH", "Védőhüvely a tömlőhöz", "70" },
                    { 2, "PSH", "Védőhüvely a tömlőhöz", "75" },
                    { 3, "PSH", "Védőhüvely a tömlőhöz", "95" },
                    { 4, "PSH", "Védőhüvely a tömlőhöz", "105" }
                });

            migrationBuilder.InsertData(
                table: "Rotator",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "R0", "Rotátor nélkül", "0" },
                    { 2, "R30", "30 kN-os rotátor (csapos)", "300" },
                    { 3, "R31", "30 kN-os rotátor FL (talpas)", "430" },
                    { 4, "R45", "45 kN-os rotátor FL (talpas)", "620" },
                    { 5, "R55", "55 kN-os rotátor FL (talpas)", "915" },
                    { 6, "R60", "60 kN-os rotátor FL Indexator GV6 (talpas)", "1600" },
                    { 7, "R90", "100 kN-os rotátor FL Indexator T10 (talpas)", "1880" },
                    { 8, "R10", "Rotátor 1000 kN (csapos - Finrotor)", "245" }
                });

            migrationBuilder.InsertData(
                table: "RotatorBrake",
                columns: new[] { "Id", "Code", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Br0", null, "Rotátorfék  nélkül", "0" },
                    { 2, "Br1", "Fék az oldalirányú mozgáshoz. A fékek terheletlen markolókhoz vannak beállítva.", "Rotátor fék", "75" },
                    { 3, "Br1", "Fék az oldalirányú mozgáshoz. A fékek terheletlen markolókhoz vannak beállítva.", "Rotátor fék", "55" },
                    { 4, "Br2", "Fékek az oldalirányú és előre-hátra mozgáshoz. A fékek terheletlen markolókhoz vannak beállítva.", "Dupla rotátor fék", "115" },
                    { 5, "Br2", "Fékek az oldalirányú és előre-hátra mozgáshoz. A fékek terheletlen markolókhoz vannak beállítva.", "Dupla rotátor fék", "220" }
                });

            migrationBuilder.InsertData(
                table: "Shipping",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", "Pótkocsi szállítása Észtországból Magyarországra", "750" },
                    { 2, "", "Daru szállítása Észtországból Magyarországra", "750" }
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
                    { 42, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "26380" },
                    { 43, "A3", "Pótkocsi 3 pár rakoncával", "10495" },
                    { 44, "A3F", "Pótkocsi 3 pár forwader típusú rakoncával", "10495" },
                    { 45, "A4", "Pótkocsi 4 pár rakoncával", "11125" },
                    { 46, "A4F", "Pótkocsi 4 pár forwader típusú rakoncával", "11125" },
                    { 47, "A4Ex", "Pótkocsi raktér hosszabbítással és 4 pár rakoncával", "11850" },
                    { 48, "A4FEx", "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "11850" },
                    { 49, "A5Ex", "Pótkocsi raktér hosszabbítással és 5 pár rakoncával", "12480" },
                    { 50, "A5FEx", "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "12480" },
                    { 51, "A3", "Pótkocsi 3 pár rakoncával", "23260" },
                    { 52, "A3F", "Pótkocsi 3 pár forwader típusú rakoncával", "23260" },
                    { 53, "A4", "Pótkocsi 4 pár rakoncával", "23890" },
                    { 54, "A4F", "Pótkocsi 4 pár forwader típusú rakoncával", "23890" },
                    { 55, "A4Ex", "Pótkocsi raktér hosszabbítással és 4 pár rakoncával", "24615" },
                    { 56, "A4FEx", "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "24615" },
                    { 57, "A5Ex", "Pótkocsi raktér hosszabbítással és 5 pár rakoncával", "25245" },
                    { 58, "A5FEx", "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "25245" },
                    { 59, "A3", "Pótkocsi 3 pár rakoncával", "12580" },
                    { 60, "A3F", "Pótkocsi 3 pár forwader típusú rakoncával", "12580" },
                    { 61, "A4", "Pótkocsi 4 pár rakoncával", "13295" },
                    { 62, "A4F", "Pótkocsi 4 pár forwader típusú rakoncával", "13295" },
                    { 63, "A4Ex", "Pótkocsi raktér hosszabbítással és 4 pár rakoncával", "14020" },
                    { 64, "A4FEx", "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "14020" },
                    { 65, "A5Ex", "Pótkocsi raktér hosszabbítással és 5 pár rakoncával", "14735" },
                    { 66, "A5FEx", "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "14735" },
                    { 67, "A3", "Pótkocsi 3 pár rakoncával", "24665" },
                    { 68, "A3F", "Pótkocsi 3 pár forwader típusú rakoncával", "24665" },
                    { 69, "A4", "Pótkocsi 4 pár rakoncával", "25380" },
                    { 70, "A4F", "Pótkocsi 4 pár forwader típusú rakoncával", "25380" },
                    { 71, "A4Ex", "Pótkocsi raktér hosszabbítással és 4 pár rakoncával", "26105" },
                    { 72, "A4FEx", "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "26105" },
                    { 73, "A5Ex", "Pótkocsi raktér hosszabbítással és 5 pár rakoncával", "26820" },
                    { 74, "A5FEx", "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "26820" },
                    { 75, "A3", "Pótkocsi 3 pár rakoncával", "37980" },
                    { 76, "A3F", "Pótkocsi 3 pár forwader típusú rakoncával", "37980" },
                    { 77, "A4", "Pótkocsi 4 pár rakoncával", "38695" },
                    { 78, "A4F", "Pótkocsi 4 pár forwader típusú rakoncával", "38695" },
                    { 79, "A4Ex", "Pótkocsi raktér hosszabbítással és 4 pár rakoncával", "39420" },
                    { 80, "A4FEx", "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "39420" },
                    { 81, "A5Ex", "Pótkocsi raktér hosszabbítással és 5 pár rakoncával", "40135" },
                    { 82, "A5FEx", "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "40135" },
                    { 83, "A3", "Pótkocsi 3 pár rakoncával", "14595" },
                    { 84, "A3F", "Pótkocsi 3 pár forwader típusú rakoncával", "14595" },
                    { 85, "A4", "Pótkocsi 4 pár rakoncával", "15515" },
                    { 86, "A4F", "Pótkocsi 4 pár forwader típusú rakoncával", "15515" },
                    { 87, "A4Ex", "Pótkocsi raktér hosszabbítással és 4 pár rakoncával", "16240" },
                    { 88, "A4FEx", "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "16240" },
                    { 89, "A5Ex", "Pótkocsi raktér hosszabbítással és 5 pár rakoncával", "17160" },
                    { 90, "A5FEx", "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "17160" },
                    { 91, "A3", "Pótkocsi 3 pár rakoncával", "26680" },
                    { 92, "A3F", "Pótkocsi 3 pár forwader típusú rakoncával", "26680" },
                    { 93, "A4", "Pótkocsi 4 pár rakoncával", "27600" },
                    { 94, "A4F", "Pótkocsi 4 pár forwader típusú rakoncával", "27600" },
                    { 95, "A4Ex", "Pótkocsi raktér hosszabbítással és 4 pár rakoncával", "28325" },
                    { 96, "A4FEx", "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "28325" },
                    { 97, "A5Ex", "Pótkocsi raktér hosszabbítással és 5 pár rakoncával", "29245" },
                    { 98, "A5FEx", "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "29245" },
                    { 99, "A3", "Pótkocsi 3 pár rakoncával", "39995" },
                    { 100, "A3F", "Pótkocsi 3 pár forwader típusú rakoncával", "39995" },
                    { 101, "A4", "Pótkocsi 4 pár rakoncával", "40915" },
                    { 102, "A4F", "Pótkocsi 4 pár forwader típusú rakoncával", "40915" },
                    { 103, "A4Ex", "Pótkocsi raktér hosszabbítással és 4 pár rakoncával", "41640" },
                    { 104, "A4FEx", "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "41640" },
                    { 105, "A5Ex", "Pótkocsi raktér hosszabbítással és 5 pár rakoncával", "42560" },
                    { 106, "A5FEx", "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "42560" },
                    { 107, "A4F", "Pótkocsi 4 pár forwarder típusú rakoncával", "52325" },
                    { 108, "A5F", "Pótkocsi 5 pár forwarder típusú rakoncával", "53455" },
                    { 109, "A4FHEx", "Pótkocsi hidraulikus raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "55025" },
                    { 110, "A5FHEx", "Pótkocsi hidraulikus raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "56155" },
                    { 111, "A4F", "Pótkocsi 4 pár forwarder típusú rakoncával", "52985" },
                    { 112, "A5F", "Pótkocsi 5 pár forwarder típusú rakoncával", "54115" },
                    { 113, "A4FHEx", "Pótkocsi hidraulikus raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "55685" },
                    { 114, "A5FHEx", "Pótkocsi hidraulikus raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "56815" },
                    { 115, "A4F", "Pótkocsi 4 pár forwarder típusú rakoncával", "56815" },
                    { 116, "A5F", "Pótkocsi 5 pár forwarder típusú rakoncával", "57945" },
                    { 117, "A4FHEx", "Pótkocsi hidraulikus raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "59515" },
                    { 118, "A5FHEx", "Pótkocsi hidraulikus raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "60645" },
                    { 119, "A4F", "Pótkocsi 4 pár forwarder típusú rakoncával", "57475" },
                    { 120, "A5F", "Pótkocsi 5 pár forwarder típusú rakoncával", "58605" },
                    { 121, "A4FHEx", "Pótkocsi hidraulikus raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "60175" },
                    { 122, "A5FHEx", "Pótkocsi hidraulikus raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "61305" },
                    { 123, "A3", "Pótkocsi 3 pár rakoncával", "2490" },
                    { 124, "A4", "Pótkocsi 4 pár rakoncával", "2595" },
                    { 125, "A5", "Pótkocsi 5 pár rakoncával", "2700" }
                });

            migrationBuilder.InsertData(
                table: "StanchionExtension",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "PE", "Rakonca hosszabbítás (az ár 1 db-ra vonatkozik)", "55" });

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
                table: "SupportLegCounterPlate",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "PL2", "Fedőlap a Palms talpaló lábhoz", "475" });

            migrationBuilder.InsertData(
                table: "TrailerLight",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "L1", "Összecsukható hátsó lámpák", "420" },
                    { 2, "L2", "Hátsó LED lámpa flexibilis Kilpi karokkal", "465" },
                    { 3, "L4", "Fix hátsó LED lámpák", "420" },
                    { 4, "L1", "Összecsukható hátsó lámpák", "340" },
                    { 5, "L2", "Hátsó LED lámpa flexibilis Kilpi karokkal", "440" }
                });

            migrationBuilder.InsertData(
                table: "TrailerOilCooler",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "CP2", "Olajhűtő csomag a tartályhoz rögzítve", "1035" },
                    { 2, "CP4", "Olajhűtő csomag a tartályhoz rögzítve", "1190" }
                });

            migrationBuilder.InsertData(
                table: "TurningDeviceCounterPlate",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "PL", "Fedőlap a fordító szerkezethez", "340" });

            migrationBuilder.InsertData(
                table: "Tyre",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "WH2.6e", "400/60-15,5 standard felni, 6 lyukas, Starco", "1250" },
                    { 2, "WH2.6", "400/60-15,5 RF-felni, 6 lyukas, Starco", "1450" },
                    { 3, "WH4.6", "480/45-17 RF-felni, 6 lyukas, Starco", "2310" },
                    { 4, "WH4.8", "480/45-17 RF-felni, 8 lyukas, Starco", "2310" },
                    { 5, "WH3.6", "500/50-17 RF-felni, 6 lyukas, BKT", "2500" },
                    { 6, "WH3.8", "500/50-17 RF-felni, 8 lyukas, BKT", "2500" },
                    { 7, "WH5.6", "400/55-22,5 RF-felni, 6 lyukas, Alliance", "3215" },
                    { 8, "WH8.8", "500/55-22,5 RF-felni, 8 lyukas, BKT", "3770" },
                    { 9, "WH6.8", "550/45-22,5 RF-felni, 8 lyukas, BKT", "4010" },
                    { 10, "WH6.8V", "550/45-22,5 RF-felni, 8 lyukas, BKT - traktor mintás", "4410" },
                    { 11, "WH9.8V", "600/40-22,5 RF-felni, 8 lyukas, BKT - traktor mintás", "6425" },
                    { 12, "WH7.8", "600/50-22,5 RF-felni, 8 lyukas, Alliance", "5410" },
                    { 13, "WH7.10", "600/50-22,5 RF-felni, 10 lyukas, Nokian", "11020" },
                    { 14, "WH9.10", "710/40-22,5 RF-felni, 10 lyukas, Nokian", "11150" },
                    { 15, "WH1.4", "22/11-8", "465" }
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
                table: "ValveBlock",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "AH", "A21-A42 vezértömb a főgémhez erősítve", "0" });

            migrationBuilder.InsertData(
                table: "Winch",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "W0", "Csörlő előkészítés a főgémen", "70" },
                    { 2, "W1", "Rádió távvezérlésű 1400-as csörlő (A11-A41 vezértömbhöz)", "2365" },
                    { 3, "W2", "Rádió távvezérlésű 2200-as csörlő (A11-A41 vezértömbhöz)", "2845" }
                });

            migrationBuilder.InsertData(
                table: "WoodControl",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "LWS", "Hosszú fás kiegészítő a főgémhez", "150" });

            migrationBuilder.InsertData(
                table: "WoodSorter",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "WS", "Faosztályozó rövidebb fához (1db/rakonca, az ár 1 db-ra vonatkozik)", "65" });

            migrationBuilder.InsertData(
                table: "Crane",
                columns: new[] { "Id", "BoomGuardId", "BrutLiftingTorque190Bar", "BrutLiftingTorque215Bar", "BrutLiftingTorque240Bar", "CoverId", "CraneOilCoolerId", "CraneWeight", "Description", "ElectricalFloatingId", "JoystickHolderId", "LiftAtFourMeters190Bar", "LiftAtFourMeters215Bar", "LiftAtFourMeters240Bar", "LiftAtFullReach190Bar", "LiftAtFullReach215Bar", "LiftAtFullReach240Bar", "LightId", "LinkageId", "MaxReach", "Name", "OperatorSeatId", "PillarSlewingAngle", "Price", "ProtectionSleevesId", "RecommendedOilFlow", "RotatorMaximumLoad", "Series", "ShippingId", "SlewingCylinder", "SlewingTorque", "SupportLegCounterPlateId", "TelescopeLength", "TurningDeviceCounterPlateId", "ValveBlockId", "WoodControlId", "WorkingPressure" },
                values: new object[,]
                {
                    { 1, null, "26", "-", "-", 1, null, "360", "Ideális választás azoknak a vásárlóknak, akik egyszerűséget, könnyűséget és kompakt méretet keresnek. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.", null, 1, "570", "-", "-", "540", "-", "-", null, null, "4.2", "PALMS 2.42", null, "370", "5165", 1, "20-35", "45", "2", 2, "4", "7.8", 1, "-", 1, null, 1, "190" },
                    { 2, null, "26", "29", "-", 1, null, "400", "Kompakt és könnyű daru, ideális városi parkokhoz és más környezetvédelmi érzékeny területekhez. Rögzíthető különböző platformokra, erdészeti pótkocsiktól és teherautóktól kezdve a mini-forwarderekig. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.", null, 1, "530", "600", "-", "370", "410", "-", null, null, "5.4", "PALMS 2.54", null, "370", "6285", 1, "20-35", "45", "2", 2, "4", "7.8", 1, "1,33", 1, null, 1, "190/215" },
                    { 3, null, "36", "-", "-", 1, null, "415", "Kis erdőtulajdonosoknak tervezett daru a tűzifa előkészítésére saját maguk és szomszédos háztartások számára. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.", null, 1, "655", "-", "-", "355", "-", "-", null, null, "6.3", "PALMS 3.63", null, "370", "6985", 1, "20-35", "45", "3", 2, "4", "9", 1, "1,85", 1, null, 1, "190" },
                    { 4, null, "41", "46", "-", 1, null, "620", "Egy gazda legjobb társa, kiváló teljesítményt nyújtva tűzifa előkészítésében és általános emelési feladatokban a gazdaságokon. Kompatibilis a PALMS 8SX, 8D, 9SC és 10D pótkocsikkal.", null, 1, "820", "910", "-", "430", "480", "-", 1, null, "6.7", "PALMS 3.67", null, "370", "8260", 1, "30-45", "45", "3", 2, "4", "12", 1, "1,85", 1, null, 1, "190/215" },
                    { 5, null, "48", "54", "-", 1, 1, "710", "Sokoldalú közepes méretű daru, különféle ágazatokban, például fakitermelésben és mezőgazdaságban. Kompatibilis a legtöbb PALMS pótkocsival", 1, 1, "960", "1040", "-", "480", "535", "-", 1, null, "7.1", "PALMS 4.71", 1, "370", "9450", 2, "45-70", "45", "4", 2, "4", "15", 1, "1,95", 1, 1, 1, "190/215" },
                    { 6, 1, "56", "63", "-", 1, 1, "820", "Naponta használt, professzionális erdészeti műveletekre tervezett daru lágy talajon, közepes méretű traktorokhoz optimalizálva, és kompatibilis a PALMS pótkocsik többségével.", 1, 1, "1100", "1240", "-", "620", "710", "-", 1, 1, "7.2", "PALMS 5.72", 1, "380", "11435", 3, "50-90", "60", "5", 2, "4", "17", 1, "1,95", 1, 1, 1, "190/215" },
                    { 7, 1, "56", "63", "-", 1, 1, "900", "Professzionális erdészeti daru, dupla teleszkópos kinyúlási boommal felszerelve. Kifejezetten tervezve a mindennapi erdészeti műveletekhez lágy talajon. Optimalizálva a közepes méretű traktorok használatához, és kompatibilis a PALMS pótkocsik többségével.", 1, 1, "1050", "1220", "-", "450", "520", "-", 1, 1, "8.5", "PALMS 5.85", 1, "380", "14265", 3, "50-90", "60", "5", 2, "4", "17", 1, "3,3", 1, 1, 1, "190/215" },
                    { 8, null, "-", "63", "-", 1, 1, "995", "A PALMS 5.87Z daru kompakt szállítási méreteivel és sokoldalúságával tűnik ki, amely nemcsak erdészeti, hanem mezőgazdasági pótkocsikhoz és teherautókhoz is illeszkedik.", null, 1, "-", "1235", "-", "-", "490 (8,4 m)", "-", 1, 1, "8.7", "PALMS 5.87Z", 1, "340", "15385", 3, "50-90", "60", "5", 2, "4", "17", 1, "3,3", 1, 1, null, "215" },
                    { 9, 2, "74", "83", "-", 1, 1, "1170", "Nagy teljesítményű erdészeti daru, amelyet a mindennapos profi erdészeti munkákra terveztek. Magasabb emelőkapacitása és forgatónyomatéka miatt is alkalmas vágófejjel való munkavégzésre is. Kompatibilis a Palms egyalvázas és duplaalvázat pótkocsijaval is.", 1, 1, "1325", "1585", "-", "610", "755", "-", 1, 1, "7.5", "PALMS 7.75", 1, "380", "14780", 3, "60-120", "60", "7", 2, "4", "21", 1, "2", 1, 1, 1, "190/215" },
                    { 10, 2, "74", "83", "-", 1, 1, "1280", "Nagy teherbírású erdészeti daru, két teleszkóppal, amelyet a mindennapos profi erdészeti munkákhoz terveztek. Magasabb emelőkapacítása és forgatónyomatéka miatt alkalmas vágókanállal történő munkavégzéshez is. Egyaránt kompatibilis a Palms egyalvázas és duplaalvázas kivitelű pótkocsijaival.", 1, 1, "1250", "1480", "-", "530", "630", "-", 1, 1, "8.6", "PALMS 7.86", 1, "380", "19940", 3, "60-120", "60", "7", 2, "4", "21", 1, "3,4", 1, 1, 1, "190/215" },
                    { 11, 2, "-", "83", "-", 1, 1, "1310", "Nagy teherbírású erdészeti daru, két, kitolható teleszkóppal ellátva, a mindennapos erdészeti munkákra tervezve, profi szinten. Magas emelőkapacitással és forgatónyomatékkal rendelkezik, akár vágókanállal, biokanállal is használható. Kompatibilis a nagyobb Palms pótkocsikkal, akár egy, akár duplaalvázas kivitelű.", 1, 1, "-", "1410", "-", "-", "540", "-", 1, 1, "9.4", "PALMS 7.94", 1, "380", "21105", 3, "60-120", "60", "7", 2, "4", "21", 1, "3,8", 1, 1, 1, "215" },
                    { 12, 3, "-", "-", "106", 1, 1, "1760", "A Palms X100-as daruja a kínálatunkban a legnagyobb kinyúlással és emelőkapacitással rendelkezik. Dupla teleszkópos kivitelű, a hidraulikus alkatrészek a teleszkópokban rejtve, mégis könnyen hozzáférhetően vannak elhelyezve, biztosítva ezzel, hogy a munkálatok során ezek az alkatrészek ne sérüljenek, mégis a folyamatos üzemelés, nagy munkabírás biztosítva van.", null, 1, "-", "-", "2000", "-", "-", "680", 1, 1, "10.1", "PALMS X100", 1, "380", "31460", 4, "120", "100", "X", 2, "4", "30", 1, "4,2", 1, 1, 1, "240" },
                    { 13, null, "11,5", "-", "-", null, null, "185", "", null, null, "-", "-", "-", "-", "-", "-", null, null, "4.2", "PALMS 1.42", null, "330", "3025", null, "-", "10", "1", 2, "2", "2.1", null, "1,2", null, null, null, "180" }
                });

            migrationBuilder.InsertData(
                table: "KrpanTrailer",
                columns: new[] { "Id", "CentralBeams", "Description", "DrawbarAngle", "FrameSteeringCylinders", "KrpanAdjustableDriveId", "KrpanAxeHolderId", "KrpanBBoxId", "KrpanBaleTransportPlatformId", "KrpanCardanShaftId", "KrpanCargoSpaceExtensionId", "KrpanChainsawHolderId", "KrpanChockId", "KrpanDrawHeadId", "KrpanDrawbarSteeringId", "KrpanExtensionId", "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId", "KrpanFuelTankHolderId", "KrpanGrappleLocationId", "KrpanHandBrakeId", "KrpanHydraulicAdjustableChassisId", "KrpanHydraulicSupportLegId", "KrpanPlatoId", "KrpanToolBoxId", "KrpanTopConnectionId", "KrpanTrailerLampId", "KrpanTrailerSupportLegId", "LoadCapacity", "LoadingLength", "LoadingLengthWithExtension", "Name", "Price", "TotalLength", "TotalLengthWithExtension", "TotalWidth", "Weight" },
                values: new object[,]
                {
                    { 1, "2/180×100x6", "", "40", "2", 1, 2, 1, 1, 1, 2, 2, 1, 1, 1, null, null, 1, 2, 1, 1, null, null, null, 2, 1, 1, 1, "8000", "3582", "4477", "GP 8 DF", "10300", "5919", "6814", "2067", "1690" },
                    { 2, "2/180×100x6", "", "40", "2", 1, 2, 1, 1, 1, 2, 2, 1, 1, 1, null, null, 1, 2, 1, 1, null, null, null, 2, 1, 1, 1, "9000", "3582", "4477", "GP 9 DF", "10865", "5919", "6814", "2067", "1690" },
                    { 3, "2/180×100x6", "", "40", "2", 1, 2, 1, 1, 1, 2, 2, 1, 1, 1, null, null, 1, 2, 1, 1, null, null, null, 2, 1, 1, 1, "10000", "3582", "4477", "GP 10 DF", "11430", "5919", "6814", "2067", "1690" },
                    { 4, "2/180×100x6", "", "40", "2", 1, 2, 1, 1, 1, 2, 2, 1, 1, 1, null, 1, 1, 2, 1, 1, null, null, null, 2, 1, 1, 1, "12000", "3975", "4755", "GP 12 DF", "13060", "6209", "7100", "2122", "2100" },
                    { 5, "2/200×100x8", "", "40", "2", 1, 2, 1, 1, 1, 2, 2, 1, 1, 1, null, 1, 1, 2, 1, 1, null, null, null, 2, 1, 1, 1, "14000", "4325", "5105", "GP 14 DF", "14915", "6559", "7545", "2222", "2300" },
                    { 6, "2/180×100x6", "", "40", "2", 1, 1, 2, 2, 1, null, 1, 1, 2, 1, null, null, 2, 1, 1, 1, 1, null, null, 1, null, 1, 1, "11000", "3707", "4487", "GP 11 D", "13510", "5944", "6724", "2152", "1734" },
                    { 7, "2/200×100x6", "", "40", "2", 1, 1, 3, 3, 1, null, 1, 1, 2, 1, null, 1, 2, 1, 1, 1, 1, null, 1, 1, null, 1, 1, "13000", "3975", "4755", "GP 13 D", "15310", "6334", "7144", "2200", "2144" },
                    { 8, "2/200×100x8", "", "40", "2", 1, 1, 4, 4, 1, null, 1, 1, 2, 1, 1, 1, 2, 1, 1, 1, 1, null, 1, 1, null, 1, 1, "14800", "4325", "5105", "GP 15 D", "16960", "6686", "6686", "2318", "2352" }
                });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "BBoxId", "BeamType", "BolsterLockId", "BunkAdapterId", "BunkExtensionId", "ChainsawHolderId", "CurbWeight", "Description", "DrawbarControlCylinders", "Frame", "FrameExtensionId", "FrameExtensionLength", "GrossWeight", "HandBrakeId", "HayBaleFrameId", "HydroPackId", "LoadingAreaCross", "LoadingAreaLength", "MOTId", "MaxCraneSize", "Name", "Price", "ShippingId", "StanchionExtensionId", "StandardWheelSize", "TotalLength", "TrailerOilCoolerId", "UnderrunProtectionId", "WidthWithStandardWheels", "WoodSorterId" },
                values: new object[,]
                {
                    { 1, null, "Egyalvázas", null, null, null, 1, "890", "A PALMS 6S egy egyalvázas erdészeti pótkocsi, melynek össztömege 8500 kg. Könnyű és kompakt kialakítása tökéletes választás kisebb traktorokhoz, ideális erdőgazdálkodáshoz és gazdálkodóknak. A PALMS 6S hasonló technológiákat használ, mint nagyobb pótkocsijaink, beleértve a magas minőségű KTL és porfestési bevonatot, ami hosszabb élettartamot és magasabb maradványértéket biztosít.", "1", "140x140x6", null, "-", "8500", null, null, null, "1,5", "3000", 1, "35", "PALMS 6S", "", 1, null, "400/60-15,5", "4900", 1, null, "1950", null },
                    { 2, 1, "Egyalvázas", 1, null, null, 1, "1180", "A PALMS 8SX egy egyalvázas erdészeti pótkocsi, amelynek össztömege 10.000 kg. Ez a modell népszerű választás számos kis erdőbirtokos és gazdálkodó körében. A pótkocsi egyszerű, mégis robusztus kialakítása és tartóssága megbízható társává teszi különböző erdészeti és mezőgazdasági feladatokban.", "2", "160x160x8", null, "0,61", "10000", 1, null, null, "2", "3550", 1, "47", "PALMS 8SX", "", 1, null, "400/60-15,5", "5690", 1, 2, "2070", 1 },
                    { 3, 1, "Dupla alvázas", 1, null, null, 1, "1510", "A PALMS 8D erdészeti pótkocsi, melynek össztömege 10000 kg. Ez a modell már duplaalvázas kivitelű, a legkompaktabb pótkocsi a kínálatunkban. Azoknak a felhasználóknak ajánljuk, akik könnyebb pótkocsit keresnek, de mégis már egy duplaalvázas kivitel nagyobb szilárdságát és merevségét szeretnék kihasználni.", "2", "2x200x100x8", null, "0,85", "10000", 1, 1, null, "1,95", "3975", 1, "85", "PALMS 8D", "", 1, null, "400/60-15,5", "6200", 1, 1, "2095", 1 },
                    { 4, 1, "Dupla alvázas", 1, null, null, 1, "1510", "A PALMS 8DWD erdészeti pótkocsi, melynek össztömege 10000 kg. Ez a modell már duplaalvázas kivitelű, a legkompaktabb pótkocsi a kínálatunkban. Azoknak a felhasználóknak ajánljuk, akik könnyebb pótkocsit keresnek, de mégis már egy duplaalvázas kivitel nagyobb szilárdságát és merevségét szeretnék kihasználni, ugyanakkor a kétkerék hajtásnak köszönhetően mindenféle terepen megállja helyét.", "2", "2x200x100x8", null, "0,85", "10000", 1, 1, null, "1,95", "3975", 1, "85", "PALMS 8DWD", "", 1, null, "400/60-15,5", "6200", 1, 1, "2095", 1 },
                    { 5, 1, "Egyalvázas", 1, null, null, 1, "1425", "A PALMS 9SC a termékpalettánk legnagyobb egyalvázas pótkocsija, össztömege 12000 kg. Ideális választás azoknak, akik preferálják az egyalvázas pótkocsi egyszerűségét, miközben hosszabb kinyúlást igényelnek egy erdészeti darutól. Emellett a Palms 9SC kiemelkedik a felhasználói kényelem terén más, szintén egyalvázas pótkocsik közül a csapszeges vonórúd zár megoldásával és a szabadalmaztatott rakonca rögzítéssel.", "2", "200x200x6", null, "0,70", "12000", 1, null, null, "2,15", "3870", 1, "65", "PALMS 9SC", "", 1, null, "400/60-15,5", "6095", 1, 2, "2135", 1 },
                    { 6, 1, "Dupla alvázas", 1, null, null, 1, "1765", "A PALMS 10D duplaalvázas pótkocsi, melynek össztömege 13000 kg, az egyik legkeresettebb erdészeti pótkocsi a PALMS terméksorozatában. Kiválóan párosítható a legtöbb Palms daruval és egyéb kiegészítőkkel, lehetővé téve az egyéni igény szerinti felszereltséget, hogy olyan konstrukciót alkosson, amely pontosan megfelel az elvárásainak.", "2", "2x200x100x8", null, "0,85", "13000", 1, 1, null, "2,4", "3975", 1, "85", "PALMS 10D", "", 1, null, "400/60-15,5", "6200", 1, 1, "2165", 1 },
                    { 7, 1, "Dupla alvázas", 1, null, null, 1, "1765", "A PALMS 10DWD duplaalvázas pótkocsi, melynek össztömege 12500 kg, és amely a 10D alapváltozathoz hasonlóan a másik legkeresettebb erdészeti pótkocsi a PALMS kínálatában. Szintén jól párosítható a legtöbb Palms daruval és egyéb kiegészítőkkel, ugyanakkor viszont olyan kétkerék hajtással ellátott változat, mely nemcsak igény szerinti, kiváló konstrukciót jelent, hanem kiváló közlekedést biztosít mindenfajta terepen és emellett természetesen elvárásainak is mindenben megfelel.", "2", "2x200x100x8", null, "0,85", "12500", 1, 1, null, "2,4", "3975", 1, "85", "PALMS 10DWD", "", 1, null, "400/60-15,5", "6200", 1, 1, "2165", 1 },
                    { 8, 1, "Dupla alvázas", 1, null, null, 1, "2030", "A PALMS 12D duplaalvázas erdészeti pótkocsi, melynek összetömege 15000 kg. Akár mindennapi, akár nagyobb munkálatok elvégzésére is kiválóan alkalmas, nagyszerű kompatibilitás nyújtva a Palms 5-ös és 7-es szériás daruival.  ", "2", "2x200x100x8", null, "0,85", "15000", 1, 1, null, "2,7", "3975", 1, "85", "PALMS 12D", "", 1, null, "500/50-17", "6200", 1, 1, "2350", 1 },
                    { 9, 1, "Dupla alvázas", 1, null, null, 1, "2030", "A PALMS 12DWD duplaalvázas erdészeti pótkocsi, melynek összetömege 15000 kg. Akár mindennapi, akár nagyobb munkálatok elvégzésére is kiválóan alkalmas, nagyszerű kompatibilitás nyújtva a Palms 5-ös és 7-es szériás daruival. Ennek a modellnek az előnye, hogy kétkerék hajtással rendelkezik, amely alkalmassá teszi, hogy bármilyen talajviszonyok között kiváló teljesítményt nyújtson a kiközelítés során.", "2", "2x200x100x8", null, "0,85", "15000", 1, 1, null, "2,7", "3975", 1, "85", "PALMS 12DWD", "", 1, null, "500/50-17", "6200", 1, 1, "2350", 1 },
                    { 10, 1, "Dupla alvázas", 1, null, null, 1, "2375", "A PALMS 14D a Palms gyár termékkínálatának legnagyobb dupla alvázas pótkocsija, jelentős, 18000 kg össztömegével. Nemcsak a legnagyobb rakfelülettel rendelkezik, hanem kiterjesztett rakfelületet kínál más dupla alvázas pótkocsikhoz képest. További előnye, hogy kompatibilis a Palms legnagyobb, legprofibb erdészeti darujával, az X100-sal is. ", "2", "2x200x120x10", null, "0,86", "18000", 1, 1, null, "3,0", "4080", 1, "112", "PALMS 14D", "", 1, null, "500/50-17", "6300", 1, 1, "2450", 1 },
                    { 11, 1, "Dupla alvázas", 1, null, null, 1, "2375", "A PALMS 14DWD a Palms gyár termékkínálatának legnagyobb dupla alvázas pótkocsija, jelentős, 18000 kg össztömegével. Nemcsak a legnagyobb rakfelülettel rendelkezik, hanem kiterjesztett rakfelületet kínál más dupla alvázas pótkocsikhoz képest. További előnye, hogy kompatibilis a Palms legnagyobb, legprofibb erdészeti darujával, az X100-sal is. Ugyanakkor ez a kétkerék hajtással is ellátott változat alkalmas az összes, akár extrém terepviszony leküzdésére is.", "2", "2x200x120x10", null, "0,86", "18000", 1, 1, null, "3,0", "4080", 1, "112", "PALMS 14DWD", "", 1, null, "500/50-17", "6300", 1, 1, "2450", 1 },
                    { 12, 2, "Unibody (Forwarder)", 1, 1, null, 1, "2170", "A PALMS 10U erdészeti pótkocsi az U-sorozat legkisebb változata, mely a duplaalvázas kivitel mellett az úgynevezett unibody típusú rakoncákkal van szerelve. Össztömege 15000 kg. Nagy hasmagassága és az unibody keret csökkenti az elakadás kockázatát. A hidraulikus alkatrészek az unibody keretben vannak elhelyezve, védve ezzel azokat, mégis könnyű hozzáférést biztosít a karbantartáshoz. ", "2", "unibody", 1, "1,085", "15000", 1, 2, null, "2.4", "3990", 1, "120", "PALMS 10U", "", 1, null, "500/50-17", "6215", 1, 2, "2245", null },
                    { 13, 2, "Unibody (Forwarder)", 1, 1, null, 1, "2170", "A PALMS 10UWD erdészeti pótkocsi az U-sorozat legkisebb változata, mely a duplaalvázas kivitel mellett az úgynevezett unibody típusú rakoncákkal van szerelve. Össztömege 15000 kg. Nagy hasmagassága és az unibody keret csökkenti az elakadás kockázatát. A hidraulikus alkatrészek az unibody keretben vannak elhelyezve, védve ezzel azokat, mégis könnyű hozzáférést biztosít a karbantartáshoz. Az UWD változat kétkerék hajtással is rendelkezik, mely által a terepviszonyok is kiválóan kezelhetők.  ", "2", "unibody", 1, "1,085", "15000", 1, 2, null, "2.4", "3990", 1, "120", "PALMS 10UWD", "", 1, null, "500/50-17", "6215", 1, 2, "2245", null },
                    { 14, 2, "Unibody (Forwarder)", 1, 1, null, 1, "2270", "A PALMS 12U pótkocsi össztömege 17000 kg, unibody típusú erdészeti pótkocsi, melyet kifejezetten a mindennapi, szakmai erdészeti munkákhoz terveztek. Magas hasmagassággal rendelkezik, ez és a forwarder típusú keret elősegíti, hogy az elakadás kockázata minél kisebb legyen. Mivel az összes hidraulikus alkatrész ebben a keretben került elhelyezésre, így azok védve vannak, ugyanakkor viszont könnyű hozzáférhetőség biztosítja a karbantartás elvégzését.", "2", "unibody", 1, "1,085", "17000", 1, 2, null, "2.75", "3990", 1, "120", "PALMS 12U", "", 1, null, "500/50-22,5", "6215", 1, 2, "2245", null },
                    { 15, 2, "Unibody (Forwarder)", 1, 1, null, 1, "2270", "A PALMS 12UWD pótkocsi össztömege 17000 kg, unibody típusú erdészeti pótkocsi, melyet kifejezetten a mindennapi, szakmai erdészeti munkákhoz terveztek. Magas hasmagassággal rendelkezik, ez és a forwarder típusú keret elősegíti, hogy az elakadás kockázata minél kisebb legyen. Mivel az összes hidraulikus alkatrész ebben a keretben került elhelyezésre, így azok védve vannak, ugyanakkor viszont könnyű hozzáférhetőség biztosítja a karbantartás elvégzését. Ennek a típusnak további előnye, hogy kétkerék hajtással rendelkezik, amely alkalmassá teszi arra, hogy akár extrém talajviszonyok között is megállja a helyét. ", "2", "unibody", 1, "1,085", "17000", 1, 2, null, "2.75", "3990", 1, "120", "PALMS 12UWD", "", 1, null, "500/50-22,5", "6215", 1, 2, "2245", null },
                    { 16, 2, "Unibody (Forwarder)", 1, 1, null, 1, "2270", "A PALMS 12UAWD pótkocsi össztömege 17000 kg, unibody típusú erdészeti pótkocsi, melyet kifejezetten a mindennapi, szakmai erdészeti munkákhoz terveztek. Magas hasmagassággal rendelkezik, ez és a forwarder típusú keret elősegíti, hogy az elakadás kockázata minél kisebb legyen. Mivel az összes hidraulikus alkatrész ebben a keretben került elhelyezésre, így azok védve vannak, ugyanakkor viszont könnyű hozzáférhetőség biztosítja a karbantartás elvégzését. Ennek a típusnak további előnye, hogy négykerék hajtással rendelkezik, amely alkalmassá teszi arra, hogy akár extrém talajviszonyok között is megállja a helyét. ", "2", "unibody", 1, "1,085", "17000", 1, 2, null, "2.75", "3990", 1, "120", "PALMS 12UAWD", "", 1, null, "500/50-22,5", "6215", 1, 2, "2245", null },
                    { 17, 3, "Unibody (Forwarder)", 1, 1, 1, 1, "2545", "A PALMS 15U pótkocsi a legnagyobb a Palms U típusú pótkocsi kínálatában, össztömege 19000 kg. Az U pótkocsikat nehéz fakitermelésre tervezték, a kialakításának köszönhetően tartósak és igazán nagy terheket képesek vinni. Ez a pótkocsi nagysága ellenére igen könnyen mozog, gumikerekes kivitele környezetkímélő. Nagyobb mennyiségű fa kitermelésére alkalmas, megkönnyíti az erdészeti munkát. Nagy hasmagassággal rendelkezik, ez és a forwarder típusú keret az elakadás kockázatát csökkentik. A hidraulikus alkatrészek a keretben kerültek elhelyezésre, hogy védettek legyenek a külső behatás ellen, ugyanakkor karbantartásilag könnyen elérhetők. ", "2", "unibody", 1, "1,085", "19000", 1, 2, null, "3.2", "4175", 1, "120", "PALMS 15U", "", 1, null, "500/50-22,5", "6415", 1, 2, "2450", null },
                    { 18, 3, "Unibody (Forwarder)", 1, 1, 1, 1, "2545", "A PALMS 15U pótkocsi a legnagyobb a Palms U típusú pótkocsi kínálatában, össztömege 19000 kg. Az U pótkocsikat nehéz fakitermelésre tervezték, a kialakításának köszönhetően tartósak és igazán nagy terheket képesek vinni. Ez a pótkocsi nagysága ellenére igen könnyen mozog, gumikerekes kivitele környezetkímélő. Nagyobb mennyiségű fa kitermelésére alkalmas, megkönnyíti az erdészeti munkát. Nagy hasmagassággal rendelkezik, ez és a forwarder típusú keret az elakadás kockázatát csökkentik. A hidraulikus alkatrészek a keretben kerültek elhelyezésre, hogy védettek legyenek a külső behatás ellen, ugyanakkor karbantartásilag könnyen elérhetők. Ez a típus kétkerék hajtással is rendelkezik, mely által mindenféle terepen könnyen mozgatható.", "2", "unibody", 1, "1,085", "19000", 1, 2, null, "3.2", "4175", 1, "120", "PALMS 15UWD", "", 1, null, "500/50-22,5", "6415", 1, 2, "2450", null },
                    { 19, 3, "Unibody (Forwarder)", 1, 1, 1, 1, "2545", "A PALMS 15U pótkocsi a legnagyobb a Palms U típusú pótkocsi kínálatában, össztömege 19000 kg. Az U pótkocsikat nehéz fakitermelésre tervezték, a kialakításának köszönhetően tartósak és igazán nagy terheket képesek vinni. Ez a pótkocsi nagysága ellenére igen könnyen mozog, gumikerekes kivitele környezetkímélő. Nagyobb mennyiségű fa kitermelésére alkalmas, megkönnyíti az erdészeti munkát. Nagy hasmagassággal rendelkezik, ez és a forwarder típusú keret az elakadás kockázatát csökkentik. A hidraulikus alkatrészek a keretben kerültek elhelyezésre, hogy védettek legyenek a külső behatás ellen, ugyanakkor karbantartásilag könnyen elérhetők. Ez a típus már négykerék hajtással rendelkezik, ezáltal bármilyen tereppel könnyedén megbirkózik.", "2", "unibody", 1, "1,085", "19000", 1, 2, null, "3.2", "4175", 1, "120", "PALMS 15UAWD", "", 1, null, "500/50-22,5", "6415", 1, 2, "2450", null },
                    { 20, 4, "Unibody (Forwarder)", null, 2, 2, null, "4700", "Ismerje meg a PALMS MWD sorozatú forwarder típusú pótkocsit, amelyet a legnehezebb terepek legyőzésére terveztek. Az összes MWD pótkocsi mechanikus áttétele egyedileg lesz testre szabva minden ügyfelünk traktorához.", "2", "unibody", null, "1.085", "18000", null, 2, null, "3.2", "4235", 1, "120", "PALMS MWD 3.2", "", 1, 1, "600/50x22.5", "6430", null, null, "2470", null },
                    { 21, 4, "Unibody (Forwarder)", null, 2, 2, null, "4920", "Ismerje meg a PALMS hidromechanikus meghajtású pótkocsiját, amelyet a legnehezebb terepek legyőzésére terveztek. A hidromechanikus 4x4 rendszer alkalmas minden méretű traktorhoz, amelynek TLT hajtása van.", "2", "unibody", null, "1.085", "18000", null, 2, null, "3.2", "4185", 1, "120", "PALMS HMWD 3.2", "", 1, 1, "600/50x22.5", "6430", 2, null, "2470", null },
                    { 22, 5, "Dupla alvázas", null, null, null, 1, "260", "Tökéletes kompakt traktorokhoz és terepjárókhoz. Strenx Performance acélból készült strapabíró duplaalvázzal, fokozott korrózióállósággal (KTL+por bevonatt), valamint 1500 kg névleges teherbírással rendelkezik.", "1", "2x4 mm C-alváz", null, "-", "1500", null, 1, 1, "0,6", "2450", 1, "12", "PALMS 2D", "", 1, null, "22/11-8", "3865", null, null, "1285", null }
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
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 12 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 12 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 12 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 12 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 5 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 5 },
                    { 8, 3 },
                    { 8, 6 },
                    { 8, 12 },
                    { 9, 3 },
                    { 9, 6 },
                    { 9, 12 },
                    { 10, 4 },
                    { 10, 7 },
                    { 10, 8 },
                    { 10, 9 },
                    { 10, 10 },
                    { 10, 11 },
                    { 10, 13 },
                    { 10, 14 },
                    { 10, 15 },
                    { 10, 17 },
                    { 10, 18 },
                    { 11, 4 },
                    { 11, 7 },
                    { 11, 9 },
                    { 11, 11 },
                    { 11, 13 },
                    { 11, 15 },
                    { 11, 18 },
                    { 12, 4 },
                    { 12, 7 },
                    { 12, 8 },
                    { 12, 9 },
                    { 12, 10 },
                    { 12, 11 },
                    { 12, 13 },
                    { 12, 15 },
                    { 12, 18 },
                    { 13, 4 },
                    { 13, 7 },
                    { 13, 9 },
                    { 13, 11 },
                    { 13, 13 },
                    { 13, 15 },
                    { 13, 18 },
                    { 14, 4 },
                    { 14, 7 },
                    { 14, 9 },
                    { 14, 11 },
                    { 14, 13 },
                    { 14, 15 },
                    { 14, 18 },
                    { 15, 4 },
                    { 15, 7 },
                    { 15, 9 },
                    { 15, 11 },
                    { 15, 13 },
                    { 15, 15 },
                    { 15, 18 },
                    { 16, 8 },
                    { 16, 10 },
                    { 17, 8 },
                    { 17, 10 },
                    { 18, 8 },
                    { 18, 10 },
                    { 19, 8 },
                    { 19, 10 },
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
                    { 30, 17 },
                    { 31, 20 },
                    { 31, 21 },
                    { 32, 20 },
                    { 32, 21 }
                });

            migrationBuilder.InsertData(
                table: "ControlBlockCrane",
                columns: new[] { "ControlBlockId", "CraneId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 13 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 4, 2 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 },
                    { 6, 2 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 6, 8 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 7, 6 },
                    { 7, 7 },
                    { 7, 8 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 11 },
                    { 7, 12 },
                    { 8, 2 },
                    { 8, 4 },
                    { 8, 5 },
                    { 8, 6 },
                    { 8, 7 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 8, 11 },
                    { 8, 12 },
                    { 9, 2 },
                    { 9, 4 },
                    { 9, 5 },
                    { 9, 6 },
                    { 9, 7 },
                    { 9, 8 },
                    { 9, 9 },
                    { 9, 10 },
                    { 9, 11 },
                    { 9, 12 },
                    { 10, 6 },
                    { 10, 7 },
                    { 10, 8 },
                    { 10, 9 },
                    { 10, 10 },
                    { 10, 11 },
                    { 10, 12 },
                    { 11, 2 },
                    { 11, 4 },
                    { 11, 5 },
                    { 11, 6 },
                    { 11, 7 },
                    { 11, 8 },
                    { 11, 9 },
                    { 11, 10 },
                    { 11, 11 },
                    { 11, 12 },
                    { 12, 6 },
                    { 12, 7 },
                    { 12, 8 },
                    { 12, 9 },
                    { 12, 10 },
                    { 12, 11 },
                    { 12, 12 },
                    { 13, 6 },
                    { 13, 7 },
                    { 13, 8 },
                    { 13, 9 },
                    { 13, 10 },
                    { 13, 11 },
                    { 13, 12 },
                    { 14, 10 },
                    { 14, 11 },
                    { 14, 12 }
                });

            migrationBuilder.InsertData(
                table: "CraneControlBlocks",
                columns: new[] { "Id", "ControlBlockId", "CraneId", "FrameTypeId" },
                values: new object[,]
                {
                    { 1, 1, 1, 2 },
                    { 2, 2, 2, 2 },
                    { 3, 3, 2, 2 },
                    { 4, 4, 2, 2 },
                    { 5, 5, 2, 2 },
                    { 6, 6, 2, 2 },
                    { 7, 8, 2, 2 },
                    { 8, 9, 2, 2 },
                    { 9, 11, 2, 2 },
                    { 10, 2, 3, 2 },
                    { 11, 3, 3, 2 },
                    { 12, 5, 3, 2 },
                    { 13, 2, 4, 3 },
                    { 14, 3, 4, 3 },
                    { 15, 4, 4, 3 },
                    { 16, 5, 4, 3 },
                    { 17, 6, 4, 3 },
                    { 18, 8, 4, 3 },
                    { 19, 9, 4, 3 },
                    { 20, 11, 4, 3 },
                    { 21, 2, 4, 4 },
                    { 22, 3, 4, 4 },
                    { 23, 4, 4, 4 },
                    { 24, 5, 4, 4 },
                    { 25, 6, 4, 4 },
                    { 26, 8, 4, 4 },
                    { 27, 9, 4, 4 },
                    { 28, 11, 4, 4 },
                    { 29, 2, 4, 5 },
                    { 30, 3, 4, 5 },
                    { 31, 4, 4, 5 },
                    { 32, 5, 4, 5 },
                    { 33, 6, 4, 5 },
                    { 34, 8, 4, 5 },
                    { 35, 9, 4, 5 },
                    { 36, 11, 4, 5 },
                    { 37, 2, 5, 3 },
                    { 38, 3, 5, 3 },
                    { 39, 4, 5, 3 },
                    { 40, 5, 5, 3 },
                    { 41, 6, 5, 3 },
                    { 42, 8, 5, 3 },
                    { 43, 9, 5, 3 },
                    { 44, 11, 5, 3 },
                    { 45, 2, 5, 5 },
                    { 46, 3, 5, 5 },
                    { 47, 4, 5, 5 },
                    { 48, 5, 5, 5 },
                    { 49, 6, 5, 5 },
                    { 50, 8, 5, 5 },
                    { 51, 9, 5, 5 },
                    { 52, 11, 5, 5 },
                    { 53, 3, 6, 3 },
                    { 54, 4, 6, 3 },
                    { 55, 5, 6, 3 },
                    { 56, 6, 6, 3 },
                    { 57, 7, 6, 3 },
                    { 58, 8, 6, 3 },
                    { 59, 9, 6, 3 },
                    { 60, 10, 6, 3 },
                    { 61, 11, 6, 3 },
                    { 62, 12, 6, 3 },
                    { 63, 13, 6, 3 },
                    { 64, 3, 6, 5 },
                    { 65, 4, 6, 5 },
                    { 66, 5, 6, 5 },
                    { 67, 6, 6, 5 },
                    { 68, 7, 6, 5 },
                    { 69, 8, 6, 5 },
                    { 70, 9, 6, 5 },
                    { 71, 10, 6, 5 },
                    { 72, 11, 6, 5 },
                    { 73, 12, 6, 5 },
                    { 74, 13, 6, 5 },
                    { 75, 3, 6, 6 },
                    { 76, 4, 6, 6 },
                    { 77, 5, 6, 6 },
                    { 78, 6, 6, 6 },
                    { 79, 7, 6, 6 },
                    { 80, 8, 6, 6 },
                    { 81, 9, 6, 6 },
                    { 82, 10, 6, 6 },
                    { 83, 11, 6, 6 },
                    { 84, 12, 6, 6 },
                    { 85, 13, 6, 6 },
                    { 86, 3, 6, 7 },
                    { 87, 4, 6, 7 },
                    { 88, 5, 6, 7 },
                    { 89, 6, 6, 7 },
                    { 90, 7, 6, 7 },
                    { 91, 8, 6, 7 },
                    { 92, 9, 6, 7 },
                    { 93, 10, 6, 7 },
                    { 94, 11, 6, 7 },
                    { 95, 12, 6, 7 },
                    { 96, 13, 6, 7 },
                    { 97, 8, 6, 9 },
                    { 98, 9, 6, 9 },
                    { 99, 10, 6, 9 },
                    { 100, 11, 6, 9 },
                    { 101, 12, 6, 9 },
                    { 102, 13, 6, 9 },
                    { 103, 8, 6, 10 },
                    { 104, 9, 6, 10 },
                    { 105, 10, 6, 10 },
                    { 106, 11, 6, 10 },
                    { 107, 12, 6, 10 },
                    { 108, 13, 6, 10 },
                    { 109, 3, 7, 3 },
                    { 110, 4, 7, 3 },
                    { 111, 5, 7, 3 },
                    { 112, 6, 7, 3 },
                    { 113, 7, 7, 3 },
                    { 114, 8, 7, 3 },
                    { 115, 9, 7, 3 },
                    { 116, 10, 7, 3 },
                    { 117, 11, 7, 3 },
                    { 118, 12, 7, 3 },
                    { 119, 13, 7, 3 },
                    { 120, 3, 7, 5 },
                    { 121, 4, 7, 5 },
                    { 122, 5, 7, 5 },
                    { 123, 6, 7, 5 },
                    { 124, 7, 7, 5 },
                    { 125, 8, 7, 5 },
                    { 126, 9, 7, 5 },
                    { 127, 10, 7, 5 },
                    { 128, 11, 7, 5 },
                    { 129, 12, 7, 5 },
                    { 130, 13, 7, 5 },
                    { 131, 3, 7, 6 },
                    { 132, 4, 7, 6 },
                    { 133, 5, 7, 6 },
                    { 134, 6, 7, 6 },
                    { 135, 7, 7, 6 },
                    { 136, 8, 7, 6 },
                    { 137, 9, 7, 6 },
                    { 138, 10, 7, 6 },
                    { 139, 11, 7, 6 },
                    { 140, 12, 7, 6 },
                    { 141, 13, 7, 6 },
                    { 142, 3, 7, 7 },
                    { 143, 4, 7, 7 },
                    { 144, 5, 7, 7 },
                    { 145, 6, 7, 7 },
                    { 146, 7, 7, 7 },
                    { 147, 8, 7, 7 },
                    { 148, 9, 7, 7 },
                    { 149, 10, 7, 7 },
                    { 150, 11, 7, 7 },
                    { 151, 12, 7, 7 },
                    { 152, 13, 7, 7 },
                    { 153, 8, 7, 9 },
                    { 154, 9, 7, 9 },
                    { 155, 10, 7, 9 },
                    { 156, 11, 7, 9 },
                    { 157, 12, 7, 9 },
                    { 158, 13, 7, 9 },
                    { 159, 8, 7, 10 },
                    { 160, 9, 7, 10 },
                    { 161, 10, 7, 10 },
                    { 162, 11, 7, 10 },
                    { 163, 12, 7, 10 },
                    { 164, 13, 7, 10 },
                    { 165, 6, 8, 8 },
                    { 166, 7, 8, 8 },
                    { 167, 8, 8, 8 },
                    { 168, 9, 8, 8 },
                    { 169, 10, 8, 8 },
                    { 170, 11, 8, 8 },
                    { 171, 12, 8, 8 },
                    { 172, 13, 8, 8 },
                    { 173, 6, 9, 5 },
                    { 174, 7, 9, 5 },
                    { 175, 8, 9, 5 },
                    { 176, 9, 9, 5 },
                    { 177, 10, 9, 5 },
                    { 178, 11, 9, 5 },
                    { 179, 12, 9, 5 },
                    { 180, 13, 9, 5 },
                    { 181, 6, 9, 6 },
                    { 182, 7, 9, 6 },
                    { 183, 8, 9, 6 },
                    { 184, 9, 9, 6 },
                    { 185, 10, 9, 6 },
                    { 186, 11, 9, 6 },
                    { 187, 12, 9, 6 },
                    { 188, 13, 9, 6 },
                    { 189, 6, 9, 7 },
                    { 190, 7, 9, 7 },
                    { 191, 8, 9, 7 },
                    { 192, 9, 9, 7 },
                    { 193, 10, 9, 7 },
                    { 194, 11, 9, 7 },
                    { 195, 12, 9, 7 },
                    { 196, 13, 9, 7 },
                    { 197, 8, 9, 9 },
                    { 198, 9, 9, 9 },
                    { 199, 10, 9, 9 },
                    { 200, 11, 9, 9 },
                    { 201, 12, 9, 9 },
                    { 202, 13, 9, 9 },
                    { 203, 8, 9, 10 },
                    { 204, 9, 9, 10 },
                    { 205, 10, 9, 10 },
                    { 206, 11, 9, 10 },
                    { 207, 12, 9, 10 },
                    { 208, 13, 9, 10 },
                    { 209, 6, 10, 5 },
                    { 210, 7, 10, 5 },
                    { 211, 8, 10, 5 },
                    { 212, 9, 10, 5 },
                    { 213, 10, 10, 5 },
                    { 214, 11, 10, 5 },
                    { 215, 12, 10, 5 },
                    { 216, 13, 10, 5 },
                    { 217, 14, 10, 5 },
                    { 218, 6, 10, 6 },
                    { 219, 7, 10, 6 },
                    { 220, 8, 10, 6 },
                    { 221, 9, 10, 6 },
                    { 222, 10, 10, 6 },
                    { 223, 11, 10, 6 },
                    { 224, 12, 10, 6 },
                    { 225, 13, 10, 6 },
                    { 226, 14, 10, 6 },
                    { 227, 6, 10, 7 },
                    { 228, 7, 10, 7 },
                    { 229, 8, 10, 7 },
                    { 230, 9, 10, 7 },
                    { 231, 10, 10, 7 },
                    { 232, 11, 10, 7 },
                    { 233, 12, 10, 7 },
                    { 234, 13, 10, 7 },
                    { 235, 14, 10, 7 },
                    { 236, 8, 10, 9 },
                    { 237, 9, 10, 9 },
                    { 238, 10, 10, 9 },
                    { 239, 11, 10, 9 },
                    { 240, 12, 10, 9 },
                    { 241, 13, 10, 9 },
                    { 242, 14, 10, 9 },
                    { 243, 8, 10, 10 },
                    { 244, 9, 10, 10 },
                    { 245, 10, 10, 10 },
                    { 246, 11, 10, 10 },
                    { 247, 12, 10, 10 },
                    { 248, 13, 10, 10 },
                    { 249, 14, 10, 10 },
                    { 250, 6, 11, 5 },
                    { 251, 7, 11, 5 },
                    { 252, 8, 11, 5 },
                    { 253, 9, 11, 5 },
                    { 254, 10, 11, 5 },
                    { 255, 11, 11, 5 },
                    { 256, 12, 11, 5 },
                    { 257, 13, 11, 5 },
                    { 258, 14, 11, 5 },
                    { 259, 6, 11, 6 },
                    { 260, 7, 11, 6 },
                    { 261, 8, 11, 6 },
                    { 262, 9, 11, 6 },
                    { 263, 10, 11, 6 },
                    { 264, 11, 11, 6 },
                    { 265, 12, 11, 6 },
                    { 266, 13, 11, 6 },
                    { 267, 14, 11, 6 },
                    { 268, 6, 11, 7 },
                    { 269, 7, 11, 7 },
                    { 270, 8, 11, 7 },
                    { 271, 9, 11, 7 },
                    { 272, 10, 11, 7 },
                    { 273, 11, 11, 7 },
                    { 274, 12, 11, 7 },
                    { 275, 13, 11, 7 },
                    { 276, 14, 11, 7 },
                    { 277, 8, 11, 9 },
                    { 278, 9, 11, 9 },
                    { 279, 10, 11, 9 },
                    { 280, 11, 11, 9 },
                    { 281, 12, 11, 9 },
                    { 282, 13, 11, 9 },
                    { 283, 14, 11, 9 },
                    { 284, 8, 11, 10 },
                    { 285, 9, 11, 10 },
                    { 286, 10, 11, 10 },
                    { 287, 11, 11, 10 },
                    { 288, 12, 11, 10 },
                    { 289, 13, 11, 10 },
                    { 290, 14, 11, 10 },
                    { 291, 7, 12, 6 },
                    { 292, 8, 12, 6 },
                    { 293, 9, 12, 6 },
                    { 294, 10, 12, 6 },
                    { 295, 11, 12, 6 },
                    { 296, 12, 12, 6 },
                    { 297, 13, 12, 6 },
                    { 298, 14, 12, 6 },
                    { 299, 7, 12, 7 },
                    { 300, 8, 12, 7 },
                    { 301, 9, 12, 7 },
                    { 302, 10, 12, 7 },
                    { 303, 11, 12, 7 },
                    { 304, 12, 12, 7 },
                    { 305, 13, 12, 7 },
                    { 306, 14, 12, 7 },
                    { 307, 8, 12, 9 },
                    { 308, 9, 12, 9 },
                    { 309, 10, 12, 9 },
                    { 310, 11, 12, 9 },
                    { 311, 12, 12, 9 },
                    { 312, 13, 12, 9 },
                    { 313, 14, 12, 9 },
                    { 314, 8, 12, 10 },
                    { 315, 9, 12, 10 },
                    { 316, 10, 12, 10 },
                    { 317, 11, 12, 10 },
                    { 318, 12, 12, 10 },
                    { 319, 13, 12, 10 },
                    { 320, 14, 12, 10 },
                    { 321, 1, 1, 1 },
                    { 322, 2, 2, 1 },
                    { 323, 3, 2, 1 },
                    { 324, 4, 2, 1 },
                    { 325, 5, 2, 1 },
                    { 326, 6, 2, 1 },
                    { 327, 8, 2, 1 },
                    { 328, 9, 2, 1 },
                    { 329, 11, 2, 1 },
                    { 330, 2, 3, 1 },
                    { 331, 3, 3, 1 },
                    { 332, 5, 3, 1 },
                    { 333, 2, 4, 1 },
                    { 334, 3, 4, 1 },
                    { 335, 4, 4, 1 },
                    { 336, 5, 4, 1 },
                    { 337, 6, 4, 1 },
                    { 338, 8, 4, 1 },
                    { 339, 9, 4, 1 },
                    { 340, 11, 4, 1 },
                    { 341, 2, 5, 1 },
                    { 342, 3, 5, 1 },
                    { 343, 4, 5, 1 },
                    { 344, 5, 5, 1 },
                    { 345, 6, 5, 1 },
                    { 346, 8, 5, 1 },
                    { 347, 9, 5, 1 },
                    { 348, 11, 5, 1 },
                    { 349, 3, 6, 1 },
                    { 350, 4, 6, 1 },
                    { 351, 5, 6, 1 },
                    { 352, 6, 6, 1 },
                    { 353, 7, 6, 1 },
                    { 354, 8, 6, 1 },
                    { 355, 9, 6, 1 },
                    { 356, 10, 6, 1 },
                    { 357, 11, 6, 1 },
                    { 358, 12, 6, 1 },
                    { 359, 13, 6, 1 },
                    { 360, 3, 7, 1 },
                    { 361, 4, 7, 1 },
                    { 362, 5, 7, 1 },
                    { 363, 6, 7, 1 },
                    { 364, 7, 7, 1 },
                    { 365, 8, 7, 1 },
                    { 366, 9, 7, 1 },
                    { 367, 10, 7, 1 },
                    { 368, 11, 7, 1 },
                    { 369, 12, 7, 1 },
                    { 370, 13, 7, 1 },
                    { 371, 6, 9, 1 },
                    { 372, 7, 9, 1 },
                    { 373, 8, 9, 1 },
                    { 374, 9, 9, 1 },
                    { 375, 10, 9, 1 },
                    { 376, 11, 9, 1 },
                    { 377, 12, 9, 1 },
                    { 378, 13, 9, 1 },
                    { 379, 6, 10, 1 },
                    { 380, 7, 10, 1 },
                    { 381, 8, 10, 1 },
                    { 382, 9, 10, 1 },
                    { 383, 10, 10, 1 },
                    { 384, 11, 10, 1 },
                    { 385, 12, 10, 1 },
                    { 386, 13, 10, 1 },
                    { 387, 14, 10, 1 },
                    { 388, 6, 11, 1 },
                    { 389, 7, 11, 1 },
                    { 390, 8, 11, 1 },
                    { 391, 9, 11, 1 },
                    { 392, 10, 11, 1 },
                    { 393, 11, 11, 1 },
                    { 394, 12, 11, 1 },
                    { 395, 13, 11, 1 },
                    { 396, 14, 11, 1 },
                    { 397, 7, 12, 1 },
                    { 398, 8, 12, 1 },
                    { 399, 9, 12, 1 },
                    { 400, 10, 12, 1 },
                    { 401, 11, 12, 1 },
                    { 402, 12, 12, 1 },
                    { 403, 13, 12, 1 },
                    { 404, 14, 12, 1 }
                });

            migrationBuilder.InsertData(
                table: "CraneTrailer",
                columns: new[] { "CraneId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 8 },
                    { 4, 9 },
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
                    { 5, 13 },
                    { 5, 14 },
                    { 5, 15 },
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
                    { 6, 13 },
                    { 6, 14 },
                    { 6, 15 },
                    { 6, 16 },
                    { 6, 17 },
                    { 6, 18 },
                    { 6, 19 },
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
                    { 7, 13 },
                    { 7, 14 },
                    { 7, 15 },
                    { 7, 16 },
                    { 7, 17 },
                    { 7, 18 },
                    { 7, 19 },
                    { 8, 3 },
                    { 8, 4 },
                    { 8, 6 },
                    { 8, 7 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 8, 11 },
                    { 8, 12 },
                    { 8, 13 },
                    { 8, 14 },
                    { 8, 15 },
                    { 8, 16 },
                    { 8, 17 },
                    { 8, 18 },
                    { 8, 19 },
                    { 9, 3 },
                    { 9, 4 },
                    { 9, 6 },
                    { 9, 7 },
                    { 9, 8 },
                    { 9, 9 },
                    { 9, 10 },
                    { 9, 11 },
                    { 9, 12 },
                    { 9, 13 },
                    { 9, 14 },
                    { 9, 15 },
                    { 9, 16 },
                    { 9, 17 },
                    { 9, 18 },
                    { 9, 19 },
                    { 9, 20 },
                    { 9, 21 },
                    { 10, 3 },
                    { 10, 4 },
                    { 10, 6 },
                    { 10, 7 },
                    { 10, 8 },
                    { 10, 9 },
                    { 10, 10 },
                    { 10, 11 },
                    { 10, 12 },
                    { 10, 13 },
                    { 10, 14 },
                    { 10, 15 },
                    { 10, 16 },
                    { 10, 17 },
                    { 10, 18 },
                    { 10, 19 },
                    { 10, 20 },
                    { 10, 21 },
                    { 11, 8 },
                    { 11, 9 },
                    { 11, 10 },
                    { 11, 11 },
                    { 11, 12 },
                    { 11, 13 },
                    { 11, 14 },
                    { 11, 15 },
                    { 11, 16 },
                    { 11, 17 },
                    { 11, 18 },
                    { 11, 19 },
                    { 11, 20 },
                    { 11, 21 },
                    { 12, 10 },
                    { 12, 11 },
                    { 12, 12 },
                    { 12, 13 },
                    { 12, 14 },
                    { 12, 15 },
                    { 12, 16 },
                    { 12, 17 },
                    { 12, 18 },
                    { 12, 19 },
                    { 12, 20 },
                    { 12, 21 },
                    { 13, 22 }
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
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 1, 20 },
                    { 1, 21 },
                    { 1, 22 },
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
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 },
                    { 2, 17 },
                    { 2, 18 },
                    { 2, 19 },
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
                    { 3, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 3, 19 },
                    { 3, 20 },
                    { 3, 21 },
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
                    { 4, 13 },
                    { 4, 14 },
                    { 4, 15 },
                    { 4, 16 },
                    { 4, 17 },
                    { 4, 18 },
                    { 4, 19 },
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
                    { 5, 13 },
                    { 5, 14 },
                    { 5, 15 },
                    { 5, 16 },
                    { 5, 17 },
                    { 5, 18 },
                    { 5, 19 },
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
                    { 6, 13 },
                    { 6, 14 },
                    { 6, 15 },
                    { 6, 16 },
                    { 6, 17 },
                    { 6, 18 },
                    { 6, 19 },
                    { 7, 2 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 8, 11 },
                    { 8, 12 },
                    { 8, 13 },
                    { 8, 14 },
                    { 8, 15 },
                    { 8, 16 },
                    { 8, 17 },
                    { 8, 18 },
                    { 8, 19 },
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
                    { 9, 13 },
                    { 9, 14 },
                    { 9, 15 },
                    { 9, 16 },
                    { 9, 17 },
                    { 9, 18 },
                    { 9, 19 },
                    { 10, 20 },
                    { 10, 21 },
                    { 11, 20 },
                    { 11, 21 },
                    { 12, 20 },
                    { 12, 21 },
                    { 13, 20 },
                    { 13, 21 }
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
                    { 5, 5 },
                    { 6, 1 },
                    { 6, 3 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 6, 9 },
                    { 6, 10 },
                    { 7, 1 },
                    { 7, 3 },
                    { 7, 5 },
                    { 7, 6 },
                    { 7, 7 },
                    { 7, 9 },
                    { 7, 10 },
                    { 8, 8 },
                    { 9, 1 },
                    { 9, 5 },
                    { 9, 6 },
                    { 9, 7 },
                    { 9, 9 },
                    { 9, 10 },
                    { 10, 1 },
                    { 10, 5 },
                    { 10, 6 },
                    { 10, 7 },
                    { 10, 9 },
                    { 10, 10 },
                    { 11, 1 },
                    { 11, 5 },
                    { 11, 6 },
                    { 11, 7 },
                    { 11, 9 },
                    { 11, 10 },
                    { 12, 1 },
                    { 12, 6 },
                    { 12, 7 },
                    { 12, 9 },
                    { 12, 10 },
                    { 13, 11 }
                });

            migrationBuilder.InsertData(
                table: "GrappleCrane",
                columns: new[] { "CraneId", "GrappleId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 8 },
                    { 4, 14 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 8 },
                    { 5, 13 },
                    { 5, 14 },
                    { 6, 1 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 6, 8 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 6, 12 },
                    { 6, 13 },
                    { 6, 14 },
                    { 7, 1 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 7, 7 },
                    { 7, 8 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 11 },
                    { 7, 12 },
                    { 7, 13 },
                    { 7, 14 },
                    { 8, 1 },
                    { 8, 4 },
                    { 8, 5 },
                    { 8, 7 },
                    { 8, 8 },
                    { 8, 10 },
                    { 8, 11 },
                    { 9, 1 },
                    { 9, 5 },
                    { 9, 6 },
                    { 9, 7 },
                    { 9, 8 },
                    { 9, 9 },
                    { 9, 10 },
                    { 9, 11 },
                    { 9, 12 },
                    { 9, 14 },
                    { 10, 1 },
                    { 10, 5 },
                    { 10, 6 },
                    { 10, 7 },
                    { 10, 8 },
                    { 10, 9 },
                    { 10, 10 },
                    { 10, 11 },
                    { 10, 12 },
                    { 10, 14 },
                    { 11, 1 },
                    { 11, 5 },
                    { 11, 6 },
                    { 11, 7 },
                    { 11, 8 },
                    { 11, 9 },
                    { 11, 10 },
                    { 11, 11 },
                    { 11, 12 },
                    { 11, 14 },
                    { 12, 1 },
                    { 12, 5 },
                    { 12, 6 },
                    { 12, 7 },
                    { 12, 8 },
                    { 12, 9 },
                    { 12, 10 },
                    { 12, 11 },
                    { 12, 12 },
                    { 12, 14 },
                    { 13, 15 }
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
                    { 11, 1 },
                    { 11, 2 },
                    { 12, 2 }
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
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 6 },
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
                    { 6, 8 }
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
                    { 1, 1 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 3 },
                    { 4, 1 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 5, 1 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 4 },
                    { 7, 2 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 8, 2 },
                    { 8, 4 },
                    { 8, 5 },
                    { 8, 6 }
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
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
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
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 },
                    { 2, 17 },
                    { 2, 18 },
                    { 2, 19 },
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
                    { 3, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 3, 19 },
                    { 4, 20 },
                    { 4, 21 },
                    { 5, 20 },
                    { 5, 21 }
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
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
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
                    { 2, 14 },
                    { 2, 17 },
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
                    { 3, 15 },
                    { 3, 17 },
                    { 3, 18 },
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
                    { 4, 13 },
                    { 4, 14 },
                    { 4, 15 },
                    { 4, 16 },
                    { 4, 17 },
                    { 4, 18 },
                    { 4, 19 },
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
                    { 5, 13 },
                    { 5, 14 },
                    { 5, 15 },
                    { 5, 16 },
                    { 5, 17 },
                    { 5, 18 },
                    { 5, 19 },
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
                    { 6, 13 },
                    { 6, 14 },
                    { 6, 15 },
                    { 6, 16 },
                    { 6, 17 },
                    { 6, 18 },
                    { 6, 19 },
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
                    { 7, 13 },
                    { 7, 14 },
                    { 7, 15 },
                    { 7, 16 },
                    { 7, 17 },
                    { 7, 18 },
                    { 7, 19 },
                    { 8, 21 }
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
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
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
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 3, 19 },
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
                    { 5, 12 },
                    { 5, 13 },
                    { 5, 14 },
                    { 5, 15 },
                    { 5, 16 },
                    { 5, 17 },
                    { 5, 18 },
                    { 5, 19 },
                    { 6, 12 },
                    { 6, 13 },
                    { 6, 14 },
                    { 6, 15 },
                    { 6, 16 },
                    { 6, 17 },
                    { 6, 18 },
                    { 6, 19 },
                    { 7, 21 }
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
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
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
                    { 3, 13 },
                    { 3, 15 },
                    { 3, 18 },
                    { 4, 4 },
                    { 4, 7 },
                    { 4, 9 },
                    { 4, 11 },
                    { 4, 13 },
                    { 4, 15 },
                    { 4, 18 },
                    { 5, 6 },
                    { 5, 8 },
                    { 5, 10 },
                    { 6, 6 },
                    { 6, 8 },
                    { 6, 10 },
                    { 7, 16 },
                    { 7, 19 },
                    { 8, 16 },
                    { 8, 19 },
                    { 9, 22 }
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
                    { 5, 4 },
                    { 6, 1 },
                    { 6, 3 },
                    { 6, 5 },
                    { 7, 1 },
                    { 7, 3 },
                    { 7, 5 },
                    { 8, 1 },
                    { 8, 3 },
                    { 8, 5 },
                    { 9, 1 },
                    { 9, 3 },
                    { 9, 5 },
                    { 10, 1 },
                    { 10, 3 },
                    { 10, 5 },
                    { 11, 1 },
                    { 11, 3 },
                    { 11, 5 },
                    { 12, 1 },
                    { 12, 3 },
                    { 12, 5 }
                });

            migrationBuilder.InsertData(
                table: "RotatorCrane",
                columns: new[] { "CraneId", "RotatorId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 6, 1 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 7, 1 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 8, 1 },
                    { 8, 4 },
                    { 8, 5 },
                    { 8, 6 },
                    { 9, 1 },
                    { 9, 5 },
                    { 9, 6 },
                    { 9, 7 },
                    { 10, 1 },
                    { 10, 5 },
                    { 10, 6 },
                    { 10, 7 },
                    { 11, 1 },
                    { 11, 5 },
                    { 11, 6 },
                    { 11, 7 },
                    { 12, 1 },
                    { 12, 6 },
                    { 12, 7 },
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
                    { 42, 11 },
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
                    { 106, 19 },
                    { 107, 20 },
                    { 108, 20 },
                    { 109, 20 },
                    { 110, 20 },
                    { 115, 21 },
                    { 116, 21 },
                    { 117, 21 },
                    { 118, 21 },
                    { 123, 22 },
                    { 124, 22 },
                    { 125, 22 }
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
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 },
                    { 2, 17 },
                    { 2, 18 },
                    { 2, 19 },
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
                    { 3, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 3, 19 }
                });

            migrationBuilder.InsertData(
                table: "TrailerCraneConfigurations",
                columns: new[] { "Id", "CraneId", "SelectedFrameTypeId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 1, 2, 1 },
                    { 3, 2, 1, 1 },
                    { 4, 2, 2, 1 },
                    { 5, 3, 1, 1 },
                    { 6, 3, 2, 1 },
                    { 7, 1, 1, 2 },
                    { 8, 1, 2, 2 },
                    { 9, 2, 1, 2 },
                    { 10, 2, 2, 2 },
                    { 11, 3, 1, 2 },
                    { 12, 3, 2, 2 },
                    { 13, 4, 1, 2 },
                    { 14, 4, 3, 2 },
                    { 15, 4, 4, 2 }
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
                    { 3, 7 },
                    { 4, 4 },
                    { 4, 6 },
                    { 4, 8 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 5 },
                    { 5, 7 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 5 },
                    { 6, 7 },
                    { 7, 4 },
                    { 7, 6 },
                    { 7, 8 },
                    { 8, 6 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 9, 6 },
                    { 9, 8 },
                    { 9, 9 },
                    { 9, 10 },
                    { 10, 6 },
                    { 10, 8 },
                    { 10, 9 },
                    { 10, 12 },
                    { 11, 6 },
                    { 11, 8 },
                    { 11, 9 },
                    { 11, 10 },
                    { 11, 11 },
                    { 11, 12 },
                    { 12, 3 },
                    { 12, 5 },
                    { 12, 7 },
                    { 13, 6 },
                    { 13, 8 },
                    { 13, 9 },
                    { 13, 10 },
                    { 14, 6 },
                    { 14, 8 },
                    { 14, 9 },
                    { 14, 10 },
                    { 14, 11 },
                    { 14, 12 },
                    { 15, 6 },
                    { 15, 8 },
                    { 15, 9 },
                    { 15, 10 },
                    { 15, 11 },
                    { 15, 12 },
                    { 16, 8 },
                    { 16, 9 },
                    { 16, 10 },
                    { 16, 11 },
                    { 16, 12 },
                    { 17, 8 },
                    { 17, 9 },
                    { 17, 10 },
                    { 17, 11 },
                    { 17, 12 },
                    { 18, 8 },
                    { 18, 9 },
                    { 18, 10 },
                    { 18, 11 },
                    { 18, 12 },
                    { 19, 8 },
                    { 19, 9 },
                    { 19, 10 },
                    { 19, 11 },
                    { 19, 12 },
                    { 20, 13 },
                    { 20, 14 },
                    { 21, 13 },
                    { 21, 14 },
                    { 22, 15 }
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

            migrationBuilder.CreateIndex(
                name: "IX_BrakeTrailer_TrailerId",
                table: "BrakeTrailer",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlBlockCrane_CraneId",
                table: "ControlBlockCrane",
                column: "CraneId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlBlockFrameType_ControlBlockId",
                table: "ControlBlockFrameType",
                column: "ControlBlockId");

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
                name: "IX_CraneControlBlocks_ControlBlockId",
                table: "CraneControlBlocks",
                column: "ControlBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_CraneControlBlocks_CraneId",
                table: "CraneControlBlocks",
                column: "CraneId");

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
                name: "IX_HoseGuardCrane_HoseGuardId",
                table: "HoseGuardCrane",
                column: "HoseGuardId");

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
                name: "IX_Trailer_HydroPackId",
                table: "Trailer",
                column: "HydroPackId");

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
                name: "IX_TrailerCraneConfigurations_CraneId",
                table: "TrailerCraneConfigurations",
                column: "CraneId");

            migrationBuilder.CreateIndex(
                name: "IX_TrailerCraneConfigurations_SelectedFrameTypeId",
                table: "TrailerCraneConfigurations",
                column: "SelectedFrameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TrailerCraneConfigurations_TrailerId",
                table: "TrailerCraneConfigurations",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrailerFrameTypeConfiguration_FrameTypeId",
                table: "TrailerFrameTypeConfiguration",
                column: "FrameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TrailerFrameTypeConfiguration_TrailerId",
                table: "TrailerFrameTypeConfiguration",
                column: "TrailerId");

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
                name: "ControlBlockFrameType");

            migrationBuilder.DropTable(
                name: "CraneControlBlocks");

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
                name: "HoseGuardCrane");

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
                name: "SupportLegTrailer");

            migrationBuilder.DropTable(
                name: "TrailerCraneConfigurations");

            migrationBuilder.DropTable(
                name: "TrailerFrameTypeConfiguration");

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
                name: "Grapple");

            migrationBuilder.DropTable(
                name: "HoseGuard");

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
                name: "SupportLeg");

            migrationBuilder.DropTable(
                name: "FrameType");

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
                name: "FrameExtension");

            migrationBuilder.DropTable(
                name: "HandBrake");

            migrationBuilder.DropTable(
                name: "HayBaleFrame");

            migrationBuilder.DropTable(
                name: "HydroPack");

            migrationBuilder.DropTable(
                name: "MOT");

            migrationBuilder.DropTable(
                name: "StanchionExtension");

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
