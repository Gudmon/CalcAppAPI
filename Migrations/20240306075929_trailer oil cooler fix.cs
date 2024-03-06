using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class traileroilcoolerfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OilTank_TrailerOilCooler_TrailerOilCoolerId",
                table: "OilTank");

            migrationBuilder.DropIndex(
                name: "IX_OilTank_TrailerOilCoolerId",
                table: "OilTank");

            migrationBuilder.DropColumn(
                name: "TrailerOilCoolerId",
                table: "OilTank");

            migrationBuilder.AddColumn<int>(
                name: "TrailerOilCoolerId",
                table: "Trailer",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "2WD agyhajtás (BB 250 az első tengelyen elektronikus vezérléssel)");

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "2WD agyhajtás (BB 250 a hátsó tengelyen elektronikus vezérléssel)");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "TrailerOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "TrailerOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "TrailerOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "TrailerOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "TrailerOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "TrailerOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "TrailerOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "TrailerOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9,
                column: "TrailerOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "TrailerOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "TrailerOilCoolerId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_TrailerOilCoolerId",
                table: "Trailer",
                column: "TrailerOilCoolerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trailer_TrailerOilCooler_TrailerOilCoolerId",
                table: "Trailer",
                column: "TrailerOilCoolerId",
                principalTable: "TrailerOilCooler",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trailer_TrailerOilCooler_TrailerOilCoolerId",
                table: "Trailer");

            migrationBuilder.DropIndex(
                name: "IX_Trailer_TrailerOilCoolerId",
                table: "Trailer");

            migrationBuilder.DropColumn(
                name: "TrailerOilCoolerId",
                table: "Trailer");

            migrationBuilder.AddColumn<int>(
                name: "TrailerOilCoolerId",
                table: "OilTank",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 1,
                column: "TrailerOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 2,
                column: "TrailerOilCoolerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 3,
                column: "TrailerOilCoolerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 4,
                column: "TrailerOilCoolerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "2WD agyhajtás (BB 250 az első tengelyen elektronikus vezérléssel");

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "2WD agyhajtás (BB 250 a hátsó tengelyen elektronikus vezérléssel");

            migrationBuilder.CreateIndex(
                name: "IX_OilTank_TrailerOilCoolerId",
                table: "OilTank",
                column: "TrailerOilCoolerId");

            migrationBuilder.AddForeignKey(
                name: "FK_OilTank_TrailerOilCooler_TrailerOilCoolerId",
                table: "OilTank",
                column: "TrailerOilCoolerId",
                principalTable: "TrailerOilCooler",
                principalColumn: "Id");
        }
    }
}
