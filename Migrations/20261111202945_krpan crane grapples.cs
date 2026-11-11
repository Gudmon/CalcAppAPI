using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpancranegrapples : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KrpanGrapple",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanGrapple", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanGrapplesCrane",
                columns: table => new
                {
                    KrpanCranesId = table.Column<int>(type: "int", nullable: false),
                    KrpanGrapplesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanGrapplesCrane", x => new { x.KrpanCranesId, x.KrpanGrapplesId });
                    table.ForeignKey(
                        name: "FK_KrpanGrapplesCrane_KrpanCrane_KrpanCranesId",
                        column: x => x.KrpanCranesId,
                        principalTable: "KrpanCrane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KrpanGrapplesCrane_KrpanGrapple_KrpanGrapplesId",
                        column: x => x.KrpanGrapplesId,
                        principalTable: "KrpanGrapple",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LiftCapacityAtMaxReach", "MaxReach", "NetLiftingTorque", "SlewTorque", "SlewingAngle", "SystemPressure", "Weight" },
                values: new object[] { "540", "5.6", "37", "10", "200", "190", "525" });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "LiftCapacityAtMaxReach", "MaxReach", "NetLiftingTorque", "SlewTorque", "SlewingAngle", "SystemPressure", "Weight" },
                values: new object[] { "485", "6.2", "37", "10", "200", "190", "540" });

            migrationBuilder.InsertData(
                table: "KrpanGrapple",
                columns: new[] { "Id", "Code", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", "", "GR 120 karimával", "0" },
                    { 2, "", "", "GR 130", "215,83" },
                    { 3, "", "", "GR 150", "403,33" },
                    { 4, "", "", "GR 23", "980,00" },
                    { 5, "", "", "GR 27", "1.275,83" },
                    { 6, "", "", "GR 27 BIO", "2.003,33" },
                    { 7, "", "", "GR 130", "0" }
                });

            migrationBuilder.InsertData(
                table: "KrpanGrapplesCrane",
                columns: new[] { "KrpanCranesId", "KrpanGrapplesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 3, 1 },
                    { 3, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 },
                    { 6, 3 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 7, 1 },
                    { 7, 2 },
                    { 8, 1 },
                    { 8, 2 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 3 },
                    { 9, 4 },
                    { 9, 5 },
                    { 9, 6 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 3 },
                    { 10, 4 },
                    { 10, 5 },
                    { 10, 6 },
                    { 11, 1 },
                    { 11, 2 },
                    { 11, 3 },
                    { 11, 4 },
                    { 11, 5 },
                    { 11, 6 },
                    { 12, 1 },
                    { 12, 2 },
                    { 12, 3 },
                    { 12, 4 },
                    { 12, 5 },
                    { 12, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KrpanGrapplesCrane_KrpanGrapplesId",
                table: "KrpanGrapplesCrane",
                column: "KrpanGrapplesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KrpanGrapplesCrane");

            migrationBuilder.DropTable(
                name: "KrpanGrapple");

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LiftCapacityAtMaxReach", "MaxReach", "NetLiftingTorque", "SlewTorque", "SlewingAngle", "SystemPressure", "Weight" },
                values: new object[] { "", "", "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "KrpanCrane",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "LiftCapacityAtMaxReach", "MaxReach", "NetLiftingTorque", "SlewTorque", "SlewingAngle", "SystemPressure", "Weight" },
                values: new object[] { "", "", "", "", "", "", "" });
        }
    }
}
