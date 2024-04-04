using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class changecranenames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Nagy teljesítményű erdészeti daru, amelyet a mindennapos profi erdészeti munkákra terveztek. Magasabb emelőkapacitása és forgatónyomatéka miatt is alkalmas vágófejjel való munkavégzésre is. Kompatibilis a Palms egyalvázas és duplaalvázat pótkocsijaval is.");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Nagy teherbírású erdészeti daru, két teleszkóppal, amelyet a mindennapos profi erdészeti munkákhoz terveztek. Magasabb emelőkapacítása és forgatónyomatéka miatt alkalmas vágókanállal történő munkavégzéshez is. Egyaránt kompatibilis a Palms egyalvázas és duplaalvázas kivitelű pótkocsijaival.");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Nagy teherbírású erdészeti daru, két, kitolható teleszkóppal ellátva, a mindennapos erdészeti munkákra tervezve, profi szinten. Magas emelőkapacitással és forgatónyomatékkal rendelkezik, akár vágókanállal, biokanállal is használható. Kompatibilis a nagyobb Palms pótkocsikkal, akár egy, akár duplaalvázas kivitelű.");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "A Palms X100-as daruja a kínálatunkban a legnagyobb kinyúlással és emelőkapacitással rendelkezik. Dupla teleszkópos kivitelű, a hidraulikus alkatrészek a teleszkópokban rejtve, mégis könnyen hozzáférhetően vannak elhelyezve, biztosítva ezzel, hogy a munkálatok során ezek az alkatrészek ne sérüljenek, mégis a folyamatos üzemelés, nagy munkabírás biztosítva van.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Nagy teljesítményű erdészeti daru, amelyet a mindennapos profi erdészeti műveletekhez terveztek. Magasabb emelőkapacitása és forgási nyomatéka miatt alkalmas forgácsgépek és szüretelőfejekkel való munkavégzéshez is. Kompatibilis a PALMS dupla tartógerendás és egyrészes pótkocsikkal.");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Nagy teherbírású erdészeti daru két darab teleszkópos kinyújtóval, amelyet a mindennapos profi erdészeti műveletekhez terveztek. Magasabb emelőkapacitása és forgási nyomatéka miatt alkalmas forgácsgépek és szüretelőfejekkel való munkavégzéshez is. Kompatibilis a PALMS dupla tartógerendás és egyrészes pótkocsikkal.");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Nagy teherbírású erdészeti daru két darab teleszkópos kinyújtóval, amelyet a mindennapos profi erdészeti műveletekhez terveztek. Magasabb emelőkapacitása és forgási nyomatéka miatt alkalmas forgácsgépek és szüretelőfejekkel való munkavégzéshez is. Kompatibilis a PALMS dupla tartógerendás és egyrészes pótkocsikkal.");

            migrationBuilder.UpdateData(
                table: "Crane",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "A PALMS X100 kínálatunkban a leghosszabb hatótávval és legnagyobb emelőkapacitással rendelkezik. Dupla teleszkópos kinyújtója rejtett hidraulikus alkatrészeket rejteget, biztosítva ezzel a folyamatos üzemelést.");
        }
    }
}
