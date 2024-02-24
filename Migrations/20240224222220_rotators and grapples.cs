using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class rotatorsandgrapples : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Grapple",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 8, "C36", "Biomasszás kanál 0,21 Palms (FL)", "2230" },
                    { 9, "C7.1", "Biomasszás kanál 0,25 Grippen (FL)", "3345" },
                    { 10, "C7.2", "Biomasszás kanál 0,23 Palms (FL)", "3020" },
                    { 11, "C11", "Biomasszás kanál 0,25 Palms (FL)", "3450" },
                    { 12, "C10", "Palms 0,28-as kanál (FL)", "3125" },
                    { 13, "C175", "Palms vágó kanál a Nisula-tól", "6500" },
                    { 14, "GB3", "Aprítékos kiegészítő C3-hoz", "910" }
                });

            migrationBuilder.InsertData(
                table: "GrappleCrane",
                columns: new[] { "CraneId", "GrappleId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 6, 1 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 7, 1 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 7, 7 },
                    { 8, 1 },
                    { 8, 4 },
                    { 8, 5 },
                    { 8, 7 },
                    { 9, 1 },
                    { 9, 5 },
                    { 9, 6 },
                    { 9, 7 },
                    { 10, 1 },
                    { 10, 5 },
                    { 10, 6 },
                    { 10, 7 },
                    { 11, 1 },
                    { 11, 5 },
                    { 11, 6 },
                    { 11, 7 },
                    { 12, 1 },
                    { 12, 5 },
                    { 12, 6 },
                    { 12, 7 }
                });

            migrationBuilder.InsertData(
                table: "RotatorCrane",
                columns: new[] { "CraneId", "RotatorId" },
                values: new object[,]
                {
                    { 6, 1 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 7, 1 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 8, 1 },
                    { 8, 4 },
                    { 8, 5 },
                    { 8, 6 },
                    { 9, 1 },
                    { 9, 5 },
                    { 9, 6 },
                    { 9, 7 },
                    { 10, 1 },
                    { 10, 5 },
                    { 10, 6 },
                    { 10, 7 },
                    { 11, 1 },
                    { 11, 5 },
                    { 11, 6 },
                    { 11, 7 },
                    { 12, 1 },
                    { 12, 6 },
                    { 12, 7 }
                });

            migrationBuilder.InsertData(
                table: "GrappleCrane",
                columns: new[] { "CraneId", "GrappleId" },
                values: new object[,]
                {
                    { 4, 8 },
                    { 4, 14 },
                    { 5, 8 },
                    { 5, 13 },
                    { 5, 14 },
                    { 6, 8 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 6, 12 },
                    { 6, 13 },
                    { 6, 14 },
                    { 7, 8 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 11 },
                    { 7, 12 },
                    { 7, 13 },
                    { 7, 14 },
                    { 8, 8 },
                    { 8, 10 },
                    { 8, 11 },
                    { 9, 8 },
                    { 9, 9 },
                    { 9, 10 },
                    { 9, 11 },
                    { 9, 12 },
                    { 9, 14 },
                    { 10, 8 },
                    { 10, 9 },
                    { 10, 10 },
                    { 10, 11 },
                    { 10, 12 },
                    { 10, 14 },
                    { 11, 8 },
                    { 11, 9 },
                    { 11, 10 },
                    { 11, 11 },
                    { 11, 12 },
                    { 11, 14 },
                    { 12, 8 },
                    { 12, 9 },
                    { 12, 10 },
                    { 12, 11 },
                    { 12, 12 },
                    { 12, 14 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 7, 11 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 7, 14 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 9, 11 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 9, 14 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 10, 14 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 11, 12 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 11, 14 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "GrappleCrane",
                keyColumns: new[] { "CraneId", "GrappleId" },
                keyValues: new object[] { 12, 14 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "RotatorCrane",
                keyColumns: new[] { "CraneId", "RotatorId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Grapple",
                keyColumn: "Id",
                keyValue: 14);
        }
    }
}
