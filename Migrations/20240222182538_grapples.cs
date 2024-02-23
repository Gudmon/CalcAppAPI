using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class grapples : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grapple",
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
                    table.PrimaryKey("PK_Grapple", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "Grapple",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "C0", "Rönkfogó kanál nélkül", "0" },
                    { 2, "C01", "Kanál 0,16 Palms (csapos rotátorhoz)", "1105" },
                    { 3, "C02", "Kanál 0,16 Palms (FL)", "1085" },
                    { 4, "C1", "Kanál 0,18 Palms (FL)", "1395" },
                    { 5, "C3", "Kanál 0,23 Palms (FL)", "1745" },
                    { 6, "C5.1", "Kanál 0,25 Grippen (FL)", "3015" },
                    { 7, "C5.2", "Kanál 0,26 Palms (FL)", "3090" }
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
                    { 3, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GrappleCrane_GrappleId",
                table: "GrappleCrane",
                column: "GrappleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrappleCrane");

            migrationBuilder.DropTable(
                name: "Grapple");
        }
    }
}
