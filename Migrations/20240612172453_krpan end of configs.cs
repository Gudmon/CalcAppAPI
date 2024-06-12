using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpanendofconfigs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KrpanExtensionId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanFuelTankHolderId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanGrappleLocationId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanHydraulicSupportLegId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanPlatoId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanToolBoxId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "KrpanExtension",
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
                    table.PrimaryKey("PK_KrpanExtension", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanFuelTankHolder",
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
                    table.PrimaryKey("PK_KrpanFuelTankHolder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanGrappleLocation",
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
                    table.PrimaryKey("PK_KrpanGrappleLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanHydraulicSupportLeg",
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
                    table.PrimaryKey("PK_KrpanHydraulicSupportLeg", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanPlato",
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
                    table.PrimaryKey("PK_KrpanPlato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanToolBox",
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
                    table.PrimaryKey("PK_KrpanToolBox", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "KrpanExtension",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "300015365", "Hosszabbítás (GP15D pótkocsihoz 1,8 m)", "675" });

            migrationBuilder.InsertData(
                table: "KrpanFuelTankHolder",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "300007925", "Üzemanyagtartály tartó", "40" });

            migrationBuilder.InsertData(
                table: "KrpanGrappleLocation",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Kanál lerakási helyének megerősítése", "180" });

            migrationBuilder.InsertData(
                table: "KrpanHydraulicSupportLeg",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "300013635", "Hidraulikus támasztóláb GP pótkocsihoz (Z darunál kötelező)", "530" });

            migrationBuilder.InsertData(
                table: "KrpanPlato",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "300015209", "Plató (GP 15 D pótkocsihoz)", "6185" });

            migrationBuilder.InsertData(
                table: "KrpanToolBox",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "300015651", "Szerszámos láda", "145" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KrpanExtensionId", "KrpanFuelTankHolderId", "KrpanGrappleLocationId", "KrpanHydraulicSupportLegId", "KrpanPlatoId", "KrpanToolBoxId" },
                values: new object[] { null, 1, 1, null, null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KrpanExtensionId", "KrpanFuelTankHolderId", "KrpanGrappleLocationId", "KrpanHydraulicSupportLegId", "KrpanPlatoId", "KrpanToolBoxId" },
                values: new object[] { null, 1, 1, null, null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "KrpanExtensionId", "KrpanFuelTankHolderId", "KrpanGrappleLocationId", "KrpanHydraulicSupportLegId", "KrpanPlatoId", "KrpanToolBoxId" },
                values: new object[] { null, 1, 1, null, null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "KrpanExtensionId", "KrpanFuelTankHolderId", "KrpanGrappleLocationId", "KrpanHydraulicSupportLegId", "KrpanPlatoId", "KrpanToolBoxId" },
                values: new object[] { null, 1, 1, null, null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "KrpanExtensionId", "KrpanFuelTankHolderId", "KrpanGrappleLocationId", "KrpanHydraulicSupportLegId", "KrpanPlatoId", "KrpanToolBoxId" },
                values: new object[] { null, 1, 1, null, null, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "KrpanExtensionId", "KrpanFuelTankHolderId", "KrpanGrappleLocationId", "KrpanHydraulicSupportLegId", "KrpanPlatoId", "KrpanToolBoxId" },
                values: new object[] { null, null, 1, null, null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "KrpanExtensionId", "KrpanFuelTankHolderId", "KrpanGrappleLocationId", "KrpanHydraulicSupportLegId", "KrpanPlatoId", "KrpanToolBoxId" },
                values: new object[] { null, null, 1, null, null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "KrpanExtensionId", "KrpanFuelTankHolderId", "KrpanGrappleLocationId", "KrpanHydraulicSupportLegId", "KrpanPlatoId", "KrpanToolBoxId" },
                values: new object[] { 1, null, 1, null, 1, null });

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanExtensionId",
                table: "KrpanTrailer",
                column: "KrpanExtensionId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanFuelTankHolderId",
                table: "KrpanTrailer",
                column: "KrpanFuelTankHolderId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanGrappleLocationId",
                table: "KrpanTrailer",
                column: "KrpanGrappleLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanHydraulicSupportLegId",
                table: "KrpanTrailer",
                column: "KrpanHydraulicSupportLegId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanPlatoId",
                table: "KrpanTrailer",
                column: "KrpanPlatoId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanToolBoxId",
                table: "KrpanTrailer",
                column: "KrpanToolBoxId");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanExtension_KrpanExtensionId",
                table: "KrpanTrailer",
                column: "KrpanExtensionId",
                principalTable: "KrpanExtension",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanFuelTankHolder_KrpanFuelTankHolderId",
                table: "KrpanTrailer",
                column: "KrpanFuelTankHolderId",
                principalTable: "KrpanFuelTankHolder",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanGrappleLocation_KrpanGrappleLocationId",
                table: "KrpanTrailer",
                column: "KrpanGrappleLocationId",
                principalTable: "KrpanGrappleLocation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanHydraulicSupportLeg_KrpanHydraulicSupportLegId",
                table: "KrpanTrailer",
                column: "KrpanHydraulicSupportLegId",
                principalTable: "KrpanHydraulicSupportLeg",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanPlato_KrpanPlatoId",
                table: "KrpanTrailer",
                column: "KrpanPlatoId",
                principalTable: "KrpanPlato",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanToolBox_KrpanToolBoxId",
                table: "KrpanTrailer",
                column: "KrpanToolBoxId",
                principalTable: "KrpanToolBox",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanExtension_KrpanExtensionId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanFuelTankHolder_KrpanFuelTankHolderId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanGrappleLocation_KrpanGrappleLocationId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanHydraulicSupportLeg_KrpanHydraulicSupportLegId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanPlato_KrpanPlatoId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanToolBox_KrpanToolBoxId",
                table: "KrpanTrailer");

            migrationBuilder.DropTable(
                name: "KrpanExtension");

            migrationBuilder.DropTable(
                name: "KrpanFuelTankHolder");

            migrationBuilder.DropTable(
                name: "KrpanGrappleLocation");

            migrationBuilder.DropTable(
                name: "KrpanHydraulicSupportLeg");

            migrationBuilder.DropTable(
                name: "KrpanPlato");

            migrationBuilder.DropTable(
                name: "KrpanToolBox");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanExtensionId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanFuelTankHolderId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanGrappleLocationId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanHydraulicSupportLegId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanPlatoId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanToolBoxId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanExtensionId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanFuelTankHolderId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanGrappleLocationId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanHydraulicSupportLegId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanPlatoId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanToolBoxId",
                table: "KrpanTrailer");
        }
    }
}
