using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class krpanpropulsionsfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "KrpanPropulsionTrailer",
                keyColumns: new[] { "KrpanPropulsionId", "KrpanTrailerId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "KrpanAdjustableDrive",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Proporcionális hajtássebesség-állítás", "2187,50" });

            migrationBuilder.UpdateData(
                table: "KrpanPropulsion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "2WD belső dobos hajtás (2WD BB4)", "9681,67" });

            migrationBuilder.UpdateData(
                table: "KrpanPropulsion",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "2WD belső dobos hajtás (2WD BB5)", "12111,67" });

            migrationBuilder.UpdateData(
                table: "KrpanPropulsion",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Dupla belső dobos hajtás (4WD BB4)", "19363,34" });

            migrationBuilder.UpdateData(
                table: "KrpanPropulsion",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Dupla belső dobos hajtás (4WD BB5)", "24223,34" });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "KrpanAdjustableDriveId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "KrpanAdjustableDriveId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "KrpanAdjustableDriveId",
                value: null);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "KrpanAdjustableDriveId",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KrpanAdjustableDrive",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Proporcionálisan állítható meghajtás (BB5 esetén kötelező)", "2235" });

            migrationBuilder.UpdateData(
                table: "KrpanPropulsion",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "2 WD (BB4, 400/60-15,5 vagy 500/50-17 gumimérethez)", "9875" });

            migrationBuilder.UpdateData(
                table: "KrpanPropulsion",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "2 WD (BB5, 550/45-22,5 vagy 400/55-22,5 gumimérethez)", "12355" });

            migrationBuilder.UpdateData(
                table: "KrpanPropulsion",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "4 WD (BB4, 400/60-15,5 vagy 500/50-17 gumimérethez)", "21210" });

            migrationBuilder.UpdateData(
                table: "KrpanPropulsion",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price" },
                values: new object[] { "4 WD (BB5, 550/45-22,5 vagy 400/55-22,5 gumimérethez)", "26165" });

            migrationBuilder.InsertData(
                table: "KrpanPropulsionTrailer",
                columns: new[] { "KrpanPropulsionId", "KrpanTrailerId" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "KrpanAdjustableDriveId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "KrpanAdjustableDriveId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "KrpanAdjustableDriveId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KrpanTrailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "KrpanAdjustableDriveId",
                value: 1);
        }
    }
}
