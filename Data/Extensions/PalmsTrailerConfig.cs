using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions
{
    public static class PalmsTrailerConfig
    {
        public static void ConfigureMultiplePalmsTrailers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trailer>().HasData(
                new Trailer
                {
                    Id = 1,
                    Name = "PALMS 6S",
                    Description = "A PALMS 6S egyetlen gerendás erdészeti pótkocsi, melynek nominális teherbírása 6 tonna. Könnyű és kompakt kialakítása tökéletes választás kisebb traktorokhoz, ideális magán-erdőgazdálkodáshoz és gazdálkodóknak. A PALMS 6S hasonló technológiákat használ, mint nagyobb pótkocsijaink, beleértve a magas minőségű KTL és porfestési bevonatot, ami hosszabb élettartamot és nagyobb újraértékesítési értéket biztosít.",
                    Price = "",
                    LoadingAreaCross = "1,5",
                    LoadingAreaLength = "3000",
                    FrameExtensionLength = "-",
                    GrossWeight = "8500",
                    CurbWeight = "890",
                    TotalLength = "4900",
                    WidthWithStandardWheels = "1950",
                    StandardWheelSize = "400/60-15,5",
                    MaxCraneSize = "35",
                    DrawbarControlCylinders = "1",
                    BeamType = Static.BeamTypes.Single,
                    Frame = "140x140x6",
                    BolsterLockId = null,
                    BBoxId = null,
                    WoodSorterId = null,
                    HandBrakeId = null,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = null
                },

                new Trailer
                {
                    Id = 2,
                    Name = "PALMS 8SX",
                    Description = "A PALMS 8SX egyetlen gerendával rendelkező erdészeti utánfutó, amelynek nominális teherbírása 8 tonna. Ez a modell népszerű választás számos kis erdőbirtokos és gazdálkodó körében. Az utánfutó egyszerű, mégis robosztus kialakítása és tartóssága megbízható társává teszi különböző erdészeti és mezőgazdasági feladatokban.",
                    Price = "",
                    LoadingAreaCross = "2",
                    LoadingAreaLength = "3550",
                    FrameExtensionLength = "0,61",
                    GrossWeight = "10000",
                    CurbWeight = "1180",
                    TotalLength = "5690",
                    WidthWithStandardWheels = "2070",
                    StandardWheelSize = "400/60-15,5",
                    MaxCraneSize = "47",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Single,
                    Frame = "160x160x8",
                    BolsterLockId = 1,
                    BBoxId = 1,
                    WoodSorterId = 1,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 2
                },

                new Trailer
                {
                    Id = 3,
                    Name = "PALMS 8D",
                    Description = "A PALMS 8D, amelynek nominális teherbírása 8 tonna, a legkompaktabb két gerendás utánfutó a termékpalettánkban. Azoknak a felhasználóknak terveztük, akik könnyebb utánfutót keresnek, de mégis szeretnének egy két gerendás utánfutó nagyobb szilárdságát és merevségét.",
                    Price = "",
                    LoadingAreaCross = "1,95",
                    LoadingAreaLength = "3975",
                    FrameExtensionLength = "0,85",
                    GrossWeight = "10000",
                    CurbWeight = "1510",
                    TotalLength = "6200",
                    WidthWithStandardWheels = "2095",
                    StandardWheelSize = "400/60-15,5",
                    MaxCraneSize = "85",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Double,
                    Frame = "2x200x100x8",
                    BolsterLockId = 1,
                    BBoxId = 1,
                    WoodSorterId = 1,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 1
                }
            );
        }
    }
}
