using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class connectvehicles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.InsertData(
                table: "Brake",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 8, "BA-EU", "Légfék", "3125" },
                    { 9, "BH-EU", "Hidraulikus fék", "4295" },
                    { 10, "B1", "2 keréken hidraulikus fék", "1255" },
                    { 11, "B2", "4 keréken hidraulikus fék", "4545" },
                    { 12, "B3", "2 keréken légfék", "1915" },
                    { 13, "B4", "4 keréken légfék", "5385" },
                    { 14, "BA-EU", "Légfék", "5605" },
                    { 15, "BH-EU", "Hidraulikus fék", "6770" },
                    { 16, "B2", "4 keréken hidraulikus fék", "2415" },
                    { 17, "B4", "4 keréken légfék", "3255" },
                    { 18, "BA-EU", "Légfék", "3740" },
                    { 19, "BH-EU", "Hidraulikus fék", "4905" }
                });

            migrationBuilder.InsertData(
                table: "BrakeTrailer",
                columns: new[] { "BrakeId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 2, 5 },
                    { 2, 6 },
                    { 3, 5 },
                    { 3, 6 },
                    { 4, 5 },
                    { 4, 6 },
                    { 5, 5 },
                    { 5, 6 },
                    { 6, 5 },
                    { 7, 5 }
                });

            migrationBuilder.InsertData(
                table: "DrawbarTrailer",
                columns: new[] { "DrawbarId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 8 },
                    { 4, 9 },
                    { 4, 10 },
                    { 4, 11 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 },
                    { 5, 8 },
                    { 5, 9 },
                    { 5, 10 },
                    { 5, 11 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 6, 8 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 8, 11 },
                    { 9, 4 },
                    { 9, 5 },
                    { 9, 6 },
                    { 9, 7 },
                    { 9, 8 },
                    { 9, 9 },
                    { 9, 10 },
                    { 9, 11 }
                });

            migrationBuilder.InsertData(
                table: "Propulsion",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 3, "25WDF", "2WD agyhajtás (BB 250 az első tengelyen elektronikus vezérléssel", "0" },
                    { 4, "25WDR", "2WD agyhajtás (BB 250 a hátsó tengelyen elektronikus vezérléssel", "0" },
                    { 5, "RWD", "Robson WD dörzshajtás (traktor hidarulikáról)", "4845" },
                    { 6, "RWD+", "Robson WD dörzshajtás elektronikus vezérlőrendszerrel", "7170" }
                });

            migrationBuilder.InsertData(
                table: "PropulsionTrailer",
                columns: new[] { "PropulsionId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 2, 5 }
                });

            migrationBuilder.InsertData(
                table: "Stanchion",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 11, "A3", "Pótkocsi 3 pár rakoncával", "20215" },
                    { 12, "A4", "Pótkocsi 4 pár rakoncával", "20580" },
                    { 13, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "21200" },
                    { 14, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "21570" },
                    { 15, "A3", "Pótkocsi 3 pár rakoncával", "8080" },
                    { 16, "A4", "Pótkocsi 4 pár rakoncával", "8540" },
                    { 17, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "8755" },
                    { 18, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "9210" },
                    { 19, "A3", "Pótkocsi 3 pár rakoncával", "8830" },
                    { 20, "A4", "Pótkocsi 4 pár rakoncával", "9240" },
                    { 21, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "9860" },
                    { 22, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "10270" },
                    { 23, "A3", "Pótkocsi 3 pár rakoncával", "21315" },
                    { 24, "A4", "Pótkocsi 4 pár rakoncával", "21725" },
                    { 25, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "22345" },
                    { 26, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "22755" },
                    { 27, "A3", "Pótkocsi 3 pár rakoncával", "10880" },
                    { 28, "A4", "Pótkocsi 4 pár rakoncával", "11290" },
                    { 29, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "11910" },
                    { 30, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "12320" },
                    { 31, "A3", "Pótkocsi 3 pár rakoncával", "22955" },
                    { 32, "A4", "Pótkocsi 4 pár rakoncával", "23365" },
                    { 33, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "23985" },
                    { 34, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "24395" },
                    { 35, "A3", "Pótkocsi 3 pár rakoncával", "12665" },
                    { 36, "A4", "Pótkocsi 4 pár rakoncával", "13160" },
                    { 37, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "13810" },
                    { 38, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "14305" },
                    { 39, "A3", "Pótkocsi 3 pár rakoncával", "24740" },
                    { 40, "A4", "Pótkocsi 4 pár rakoncával", "25235" },
                    { 41, "A4Ex", "Pótkocsi raktérhosszabbítással és 4 pár rakoncával", "25885" },
                    { 42, "A5Ex", "Pótkocsi raktérhosszabbítással és 5 pár rakoncával", "26380" }
                });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "BeamType",
                value: "Egy");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "BeamType",
                value: "Egy");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "BeamType",
                value: "Dupla");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "BeamType",
                value: "Dupla");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "BeamType",
                value: "Egy");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "BeamType",
                value: "Dupla");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "BeamType",
                value: "Dupla");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "BeamType",
                value: "Dupla");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9,
                column: "BeamType",
                value: "Dupla");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "BeamType",
                value: "Dupla");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "BeamType",
                value: "Dupla");

            migrationBuilder.InsertData(
                table: "BrakeTrailer",
                columns: new[] { "BrakeId", "TrailerId" },
                values: new object[,]
                {
                    { 8, 3 },
                    { 8, 6 },
                    { 9, 3 },
                    { 9, 6 },
                    { 10, 4 },
                    { 10, 7 },
                    { 10, 8 },
                    { 10, 9 },
                    { 10, 10 },
                    { 10, 11 },
                    { 11, 4 },
                    { 11, 7 },
                    { 11, 9 },
                    { 11, 11 },
                    { 12, 4 },
                    { 12, 7 },
                    { 12, 8 },
                    { 12, 9 },
                    { 12, 10 },
                    { 12, 11 },
                    { 13, 4 },
                    { 13, 7 },
                    { 13, 9 },
                    { 13, 11 },
                    { 14, 4 },
                    { 14, 7 },
                    { 14, 9 },
                    { 14, 11 },
                    { 15, 4 },
                    { 15, 7 },
                    { 15, 9 },
                    { 15, 11 },
                    { 16, 8 },
                    { 16, 10 },
                    { 17, 8 },
                    { 17, 10 },
                    { 18, 8 },
                    { 18, 10 },
                    { 19, 8 },
                    { 19, 10 }
                });

            migrationBuilder.InsertData(
                table: "PropulsionTrailer",
                columns: new[] { "PropulsionId", "TrailerId" },
                values: new object[,]
                {
                    { 3, 4 },
                    { 3, 7 },
                    { 3, 9 },
                    { 3, 11 },
                    { 4, 4 },
                    { 4, 7 },
                    { 4, 9 },
                    { 4, 11 },
                    { 5, 6 },
                    { 5, 8 },
                    { 5, 10 },
                    { 6, 6 },
                    { 6, 8 },
                    { 6, 10 }
                });

            migrationBuilder.InsertData(
                table: "StanchionTrailer",
                columns: new[] { "StanchionId", "TrailerId" },
                values: new object[,]
                {
                    { 11, 4 },
                    { 12, 4 },
                    { 13, 4 },
                    { 14, 4 },
                    { 15, 5 },
                    { 16, 5 },
                    { 17, 5 },
                    { 18, 5 },
                    { 19, 6 },
                    { 20, 6 },
                    { 21, 6 },
                    { 22, 6 },
                    { 23, 7 },
                    { 24, 7 },
                    { 25, 7 },
                    { 26, 7 },
                    { 27, 8 },
                    { 28, 8 },
                    { 29, 8 },
                    { 30, 8 },
                    { 31, 9 },
                    { 32, 9 },
                    { 33, 9 },
                    { 34, 9 },
                    { 35, 10 },
                    { 36, 10 },
                    { 37, 10 },
                    { 38, 10 },
                    { 39, 11 },
                    { 40, 11 },
                    { 41, 11 },
                    { 42, 11 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 13, 11 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 14, 11 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 15, 11 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 17, 8 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 17, 10 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 18, 8 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 18, 10 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 19, 8 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 19, 10 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 11 });

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
                keyValues: new object[] { 3, 4 });

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
                keyValues: new object[] { 4, 4 });

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
                keyValues: new object[] { 5, 6 });

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
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 19, 6 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 21, 6 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 22, 6 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 23, 7 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 24, 7 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 25, 7 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 26, 7 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 27, 8 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 28, 8 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 29, 8 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 30, 8 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 31, 9 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 32, 9 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 33, 9 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 34, 9 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 35, 10 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 36, 10 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 37, 10 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 38, 10 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 39, 11 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 40, 11 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 41, 11 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 42, 11 });

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.InsertData(
                table: "BrakeTrailer",
                columns: new[] { "BrakeId", "TrailerId" },
                values: new object[,]
                {
                    { 6, 3 },
                    { 7, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "BeamType",
                value: "Single");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "BeamType",
                value: "Single");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "BeamType",
                value: "Double");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "BeamType",
                value: "Double");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "BeamType",
                value: "Single");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "BeamType",
                value: "Double");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "BeamType",
                value: "Double");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "BeamType",
                value: "Double");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9,
                column: "BeamType",
                value: "Double");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "BeamType",
                value: "Double");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "BeamType",
                value: "Double");
        }
    }
}
