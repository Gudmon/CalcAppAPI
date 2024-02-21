using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class frametypetocranes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FrameTypeCrane",
                columns: new[] { "CraneId", "FrameTypeId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 1 },
                    { 3, 2 },
                    { 4, 1 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 5, 1 },
                    { 5, 3 },
                    { 5, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 5, 5 });
        }
    }
}
