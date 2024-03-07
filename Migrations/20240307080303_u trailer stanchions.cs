using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class utrailerstanchions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stanchion",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 43, "A3", "Pótkocsi 3 pár rakoncával", "10495" },
                    { 44, "A3F", "Pótkocsi 3 pár forwader típusú rakoncával", "10495" },
                    { 45, "A4", "Pótkocsi 4 pár rakoncával", "11125" },
                    { 46, "A4F", "Pótkocsi 4 pár forwader típusú rakoncával", "11125" },
                    { 47, "A4Ex", "Pótkocsi raktér hosszabbítással és 4 pár rakoncával", "11850" },
                    { 48, "A4FEx", "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "11850" },
                    { 49, "A5Ex", "Pótkocsi raktér hosszabbítással és 5 pár rakoncával", "12480" },
                    { 50, "A5FEx", "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "12480" },
                    { 51, "A3", "Pótkocsi 3 pár rakoncával", "23260" },
                    { 52, "A3F", "Pótkocsi 3 pár forwader típusú rakoncával", "23260" },
                    { 53, "A4", "Pótkocsi 4 pár rakoncával", "23890" },
                    { 54, "A4F", "Pótkocsi 4 pár forwader típusú rakoncával", "23890" },
                    { 55, "A4Ex", "Pótkocsi raktér hosszabbítással és 4 pár rakoncával", "24615" },
                    { 56, "A4FEx", "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "24615" },
                    { 57, "A5Ex", "Pótkocsi raktér hosszabbítással és 5 pár rakoncával", "25245" },
                    { 58, "A5FEx", "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "25245" },
                    { 59, "A3", "Pótkocsi 3 pár rakoncával", "12580" },
                    { 60, "A3F", "Pótkocsi 3 pár forwader típusú rakoncával", "12580" },
                    { 61, "A4", "Pótkocsi 4 pár rakoncával", "13295" },
                    { 62, "A4F", "Pótkocsi 4 pár forwader típusú rakoncával", "13295" },
                    { 63, "A4Ex", "Pótkocsi raktér hosszabbítással és 4 pár rakoncával", "14020" },
                    { 64, "A4FEx", "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "14020" },
                    { 65, "A5Ex", "Pótkocsi raktér hosszabbítással és 5 pár rakoncával", "14735" },
                    { 66, "A5FEx", "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "14735" },
                    { 67, "A3", "Pótkocsi 3 pár rakoncával", "24665" },
                    { 68, "A3F", "Pótkocsi 3 pár forwader típusú rakoncával", "24665" },
                    { 69, "A4", "Pótkocsi 4 pár rakoncával", "25380" },
                    { 70, "A4F", "Pótkocsi 4 pár forwader típusú rakoncával", "25380" },
                    { 71, "A4Ex", "Pótkocsi raktér hosszabbítással és 4 pár rakoncával", "26105" },
                    { 72, "A4FEx", "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "26105" },
                    { 73, "A5Ex", "Pótkocsi raktér hosszabbítással és 5 pár rakoncával", "26820" },
                    { 74, "A5FEx", "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "26820" },
                    { 75, "A3", "Pótkocsi 3 pár rakoncával", "37980" },
                    { 76, "A3F", "Pótkocsi 3 pár forwader típusú rakoncával", "37980" },
                    { 77, "A4", "Pótkocsi 4 pár rakoncával", "38695" },
                    { 78, "A4F", "Pótkocsi 4 pár forwader típusú rakoncával", "38695" },
                    { 79, "A4Ex", "Pótkocsi raktér hosszabbítással és 4 pár rakoncával", "39420" },
                    { 80, "A4FEx", "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "39420" },
                    { 81, "A5Ex", "Pótkocsi raktér hosszabbítással és 5 pár rakoncával", "40135" },
                    { 82, "A5FEx", "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "40135" },
                    { 83, "A3", "Pótkocsi 3 pár rakoncával", "14595" },
                    { 84, "A3F", "Pótkocsi 3 pár forwader típusú rakoncával", "14595" },
                    { 85, "A4", "Pótkocsi 4 pár rakoncával", "15515" },
                    { 86, "A4F", "Pótkocsi 4 pár forwader típusú rakoncával", "15515" },
                    { 87, "A4Ex", "Pótkocsi raktér hosszabbítással és 4 pár rakoncával", "16240" },
                    { 88, "A4FEx", "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "16240" },
                    { 89, "A5Ex", "Pótkocsi raktér hosszabbítással és 5 pár rakoncával", "17160" },
                    { 90, "A5FEx", "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "17160" },
                    { 91, "A3", "Pótkocsi 3 pár rakoncával", "26680" },
                    { 92, "A3F", "Pótkocsi 3 pár forwader típusú rakoncával", "26680" },
                    { 93, "A4", "Pótkocsi 4 pár rakoncával", "27600" },
                    { 94, "A4F", "Pótkocsi 4 pár forwader típusú rakoncával", "27600" },
                    { 95, "A4Ex", "Pótkocsi raktér hosszabbítással és 4 pár rakoncával", "28325" },
                    { 96, "A4FEx", "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "28325" },
                    { 97, "A5Ex", "Pótkocsi raktér hosszabbítással és 5 pár rakoncával", "29245" },
                    { 98, "A5FEx", "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "29245" },
                    { 99, "A3", "Pótkocsi 3 pár rakoncával", "39995" },
                    { 100, "A3F", "Pótkocsi 3 pár forwader típusú rakoncával", "39995" },
                    { 101, "A4", "Pótkocsi 4 pár rakoncával", "40915" },
                    { 102, "A4F", "Pótkocsi 4 pár forwader típusú rakoncával", "40915" },
                    { 103, "A4Ex", "Pótkocsi raktér hosszabbítással és 4 pár rakoncával", "41640" },
                    { 104, "A4FEx", "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "41640" },
                    { 105, "A5Ex", "Pótkocsi raktér hosszabbítással és 5 pár rakoncával", "42560" },
                    { 106, "A5FEx", "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "42560" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 106);
        }
    }
}
