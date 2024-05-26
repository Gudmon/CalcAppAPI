﻿using CalcAppAPI.Models.Machine.Palms.Trailers;
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
                    Description = "A PALMS 6S egy egyalvázas erdészeti pótkocsi, melynek össztömege 8500 kg. Könnyű és kompakt kialakítása tökéletes választás kisebb traktorokhoz, ideális erdőgazdálkodáshoz és gazdálkodóknak. A PALMS 6S hasonló technológiákat használ, mint nagyobb pótkocsijaink, beleértve a magas minőségű KTL és porfestési bevonatot, ami hosszabb élettartamot és magasabb maradványértéket biztosít.",
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
                    UnderrunProtectionId = null,
                    BunkAdapterId = null,
                    BunkExtensionId = null,
                    FrameExtensionId = null,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
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
                    UnderrunProtectionId = 2,
                    BunkAdapterId = null,
                    BunkExtensionId = null,
                    FrameExtensionId = null,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 3,
                    Name = "PALMS 8D",
                    Description = "A PALMS 8D erdészeti pótkocsi, melynek össztömege 10000 kg. Ez a modell már duplaalvázas kivitelű, a legkompaktabb pótkocsi a kínálatunkban. Azoknak a felhasználóknak ajánljuk, akik könnyebb pótkocsit keresnek, de mégis már egy duplaalvázas kivitel nagyobb szilárdságát és merevségét szeretnék kihasználni.",
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
                    UnderrunProtectionId = 1,
                    BunkAdapterId = null,
                    BunkExtensionId = null,
                    FrameExtensionId = null,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 4,
                    Name = "PALMS 8DWD",
                    Description = "A PALMS 8DWD erdészeti pótkocsi, melynek össztömege 10000 kg. Ez a modell már duplaalvázas kivitelű, a legkompaktabb pótkocsi a kínálatunkban. Azoknak a felhasználóknak ajánljuk, akik könnyebb pótkocsit keresnek, de mégis már egy duplaalvázas kivitel nagyobb szilárdságát és merevségét szeretnék kihasználni, ugyanakkor a kétkerék hajtásnak köszönhetően mindenféle terepen megállja helyét.",
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
                    UnderrunProtectionId = 1,
                    BunkAdapterId = null,
                    BunkExtensionId = null,
                    FrameExtensionId = null,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 5,
                    Name = "PALMS 9SC",
                    Description = "A PALMS 9SC a termékpalettánk legnagyobb egyalvázas pótkocsija, össztömege 12000 kg. Ideális választás azoknak, akik preferálják az egyalvázas pótkocsi egyszerűségét, miközben hosszabb kinyúlást igényelnek egy erdészeti darutól. Emellett a Palms 9SC kiemelkedik a felhasználói kényelem terén más, szintén egyalvázas pótkocsik közül a csapszeges vonórúd zár megoldásával és a szabadalmaztatott rakonca rögzítéssel.",
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
                    UnderrunProtectionId = 2,
                    BunkAdapterId = null,
                    BunkExtensionId = null,
                    FrameExtensionId = null,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 6,
                    Name = "PALMS 10D",
                    Description = "A PALMS 10D duplaalvázas pótkocsi, melynek össztömege 13000 kg, az egyik legkeresettebb erdészeti pótkocsi a PALMS terméksorozatában. Kiválóan párosítható a legtöbb Palms daruval és egyéb kiegészítőkkel, lehetővé téve az egyéni igény szerinti felszereltséget, hogy olyan konstrukciót alkosson, amely pontosan megfelel az elvárásainak.",
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
                    UnderrunProtectionId = 1,
                    BunkAdapterId = null,
                    BunkExtensionId = null,
                    FrameExtensionId = null,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 7,
                    Name = "PALMS 10DWD",
                    Description = "A PALMS 10DWD duplaalvázas pótkocsi, melynek össztömege 12500 kg, és amely a 10D alapváltozathoz hasonlóan a másik legkeresettebb erdészeti pótkocsi a PALMS kínálatában. Szintén jól párosítható a legtöbb Palms daruval és egyéb kiegészítőkkel, ugyanakkor viszont olyan kétkerék hajtással ellátott változat, mely nemcsak igény szerinti, kiváló konstrukciót jelent, hanem kiváló közlekedést biztosít mindenfajta terepen és emellett természetesen elvárásainak is mindenben megfelel.",
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
                    UnderrunProtectionId = 1,
                    BunkAdapterId = null,
                    BunkExtensionId = null,
                    FrameExtensionId = null,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 8,
                    Name = "PALMS 12D",
                    Description = "A PALMS 12D duplaalvázas erdészeti pótkocsi, melynek összetömege 15000 kg. Akár mindennapi, akár nagyobb munkálatok elvégzésére is kiválóan alkalmas, nagyszerű kompatibilitás nyújtva a Palms 5-ös és 7-es szériás daruival.  ",
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
                    UnderrunProtectionId = 1,
                    BunkAdapterId = null,
                    BunkExtensionId = null,
                    FrameExtensionId = null,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 9,
                    Name = "PALMS 12DWD",
                    Description = "A PALMS 12DWD duplaalvázas erdészeti pótkocsi, melynek összetömege 15000 kg. Akár mindennapi, akár nagyobb munkálatok elvégzésére is kiválóan alkalmas, nagyszerű kompatibilitás nyújtva a Palms 5-ös és 7-es szériás daruival. Ennek a modellnek az előnye, hogy kétkerék hajtással rendelkezik, amely alkalmassá teszi, hogy bármilyen talajviszonyok között kiváló teljesítményt nyújtson a kiközelítés során.",
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
                    UnderrunProtectionId = 1,
                    BunkAdapterId = null,
                    BunkExtensionId = null,
                    FrameExtensionId = null,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 10,
                    Name = "PALMS 14D",
                    Description = "A PALMS 14D a Palms gyár termékkínálatának legnagyobb dupla alvázas pótkocsija, jelentős, 18000 kg össztömegével. Nemcsak a legnagyobb rakfelülettel rendelkezik, hanem kiterjesztett rakfelületet kínál más dupla alvázas pótkocsikhoz képest. További előnye, hogy kompatibilis a Palms legnagyobb, legprofibb erdészeti darujával, az X100-sal is. ",
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
                    UnderrunProtectionId = 1,
                    BunkAdapterId = null,
                    BunkExtensionId = null,
                    FrameExtensionId = null,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 11,
                    Name = "PALMS 14DWD",
                    Description = "A PALMS 14DWD a Palms gyár termékkínálatának legnagyobb dupla alvázas pótkocsija, jelentős, 18000 kg össztömegével. Nemcsak a legnagyobb rakfelülettel rendelkezik, hanem kiterjesztett rakfelületet kínál más dupla alvázas pótkocsikhoz képest. További előnye, hogy kompatibilis a Palms legnagyobb, legprofibb erdészeti darujával, az X100-sal is. Ugyanakkor ez a kétkerék hajtással is ellátott változat alkalmas az összes, akár extrém terepviszony leküzdésére is.",
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
                    UnderrunProtectionId = 1,
                    BunkAdapterId = null,
                    BunkExtensionId = null,
                    FrameExtensionId = null,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 12,
                    Name = "PALMS 10U",
                    Description = "A PALMS 10U erdészeti pótkocsi az U-sorozat legkisebb változata, mely a duplaalvázas kivitel mellett az úgynevezett unibody típusú rakoncákkal van szerelve. Össztömege 15000 kg. Nagy hasmagassága és az unibody keret csökkenti az elakadás kockázatát. A hidraulikus alkatrészek az unibody keretben vannak elhelyezve, védve ezzel azokat, mégis könnyű hozzáférést biztosít a karbantartáshoz. ",
                    Price = "",
                    LoadingAreaCross = "2.4",
                    LoadingAreaLength = "3990",
                    FrameExtensionLength = "1,085",
                    GrossWeight = "15000",
                    CurbWeight = "2170",
                    TotalLength = "6215",
                    WidthWithStandardWheels = "2245",
                    StandardWheelSize = "500/50-17",
                    MaxCraneSize = "120",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Unibody,
                    Frame = "unibody",
                    TrailerOilCoolerId = 1,
                    BolsterLockId = 1,
                    BBoxId = 2,
                    WoodSorterId = null,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 2,
                    BunkAdapterId = 1,
                    BunkExtensionId = null,
                    FrameExtensionId = 1,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 13,
                    Name = "PALMS 10UWD",
                    Description = "A PALMS 10UWD erdészeti pótkocsi az U-sorozat legkisebb változata, mely a duplaalvázas kivitel mellett az úgynevezett unibody típusú rakoncákkal van szerelve. Össztömege 15000 kg. Nagy hasmagassága és az unibody keret csökkenti az elakadás kockázatát. A hidraulikus alkatrészek az unibody keretben vannak elhelyezve, védve ezzel azokat, mégis könnyű hozzáférést biztosít a karbantartáshoz. Az UWD változat kétkerék hajtással is rendelkezik, mely által a terepviszonyok is kiválóan kezelhetők.  ",
                    Price = "",
                    LoadingAreaCross = "2.4",
                    LoadingAreaLength = "3990",
                    FrameExtensionLength = "1,085",
                    GrossWeight = "15000",
                    CurbWeight = "2170",
                    TotalLength = "6215",
                    WidthWithStandardWheels = "2245",
                    StandardWheelSize = "500/50-17",
                    MaxCraneSize = "120",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Unibody,
                    Frame = "unibody",
                    TrailerOilCoolerId = 1,
                    BolsterLockId = 1,
                    BBoxId = 2,
                    WoodSorterId = null,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 2,
                    BunkAdapterId = 1,
                    BunkExtensionId = null,
                    FrameExtensionId = 1,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 14,
                    Name = "PALMS 12U",
                    Description = "A PALMS 12U pótkocsi össztömege 17000 kg, unibody típusú erdészeti pótkocsi, melyet kifejezetten a mindennapi, szakmai erdészeti munkákhoz terveztek. Magas hasmagassággal rendelkezik, ez és a forwarder típusú keret elősegíti, hogy az elakadás kockázata minél kisebb legyen. Mivel az összes hidraulikus alkatrész ebben a keretben került elhelyezésre, így azok védve vannak, ugyanakkor viszont könnyű hozzáférhetőség biztosítja a karbantartás elvégzését.",
                    Price = "",
                    LoadingAreaCross = "2.75",
                    LoadingAreaLength = "3990",
                    FrameExtensionLength = "1,085",
                    GrossWeight = "17000",
                    CurbWeight = "2270",
                    TotalLength = "6215",
                    WidthWithStandardWheels = "2245",
                    StandardWheelSize = "500/50-22,5",
                    MaxCraneSize = "120",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Unibody,
                    Frame = "unibody",
                    TrailerOilCoolerId = 1,
                    BolsterLockId = 1,
                    BBoxId = 2,
                    WoodSorterId = null,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 2,
                    BunkAdapterId = 1,
                    BunkExtensionId = null,
                    FrameExtensionId = 1,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 15,
                    Name = "PALMS 12UWD",
                    Description = "A PALMS 12UWD pótkocsi össztömege 17000 kg, unibody típusú erdészeti pótkocsi, melyet kifejezetten a mindennapi, szakmai erdészeti munkákhoz terveztek. Magas hasmagassággal rendelkezik, ez és a forwarder típusú keret elősegíti, hogy az elakadás kockázata minél kisebb legyen. Mivel az összes hidraulikus alkatrész ebben a keretben került elhelyezésre, így azok védve vannak, ugyanakkor viszont könnyű hozzáférhetőség biztosítja a karbantartás elvégzését. Ennek a típusnak további előnye, hogy kétkerék hajtással rendelkezik, amely alkalmassá teszi arra, hogy akár extrém talajviszonyok között is megállja a helyét. ",
                    Price = "",
                    LoadingAreaCross = "2.75",
                    LoadingAreaLength = "3990",
                    FrameExtensionLength = "1,085",
                    GrossWeight = "17000",
                    CurbWeight = "2270",
                    TotalLength = "6215",
                    WidthWithStandardWheels = "2245",
                    StandardWheelSize = "500/50-22,5",
                    MaxCraneSize = "120",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Unibody,
                    Frame = "unibody",
                    TrailerOilCoolerId = 1,
                    BolsterLockId = 1,
                    BBoxId = 2,
                    WoodSorterId = null,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 2,
                    BunkAdapterId = 1,
                    BunkExtensionId = null,
                    FrameExtensionId = 1,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 16,
                    Name = "PALMS 12UAWD",
                    Description = "A PALMS 12UAWD pótkocsi össztömege 17000 kg, unibody típusú erdészeti pótkocsi, melyet kifejezetten a mindennapi, szakmai erdészeti munkákhoz terveztek. Magas hasmagassággal rendelkezik, ez és a forwarder típusú keret elősegíti, hogy az elakadás kockázata minél kisebb legyen. Mivel az összes hidraulikus alkatrész ebben a keretben került elhelyezésre, így azok védve vannak, ugyanakkor viszont könnyű hozzáférhetőség biztosítja a karbantartás elvégzését. Ennek a típusnak további előnye, hogy négykerék hajtással rendelkezik, amely alkalmassá teszi arra, hogy akár extrém talajviszonyok között is megállja a helyét. ",
                    Price = "",
                    LoadingAreaCross = "2.75",
                    LoadingAreaLength = "3990",
                    FrameExtensionLength = "1,085",
                    GrossWeight = "17000",
                    CurbWeight = "2270",
                    TotalLength = "6215",
                    WidthWithStandardWheels = "2245",
                    StandardWheelSize = "500/50-22,5",
                    MaxCraneSize = "120",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Unibody,
                    Frame = "unibody",
                    TrailerOilCoolerId = 1,
                    BolsterLockId = 1,
                    BBoxId = 2,
                    WoodSorterId = null,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 2,
                    BunkAdapterId = 1,
                    BunkExtensionId = null,
                    FrameExtensionId = 1,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 17,
                    Name = "PALMS 15U",
                    Description = "A PALMS 15U pótkocsi a legnagyobb a Palms U típusú pótkocsi kínálatában, össztömege 19000 kg. Az U pótkocsikat nehéz fakitermelésre tervezték, a kialakításának köszönhetően tartósak és igazán nagy terheket képesek vinni. Ez a pótkocsi nagysága ellenére igen könnyen mozog, gumikerekes kivitele környezetkímélő. Nagyobb mennyiségű fa kitermelésére alkalmas, megkönnyíti az erdészeti munkát. Nagy hasmagassággal rendelkezik, ez és a forwarder típusú keret az elakadás kockázatát csökkentik. A hidraulikus alkatrészek a keretben kerültek elhelyezésre, hogy védettek legyenek a külső behatás ellen, ugyanakkor karbantartásilag könnyen elérhetők. ",
                    Price = "",
                    LoadingAreaCross = "3.2",
                    LoadingAreaLength = "4175",
                    FrameExtensionLength = "1,085",
                    GrossWeight = "19000",
                    CurbWeight = "2545",
                    TotalLength = "6415",
                    WidthWithStandardWheels = "2450",
                    StandardWheelSize = "500/50-22,5",
                    MaxCraneSize = "120",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Unibody,
                    Frame = "unibody",
                    TrailerOilCoolerId = 1,
                    BolsterLockId = 1,
                    BBoxId = 3,
                    WoodSorterId = null,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 2,
                    BunkAdapterId = 1,
                    BunkExtensionId = 1,
                    FrameExtensionId = 1,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 18,
                    Name = "PALMS 15UWD",
                    Description = "A PALMS 15U pótkocsi a legnagyobb a Palms U típusú pótkocsi kínálatában, össztömege 19000 kg. Az U pótkocsikat nehéz fakitermelésre tervezték, a kialakításának köszönhetően tartósak és igazán nagy terheket képesek vinni. Ez a pótkocsi nagysága ellenére igen könnyen mozog, gumikerekes kivitele környezetkímélő. Nagyobb mennyiségű fa kitermelésére alkalmas, megkönnyíti az erdészeti munkát. Nagy hasmagassággal rendelkezik, ez és a forwarder típusú keret az elakadás kockázatát csökkentik. A hidraulikus alkatrészek a keretben kerültek elhelyezésre, hogy védettek legyenek a külső behatás ellen, ugyanakkor karbantartásilag könnyen elérhetők. Ez a típus kétkerék hajtással is rendelkezik, mely által mindenféle terepen könnyen mozgatható.",
                    Price = "",
                    LoadingAreaCross = "3.2",
                    LoadingAreaLength = "4175",
                    FrameExtensionLength = "1,085",
                    GrossWeight = "19000",
                    CurbWeight = "2545",
                    TotalLength = "6415",
                    WidthWithStandardWheels = "2450",
                    StandardWheelSize = "500/50-22,5",
                    MaxCraneSize = "120",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Unibody,
                    Frame = "unibody",
                    TrailerOilCoolerId = 1,
                    BolsterLockId = 1,
                    BBoxId = 3,
                    WoodSorterId = null,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 2,
                    BunkAdapterId = 1,
                    BunkExtensionId = 1,
                    FrameExtensionId = 1,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 19,
                    Name = "PALMS 15UAWD",
                    Description = "A PALMS 15U pótkocsi a legnagyobb a Palms U típusú pótkocsi kínálatában, össztömege 19000 kg. Az U pótkocsikat nehéz fakitermelésre tervezték, a kialakításának köszönhetően tartósak és igazán nagy terheket képesek vinni. Ez a pótkocsi nagysága ellenére igen könnyen mozog, gumikerekes kivitele környezetkímélő. Nagyobb mennyiségű fa kitermelésére alkalmas, megkönnyíti az erdészeti munkát. Nagy hasmagassággal rendelkezik, ez és a forwarder típusú keret az elakadás kockázatát csökkentik. A hidraulikus alkatrészek a keretben kerültek elhelyezésre, hogy védettek legyenek a külső behatás ellen, ugyanakkor karbantartásilag könnyen elérhetők. Ez a típus már négykerék hajtással rendelkezik, ezáltal bármilyen tereppel könnyedén megbirkózik.",
                    Price = "",
                    LoadingAreaCross = "3.2",
                    LoadingAreaLength = "4175",
                    FrameExtensionLength = "1,085",
                    GrossWeight = "19000",
                    CurbWeight = "2545",
                    TotalLength = "6415",
                    WidthWithStandardWheels = "2450",
                    StandardWheelSize = "500/50-22,5",
                    MaxCraneSize = "120",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Unibody,
                    Frame = "unibody",
                    TrailerOilCoolerId = 1,
                    BolsterLockId = 1,
                    BBoxId = 3,
                    WoodSorterId = null,
                    HandBrakeId = 1,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = 2,
                    BunkAdapterId = 1,
                    BunkExtensionId = 1,
                    FrameExtensionId = 1,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 20,
                    Name = "PALMS MWD 3.2",
                    Description = "Ismerje meg a PALMS MWD sorozatú forwarder típusú pótkocsit, amelyet a legnehezebb terepek legyőzésére terveztek. Az összes MWD pótkocsi mechanikus áttétele egyedileg lesz testre szabva minden ügyfelünk traktorához.",
                    Price = "",
                    LoadingAreaCross = "3.2",
                    LoadingAreaLength = "4235",
                    FrameExtensionLength = "1.085",
                    GrossWeight = "18000",
                    CurbWeight = "4700",
                    TotalLength = "6430",
                    WidthWithStandardWheels = "2470",
                    StandardWheelSize = "600/50x22.5",
                    MaxCraneSize = "120",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Unibody,
                    Frame = "unibody",
                    TrailerOilCoolerId = null,
                    BolsterLockId = null,
                    BBoxId = 4,
                    WoodSorterId = null,
                    HandBrakeId = null,
                    ChainsawHolderId = null,
                    UnderrunProtectionId = null,
                    BunkAdapterId = 2,
                    BunkExtensionId = 2,
                    FrameExtensionId = null,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = 1,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 21,
                    Name = "PALMS HMWD 3.2",
                    Description = "Ismerje meg a PALMS hidromechanikus meghajtású pótkocsiját, amelyet a legnehezebb terepek legyőzésére terveztek. A hidromechanikus 4x4 rendszer alkalmas minden méretű traktorhoz, amelynek TLT hajtása van.",
                    Price = "",
                    LoadingAreaCross = "3.2",
                    LoadingAreaLength = "4185",
                    FrameExtensionLength = "1.085",
                    GrossWeight = "18000",
                    CurbWeight = "4920",
                    TotalLength = "6430",
                    WidthWithStandardWheels = "2470",
                    StandardWheelSize = "600/50x22.5",
                    MaxCraneSize = "120",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Unibody,
                    Frame = "unibody",
                    TrailerOilCoolerId = 2,
                    BolsterLockId = null,
                    BBoxId = 4,
                    WoodSorterId = null,
                    HandBrakeId = null,
                    ChainsawHolderId = null,
                    UnderrunProtectionId = null,
                    BunkAdapterId = 2,
                    BunkExtensionId = 2,
                    FrameExtensionId = null,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = 1,
                    HydroPackId = null,
                },

                new Trailer
                {
                    Id = 22,
                    Name = "PALMS 2D",
                    Description = "Tökéletes kompakt traktorokhoz és terepjárókhoz. Strenx Performance acélból készült strapabíró duplaalvázzal, fokozott korrózióállósággal (KTL+por bevonatt), valamint 1500 kg névleges teherbírással rendelkezik.",
                    Price = "",
                    LoadingAreaCross = "0,6",
                    LoadingAreaLength = "2450",
                    FrameExtensionLength = "-",
                    GrossWeight = "1500",
                    CurbWeight = "260",
                    TotalLength = "3865",
                    WidthWithStandardWheels = "1285",
                    StandardWheelSize = "22/11-8",
                    MaxCraneSize = "12",
                    DrawbarControlCylinders = "1",
                    BeamType = Static.BeamTypes.Double,
                    Frame = "2x4 mm C-alváz",
                    TrailerOilCoolerId = null,
                    BolsterLockId = null,
                    BBoxId = 5,
                    WoodSorterId = null,
                    HandBrakeId = null,
                    ChainsawHolderId = 1,
                    UnderrunProtectionId = null,
                    BunkAdapterId = null,
                    BunkExtensionId = null,
                    FrameExtensionId = null,
                    ShippingId = 1,
                    MOTId = 1,
                    StanchionExtensionId = null,
                    HydroPackId = 1,
                }
            );
        }
    }
}
