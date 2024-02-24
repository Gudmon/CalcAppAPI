using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class craneswframetypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "FrameType");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrutLiftingTorque190Bar", "CraneWeight", "LiftAtFourMeters190Bar", "LiftAtFullReach190Bar", "MaxReach", "Name" },
                values: new object[] { "36", "415", "655", "355", "6.3", "PALMS 3.63" });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Különösen erős talp daru billentéssel, vezérléssel, talpaló lábak nélkül (csak A21-A42 vezértömbhöz)");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "B11", "Különösen erős talp daru billentéssel, vezérléssel, talpaló lábakkal (csak A21-A42 vezértömbhöz)", "7300" });

            migrationBuilder.InsertData(
                table: "FrameTypeCrane",
                columns: new[] { "CraneId", "FrameTypeId" },
                values: new object[,]
                {
                    { 6, 1 },
                    { 6, 3 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 6, 9 },
                    { 6, 10 },
                    { 7, 1 },
                    { 7, 3 },
                    { 7, 5 },
                    { 7, 6 },
                    { 7, 7 },
                    { 7, 9 },
                    { 7, 10 },
                    { 8, 8 },
                    { 9, 1 },
                    { 9, 5 },
                    { 9, 6 },
                    { 9, 7 },
                    { 9, 9 },
                    { 9, 10 },
                    { 10, 1 },
                    { 10, 5 },
                    { 10, 6 },
                    { 10, 7 },
                    { 10, 9 },
                    { 10, 10 },
                    { 11, 1 },
                    { 11, 5 },
                    { 11, 6 },
                    { 11, 7 },
                    { 11, 9 },
                    { 11, 10 },
                    { 12, 1 },
                    { 12, 6 },
                    { 12, 7 },
                    { 12, 9 },
                    { 12, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "FrameTypeCrane",
                keyColumns: new[] { "CraneId", "FrameTypeId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "FrameType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrutLiftingTorque190Bar", "CraneWeight", "LiftAtFourMeters190Bar", "LiftAtFullReach190Bar", "MaxReach", "Name" },
                values: new object[] { "33", "410", "580", "350", "6.1", "PALMS 3.61" });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Kisebb PALMS erdészeti darukhoz megfelelő típusú támasztólábak");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "A típusú támasztólábak közepes méretű PALMS darukhoz");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "FD típusú támasztólábak");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "FD típusú támasztólábak");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Nagy teherbírású talp támasztólábak nélkül");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "FD nagy teherbírású (HD) típusú támaszlábak");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "FD típusú támasztólábak PALMS 5.87Z daruhoz");

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "HD alap daru dönthető vezérléssel, támasztólábak nélkül", "Különösen erős talp daru billentéssel, vezérléssel, talpaló lábak nélkül" });

            migrationBuilder.UpdateData(
                table: "FrameType",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Code", "Description", "Name", "Price" },
                values: new object[] { "B011", "HD alap daru dönthető vezérléssel, támasztólábak nélkül", "Különösen erős talp daru billentéssel, talpaló lábakkal, vezérlésse", "4830" });
        }
    }
}
