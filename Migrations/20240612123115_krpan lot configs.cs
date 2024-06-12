using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpanlotconfigs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KrpanAxeHolderId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanBBoxId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanBaleTransportPlatformId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanCardanShaftId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanCargoSpaceExtensionId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanChainsawHolderId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanExtraForwarderStanchionId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanExtraStanchionId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanHandBrakeId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanTopConnectionId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "KrpanAxeHolder",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "300015366", "Csákány és fejsze tartó", "40" });

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
                table: "KrpanCardanShaft",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "200004712", "Kardántengely Walterscheid WWE 2480-SDF25-910 (egyik oldalon nagy hajlásszögű)", "540" });

            migrationBuilder.InsertData(
                table: "KrpanCargoSpaceExtension",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "300014961", "Raktér hosszabbítás (80 cm)", "490" });

            migrationBuilder.InsertData(
                table: "KrpanChainsawHolder",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "300015821", "Motorfűrész tartó", "45" });

            migrationBuilder.InsertData(
                table: "KrpanClutch",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "", "Alsó tengelykapcsoló", "0" },
                    { 2, "", "Felső tengelykapcsoló (a felső tengelykapcsoló és a kétkörös öntöttvas tandem szivattyú kombinációja nem lehetséges)", "145" }
                });

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
                table: "KrpanHandBrake",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Kézifék", "0" });

            migrationBuilder.InsertData(
                table: "KrpanTopConnection",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Felső csatlakozás", "145" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KrpanAxeHolderId", "KrpanBBoxId", "KrpanBaleTransportPlatformId", "KrpanCardanShaftId", "KrpanCargoSpaceExtensionId", "KrpanChainsawHolderId", "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId", "KrpanHandBrakeId", "KrpanTopConnectionId" },
                values: new object[] { 1, 1, 1, 1, 1, 1, null, 1, null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KrpanAxeHolderId", "KrpanBBoxId", "KrpanBaleTransportPlatformId", "KrpanCardanShaftId", "KrpanCargoSpaceExtensionId", "KrpanChainsawHolderId", "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId", "KrpanHandBrakeId", "KrpanTopConnectionId" },
                values: new object[] { 1, 1, 1, 1, 1, 1, null, 1, null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "KrpanAxeHolderId", "KrpanBBoxId", "KrpanBaleTransportPlatformId", "KrpanCardanShaftId", "KrpanCargoSpaceExtensionId", "KrpanChainsawHolderId", "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId", "KrpanHandBrakeId", "KrpanTopConnectionId" },
                values: new object[] { 1, 1, 1, 1, 1, 1, null, 1, null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "KrpanAxeHolderId", "KrpanBBoxId", "KrpanBaleTransportPlatformId", "KrpanCardanShaftId", "KrpanCargoSpaceExtensionId", "KrpanChainsawHolderId", "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId", "KrpanHandBrakeId", "KrpanTopConnectionId" },
                values: new object[] { 1, 1, 1, 1, 1, 1, null, 1, null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "KrpanAxeHolderId", "KrpanBBoxId", "KrpanBaleTransportPlatformId", "KrpanCardanShaftId", "KrpanCargoSpaceExtensionId", "KrpanChainsawHolderId", "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId", "KrpanHandBrakeId", "KrpanTopConnectionId" },
                values: new object[] { 1, 1, 1, 1, 1, 1, null, 1, null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "KrpanAxeHolderId", "KrpanBBoxId", "KrpanBaleTransportPlatformId", "KrpanCardanShaftId", "KrpanCargoSpaceExtensionId", "KrpanChainsawHolderId", "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId", "KrpanHandBrakeId", "KrpanTopConnectionId" },
                values: new object[] { null, 2, 2, 1, null, null, 1, 2, 1, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "KrpanAxeHolderId", "KrpanBBoxId", "KrpanBaleTransportPlatformId", "KrpanCardanShaftId", "KrpanCargoSpaceExtensionId", "KrpanChainsawHolderId", "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId", "KrpanHandBrakeId", "KrpanTopConnectionId" },
                values: new object[] { null, 3, 3, 1, null, null, 1, 2, 1, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "KrpanAxeHolderId", "KrpanBBoxId", "KrpanBaleTransportPlatformId", "KrpanCardanShaftId", "KrpanCargoSpaceExtensionId", "KrpanChainsawHolderId", "KrpanExtraForwarderStanchionId", "KrpanExtraStanchionId", "KrpanHandBrakeId", "KrpanTopConnectionId" },
                values: new object[] { null, 4, 4, 1, null, null, 1, 2, 1, null });

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
                name: "IX_KrpanTrailer_KrpanExtraForwarderStanchionId",
                table: "KrpanTrailer",
                column: "KrpanExtraForwarderStanchionId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanExtraStanchionId",
                table: "KrpanTrailer",
                column: "KrpanExtraStanchionId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanHandBrakeId",
                table: "KrpanTrailer",
                column: "KrpanHandBrakeId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanTopConnectionId",
                table: "KrpanTrailer",
                column: "KrpanTopConnectionId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanClutchTrailer_KrpanTrailerId",
                table: "KrpanClutchTrailer",
                column: "KrpanTrailerId");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanAxeHolder_KrpanAxeHolderId",
                table: "KrpanTrailer",
                column: "KrpanAxeHolderId",
                principalTable: "KrpanAxeHolder",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanBBox_KrpanBBoxId",
                table: "KrpanTrailer",
                column: "KrpanBBoxId",
                principalTable: "KrpanBBox",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanBaleTransportPlatform_KrpanBaleTransportPlatformId",
                table: "KrpanTrailer",
                column: "KrpanBaleTransportPlatformId",
                principalTable: "KrpanBaleTransportPlatform",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanCardanShaft_KrpanCardanShaftId",
                table: "KrpanTrailer",
                column: "KrpanCardanShaftId",
                principalTable: "KrpanCardanShaft",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanCargoSpaceExtension_KrpanCargoSpaceExtensionId",
                table: "KrpanTrailer",
                column: "KrpanCargoSpaceExtensionId",
                principalTable: "KrpanCargoSpaceExtension",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanChainsawHolder_KrpanChainsawHolderId",
                table: "KrpanTrailer",
                column: "KrpanChainsawHolderId",
                principalTable: "KrpanChainsawHolder",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanExtraForwarderStanchion_KrpanExtraForwarderStanchionId",
                table: "KrpanTrailer",
                column: "KrpanExtraForwarderStanchionId",
                principalTable: "KrpanExtraForwarderStanchion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanExtraStanchion_KrpanExtraStanchionId",
                table: "KrpanTrailer",
                column: "KrpanExtraStanchionId",
                principalTable: "KrpanExtraStanchion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanHandBrake_KrpanHandBrakeId",
                table: "KrpanTrailer",
                column: "KrpanHandBrakeId",
                principalTable: "KrpanHandBrake",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanTopConnection_KrpanTopConnectionId",
                table: "KrpanTrailer",
                column: "KrpanTopConnectionId",
                principalTable: "KrpanTopConnection",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanAxeHolder_KrpanAxeHolderId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanBBox_KrpanBBoxId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanBaleTransportPlatform_KrpanBaleTransportPlatformId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanCardanShaft_KrpanCardanShaftId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanCargoSpaceExtension_KrpanCargoSpaceExtensionId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanChainsawHolder_KrpanChainsawHolderId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanExtraForwarderStanchion_KrpanExtraForwarderStanchionId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanExtraStanchion_KrpanExtraStanchionId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanHandBrake_KrpanHandBrakeId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanTopConnection_KrpanTopConnectionId",
                table: "KrpanTrailer");

            migrationBuilder.DropTable(
                name: "KrpanAxeHolder");

            migrationBuilder.DropTable(
                name: "KrpanBaleTransportPlatform");

            migrationBuilder.DropTable(
                name: "KrpanBBox");

            migrationBuilder.DropTable(
                name: "KrpanCardanShaft");

            migrationBuilder.DropTable(
                name: "KrpanCargoSpaceExtension");

            migrationBuilder.DropTable(
                name: "KrpanChainsawHolder");

            migrationBuilder.DropTable(
                name: "KrpanClutchTrailer");

            migrationBuilder.DropTable(
                name: "KrpanExtraForwarderStanchion");

            migrationBuilder.DropTable(
                name: "KrpanExtraStanchion");

            migrationBuilder.DropTable(
                name: "KrpanHandBrake");

            migrationBuilder.DropTable(
                name: "KrpanTopConnection");

            migrationBuilder.DropTable(
                name: "KrpanClutch");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanAxeHolderId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanBaleTransportPlatformId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanBBoxId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanCardanShaftId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanCargoSpaceExtensionId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanChainsawHolderId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanExtraForwarderStanchionId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanExtraStanchionId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanHandBrakeId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanTopConnectionId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanAxeHolderId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanBBoxId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanBaleTransportPlatformId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanCardanShaftId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanCargoSpaceExtensionId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanChainsawHolderId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanExtraForwarderStanchionId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanExtraStanchionId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanHandBrakeId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanTopConnectionId",
                table: "KrpanTrailer");
        }
    }
}
