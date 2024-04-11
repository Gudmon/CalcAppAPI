using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class hmwdtrailers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BBox",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 4, "Bbox", "Biomasszás boksz 4 mm-es Strenx acélból", "3200" });

            migrationBuilder.InsertData(
                table: "Brake",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 31, "B2", "4 keréken hidraulikus többtárcsás fék (sebességváltón keresztül)", "250" },
                    { 32, "B4", "4 kerék légfék (hidraulikusan működtetett, többtárcsás, sebességváltón keresztül)", "3035" }
                });

            migrationBuilder.InsertData(
                table: "BunkAdapter",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 2, "PA", "Forwarder típusú bunk adapter a szélesebb rakodó felületért (az ár 1 db-ra vonatkozik)", "140" });

            migrationBuilder.InsertData(
                table: "BunkExtension",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 2, "PA-H", "Forwarder típusú bunk kiterjesztés (az ár 1 db-ra vonatkozik)", "595" });

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Osztrák típusú alacsony vonórúd vonószemmel");

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Német típusú magas vonórúd vonószemmel (P1-P3 szivattyúhoz)");

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 8,
                column: "Code",
                value: "C8");

            migrationBuilder.InsertData(
                table: "Drawbar",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 10, "C5", "Osztrák típusú alacsony vonórúd vonószemmel", "315" },
                    { 11, "C8", "K-80 típusú alacsony vonórúd vonószemmel", "535" },
                    { 12, "C9", "Osztrák típusú alacsony vonórúd elforduló vonószemmel", "500" },
                    { 13, "CY", "Y vonórúd Jake rögzítő csatlakozókkal (Valtra-hoz, egyéb traktorokhoz igény szerint) elektromos vezérléssel", "8380" }
                });

            migrationBuilder.UpdateData(
                table: "MOT",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Pótkocsi műszaki vizsga");

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "P1 101 cm3 dugattyús olajmpumpa a vonórúdon, 650 p/min - 65 l/min");

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "P2 130 cm3 dugattyús olajmpuma a vonórúdon, 650 p/min - 82 l/min");

            migrationBuilder.InsertData(
                table: "OilPump",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 8, "P6", "LS fajtájú olajmpumpa multiplikátorral, 500 p/min - 118 l/min", "5190" });

            migrationBuilder.InsertData(
                table: "OilTank",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 7, "T4+", "100 l-es olajtartály HVLP olajjal", "1610" });

            migrationBuilder.InsertData(
                table: "Stanchion",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 107, "A4F", "Pótkocsi 4 pár forwarder típusú rakoncával", "52325" },
                    { 108, "A5F", "Pótkocsi 5 pár forwarder típusú rakoncával", "53455" },
                    { 109, "A4FHEx", "Pótkocsi hidraulikus raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "55025" },
                    { 110, "A5FHEx", "Pótkocsi hidraulikus raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "56155" },
                    { 111, "A4F", "Pótkocsi 4 pár forwarder típusú rakoncával", "52985" },
                    { 112, "A5F", "Pótkocsi 5 pár forwarder típusú rakoncával", "54115" },
                    { 113, "A4FHEx", "Pótkocsi hidraulikus raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "55685" },
                    { 114, "A5FHEx", "Pótkocsi hidraulikus raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "56815" },
                    { 115, "A4F", "Pótkocsi 4 pár forwarder típusú rakoncával", "56815" },
                    { 116, "A5F", "Pótkocsi 5 pár forwarder típusú rakoncával", "57945" },
                    { 117, "A4FHEx", "Pótkocsi hidraulikus raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "59515" },
                    { 118, "A5FHEx", "Pótkocsi hidraulikus raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "60645" },
                    { 119, "A4F", "Pótkocsi 4 pár forwarder típusú rakoncával", "57475" },
                    { 120, "A5F", "Pótkocsi 5 pár forwarder típusú rakoncával", "58605" },
                    { 121, "A4FHEx", "Pótkocsi hidraulikus raktér hosszabbítással és 4 pár forwarder típusú rakoncával", "60175" },
                    { 122, "A5FHEx", "Pótkocsi hidraulikus raktér hosszabbítással és 5 pár forwarder típusú rakoncával", "61305" }
                });

            migrationBuilder.InsertData(
                table: "TrailerLight",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 4, "L1", "Összecsukható hátsó lámpák", "340" },
                    { 5, "L2", "Hátsó LED lámpa flexibilis Kilpi karokkal", "440" }
                });

            migrationBuilder.InsertData(
                table: "TrailerOilCooler",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 2, "CP4", "Olajhűtő csomag a tartályhoz rögzítve", "1190" });

            migrationBuilder.InsertData(
                table: "Tyre",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 13, "WH7.10", "600/50-22,5 RF-felni, 10 lyukas, Nokian", "11020" },
                    { 14, "WH9.10", "710/40-22,5 RF-felni, 10 lyukas, Nokian", "11150" }
                });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "BBoxId", "BeamType", "BolsterLockId", "BunkAdapterId", "BunkExtensionId", "ChainsawHolderId", "CurbWeight", "Description", "DrawbarControlCylinders", "Frame", "FrameExtensionId", "FrameExtensionLength", "GrossWeight", "HandBrakeId", "LoadingAreaCross", "LoadingAreaLength", "MOTId", "MaxCraneSize", "Name", "Price", "ShippingId", "StandardWheelSize", "TotalLength", "TrailerOilCoolerId", "UnderrunProtectionId", "WidthWithStandardWheels", "WoodSorterId" },
                values: new object[,]
                {
                    { 20, 4, "Unibody (Forwarder)", null, 2, 2, null, "4700", "Ismerje meg a PALMS MWD sorozatú forwarder típusú pótkocsit, amelyet a legnehezebb terepek legyőzésére terveztek. Az összes MWD pótkocsi mechanikus áttétele egyedileg lesz testre szabva minden ügyfelünk traktorához.", "2", "unibody", null, "1.085", "18000", null, "3.2", "4235", 1, "120", "PALMS MWD 3.2", "", 1, "600/50x22.5", "6430", null, null, "2470", null },
                    { 21, 4, "Unibody (Forwarder)", null, 2, 2, null, "4700", "Ismerje meg a PALMS mechanikus meghajtású, forwarder típusú pótkocsiját, amelyet a legnehezebb terepek legyőzésére terveztek. Az összes MWD pótkocsi mechanikus áttétele egyedileg lesz testre szabva minden ügyfelünk traktorához.", "2", "unibody", null, "1.085", "18000", null, "3.2", "4235", 1, "120", "PALMS MWD 3.2L", "", 1, "600/50x22.5", "6430", null, null, "2470", null },
                    { 22, 4, "Unibody (Forwarder)", null, 2, 2, null, "4920", "Ismerje meg a PALMS hidromechanikus meghajtású pótkocsiját, amelyet a legnehezebb terepek legyőzésére terveztek. A hidromechanikus 4x4 rendszer alkalmas minden méretű traktorhoz, amelynek TLT hajtása van.", "2", "unibody", null, "1.085", "18000", null, "3.2", "4185", 1, "120", "PALMS HMWD 3.2", "", 1, "600/50x22.5", "6430", 2, null, "2470", null },
                    { 23, 4, "Unibody (Forwarder)", null, 2, 2, null, "4920", "Ismerje meg a PALMS hidromechanikus meghajtású pótkocsiját, amelyet a legnehezebb terepek legyőzésére terveztek. A hidromechanikus 4x4 rendszer alkalmas minden méretű traktorhoz, amelynek TLT hajtása van.", "2", "unibody", null, "1.085", "18000", null, "3.2", "4185", 1, "120", "PALMS HMWD 3.2L", "", 1, "600/50x22.5", "6430", 2, null, "2470", null }
                });

            migrationBuilder.InsertData(
                table: "BrakeTrailer",
                columns: new[] { "BrakeId", "TrailerId" },
                values: new object[,]
                {
                    { 31, 20 },
                    { 31, 21 },
                    { 31, 22 },
                    { 31, 23 },
                    { 32, 20 },
                    { 32, 21 },
                    { 32, 22 },
                    { 32, 23 }
                });

            migrationBuilder.InsertData(
                table: "CraneTrailer",
                columns: new[] { "CraneId", "TrailerId" },
                values: new object[,]
                {
                    { 9, 20 },
                    { 9, 21 },
                    { 10, 20 },
                    { 10, 21 },
                    { 11, 20 },
                    { 11, 21 },
                    { 12, 20 },
                    { 12, 21 }
                });

            migrationBuilder.InsertData(
                table: "DrawbarTrailer",
                columns: new[] { "DrawbarId", "TrailerId" },
                values: new object[,]
                {
                    { 1, 20 },
                    { 1, 21 },
                    { 1, 22 },
                    { 1, 23 },
                    { 3, 20 },
                    { 3, 21 },
                    { 3, 22 },
                    { 3, 23 },
                    { 10, 20 },
                    { 10, 21 },
                    { 10, 22 },
                    { 10, 23 },
                    { 11, 20 },
                    { 11, 21 },
                    { 11, 22 },
                    { 11, 23 },
                    { 12, 20 },
                    { 12, 21 },
                    { 12, 22 },
                    { 12, 23 },
                    { 13, 20 },
                    { 13, 21 },
                    { 13, 22 },
                    { 13, 23 }
                });

            migrationBuilder.InsertData(
                table: "LightTrailer",
                columns: new[] { "LightId", "TrailerId" },
                values: new object[,]
                {
                    { 4, 20 },
                    { 4, 21 },
                    { 4, 22 },
                    { 4, 23 },
                    { 5, 20 },
                    { 5, 21 },
                    { 5, 22 },
                    { 5, 23 }
                });

            migrationBuilder.InsertData(
                table: "OilPumpTrailer",
                columns: new[] { "OilPumpId", "TrailerId" },
                values: new object[,]
                {
                    { 8, 22 },
                    { 8, 23 }
                });

            migrationBuilder.InsertData(
                table: "OilTankTrailer",
                columns: new[] { "OilTankId", "TrailerId" },
                values: new object[,]
                {
                    { 7, 22 },
                    { 7, 23 }
                });

            migrationBuilder.InsertData(
                table: "StanchionTrailer",
                columns: new[] { "StanchionId", "TrailerId" },
                values: new object[,]
                {
                    { 107, 20 },
                    { 108, 20 },
                    { 109, 20 },
                    { 110, 20 },
                    { 111, 21 },
                    { 112, 21 },
                    { 113, 21 },
                    { 114, 21 }
                });

            migrationBuilder.InsertData(
                table: "TyreTrailer",
                columns: new[] { "TrailerId", "TyreId" },
                values: new object[,]
                {
                    { 20, 13 },
                    { 20, 14 },
                    { 21, 13 },
                    { 21, 14 },
                    { 22, 13 },
                    { 22, 14 },
                    { 23, 13 },
                    { 23, 14 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 31, 20 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 31, 21 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 31, 22 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 31, 23 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 32, 20 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 32, 21 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 32, 22 });

            migrationBuilder.DeleteData(
                table: "BrakeTrailer",
                keyColumns: new[] { "BrakeId", "TrailerId" },
                keyValues: new object[] { 32, 23 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 20 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 9, 21 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 20 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 10, 21 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 20 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 11, 21 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 12, 20 });

            migrationBuilder.DeleteData(
                table: "CraneTrailer",
                keyColumns: new[] { "CraneId", "TrailerId" },
                keyValues: new object[] { 12, 21 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 20 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 21 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 10, 20 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 10, 21 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 10, 22 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 10, 23 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 11, 20 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 11, 21 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 11, 22 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 11, 23 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 12, 20 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 12, 21 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 12, 22 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 12, 23 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 13, 20 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 13, 21 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 13, 22 });

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 13, 23 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 4, 20 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 4, 21 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 4, 22 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 4, 23 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 5, 20 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 5, 21 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 5, 22 });

            migrationBuilder.DeleteData(
                table: "LightTrailer",
                keyColumns: new[] { "LightId", "TrailerId" },
                keyValues: new object[] { 5, 23 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 8, 22 });

            migrationBuilder.DeleteData(
                table: "OilPumpTrailer",
                keyColumns: new[] { "OilPumpId", "TrailerId" },
                keyValues: new object[] { 8, 23 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 7, 22 });

            migrationBuilder.DeleteData(
                table: "OilTankTrailer",
                keyColumns: new[] { "OilTankId", "TrailerId" },
                keyValues: new object[] { 7, 23 });

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 107, 20 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 108, 20 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 109, 20 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 110, 20 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 111, 21 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 112, 21 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 113, 21 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 114, 21 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 20, 13 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 20, 14 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 21, 13 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 21, 14 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 22, 13 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 22, 14 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 23, 13 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 23, 14 });

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Brake",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OilTank",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TrailerLight",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TrailerLight",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BBox",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BunkAdapter",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BunkExtension",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrailerOilCooler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Osztrák típusú magas vonórúd vonószemmel");

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Német típusú magas vonórúd vonószemmel");

            migrationBuilder.UpdateData(
                table: "Drawbar",
                keyColumn: "Id",
                keyValue: 8,
                column: "Code",
                value: "C6");

            migrationBuilder.UpdateData(
                table: "MOT",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Pótkocsi Műszaki vizsga");

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "101 cm3 dugattyús olajmpumpa a vonórúdon, 650 p/min - 65 l/min");

            migrationBuilder.UpdateData(
                table: "OilPump",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "130 cm3 dugattyús olajmpuma a vonórúdon, 650 p/min - 82 l/min");
        }
    }
}
