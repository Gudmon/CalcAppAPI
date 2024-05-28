using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Trailers
{
    public static class KrpanTyreConfig
    {
        public static void ConfigureMultipleKrpanTyres(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanTyre>().HasData(
                new KrpanTyre
                {
                    Id = 1,
                    Name = "400/60-15,5; 14 rétegű",
                    Code = "",
                    Price = "0",
                },
                new KrpanTyre
                {
                    Id = 2,
                    Name = "400/60-15,5; 18 rétegű",
                    Code = "",
                    Price = "0",
                },
                new KrpanTyre
                {
                    Id = 3,
                    Name = "480/45-17; 14 rétegű",
                    Code = "",
                    Price = "1435",
                },
                new KrpanTyre
                {
                    Id = 4,
                    Name = "500/50-17; 18 rétegű",
                    Code = "",
                    Price = "1435",
                },
                new KrpanTyre
                {
                    Id = 5,
                    Name = "550/45-22,5; 20 rétegű",
                    Code = "",
                    Price = "3050",
                },
                new KrpanTyre
                {
                    Id = 6,
                    Name = "400/55-22,5; 20 rétegű",
                    Code = "",
                    Price = "3050",
                }
                );
        }
    }
}
