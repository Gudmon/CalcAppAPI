using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class removeoldtrailercraneconfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrailerCraneConfigurations");

            migrationBuilder.DropTable(
                name: "TrailerFrameTypeConfiguration");

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 12, 16 });

            migrationBuilder.InsertData(
                table: "CraneTrailer",
                columns: new[] { "CraneId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 16 },
                    { 2, 16 },
                    { 3, 16 },
                    { 4, 16 },
                    { 5, 16 }
                });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "A PALMS 11UX az önhordó váz szerkezeti előnyeit – mint például a fokozott szilárdság, a kiváló terepjáró képességek és az egyszerű karbantartás – kínálja, a D-szériás pótkocsik árkategóriájában. Ezenkívül számos új fejlesztést is tartalmaz, beleértve a teljesen védett, vázba integrált opcionális légtartályt; az újonnan tervezett, könnyen kihúzható, forwarder-típusú szélesítést, valamint az új vonórudat.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.CreateTable(
                name: "TrailerCraneConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CraneId = table.Column<int>(type: "int", nullable: false),
                    SelectedFrameTypeId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false)
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
                    FrameTypeId = table.Column<int>(type: "int", nullable: false),
                    TrailerId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.InsertData(
                table: "CraneTrailer",
                columns: new[] { "CraneId", "TrailerId" },
                values: new object[,]
                {
                    { 9, 16 },
                    { 10, 16 },
                    { 11, 16 },
                    { 12, 16 }
                });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "A PALMS 11UX az önhordó váz szerkezeti előnyeit – mint például a fokozott szilárdság, a kiváló terepjáró képességek és az egyszerű karbantartás – kínálja, a D-szériás pótkocsik árkategóriájában. Ezenkívül számos új fejlesztést is tartalmaz, beleértve a teljesen védett, vázba integrált opcionális légtartályt; az újonnan tervezett, könnyen kihúzható, szállítógép-típusú szélesítést, valamint az új vonórudat.");

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
        }
    }
}
