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
                    LoadingAreaCross = "1.5",
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
                    Frame = "140x140x6"
                },

                new Trailer
                {
                    Id = 2,
                    Name = "PALMS 8SX",
                    Description = "PALMS 8SX is a single-beam forest trailer with a nominal load capacity of 8 tons. It stands as a popular choice among many small forest landowners and farmers. The trailer's simple yet robust construction and durability make it a reliable companion for various forestry and agricultural tasks.",
                    Price = "",
                    LoadingAreaCross = "2",
                    LoadingAreaLength = "3550",
                    FrameExtensionLength = "0.61",
                    GrossWeight = "10000",
                    CurbWeight = "1180",
                    TotalLength = "5690",
                    WidthWithStandardWheels = "2070",
                    StandardWheelSize = "400/60-15,5",
                    MaxCraneSize = "47",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Single,
                    Frame = "160x160x8"
                },

                new Trailer
                {
                    Id = 3,
                    Name = "PALMS 9SC",
                    Description = "PALMS 9SC is our largest single-beam trailer in the product lineup with a nominal load capacity of 9 tons. It is ideal for customers who prefer the simplicity of a single-beam trailer while requiring a longer reach from a forestry crane. This feature makes it a popular choice, for example, among arborists. Additionally, PALMS 9SC stands out in user convenience among other single-beam trailers with its drawbar quick-lock system and patented bolster locks.",
                    Price = "",
                    LoadingAreaCross = "2.15",
                    LoadingAreaLength = "3870",
                    FrameExtensionLength = "0.70",
                    GrossWeight = "12000",
                    CurbWeight = "1425",
                    TotalLength = "6095",
                    WidthWithStandardWheels = "2135",
                    StandardWheelSize = "400/60-15,5",
                    MaxCraneSize = "65",
                    DrawbarControlCylinders = "2",
                    BeamType = Static.BeamTypes.Single,
                    Frame = "200x200x8"
                }
            );
        }
    }
}
