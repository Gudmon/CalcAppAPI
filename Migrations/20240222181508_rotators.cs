using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class rotators : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrutLiftingTorque190Bar", "CraneWeight", "LiftAtFourMeters190Bar", "LiftAtFullReach190Bar", "MaxReach", "Name" },
                values: new object[] { "33", "410", "580", "350", "6.1", "PALMS 3.61" });

            migrationBuilder.InsertData(
                table: "Rotator",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "R0", "Rotátor nélkül", "0" },
                    { 2, "R30", "30 kN-os rotátor (csapos)", "300" },
                    { 3, "R31", "30 kN-os rotátor FL (talpas)", "430" },
                    { 4, "R45", "45 kN-os rotátor FL", "620" },
                    { 5, "R55", "55 kN-os rotátor FL", "915" },
                    { 6, "R60", "60 kN-os rotátor FL Indexator GV6", "1600" },
                    { 7, "R90", "100 kN-os rotátor FL Indexator T10", "1880" }
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
                    { 5, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RotatorCrane_RotatorId",
                table: "RotatorCrane",
                column: "RotatorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RotatorCrane");

            migrationBuilder.DropTable(
                name: "Rotator");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrutLiftingTorque190Bar", "CraneWeight", "LiftAtFourMeters190Bar", "LiftAtFullReach190Bar", "MaxReach", "Name" },
                values: new object[] { "36", "415", "355", "-", "6.3", "PALMS 3.63" });
        }
    }
}
