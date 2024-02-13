using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class tyres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tyre",
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
                    table.PrimaryKey("PK_Tyre", x => x.Id);
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
                table: "Tyre",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "WH2.6e", "400/60-15,5 standard felni, 6 lyukas, Starco", "1250" },
                    { 2, "WH2.6", "400/60-15,5 RF-felni, 6 lyukas, Starco", "1450" },
                    { 3, "WH4.6", "480/45-17 RF-felni, 6 lyukas, Starco", "2310" },
                    { 4, "WH4.8", "480/45-17 RF-felni, 8 lyukas, Starco", "kérésre" },
                    { 5, "WH3.6", "500/50-17 RF-felni, 6 lyukas, BKT", "kérésre" },
                    { 6, "WH3.6", "500/50-17 RF-felni, 6 lyukas, BKT", "2500" },
                    { 7, "WH3.8", "500/50-17 RF-felni, 8 lyukas, BKT", "2500" },
                    { 8, "WH5.6", "400/55-22,5 RF-felni, 6 lyukas, Alliance", "kérésre" },
                    { 9, "WH5.6", "400/55-22,5 RF-felni, 6 lyukas, Alliance", "3215" },
                    { 10, "WH8.8", "500/55-22,5 RF-felni, 8 lyukas, BKT", "3770" },
                    { 11, "WH6.8", "550/45-22,5 RF-felni, 8 lyukas, BKT", "4010" },
                    { 12, "WH6.8V", "550/45-22,5 RF-felni, 8 lyukas, BKT - traktor mintás", "4410" },
                    { 13, "WH9.8V", "600/40-22,5 RF-felni, 8 lyukas, BKT - traktor mintás", "6425" },
                    { 14, "WH7.8", "600/50-22,5 RF-felni, 8 lyukas, Alliance", "5410" }
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
                name: "IX_TyreTrailer_TyreId",
                table: "TyreTrailer",
                column: "TyreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TyreTrailer");

            migrationBuilder.DropTable(
                name: "Tyre");
        }
    }
}
