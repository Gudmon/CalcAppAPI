using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanPropulsionConfig
    {
        public static void ConfigureMultipleKrpanPropulsions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanPropulsion>().HasData(
                new KrpanPropulsion
                {
                    Id = 1,
                    Name = "2 WD (BB4, 400/60-15,5 vagy 500/50-17 gumimérethez)",
                    Code = "",
                    Price = "9875",
                },
                new KrpanPropulsion
                {
                    Id = 2,
                    Name = "2 WD (BB5, 550/45-22,5 vagy 400/55-22,5 gumimérethez)",
                    Code = "",
                    Price = "12355",
                },
                new KrpanPropulsion
                {
                    Id = 3,
                    Name = "4 WD (BB4, 400/60-15,5 vagy 500/50-17 gumimérethez)",
                    Code = "",
                    Price = "21210",
                },
                new KrpanPropulsion
                {
                    Id = 4,
                    Name = "4 WD (BB5, 550/45-22,5 vagy 400/55-22,5 gumimérethez)",
                    Code = "",
                    Price = "26165",
                }
                );
        }
    }
}
