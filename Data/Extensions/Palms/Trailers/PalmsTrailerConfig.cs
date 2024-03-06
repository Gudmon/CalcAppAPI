﻿using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
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
                    Description = "A PALMS 6S egy egyalvázas erdészeti pótkocsi, melynek össztömege 8500 kg. Könnyű és kompakt kialakítása tökéletes választás kisebb traktorokhoz, ideális erdőgazdálkodáshoz és gazdálkodóknak. A PALMS 6S hasonló technológiákat használ, mint nagyobb pótkocsijaink, beleértve a magas minőségű KTL és porfestési bevonatot, ami hosszabb élettartamot és nagyobb újraértékesítési értéket biztosít.",
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
                    TrailerOilCoolerId = 1,
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
                    Description = "A PALMS 8SX egy egyalvázas erdészeti pótkocsi, amelynek össztömege 10.000 kg. Ez a modell népszerű választás számos kis erdőbirtokos és gazdálkodó körében. A pótkocsi egyszerű, mégis robusztus kialakítása és tartóssága megbízható társává teszi különböző erdészeti és mezőgazdasági feladatokban.",
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
                    TrailerOilCoolerId = 1,
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
                    TrailerOilCoolerId = 1,
                    BolsterLockId = 1,
                    BBoxId = 1,
                    WoodSorterId = 1,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 1
                },

                new Trailer
                {
                    Id = 4,
                    Name = "PALMS 8DWD",
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
                    TrailerOilCoolerId = 1,
                    BolsterLockId = 1,
                    BBoxId = 1,
                    WoodSorterId = 1,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 1
                },

                new Trailer
                {
                    Id = 5,
                    Name = "PALMS 9SC",
                    Description = "A PALMS 9SC a termékpalettánk legnagyobb egygerendás utánfutója, 9 tonnás nominális teherbírással. Ideális választás azoknak a vásárlóknak, akik preferálják az egygerendás utánfutó egyszerűségét, miközben hosszabb hatótávot igényelnek egy erdészeti darutól. Ez a jellemző például népszerűvé teszi arboristák körében. Emellett a PALMS 9SC kiemelkedik a felhasználói kényelem terén más egygerendás utánfutók közül, gyorszárú vontatókar rendszerével és szabadalmaztatott tengelyzárjaival.",
                    Price = "",
                    LoadingAreaCross = "2,15",
                    LoadingAreaLength = "3870",
                    FrameExtensionLength = "0,70",
                    GrossWeight = "12000",
                    CurbWeight = "1425",
                    TotalLength = "6095",
                    WidthWithStandardWheels = "2135",
                    StandardWheelSize = "400/60-15,5",
                    MaxCraneSize = "65",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Single,
                    Frame = "200x200x6",
                    TrailerOilCoolerId = 1,
                    BolsterLockId = 1,
                    BBoxId = 1,
                    WoodSorterId = 1,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 2
                },

                new Trailer
                {
                    Id = 6,
                    Name = "PALMS 10D",
                    Description = "A PALMS 10D, dupla gerendás vázú és 10 tonnás nominális teherbírású, az egyik legkelendőbb erdészeti utánfutó a PALMS terméksorozatában. Kiválóan párosítható a legtöbb PALMS daruval és további felszereléssel, lehetővé téve a testreszabást, hogy olyan beállítást hozzon létre, amely pontosan megfelel az elvárásainak.",
                    Price = "",
                    LoadingAreaCross = "2,4",
                    LoadingAreaLength = "3975",
                    FrameExtensionLength = "0,85",
                    GrossWeight = "13000",
                    CurbWeight = "1765",
                    TotalLength = "6200",
                    WidthWithStandardWheels = "2165",
                    StandardWheelSize = "400/60-15,5",
                    MaxCraneSize = "85",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Double,
                    Frame = "2x200x100x8",
                    TrailerOilCoolerId = 1,
                    BolsterLockId = 1,
                    BBoxId = 1,
                    WoodSorterId = 1,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 1
                },

                new Trailer
                {
                    Id = 7,
                    Name = "PALMS 10DWD",
                    Description = "A PALMS 10D, dupla gerendás vázú és 10 tonnás nominális teherbírású, az egyik legkelendőbb erdészeti utánfutó a PALMS terméksorozatában. Kiválóan párosítható a legtöbb PALMS daruval és további felszereléssel, lehetővé téve a testreszabást, hogy olyan beállítást hozzon létre, amely pontosan megfelel az elvárásainak.",
                    Price = "",
                    LoadingAreaCross = "2,4",
                    LoadingAreaLength = "3975",
                    FrameExtensionLength = "0,85",
                    GrossWeight = "12500",
                    CurbWeight = "1765",
                    TotalLength = "6200",
                    WidthWithStandardWheels = "2165",
                    StandardWheelSize = "400/60-15,5",
                    MaxCraneSize = "85",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Double,
                    Frame = "2x200x100x8",
                    TrailerOilCoolerId = 1,
                    BolsterLockId = 1,
                    BBoxId = 1,
                    WoodSorterId = 1,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 1
                },

                new Trailer
                {
                    Id = 8,
                    Name = "PALMS 12D",
                    Description = "A PALMS 12D egy erdészeti utánfutó, 12 tonnás nominális teherbírással és dupla gerendás vázzal. Kiváló választás mindennapi erdészeti feladatokhoz, nagyszerű kompatibilitást nyújtva a PALMS ötödik és hetedik sorozatú daruival.",
                    Price = "",
                    LoadingAreaCross = "2,7",
                    LoadingAreaLength = "3975",
                    FrameExtensionLength = "0,85",
                    GrossWeight = "15000",
                    CurbWeight = "2030",
                    TotalLength = "6200",
                    WidthWithStandardWheels = "2350",
                    StandardWheelSize = "500/50-17",
                    MaxCraneSize = "85",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Double,
                    Frame = "2x200x100x8",
                    TrailerOilCoolerId = 1,
                    BolsterLockId = 1,
                    BBoxId = 1,
                    WoodSorterId = 1,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 1
                },

                new Trailer
                {
                    Id = 9,
                    Name = "PALMS 12DWD",
                    Description = "A PALMS 12D egy erdészeti utánfutó, 12 tonnás nominális teherbírással és dupla gerendás vázzal. Kiváló választás mindennapi erdészeti feladatokhoz, nagyszerű kompatibilitást nyújtva a PALMS ötödik és hetedik sorozatú daruival.",
                    Price = "",
                    LoadingAreaCross = "2,7",
                    LoadingAreaLength = "3975",
                    FrameExtensionLength = "0,85",
                    GrossWeight = "15000",
                    CurbWeight = "2030",
                    TotalLength = "6200",
                    WidthWithStandardWheels = "2350",
                    StandardWheelSize = "500/50-17",
                    MaxCraneSize = "85",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Double,
                    Frame = "2x200x100x8",
                    TrailerOilCoolerId = 1,
                    BolsterLockId = 1,
                    BBoxId = 1,
                    WoodSorterId = 1,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 1
                },

                new Trailer
                {
                    Id = 10,
                    Name = "PALMS 14D",
                    Description = "A PALMS 14D a PALMS palettájának legnagyobb dupla gerendás utánfutója, jelentős 14 tonnás nominális teherbírással. A PALMS 14D nemcsak nagyobb terhelési területtel rendelkezik, hanem kiterjesztett terhelési területet is kínál más dupla gerendás utánfutókkal összehasonlítva. Emellett ez az utánfutó kompatibilis a PALMS zászlóshajójával, az X100-as erdészeti daruval.",
                    Price = "",
                    LoadingAreaCross = "3,0",
                    LoadingAreaLength = "4080",
                    FrameExtensionLength = "0,86",
                    GrossWeight = "18000",
                    CurbWeight = "2375",
                    TotalLength = "6300",
                    WidthWithStandardWheels = "2450",
                    StandardWheelSize = "500/50-17",
                    MaxCraneSize = "112",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Double,
                    Frame = "2x200x120x10",
                    TrailerOilCoolerId = 1,
                    BolsterLockId = 1,
                    BBoxId = 1,
                    WoodSorterId = 1,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 1
                },

                new Trailer
                {
                    Id = 11,
                    Name = "PALMS 14DWD",
                    Description = "A PALMS 14D a PALMS palettájának legnagyobb dupla gerendás utánfutója, jelentős 14 tonnás nominális teherbírással. A PALMS 14D nemcsak nagyobb terhelési területtel rendelkezik, hanem kiterjesztett terhelési területet is kínál más dupla gerendás utánfutókkal összehasonlítva. Emellett ez az utánfutó kompatibilis a PALMS zászlóshajójával, az X100-as erdészeti daruval.",
                    Price = "",
                    LoadingAreaCross = "3,0",
                    LoadingAreaLength = "4080",
                    FrameExtensionLength = "0,86",
                    GrossWeight = "18000",
                    CurbWeight = "2375",
                    TotalLength = "6300",
                    WidthWithStandardWheels = "2450",
                    StandardWheelSize = "500/50-17",
                    MaxCraneSize = "112",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Double,
                    Frame = "2x200x120x10",
                    TrailerOilCoolerId = 1,
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
