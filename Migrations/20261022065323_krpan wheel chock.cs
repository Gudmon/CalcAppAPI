using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpanwheelchock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KrpanWheelChockId",
                table: "KrpanTrailer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "KrpanWheelChock",
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
                    table.PrimaryKey("PK_KrpanWheelChock", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "KrpanWheelChockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "KrpanWheelChockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "KrpanWheelChockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "KrpanWheelChockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "KrpanWheelChockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "KrpanWheelChockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "KrpanWheelChockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "KrpanWheelChockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 9,
                column: "KrpanWheelChockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "KrpanWheelChockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "KrpanWheelChockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 12,
                column: "KrpanWheelChockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 13,
                column: "KrpanWheelChockId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 14,
                column: "KrpanWheelChockId",
                value: 1);

            migrationBuilder.InsertData(
                table: "KrpanWheelChock",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Kerékékek", "0" });

            migrationBuilder.CreateIndex(
                name: "IX_KrpanTrailer_KrpanWheelChockId",
                table: "KrpanTrailer",
                column: "KrpanWheelChockId");

            migrationBuilder.AddForeignKey(
                name: "FK_KrpanTrailer_KrpanWheelChock_KrpanWheelChockId",
                table: "KrpanTrailer",
                column: "KrpanWheelChockId",
                principalTable: "KrpanWheelChock",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KrpanTrailer_KrpanWheelChock_KrpanWheelChockId",
                table: "KrpanTrailer");

            migrationBuilder.DropTable(
                name: "KrpanWheelChock");

            migrationBuilder.DropIndex(
                name: "IX_KrpanTrailer_KrpanWheelChockId",
                table: "KrpanTrailer");

            migrationBuilder.DropColumn(
                name: "KrpanWheelChockId",
                table: "KrpanTrailer");
        }
    }
}
