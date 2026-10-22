using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanFrameConfig
    {
        public static void ConfigureMultipleKrpanFrames(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanFrame>().HasData(
                new KrpanFrame
                {
                    Id = 1,
                    Name = "Hidraulikus keretállítás (600 mm)",
                    Code = "",
                    Price = "0",
                },
                new KrpanFrame
                {
                    Id = 2,
                    Name = "Fix keret",
                    Code = "",
                    Price = "0",
                },
                new KrpanFrame
                {
                    Id = 3,
                    Name = "Mechanikusan állítható keret",
                    Code = "",
                    Price = "0",
                }
                );
        }
    }
}
