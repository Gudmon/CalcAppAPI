using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class missingcranesfor11ux : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 31, 8 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 33, 8 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 35, 8 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 37, 8 });

            migrationBuilder.InsertData(
                table: "BrakeTrailer",
                columns: new[] { "BrakeId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 16 },
                    { 10, 16 },
                    { 11, 16 },
                    { 12, 16 },
                    { 13, 16 },
                    { 14, 16 },
                    { 15, 16 }
                });

            migrationBuilder.InsertData(
                table: "CraneTrailer",
                columns: new[] { "CraneId", "TrailerId" },
                values: new object[,]
                {
                    { 6, 16 },
                    { 7, 16 },
                    { 8, 16 },
                    { 9, 16 },
                    { 10, 16 },
                    { 11, 16 },
                    { 12, 16 }
                });

            migrationBuilder.InsertData(
                table: "DrawbarTrailer",
                columns: new[] { "DrawbarId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 16 },
                    { 2, 16 },
                    { 3, 16 },
                    { 4, 16 },
                    { 5, 16 },
                    { 7, 1 },
                    { 7, 3 },
                    { 8, 16 },
                    { 9, 16 }
                });

            migrationBuilder.UpdateData(
                table: "FrameExtension",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "HEX");

            migrationBuilder.InsertData(
                table: "LightTrailer",
                columns: new[] { "LightId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 16 },
                    { 2, 16 },
                    { 3, 16 }
                });

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "LS fajtájú olajpumpa multiplikátorral, 500 p/min - 118 l/min");

            migrationBuilder.InsertData(
                table: "OilPumpTrailer",
                columns: new[] { "OilPumpId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 16 },
                    { 2, 16 },
                    { 3, 16 },
                    { 4, 16 },
                    { 5, 16 },
                    { 6, 16 },
                    { 7, 16 }
                });

            migrationBuilder.InsertData(
                table: "OilTankTrailer",
                columns: new[] { "OilTankId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 16 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 16 },
                    { 3, 16 },
                    { 4, 8 },
                    { 4, 9 },
                    { 4, 10 },
                    { 4, 11 },
                    { 4, 12 },
                    { 4, 16 }
                });

            migrationBuilder.InsertData(
                table: "PlatformTrailer",
                columns: new[] { "PlatformId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 16 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "PropulsionTrailer",
                columns: new[] { "PropulsionId", "TrailerId" },
                values: new object[,]
                {
                    { 5, 16 },
                    { 6, 16 },
                    { 12, 16 },
                    { 13, 16 },
                    { 14, 16 },
                    { 15, 16 }
                });

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 32,
                column: "Price",
                value: "9680");

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 34,
                column: "Price",
                value: "10240");

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 36,
                column: "Price",
                value: "10920");

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 38,
                column: "Price",
                value: "11475");

            migrationBuilder.InsertData(
                table: "Stanchion",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 82, "A3F", "Pótkocsi 3 pár forwarder rakoncával", "10710" },
                    { 83, "A4F", "Pótkocsi 4 pár forwarder rakoncával", "11335" },
                    { 84, "A4FEx", "Pótkocsi 4 pár forwarder rakoncával és raktérhosszabbítással", "12020" },
                    { 85, "A5FEx", "Pótkocsi 5 pár forwarder rakoncával és raktérhosszabbítással", "12645" }
                });

            migrationBuilder.InsertData(
                table: "SupportLegTrailer",
                columns: new[] { "SupportLegId", "TrailerId" },
                values: new object[,]
                {
                    { 2, 16 },
                    { 3, 16 }
                });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BBoxId", "ChainsawHolderId", "Description", "FrameExtensionId", "HandBrakeId", "MOTId", "ShippingId", "TrailerOilCoolerId" },
                values: new object[] { 2, 1, "A PALMS 11UX az önhordó váz szerkezeti előnyeit – mint például a fokozott szilárdság, a kiváló terepjáró képességek és az egyszerű karbantartás – kínálja, a D-szériás pótkocsik árkategóriájában. Ezenkívül számos új fejlesztést is tartalmaz, beleértve a teljesen védett, vázba integrált opcionális légtartályt; az újonnan tervezett, könnyen kihúzható, szállítógép-típusú szélesítést, valamint az új vonórudat.", 1, 1, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "TyreTrailer",
                columns: new[] { "TrailerId", "TyreId" },
                values: new object[,]
                {
                    { 16, 5 },
                    { 16, 7 },
                    { 16, 8 },
                    { 16, 9 }
                });

            migrationBuilder.InsertData(
                table: "StanchionTrailer",
                columns: new[] { "StanchionId", "TrailerId" },
                values: new object[,]
                {
                    { 82, 16 },
                    { 83, 16 },
                    { 84, 16 },
                    { 85, 16 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 10, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 11, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 12, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 13, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 14, 16 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 15, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 8, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 16 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 12, 16 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 8, 16 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 9, 16 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "PlatformTrailer",
                keyColumns: new[] { "PlatformId", "TrailerId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 12, 16 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 13, 16 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 14, 16 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 15, 16 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 82, 16 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 83, 16 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 84, 16 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 85, 16 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "SupportLegTrailer",
                keyColumns: new[] { "SupportLegId", "TrailerId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 16, 9 });

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

            migrationBuilder.InsertData(
                table: "DrawbarTrailer",
                columns: new[] { "DrawbarId", "TrailerId" },
                values: new object[] { 6, 8 });

            migrationBuilder.UpdateData(
                table: "FrameExtension",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "Hex");

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "LS fajtájú olajmpumpa multiplikátorral, 500 p/min - 118 l/min");

            migrationBuilder.InsertData(
                table: "OilTankTrailer",
                columns: new[] { "OilTankId", "TrailerId" },
                values: new object[,]
                {
                    { 5, 8 },
                    { 5, 9 },
                    { 5, 10 },
                    { 5, 11 },
                    { 5, 12 },
                    { 6, 8 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 6, 12 }
                });

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 32,
                column: "Price",
                value: "10495");

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 34,
                column: "Price",
                value: "11125");

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 36,
                column: "Price",
                value: "11850");

            migrationBuilder.UpdateData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 38,
                column: "Price",
                value: "12480");

            migrationBuilder.InsertData(
                table: "StanchionTrailer",
                columns: new[] { "StanchionId", "TrailerId" },
                values: new object[,]
                {
                    { 31, 8 },
                    { 33, 8 },
                    { 35, 8 },
                    { 37, 8 }
                });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BBoxId", "ChainsawHolderId", "Description", "FrameExtensionId", "HandBrakeId", "MOTId", "ShippingId", "TrailerOilCoolerId" },
                values: new object[] { null, null, "", null, null, null, null, null });
        }
    }
}
