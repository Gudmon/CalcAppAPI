using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrailerCrane_Crane_CraneId",
                table: "TrailerCrane");

            migrationBuilder.DropForeignKey(
                name: "FK_TrailerCrane_Trailer_TrailerId",
                table: "TrailerCrane");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrailerCrane",
                table: "TrailerCrane");

            migrationBuilder.RenameTable(
                name: "TrailerCrane",
                newName: "CraneTrailer");

            migrationBuilder.RenameIndex(
                name: "IX_TrailerCrane_TrailerId",
                table: "CraneTrailer",
                newName: "IX_CraneTrailer_TrailerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CraneTrailer",
                table: "CraneTrailer",
                columns: new[] { "CraneId", "TrailerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CraneTrailer_Crane_CraneId",
                table: "CraneTrailer",
                column: "CraneId",
                principalTable: "Crane",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CraneTrailer_Trailer_TrailerId",
                table: "CraneTrailer",
                column: "TrailerId",
                principalTable: "Trailer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CraneTrailer_Crane_CraneId",
                table: "CraneTrailer");

            migrationBuilder.DropForeignKey(
                name: "FK_CraneTrailer_Trailer_TrailerId",
                table: "CraneTrailer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CraneTrailer",
                table: "CraneTrailer");

            migrationBuilder.RenameTable(
                name: "CraneTrailer",
                newName: "TrailerCrane");

            migrationBuilder.RenameIndex(
                name: "IX_CraneTrailer_TrailerId",
                table: "TrailerCrane",
                newName: "IX_TrailerCrane_TrailerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrailerCrane",
                table: "TrailerCrane",
                columns: new[] { "CraneId", "TrailerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TrailerCrane_Crane_CraneId",
                table: "TrailerCrane",
                column: "CraneId",
                principalTable: "Crane",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrailerCrane_Trailer_TrailerId",
                table: "TrailerCrane",
                column: "TrailerId",
                principalTable: "Trailer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
