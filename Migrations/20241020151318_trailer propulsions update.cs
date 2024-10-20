using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class trailerpropulsionsupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 4, 15 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 7, 19 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 8, 16 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 8, 19 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 9, 22 });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "24WDF", "2WD hajtás (BB240 az első tengelyen elektronikus vezérléssel, fékhez előkészítve", "12885" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "24WDRe", "2WD hajtás (BB240 az hátsó tengelyen elektronikus vezérléssel, fékhez előkészítve", "11130" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "Description", "Name", "Price" },
                values: new object[] { "25WDF", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.", "2WD agyhajtás (BB250 az első tengelyen elektronikus vezérléssel, fékhez előkészítve)", "15375" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "Description", "Name", "Price" },
                values: new object[] { "25WDR", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.", "2WD agyhajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, fékhez előkészítve)", "15375" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "Description", "Name", "Price" },
                values: new object[] { "25WDFe", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.", "2WD hajtás (BB250 az első tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)", "13880" });

            migrationBuilder.InsertData(
                table: "Propulsion",
                columns: new[] { "Id", "Code", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 10, "25WDRe", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.", "2WD hajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)", "13880" },
                    { 11, "45WDB.1", "", "4WD BlackBruin hajtás elektronikus vezérléssel ISOBUS-hoz", "0" },
                    { 12, "25WDF", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.", "2WD agyhajtás (BB250 az első tengelyen elektronikus vezérléssel, fékhez előkészítve)", "14805" },
                    { 13, "25WDR", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.", "2WD agyhajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, fékhez előkészítve)", "14805" },
                    { 14, "25WDFe", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.", "2WD hajtás (BB250 az első tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)", "12810" },
                    { 15, "25WDRe", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.", "2WD hajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)", "12810" },
                    { 16, "25WDF", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.", "2WD agyhajtás (BB250 az első tengelyen elektronikus vezérléssel, fékhez előkészítve)", "14450" },
                    { 17, "25WDR", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.", "2WD agyhajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, fékhez előkészítve)", "14450" },
                    { 18, "25WDFe", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal az első tengelyen.", "2WD hajtás (BB250 az első tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)", "12455" },
                    { 19, "25WDRe", "2 kerék hajtásrendszer Black Bruin hidraulikus motorokkal a hátsó tengelyen.", "2WD hajtás (BB250 a hátsó tengelyen elektronikus vezérléssel, nincs fék ezen a tengelyen)", "12455" },
                    { 20, "45WDB", "", "4WD BlackBruin hajtás elektronikus vezérléssel", "0" },
                    { 21, "45WDB.1", "", "4WD BlackBruin hajtás elektronikus vezérléssel ISOBUS-hoz", "1135" },
                    { 22, "RWD", "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további pótkocsi-hajtásra van szükségük. A rendszer működtetése a traktor hidraulikájáról történik. Előnyei az RWD+ rendszerhez képest a jobb manőverezhetőség és a műszaki egyszerűség.", "Robson WD dörzshajtás (traktor hidarulikáról)", "2040" }
                });

            migrationBuilder.InsertData(
                table: "PropulsionTrailer",
                columns: new[] { "PropulsionId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 2, 4 },
                    { 3, 3 },
                    { 3, 5 },
                    { 4, 3 },
                    { 4, 5 },
                    { 5, 5 },
                    { 5, 7 },
                    { 6, 5 },
                    { 6, 7 },
                    { 7, 5 },
                    { 7, 8 },
                    { 8, 5 },
                    { 8, 8 },
                    { 9, 5 },
                    { 9, 8 },
                    { 10, 5 },
                    { 10, 8 },
                    { 12, 6 },
                    { 12, 7 },
                    { 13, 6 },
                    { 13, 7 },
                    { 14, 6 },
                    { 14, 7 },
                    { 15, 6 },
                    { 15, 7 },
                    { 16, 9 },
                    { 16, 11 },
                    { 17, 9 },
                    { 17, 11 },
                    { 18, 9 },
                    { 18, 11 },
                    { 19, 9 },
                    { 19, 11 },
                    { 20, 10 },
                    { 20, 12 },
                    { 21, 10 },
                    { 21, 12 },
                    { 22, 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 16, 9 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 16, 11 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 17, 9 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 17, 11 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 18, 9 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 18, 11 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 19, 9 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 19, 11 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 20, 10 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 20, 12 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 21, 10 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 21, 12 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 22, 15 });

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "25WDF", "2WD agyhajtás (BB 250 az első tengelyen elektronikus vezérléssel)", "0" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "Name", "Price" },
                values: new object[] { "25WDR", "2WD agyhajtás (BB 250 a hátsó tengelyen elektronikus vezérléssel)", "0" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "Description", "Name", "Price" },
                values: new object[] { "45WDB", "", "4WD BlackBruin elektronikus teljesítmény szabályozással", "0" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "Description", "Name", "Price" },
                values: new object[] { "45WDB.1", "", "4WD BlackBruin elektronikus teljesítmény szabályozással, ISOBUS-hoz előkészítve", "1135" });

            migrationBuilder.UpdateData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Code", "Description", "Name", "Price" },
                values: new object[] { "RWD", "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további pótkocsi-hajtásra van szükségük. A rendszer működtetése a traktor hidraulikájáról történik. Előnyei az RWD+ rendszerhez képest a jobb manőverezhetőség és a műszaki egyszerűség.", "Robson WD dörzshajtás (traktor hidarulikáról)", "2040" });

            migrationBuilder.InsertData(
                table: "PropulsionTrailer",
                columns: new[] { "PropulsionId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 2, 5 },
                    { 3, 7 },
                    { 3, 9 },
                    { 3, 11 },
                    { 3, 13 },
                    { 3, 15 },
                    { 3, 18 },
                    { 4, 7 },
                    { 4, 9 },
                    { 4, 11 },
                    { 4, 13 },
                    { 4, 15 },
                    { 4, 18 },
                    { 5, 8 },
                    { 5, 10 },
                    { 6, 8 },
                    { 6, 10 },
                    { 7, 16 },
                    { 7, 19 },
                    { 8, 16 },
                    { 8, 19 },
                    { 9, 22 }
                });
        }
    }
}
