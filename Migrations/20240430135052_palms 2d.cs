using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class palms2d : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HydroPackId",
                table: "Trailer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HydroPack",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HydroPack", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BBox",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 5, "Bbox", "Biomasszás boksz 4 mm-es Strenx acélból", "905" });

            migrationBuilder.InsertData(
                table: "HydroPack",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 1, "HyP", "Hydropack 6,5 lóerő - 12 l/min", "2195" });

            migrationBuilder.InsertData(
                table: "Propulsion",
                columns: new[] { "Id", "Code", "Description", "Name", "Price" },
                values: new object[] { 9, "RWD", "Költséghatékony hajtásrendszer azoknak a felhasználóknak, akiknek időnként további pótkocsi-hajtásra van szükségük. A rendszer működtetése a traktor hidraulikájáról történik. Előnyei az RWD+ rendszerhez képest a jobb manőverezhetőség és a műszaki egyszerűség.", "Robson WD dörzshajtás (traktor hidarulikáról)", "2040" });

            migrationBuilder.InsertData(
                table: "Stanchion",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 123, "A3", "Pótkocsi 3 pár rakoncával", "2490" },
                    { 124, "A4", "Pótkocsi 4 pár rakoncával", "2595" },
                    { 125, "A5", "Pótkocsi 5 pár rakoncával", "2700" }
                });

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 1,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 2,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 3,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 4,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 5,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 6,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 7,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 8,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 9,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 10,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 11,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 12,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 13,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 14,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 15,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 16,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 17,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 18,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 19,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 20,
                column: "HydroPackId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 21,
                column: "HydroPackId",
                value: null);

            migrationBuilder.InsertData(
                table: "Tyre",
                columns: new[] { "Id", "Code", "Name", "Price" },
                values: new object[] { 15, "WH1.4", "22/11-8", "465" });

            migrationBuilder.InsertData(
                table: "Trailer",
                columns: new[] { "Id", "BBoxId", "BeamType", "BolsterLockId", "BunkAdapterId", "BunkExtensionId", "ChainsawHolderId", "CurbWeight", "Description", "DrawbarControlCylinders", "Frame", "FrameExtensionId", "FrameExtensionLength", "GrossWeight", "HandBrakeId", "HydroPackId", "LoadingAreaCross", "LoadingAreaLength", "MOTId", "MaxCraneSize", "Name", "Price", "ShippingId", "StanchionExtensionId", "StandardWheelSize", "TotalLength", "TrailerOilCoolerId", "UnderrunProtectionId", "WidthWithStandardWheels", "WoodSorterId" },
                values: new object[] { 22, 5, "Dupla alvázas", null, null, null, 1, "260", "Tökéletes kompakt traktorokhoz és terepjárókhoz. Strenx Performance acélból készült strapabíró duplaalvázzal, fokozott korrózióállósággal (KTL+por bevonatt), valamint 1500 kg névleges teherbírással rendelkezik.", "1", "2x4 mm C-beam", null, "-", "1500", null, 1, "0,6", "2450", 1, "12", "PALMS 2D", "", 1, null, "22/11-8", "3865", 1, null, "1285", null });

            migrationBuilder.InsertData(
                table: "DrawbarTrailer",
                columns: new[] { "DrawbarId", "TrailerId" },
                values: new object[] { 1, 22 });

            migrationBuilder.InsertData(
                table: "PropulsionTrailer",
                columns: new[] { "PropulsionId", "TrailerId" },
                values: new object[] { 9, 22 });

            migrationBuilder.InsertData(
                table: "StanchionTrailer",
                columns: new[] { "StanchionId", "TrailerId" },
                values: new object[,]
                {
                    { 123, 22 },
                    { 124, 22 },
                    { 125, 22 }
                });

            migrationBuilder.InsertData(
                table: "TyreTrailer",
                columns: new[] { "TrailerId", "TyreId" },
                values: new object[] { 22, 15 });

            migrationBuilder.CreateIndex(
                name: "IX_Trailer_HydroPackId",
                table: "Trailer",
                column: "HydroPackId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trailer_HydroPack_HydroPackId",
                table: "Trailer",
                column: "HydroPackId",
                principalTable: "HydroPack",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trailer_HydroPack_HydroPackId",
                table: "Trailer");

            migrationBuilder.DropTable(
                name: "HydroPack");

            migrationBuilder.DropIndex(
                name: "IX_Trailer_HydroPackId",
                table: "Trailer");

            migrationBuilder.DeleteData(
                table: "DrawbarTrailer",
                keyColumns: new[] { "DrawbarId", "TrailerId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "PropulsionTrailer",
                keyColumns: new[] { "PropulsionId", "TrailerId" },
                keyValues: new object[] { 9, 22 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 123, 22 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 124, 22 });

            migrationBuilder.DeleteData(
                table: "StanchionTrailer",
                keyColumns: new[] { "StanchionId", "TrailerId" },
                keyValues: new object[] { 125, 22 });

            migrationBuilder.DeleteData(
                table: "TyreTrailer",
                keyColumns: new[] { "TrailerId", "TyreId" },
                keyValues: new object[] { 22, 15 });

            migrationBuilder.DeleteData(
                table: "Propulsion",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Stanchion",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Trailer",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tyre",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BBox",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "HydroPackId",
                table: "Trailer");
        }
    }
}
