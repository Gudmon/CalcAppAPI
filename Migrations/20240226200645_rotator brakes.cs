using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class rotatorbrakes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RotatorBrake",
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
                    table.PrimaryKey("PK_RotatorBrake", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "RotatorBrake",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Br0", "Rotátorfék  nélkül", "0" },
                    { 2, "Br1", "Rotátor fék", "75" },
                    { 3, "Br1", "Rotátor fék", "55" },
                    { 4, "Br2", "Dupla rotátor fék", "115" },
                    { 5, "Br2", "Dupla rotátor fék", "220" }
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

            migrationBuilder.CreateIndex(
                name: "IX_RotatorBrakeCrane_RotatorBrakeId",
                table: "RotatorBrakeCrane",
                column: "RotatorBrakeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RotatorBrakeCrane");

            migrationBuilder.DropTable(
                name: "RotatorBrake");
        }
    }
}
