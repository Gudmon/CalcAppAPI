using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class fix10uxweightindesc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "A PALMS 10UX erdészeti pótkocsi az U-sorozat legkisebb változata, mely a duplaalvázas kivitel mellett az úgynevezett unibody típusú rakoncákkal van szerelve. Össztömege 13000 kg. Nagy hasmagassága és az unibody keret csökkenti az elakadás kockázatát. A hidraulikus alkatrészek az unibody keretben vannak elhelyezve, védve ezzel azokat, mégis könnyű hozzáférést biztosít a karbantartáshoz. ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "A PALMS 10UX erdészeti pótkocsi az U-sorozat legkisebb változata, mely a duplaalvázas kivitel mellett az úgynevezett unibody típusú rakoncákkal van szerelve. Össztömege 15000 kg. Nagy hasmagassága és az unibody keret csökkenti az elakadás kockázatát. A hidraulikus alkatrészek az unibody keretben vannak elhelyezve, védve ezzel azokat, mégis könnyű hozzáférést biztosít a karbantartáshoz. ");
        }
    }
}
