using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class cranelight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LightTrailer_Light_LightId",
                table: "LightTrailer");

            migrationBuilder.DropTable(
                name: "Light");

            migrationBuilder.AddColumn<int>(
                name: "LightId",
                table: "Crane",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CraneLight",
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
                    table.PrimaryKey("PK_CraneLight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrailerLight",
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
                    table.PrimaryKey("PK_TrailerLight", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 1,
                column: "LightId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 2,
                column: "LightId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                column: "LightId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 4,
                column: "LightId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 5,
                column: "LightId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 6,
                column: "LightId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 7,
                column: "LightId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 8,
                column: "LightId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 9,
                column: "LightId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 10,
                column: "LightId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 11,
                column: "LightId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 12,
                column: "LightId",
                value: null);

            migrationBuilder.InsertData(
                table: "CraneLight",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "L1", "LED munkalámpák a darugémre, 2 db", "510" });

            migrationBuilder.InsertData(
                table: "TrailerLight",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "L1", "Összecsukható hátsó lámpák", "420" },
                    { 2, "L2", "Hátsó LED lámpa flexibilis Kilpi karokkal", "465" },
                    { 3, "L4", "Fix hátsó LED lámpák", "420" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Crane_LightId",
                table: "Crane",
                column: "LightId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crane_CraneLight_LightId",
                table: "Crane",
                column: "LightId",
                principalTable: "CraneLight",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LightTrailer_TrailerLight_LightId",
                table: "LightTrailer",
                column: "LightId",
                principalTable: "TrailerLight",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crane_CraneLight_LightId",
                table: "Crane");

            migrationBuilder.DropForeignKey(
                name: "FK_LightTrailer_TrailerLight_LightId",
                table: "LightTrailer");

            migrationBuilder.DropTable(
                name: "CraneLight");

            migrationBuilder.DropTable(
                name: "TrailerLight");

            migrationBuilder.DropIndex(
                name: "IX_Crane_LightId",
                table: "Crane");

            migrationBuilder.DropColumn(
                name: "LightId",
                table: "Crane");

            migrationBuilder.CreateTable(
                name: "Light",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Light", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Light",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "L1", "Összecsukható hátsó lámpák", "420" },
                    { 2, "L2", "Hátsó LED lámpa flexibilis Kilpi karokkal", "465" },
                    { 3, "L4", "Fix hátsó LED lámpák", "420" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_LightTrailer_Light_LightId",
                table: "LightTrailer",
                column: "LightId",
                principalTable: "Light",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
