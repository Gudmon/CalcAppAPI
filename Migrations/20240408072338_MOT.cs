using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class MOT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MOTId",
                table: "Trailer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MOT",
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
                    table.PrimaryKey("PK_MOT", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MOT",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "", "Műszaki vizsga", "500" });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 12,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 13,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 14,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 15,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 16,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 17,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 18,
                column: "MOTId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 19,
                column: "MOTId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_MOTId",
                table: "Trailer",
                column: "MOTId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trailer_MOT_MOTId",
                table: "Trailer",
                column: "MOTId",
                principalTable: "MOT",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trailer_MOT_MOTId",
                table: "Trailer");

            migrationBuilder.DropTable(
                name: "MOT");

            migrationBuilder.DropIndex(
                name: "IX_Trailer_MOTId",
                table: "Trailer");

            migrationBuilder.DropColumn(
                name: "MOTId",
                table: "Trailer");
        }
    }
}
