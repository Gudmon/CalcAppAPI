using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpantrailerchainsawfueltanktoolboxconfigs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KrpanChainsawHolder",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Láncfűrész tartó");

            migrationBuilder.UpdateData(
                table: "KrpanChainsawHolder",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Láncfűrész tartó", "40,00" });

            migrationBuilder.UpdateData(
                table: "KrpanFuelTankHolder",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "Name" },
                values: new object[] { "300020894", "Üzemanyag kanna tartó" });

            migrationBuilder.UpdateData(
                table: "KrpanFuelTankHolder",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "300020894", "Üzemanyag kanna tartó", "36,67" });

            migrationBuilder.UpdateData(
                table: "KrpanToolBox",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "300015652");

            migrationBuilder.UpdateData(
                table: "KrpanToolBox",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "Price" },
                values: new object[] { "300015652", "142,50" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "KrpanChainsawHolderId", "KrpanFuelTankHolderId", "KrpanToolBoxId" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "KrpanChainsawHolderId", "KrpanFuelTankHolderId", "KrpanToolBoxId" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "KrpanChainsawHolderId", "KrpanFuelTankHolderId", "KrpanToolBoxId" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "KrpanChainsawHolderId", "KrpanFuelTankHolderId", "KrpanToolBoxId" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "KrpanChainsawHolderId", "KrpanFuelTankHolderId", "KrpanToolBoxId" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "KrpanChainsawHolderId", "KrpanFuelTankHolderId", "KrpanToolBoxId" },
                values: new object[] { 2, 2, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KrpanChainsawHolder",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Motorfűrész tartó");

            migrationBuilder.UpdateData(
                table: "KrpanChainsawHolder",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Motorfűrész tartó", "45" });

            migrationBuilder.UpdateData(
                table: "KrpanFuelTankHolder",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "Name" },
                values: new object[] { "300007925", "Üzemanyagtartály tartó" });

            migrationBuilder.UpdateData(
                table: "KrpanFuelTankHolder",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "300007925", "Üzemanyagtartály tartó", "40" });

            migrationBuilder.UpdateData(
                table: "KrpanToolBox",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "300015651");

            migrationBuilder.UpdateData(
                table: "KrpanToolBox",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "Price" },
                values: new object[] { "300015651", "145" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "KrpanChainsawHolderId", "KrpanFuelTankHolderId", "KrpanToolBoxId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "KrpanChainsawHolderId", "KrpanFuelTankHolderId", "KrpanToolBoxId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "KrpanChainsawHolderId", "KrpanFuelTankHolderId", "KrpanToolBoxId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "KrpanChainsawHolderId", "KrpanFuelTankHolderId", "KrpanToolBoxId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "KrpanChainsawHolderId", "KrpanFuelTankHolderId", "KrpanToolBoxId" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "KrpanChainsawHolderId", "KrpanFuelTankHolderId", "KrpanToolBoxId" },
                values: new object[] { null, null, null });
        }
    }
}
