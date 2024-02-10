using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions
{
    public static class PalmsCraneConfig
    {
        public static void ConfigureMultiplePalmsCranes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Crane>().HasData(
               new Crane
               {
                   Id = 1,
                   Name = "PALMS 2.42",
                   Description = "Ideális választás azoknak a vásárlóknak, akik egyszerűséget, könnyűséget és kompakt méretet keresnek. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.",
                   Price = "5165",
                   Series = "2",
                   MaxReach = "4.2",
                   LiftAtFullReach240Bar = "-",
                   LiftAtFullReach215Bar = "-",
                   LiftAtFullReach190Bar = "540",
                   LiftAtFourMeters240Bar = "-",
                   LiftAtFourMeters215Bar = "-",
                   LiftAtFourMeters190Bar = "570",
                   BrutLiftingTorque240Bar = "-",
                   BrutLiftingTorque215Bar = "-",
                   BrutLiftingTorque190Bar = "26",
                   SlewingCylinder = "4",
                   SlewingTorque = "7.8",
                   WorkingPressure = "190",
                   RotatorMaximumLoad = "45",
                   CraneWeight = "360",
                   PillarSlewingAngle = "370",
                   RecommendedOilFLow = "20-35",
               },

               new Crane
               {
                   Id = 2,
                   Name = "PALMS 2.54",
                   Description = "Kompakt és könnyű daru, ideális városi parkokhoz és más környezetvédelmi érzékeny területekhez. Rögzíthető különböző platformokra, erdészeti pótkocsiktól és teherautóktól kezdve a mini-forwarderekig. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.",
                   Price = "6285",
                   Series = "2",
                   MaxReach = "5.4",
                   LiftAtFullReach240Bar = "-",
                   LiftAtFullReach215Bar = "410",
                   LiftAtFullReach190Bar = "370",
                   LiftAtFourMeters240Bar = "-",
                   LiftAtFourMeters215Bar = "600",
                   LiftAtFourMeters190Bar = "530",
                   BrutLiftingTorque240Bar = "-",
                   BrutLiftingTorque215Bar = "29",
                   BrutLiftingTorque190Bar = "26",
                   SlewingCylinder = "4",
                   SlewingTorque = "7.8",
                   WorkingPressure = "190/215",
                   RotatorMaximumLoad = "45",
                   CraneWeight = "400",
                   PillarSlewingAngle = "370",
                   RecommendedOilFLow = "20-35",
               },


               new Crane
               {
                   Id = 3,
                   Name = "PALMS 3.63",
                   Description = "Kis erdőtulajdonosoknak tervezett daru a tűzifa előkészítésére saját maguk és szomszédos háztartások számára. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.",
                   Price = "6985",
                   Series = "3",
                   MaxReach = "6.3",
                   LiftAtFullReach240Bar = "-",
                   LiftAtFullReach215Bar = "-",
                   LiftAtFullReach190Bar = "-",
                   LiftAtFourMeters240Bar = "-",
                   LiftAtFourMeters215Bar = "-",
                   LiftAtFourMeters190Bar = "355",
                   BrutLiftingTorque240Bar = "-",
                   BrutLiftingTorque215Bar = "-",
                   BrutLiftingTorque190Bar = "36",
                   SlewingCylinder = "4",
                   SlewingTorque = "9",
                   WorkingPressure = "190",
                   RotatorMaximumLoad = "45",
                   CraneWeight = "415",
                   PillarSlewingAngle = "370",
                   RecommendedOilFLow = "20-35",
               },

               new Crane
               {
                   Id = 4,
                   Name = "PALMS 3.67",
                   Description = "Egy gazda legjobb társa, kiváló teljesítményt nyújtva tűzifa előkészítésében és általános emelési feladatokban a gazdaságokon. Kompatibilis a PALMS 8SX, 8D, 9SC és 10D pótkocsikkal.",
                   Price = "8260",
                   Series = "3",
                   MaxReach = "6.7",
                   LiftAtFullReach240Bar = "-",
                   LiftAtFullReach215Bar = "480",
                   LiftAtFullReach190Bar = "430",
                   LiftAtFourMeters240Bar = "-",
                   LiftAtFourMeters215Bar = "910",
                   LiftAtFourMeters190Bar = "820",
                   BrutLiftingTorque240Bar = "-",
                   BrutLiftingTorque215Bar = "46",
                   BrutLiftingTorque190Bar = "41",
                   SlewingCylinder = "4",
                   SlewingTorque = "12",
                   WorkingPressure = "190/215",
                   RotatorMaximumLoad = "45",
                   CraneWeight = "620",
                   PillarSlewingAngle = "370",
                   RecommendedOilFLow = "30-45",
               },

               new Crane
               {
                   Id = 5,
                   Name = "PALMS 4.71",
                   Description = "Versatile medium-sized crane, used across diverse sectors like arboriculture, farming, and land development. Compatible with the majority of PALMS trailers.",
                   Price = "9450",
                   Series = "4",
                   MaxReach = "7.1",
                   LiftAtFullReach240Bar = "-",
                   LiftAtFullReach215Bar = "535",
                   LiftAtFullReach190Bar = "480",
                   LiftAtFourMeters240Bar = "-",
                   LiftAtFourMeters215Bar = "1040",
                   LiftAtFourMeters190Bar = "960",
                   BrutLiftingTorque240Bar = "-",
                   BrutLiftingTorque215Bar = "54",
                   BrutLiftingTorque190Bar = "48",
                   SlewingCylinder = "4",
                   SlewingTorque = "15",
                   WorkingPressure = "190/215",
                   RotatorMaximumLoad = "45",
                   CraneWeight = "710",
                   PillarSlewingAngle = "370",
                   RecommendedOilFLow = "45-70",
               }
           );
        }
    }
}
