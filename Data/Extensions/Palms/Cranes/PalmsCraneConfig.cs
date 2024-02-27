﻿using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Cranes
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
                   TelescopeLength = "-",
                   SlewingCylinder = "4",
                   SlewingTorque = "7.8",
                   WorkingPressure = "190",
                   RotatorMaximumLoad = "45",
                   CraneWeight = "360",
                   PillarSlewingAngle = "370",
                   RecommendedOilFlow = "20-35",
                   ProtectionSleevesId = 1,
                   ElectricalFloatingId = null,
                   ValveBlockId = null,
                   LightId = null,
                   OperatorSeatId = null,
                   CraneOilCoolerId = null,
                   JoystickHolderId = 1,
                   TurningDeviceCounterPlateId = 1,
                   SupportLegCounterPlateId = 1,
                   CoverId = 1,
                   WoodControlId = 1,
                   LinkageId = null
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
                   TelescopeLength = "1,33",
                   SlewingCylinder = "4",
                   SlewingTorque = "7.8",
                   WorkingPressure = "190/215",
                   RotatorMaximumLoad = "45",
                   CraneWeight = "400",
                   PillarSlewingAngle = "370",
                   RecommendedOilFlow = "20-35",
                   ProtectionSleevesId = 1,
                   ElectricalFloatingId = null,
                   ValveBlockId = null,
                   LightId = null,
                   OperatorSeatId = null,
                   CraneOilCoolerId = null,
                   JoystickHolderId = 1,
                   TurningDeviceCounterPlateId = 1,
                   SupportLegCounterPlateId = 1,
                   CoverId = 1,
                   WoodControlId = 1,
                   LinkageId = null
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
                   LiftAtFullReach190Bar = "355",
                   LiftAtFourMeters240Bar = "-",
                   LiftAtFourMeters215Bar = "-",
                   LiftAtFourMeters190Bar = "655",
                   BrutLiftingTorque240Bar = "-",
                   BrutLiftingTorque215Bar = "-",
                   BrutLiftingTorque190Bar = "36",
                   TelescopeLength = "1,85",
                   SlewingCylinder = "4",
                   SlewingTorque = "9",
                   WorkingPressure = "190",
                   RotatorMaximumLoad = "45",
                   CraneWeight = "415",
                   PillarSlewingAngle = "370",
                   RecommendedOilFlow = "20-35",
                   ProtectionSleevesId = 1,
                   ElectricalFloatingId = null,
                   ValveBlockId = null,
                   LightId = null,
                   OperatorSeatId = null,
                   CraneOilCoolerId = null,
                   JoystickHolderId = 1,
                   TurningDeviceCounterPlateId = 1,
                   SupportLegCounterPlateId = 1,
                   CoverId = 1,
                   WoodControlId = 1,
                   LinkageId = null
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
                   TelescopeLength = "1,85",
                   SlewingCylinder = "4",
                   SlewingTorque = "12",
                   WorkingPressure = "190/215",
                   RotatorMaximumLoad = "45",
                   CraneWeight = "620",
                   PillarSlewingAngle = "370",
                   RecommendedOilFlow = "30-45",
                   ProtectionSleevesId = 1,
                   ElectricalFloatingId = null,
                   ValveBlockId = null,
                   LightId = 1,
                   OperatorSeatId = null,
                   CraneOilCoolerId = null,
                   JoystickHolderId = 1,
                   TurningDeviceCounterPlateId = 1,
                   SupportLegCounterPlateId = 1,
                   CoverId = 1,
                   WoodControlId = 1,
                   LinkageId = null
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
                   TelescopeLength = "1,95",
                   SlewingCylinder = "4",
                   SlewingTorque = "15",
                   WorkingPressure = "190/215",
                   RotatorMaximumLoad = "45",
                   CraneWeight = "710",
                   PillarSlewingAngle = "370",
                   RecommendedOilFlow = "45-70",
                   ProtectionSleevesId = 2,
                   ElectricalFloatingId = 1,
                   ValveBlockId = 1,
                   LightId = 1,
                   OperatorSeatId = 1,
                   CraneOilCoolerId = 1,    
                   JoystickHolderId = 1,
                   TurningDeviceCounterPlateId = 1,
                   SupportLegCounterPlateId = 1,
                   CoverId = 1,
                   WoodControlId = 1,
                   LinkageId = null
               },
               new Crane
               {
                   Id = 6,
                   Name = "PALMS 5.72",
                   Description = "Naponta használt, professzionális erdészeti műveletekre tervezett daru lágy talajon, közepes méretű traktorokhoz optimalizálva, és kompatibilis a PALMS pótkocsik többségével.",
                   Price = "11435",
                   Series = "5",
                   MaxReach = "7,2",
                   LiftAtFullReach240Bar = "-", 
                   LiftAtFullReach215Bar = "710",
                   LiftAtFullReach190Bar = "620",
                   LiftAtFourMeters240Bar = "-", 
                   LiftAtFourMeters215Bar = "1240",
                   LiftAtFourMeters190Bar = "1100",
                   BrutLiftingTorque240Bar = "-",
                   BrutLiftingTorque215Bar = "63",
                   BrutLiftingTorque190Bar = "56",
                   TelescopeLength = "1,95",
                   SlewingCylinder = "4",
                   SlewingTorque = "17",
                   WorkingPressure = "190/215",
                   RotatorMaximumLoad = "60",
                   CraneWeight = "820",
                   PillarSlewingAngle = "380",
                   RecommendedOilFlow = "50-90",
                   ProtectionSleevesId = 3,
                   ElectricalFloatingId = 1,
                   ValveBlockId = 1,
                   LightId = 1,
                   OperatorSeatId = 1,
                   CraneOilCoolerId = 1,
                   JoystickHolderId = 1,
                   TurningDeviceCounterPlateId = 1,
                   SupportLegCounterPlateId = 1,
                   CoverId = 1,
                   WoodControlId = 1,
                   LinkageId = 1
               },
               new Crane
               {
                   Id = 7,
                   Name = "PALMS 5.85",
                   Description = "Professzionális erdészeti daru, dupla teleszkópos kinyúlási boommal felszerelve. Kifejezetten tervezve a mindennapi erdészeti műveletekhez lágy talajon. Optimalizálva a közepes méretű traktorok használatához, és kompatibilis a PALMS pótkocsik többségével.",
                   Price = "14265",
                   Series = "5",
                   MaxReach = "8,5",
                   LiftAtFullReach240Bar = "-",
                   LiftAtFullReach215Bar = "520",
                   LiftAtFullReach190Bar = "450",
                   LiftAtFourMeters240Bar = "-",
                   LiftAtFourMeters215Bar = "1220",
                   LiftAtFourMeters190Bar = "1050",
                   BrutLiftingTorque240Bar = "-",
                   BrutLiftingTorque215Bar = "63",
                   BrutLiftingTorque190Bar = "56",
                   TelescopeLength = "3,3",
                   SlewingCylinder = "4",
                   SlewingTorque = "17",
                   WorkingPressure = "190/215",
                   RotatorMaximumLoad = "60",
                   CraneWeight = "900",
                   PillarSlewingAngle = "380",
                   RecommendedOilFlow = "50-90",
                   ProtectionSleevesId = 3,
                   ElectricalFloatingId = 1,
                   ValveBlockId = 1,
                   LightId = 1,
                   OperatorSeatId = 1,
                   CraneOilCoolerId = 1,
                   JoystickHolderId = 1,
                   TurningDeviceCounterPlateId = 1,
                   SupportLegCounterPlateId = 1,
                   CoverId = 1,
                   WoodControlId = 1,
                   LinkageId = 1
               },
               new Crane
               {
                   Id = 8,
                   Name = "PALMS 5.87Z",
                   Description = "A PALMS 5.87Z daru kompakt szállítási méreteivel és sokoldalúságával tűnik ki, amely nemcsak erdészeti, hanem mezőgazdasági pótkocsikhoz és teherautókhoz is illeszkedik.",
                   Price = "15385",
                   Series = "5",
                   MaxReach = "8,7",
                   LiftAtFullReach240Bar = "-",
                   LiftAtFullReach215Bar = "490 (8,4 m)",
                   LiftAtFullReach190Bar = "-",
                   LiftAtFourMeters240Bar = "-",
                   LiftAtFourMeters215Bar = "1235",
                   LiftAtFourMeters190Bar = "-",
                   BrutLiftingTorque240Bar = "-",
                   BrutLiftingTorque215Bar = "63",
                   BrutLiftingTorque190Bar = "-",
                   TelescopeLength = "3,3",
                   SlewingCylinder = "4",
                   SlewingTorque = "17",
                   WorkingPressure = "215",
                   RotatorMaximumLoad = "60",
                   CraneWeight = "995",
                   PillarSlewingAngle = "340",
                   RecommendedOilFlow = "50-90",
                   ProtectionSleevesId = 3,
                   ElectricalFloatingId = null,
                   ValveBlockId = 1,
                   LightId = 1,
                   OperatorSeatId = 1,
                   CraneOilCoolerId = 1,
                   JoystickHolderId = 1,
                   TurningDeviceCounterPlateId = 1,
                   SupportLegCounterPlateId = 1,
                   CoverId = 1,
                   WoodControlId = null,
                   LinkageId = 1
               },
               new Crane
               {
                   Id = 9,
                   Name = "PALMS 7.75",
                   Description = "Nagy teljesítményű erdészeti daru, amelyet a mindennapos profi erdészeti műveletekhez terveztek. Magasabb emelőkapacitása és forgási nyomatéka miatt alkalmas forgácsgépek és szüretelőfejekkel való munkavégzéshez is. Kompatibilis a PALMS dupla tartógerendás és egyrészes pótkocsikkal.",
                   Price = "14780",
                   Series = "7",
                   MaxReach = "7,5",
                   LiftAtFullReach240Bar = "-",
                   LiftAtFullReach215Bar = "755",
                   LiftAtFullReach190Bar = "610",
                   LiftAtFourMeters240Bar = "-",
                   LiftAtFourMeters215Bar = "1585",
                   LiftAtFourMeters190Bar = "1325",
                   BrutLiftingTorque240Bar = "-",
                   BrutLiftingTorque215Bar = "83",
                   BrutLiftingTorque190Bar = "74",
                   TelescopeLength = "2",
                   SlewingCylinder = "4",
                   SlewingTorque = "21",
                   WorkingPressure = "190/215",
                   RotatorMaximumLoad = "60",
                   CraneWeight = "1170",
                   PillarSlewingAngle = "380",
                   RecommendedOilFlow = "60-120",
                   ProtectionSleevesId = 3,
                   ElectricalFloatingId = 1,
                   ValveBlockId = 1,
                   LightId = 1,
                   OperatorSeatId = 1,
                   CraneOilCoolerId = 1,
                   JoystickHolderId = 1,
                   TurningDeviceCounterPlateId = 1,
                   SupportLegCounterPlateId = 1,
                   CoverId = 1,
                   WoodControlId = 1,
                   LinkageId = 1
               },
               new Crane
               {
                   Id = 10,
                   Name = "PALMS 7.86",
                   Description = "Nagy teherbírású erdészeti daru két darab teleszkópos kinyújtóval, amelyet a mindennapos profi erdészeti műveletekhez terveztek. Magasabb emelőkapacitása és forgási nyomatéka miatt alkalmas forgácsgépek és szüretelőfejekkel való munkavégzéshez is. Kompatibilis a PALMS dupla tartógerendás és egyrészes pótkocsikkal.",
                   Price = "19940",
                   Series = "7",
                   MaxReach = "8,6",
                   LiftAtFullReach240Bar = "-",
                   LiftAtFullReach215Bar = "630",
                   LiftAtFullReach190Bar = "530",
                   LiftAtFourMeters240Bar = "-",
                   LiftAtFourMeters215Bar = "1480",
                   LiftAtFourMeters190Bar = "1250",
                   BrutLiftingTorque240Bar = "-",
                   BrutLiftingTorque215Bar = "83",
                   BrutLiftingTorque190Bar = "74",
                   TelescopeLength = "3,4",
                   SlewingCylinder = "4",
                   SlewingTorque = "21",
                   WorkingPressure = "190/215",
                   RotatorMaximumLoad = "60",
                   CraneWeight = "1280",
                   PillarSlewingAngle = "380",
                   RecommendedOilFlow = "60-120",
                   ProtectionSleevesId = 3,
                   ElectricalFloatingId = 1,
                   ValveBlockId = 1,
                   LightId = 1,
                   OperatorSeatId = 1,
                   CraneOilCoolerId = 1,
                   JoystickHolderId = 1,
                   TurningDeviceCounterPlateId = 1,
                   SupportLegCounterPlateId = 1,
                   CoverId = 1,
                   WoodControlId = 1,
                   LinkageId = 1
               },
               new Crane
               {
                   Id = 11,
                   Name = "PALMS 7.94",
                   Description = "Nagy teherbírású erdészeti daru két darab teleszkópos kinyújtóval, amelyet a mindennapos profi erdészeti műveletekhez terveztek. Magasabb emelőkapacitása és forgási nyomatéka miatt alkalmas forgácsgépek és szüretelőfejekkel való munkavégzéshez is. Kompatibilis a PALMS dupla tartógerendás és egyrészes pótkocsikkal.",
                   Price = "21105",
                   Series = "7",
                   MaxReach = "9,4",
                   LiftAtFullReach240Bar = "-",
                   LiftAtFullReach215Bar = "540",
                   LiftAtFullReach190Bar = "-",
                   LiftAtFourMeters240Bar = "-",
                   LiftAtFourMeters215Bar = "1410",
                   LiftAtFourMeters190Bar = "-",
                   BrutLiftingTorque240Bar = "-",
                   BrutLiftingTorque215Bar = "83",
                   BrutLiftingTorque190Bar = "-",
                   TelescopeLength = "3,8",
                   SlewingCylinder = "4",
                   SlewingTorque = "21",
                   WorkingPressure = "215",
                   RotatorMaximumLoad = "60",
                   CraneWeight = "1310",
                   PillarSlewingAngle = "380",
                   RecommendedOilFlow = "60-120",
                   ProtectionSleevesId = 3,
                   ElectricalFloatingId = 1,
                   ValveBlockId = 1,
                   LightId = 1,
                   OperatorSeatId = 1,
                   CraneOilCoolerId = 1,
                   JoystickHolderId = 1,
                   TurningDeviceCounterPlateId = 1,
                   SupportLegCounterPlateId = 1,
                   CoverId = 1,
                   WoodControlId = 1,
                   LinkageId = 1
               },
               new Crane
               {
                   Id = 12,
                   Name = "PALMS X100",
                   Description = "A PALMS X100 kínálatunkban a leghosszabb hatótávval és legnagyobb emelőkapacitással rendelkezik. Dupla teleszkópos kinyújtója rejtett hidraulikus alkatrészeket rejteget, biztosítva ezzel a folyamatos üzemelést.",
                   Price = "31460",
                   Series = "X",
                   MaxReach = "10,1",
                   LiftAtFullReach240Bar = "680",
                   LiftAtFullReach215Bar = "-",
                   LiftAtFullReach190Bar = "-",
                   LiftAtFourMeters240Bar = "2000",
                   LiftAtFourMeters215Bar = "-",
                   LiftAtFourMeters190Bar = "-",
                   BrutLiftingTorque240Bar = "106",
                   BrutLiftingTorque215Bar = "-",
                   BrutLiftingTorque190Bar = "-",
                   TelescopeLength = "4,2",
                   SlewingCylinder = "4",
                   SlewingTorque = "30",
                   WorkingPressure = "240",
                   RotatorMaximumLoad = "100",
                   CraneWeight = "1760",
                   PillarSlewingAngle = "380",
                   RecommendedOilFlow = "120",
                   ElectricalFloatingId = null,
                   ProtectionSleevesId = 4,
                   ValveBlockId = 1,
                   LightId = 1,
                   OperatorSeatId = 1,
                   CraneOilCoolerId = 1,
                   JoystickHolderId = 1,
                   TurningDeviceCounterPlateId = 1,
                   SupportLegCounterPlateId = 1,
                   CoverId = 1,
                   WoodControlId = 1,
                   LinkageId = 1
               }
           );
        }
    }
}
