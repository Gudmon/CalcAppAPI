using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class trailertyreandbrake : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 6, 6 });

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
                table: "KrpanCraneTrailer",
                columns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 1, 6 },
                    { 3, 6 },
                    { 4, 4 },
                    { 5, 4 },
                    { 6, 4 }
                });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LoadCapacity", "LoadingLength", "LoadingLengthWithExtension", "Name", "Price", "TotalLength", "TotalLengthWithExtension", "TotalWidth", "Weight" },
                values: new object[] { "12000", "3975", "4755", "GP 12 DF", "13060", "6209", "7100", "2122", "2100" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CentralBeams", "LoadCapacity", "LoadingLength", "LoadingLengthWithExtension", "Name", "Price", "TotalLength", "TotalLengthWithExtension", "TotalWidth", "Weight" },
                values: new object[] { "2/200×100x8", "14000", "4325", "5105", "GP 14 DF", "14915", "6559", "7545", "2222", "2300" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CentralBeams", "LoadCapacity", "LoadingLength", "LoadingLengthWithExtension", "Name", "Price", "TotalLength", "TotalLengthWithExtension", "TotalWidth", "Weight" },
                values: new object[] { "2/180×100x6", "11000", "3707", "4487", "GP 11 D", "13510", "5944", "6724", "2152", "1734" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CentralBeams", "LoadCapacity", "LoadingLength", "LoadingLengthWithExtension", "Name", "Price", "TotalLength", "TotalLengthWithExtension", "TotalWidth", "Weight" },
                values: new object[] { "2/200×100x6", "13000", "3975", "4755", "GP 13 D", "15310", "6334", "7144", "2200", "2144" });

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

            migrationBuilder.CreateIndex(
                name: "IX_KrpanBrakeTrailer_KrpanTrailerId",
                table: "KrpanBrakeTrailer",
                column: "KrpanTrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTyreTrailer_KrpanTyreId",
                table: "KrpanTyreTrailer",
                column: "KrpanTyreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KrpanBrakeTrailer");

            migrationBuilder.DropTable(
                name: "KrpanTyreTrailer");

            migrationBuilder.DropTable(
                name: "KrpanBrake");

            migrationBuilder.DropTable(
                name: "KrpanTyre");

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "KrpanCraneTrailer",
                keyColumns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.InsertData(
                table: "KrpanCraneTrailer",
                columns: new[] { "KrpanCraneId", "KrpanTrailerId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 3, 4 },
                    { 4, 6 },
                    { 5, 6 },
                    { 6, 6 }
                });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LoadCapacity", "LoadingLength", "LoadingLengthWithExtension", "Name", "Price", "TotalLength", "TotalLengthWithExtension", "TotalWidth", "Weight" },
                values: new object[] { "11000", "3707", "4487", "GP 11 D", "13510", "5944", "6724", "2152", "1734" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CentralBeams", "LoadCapacity", "LoadingLength", "LoadingLengthWithExtension", "Name", "Price", "TotalLength", "TotalLengthWithExtension", "TotalWidth", "Weight" },
                values: new object[] { "2/180×100x6", "12000", "3975", "4755", "GP 12 DF", "13060", "6209", "7100", "2122", "2100" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CentralBeams", "LoadCapacity", "LoadingLength", "LoadingLengthWithExtension", "Name", "Price", "TotalLength", "TotalLengthWithExtension", "TotalWidth", "Weight" },
                values: new object[] { "2/200×100x6", "13000", "3975", "4755", "GP 13 D", "15310", "6334", "7144", "2200", "2144" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CentralBeams", "LoadCapacity", "LoadingLength", "LoadingLengthWithExtension", "Name", "Price", "TotalLength", "TotalLengthWithExtension", "TotalWidth", "Weight" },
                values: new object[] { "2/200×100x8", "14000", "4325", "5105", "GP 14 DF", "14915", "6559", "7545", "2222", "2300" });
        }
    }
}
