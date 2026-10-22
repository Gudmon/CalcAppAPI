using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpantrailerremovedrawheadandtopconnection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanDrawHead_KrpanDrawHeadId",
                table: "KrpanTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanTopConnection_KrpanTopConnectionId",
                table: "KrpanTrailer");

            migrationBuilder.DropTable(
                name: "KrpanDrawHead");

            migrationBuilder.DropTable(
                name: "KrpanTopConnection");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanDrawHeadId",
                table: "KrpanTrailer");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanTopConnectionId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanDrawHeadId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanTopConnectionId",
                table: "KrpanTrailer");

            migrationBuilder.UpdateData(
                table: "KrpanAxeHolder",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: "36,67");

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 9,
                column: "KrpanAxeHolderId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "KrpanAxeHolderId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "KrpanAxeHolderId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 12,
                column: "KrpanAxeHolderId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 13,
                column: "KrpanAxeHolderId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "KrpanAxeHolderId", "KrpanCardanShaftId" },
                values: new object[] { 2, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KrpanDrawHeadId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KrpanTopConnectionId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "KrpanDrawHead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanDrawHead", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KrpanTopConnection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KrpanTopConnection", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "KrpanAxeHolder",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: "40");

            migrationBuilder.InsertData(
                table: "KrpanDrawHead",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "300012588", "Vonófej K80", "340" },
                    { 2, "300012588", "Vonófej K80", "415" }
                });

            migrationBuilder.InsertData(
                table: "KrpanTopConnection",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Felső csatlakozás", "145" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KrpanDrawHeadId", "KrpanTopConnectionId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KrpanDrawHeadId", "KrpanTopConnectionId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "KrpanDrawHeadId", "KrpanTopConnectionId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "KrpanDrawHeadId", "KrpanTopConnectionId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "KrpanDrawHeadId", "KrpanTopConnectionId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "KrpanDrawHeadId", "KrpanTopConnectionId" },
                values: new object[] { 2, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "KrpanDrawHeadId", "KrpanTopConnectionId" },
                values: new object[] { 2, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "KrpanDrawHeadId", "KrpanTopConnectionId" },
                values: new object[] { 2, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "KrpanAxeHolderId", "KrpanDrawHeadId", "KrpanTopConnectionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "KrpanAxeHolderId", "KrpanDrawHeadId", "KrpanTopConnectionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "KrpanAxeHolderId", "KrpanDrawHeadId", "KrpanTopConnectionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "KrpanAxeHolderId", "KrpanDrawHeadId", "KrpanTopConnectionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "KrpanAxeHolderId", "KrpanDrawHeadId", "KrpanTopConnectionId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "KrpanAxeHolderId", "KrpanCardanShaftId", "KrpanDrawHeadId", "KrpanTopConnectionId" },
                values: new object[] { null, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanDrawHeadId",
                table: "KrpanTrailer",
                column: "KrpanDrawHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanTopConnectionId",
                table: "KrpanTrailer",
                column: "KrpanTopConnectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanDrawHead_KrpanDrawHeadId",
                table: "KrpanTrailer",
                column: "KrpanDrawHeadId",
                principalTable: "KrpanDrawHead",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanTopConnection_KrpanTopConnectionId",
                table: "KrpanTrailer",
                column: "KrpanTopConnectionId",
                principalTable: "KrpanTopConnection",
                principalColumn: "Id");
        }
    }
}
