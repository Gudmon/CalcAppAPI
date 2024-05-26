using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class connectkrpantrailerwcrane : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CentralBeams",
                table: "KrpanTrailer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DrawbarAngle",
                table: "KrpanTrailer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FrameSteeringCylinders",
                table: "KrpanTrailer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LoadCapacity",
                table: "KrpanTrailer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LoadingLength",
                table: "KrpanTrailer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TotalLength",
                table: "KrpanTrailer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "KrpanTrailer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.InsertData(
                table: "KrpanCrane",
                columns: new[] { "Id", "BrutLiftingTorque", "Description", "LiftCapacityAtFourMeters", "LiftCapacityAtMaxReach", "MaxReach", "Name", "NetLiftingTorque", "OilQuantityInTank", "Price", "SlewCylinders", "SlewTorque", "SlewingAngle", "SystemPressure", "TelescopicStages", "Weight" },
                values: new object[] { 1, "50", "", "1020", "600", "6,6 / 7,2", "Krpan GP 11 D", "40", "70", "13510", "4", "16", "375", "220", "1", "900" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CentralBeams", "DrawbarAngle", "FrameSteeringCylinders", "LoadCapacity", "LoadingLength", "Price", "TotalLength", "Weight" },
                values: new object[] { "2/180×100x6", "40", "2", "11000", "3707 / (4487)", "13510", "5944 (6724)/ 2152", "1734" });

            migrationBuilder.InsertData(
                table: "KrpanCraneTrailer",
                columns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_KrpanCraneTrailer_KrpanTrailerId",
                table: "KrpanCraneTrailer",
                column: "KrpanTrailerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KrpanCraneTrailer");

            migrationBuilder.DropTable(
                name: "KrpanCrane");

            migrationBuilder.DropColumn(
                name: "CentralBeams",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "DrawbarAngle",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "FrameSteeringCylinders",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "LoadCapacity",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "LoadingLength",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "TotalLength",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "KrpanTrailer");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: "");
        }
    }
}
