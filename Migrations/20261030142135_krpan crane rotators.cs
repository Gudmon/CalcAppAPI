using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpancranerotators : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KrpanCraneRotator",
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
                    table.PrimaryKey("PK_KrpanCraneRotator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanCraneRotators",
                columns: table => new
                {
                    KrpanCraneRotatorsId = table.Column<int>(type: "int", nullable: false),
                    KrpanCranesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanCraneRotators", x => new { x.KrpanCraneRotatorsId, x.KrpanCranesId });
                    table.ForeignKey(
                        name: "FK_KrpanCraneRotators_KrpanCraneRotator_KrpanCraneRotatorsId",
                        column: x => x.KrpanCraneRotatorsId,
                        principalTable: "KrpanCraneRotator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KrpanCraneRotators_KrpanCrane_KrpanCranesId",
                        column: x => x.KrpanCranesId,
                        principalTable: "KrpanCrane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "KrpanCraneRotator",
                columns: new[] { "Id", "Code", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", "", "Rotátor 30 kN", "0" },
                    { 2, "", "", "Rotátor 45 kN + karima", "231,66" },
                    { 3, "", "", "Rotátor 45 kN SF integrált karimával", "215,00" },
                    { 4, "", "", "Rotátor 55 kN + karima", "566,66" },
                    { 5, "", "", "Rotátor 55 kN integrált karimával", "626,67" },
                    { 6, "", "", "Rotátor 45 kN", "0" },
                    { 7, "", "", "Rotátor45 kN SF integrált karimával", "-16,00" },
                    { 8, "", "", "Rotátor 55 kN + karima", "335,00" },
                    { 9, "", "", "Rotátor 55 kN integrált karimával", "395,01" },
                    { 10, "", "", "Indexator GV45 +", "746,05" },
                    { 11, "", "", "Indexator GV6 lengéscsillapítóval", "1592,97" }
                });

            migrationBuilder.InsertData(
                table: "KrpanCraneRotators",
                columns: new[] { "KrpanCraneRotatorsId", "KrpanCranesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 2, 1 },
                    { 2, 3 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 3, 1 },
                    { 3, 3 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 3, 12 },
                    { 4, 9 },
                    { 4, 10 },
                    { 4, 11 },
                    { 4, 12 },
                    { 5, 9 },
                    { 5, 10 },
                    { 5, 11 },
                    { 5, 12 },
                    { 6, 2 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 7, 2 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 8, 2 },
                    { 8, 4 },
                    { 8, 5 },
                    { 8, 6 },
                    { 9, 2 },
                    { 9, 4 },
                    { 9, 5 },
                    { 9, 6 },
                    { 10, 4 },
                    { 11, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_KrpanCraneRotators_KrpanCranesId",
                table: "KrpanCraneRotators",
                column: "KrpanCranesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KrpanCraneRotators");

            migrationBuilder.DropTable(
                name: "KrpanCraneRotator");
        }
    }
}
