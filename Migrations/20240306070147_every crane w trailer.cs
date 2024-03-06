using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class everycranewtrailer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CraneTrailer",
                columns: new[] { "CraneId", "TrailerId" },
                values: new object[,]
                {
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 },
                    { 5, 8 },
                    { 5, 9 },
                    { 5, 10 },
                    { 5, 11 },
                    { 6, 3 },
                    { 6, 4 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 7 },
                    { 6, 8 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 7, 3 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 7, 7 },
                    { 7, 8 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 11 },
                    { 8, 3 },
                    { 8, 4 },
                    { 8, 6 },
                    { 8, 7 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 8, 11 },
                    { 9, 3 },
                    { 9, 4 },
                    { 9, 6 },
                    { 9, 7 },
                    { 9, 8 },
                    { 9, 9 },
                    { 9, 10 },
                    { 9, 11 },
                    { 10, 6 },
                    { 10, 7 },
                    { 10, 8 },
                    { 10, 9 },
                    { 10, 10 },
                    { 10, 11 },
                    { 11, 8 },
                    { 11, 9 },
                    { 11, 10 },
                    { 11, 11 },
                    { 12, 10 },
                    { 12, 11 }
                });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BeamType", "Description" },
                values: new object[] { "Egyalvázas", "A PALMS 6S egy egyalvázas erdészeti pótkocsi, melynek össztömege 8500 kg. Könnyű és kompakt kialakítása tökéletes választás kisebb traktorokhoz, ideális erdőgazdálkodáshoz és gazdálkodóknak. A PALMS 6S hasonló technológiákat használ, mint nagyobb pótkocsijaink, beleértve a magas minőségű KTL és porfestési bevonatot, ami hosszabb élettartamot és nagyobb újraértékesítési értéket biztosít." });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BeamType", "Description" },
                values: new object[] { "Egyalvázas", "A PALMS 8SX egy egyalvázas erdészeti pótkocsi, amelynek össztömege 10.000 kg. Ez a modell népszerű választás számos kis erdőbirtokos és gazdálkodó körében. A pótkocsi egyszerű, mégis robusztus kialakítása és tartóssága megbízható társává teszi különböző erdészeti és mezőgazdasági feladatokban." });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "BeamType",
                value: "Dupla alvázas");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "BeamType",
                value: "Dupla alvázas");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "BeamType",
                value: "Egyalvázas");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "BeamType",
                value: "Dupla alvázas");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "BeamType",
                value: "Dupla alvázas");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "BeamType",
                value: "Dupla alvázas");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9,
                column: "BeamType",
                value: "Dupla alvázas");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "BeamType",
                value: "Dupla alvázas");

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "BeamType",
                value: "Dupla alvázas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 11 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 11 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BeamType", "Description" },
                values: new object[] { "Egy", "A PALMS 6S egyetlen gerendás erdészeti pótkocsi, melynek nominális teherbírása 6 tonna. Könnyű és kompakt kialakítása tökéletes választás kisebb traktorokhoz, ideális magán-erdőgazdálkodáshoz és gazdálkodóknak. A PALMS 6S hasonló technológiákat használ, mint nagyobb pótkocsijaink, beleértve a magas minőségű KTL és porfestési bevonatot, ami hosszabb élettartamot és nagyobb újraértékesítési értéket biztosít." });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BeamType", "Description" },
                values: new object[] { "Egy", "A PALMS 8SX egyetlen gerendával rendelkező erdészeti utánfutó, amelynek nominális teherbírása 8 tonna. Ez a modell népszerű választás számos kis erdőbirtokos és gazdálkodó körében. Az utánfutó egyszerű, mégis robosztus kialakítása és tartóssága megbízható társává teszi különböző erdészeti és mezőgazdasági feladatokban." });

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
        }
    }
}
