using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanTyreConfig
    {
        public static void ConfigureMultipleKrpanTyres(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanTyre>().HasData(
                new KrpanTyre
                {
                    Id = 1,
                    Name = "300/80-15,3”; 14 rétegű",
                    Code = "",
                    Price = "0",
                },
                new KrpanTyre
                {
                    Id = 2,
                    Name = "400/60-15,5”; 16 rétegű",
                    Code = "",
                    Price = "0",
                },
                new KrpanTyre
                {
                    Id = 3,
                    Name = "400/60-15,5”; 18 rétegű (BKT)",
                    Code = "",
                    Price = "214,00",
                },
                new KrpanTyre
                {
                    Id = 4,
                    Name = "400/60-15,5”; 18 rétegű (BKT)",
                    Code = "",
                    Price = "883,00",
                },
                new KrpanTyre
                {
                    Id = 5,
                    Name = "400/55-22,5”; 16 rétegű (BKT)",
                    Code = "",
                    Price = "2347,00",
                },
                new KrpanTyre
                {
                    Id = 6,
                    Name = "480/45-17”; 14 rétegű",
                    Code = "",
                    Price = "1097,00",
                },
                new KrpanTyre
                {
                    Id = 7,
                    Name = "480/45-17”; 14 rétegű",
                    Code = "",
                    Price = "1084,23",
                },
                new KrpanTyre
                {
                    Id = 8,
                    Name = "500/50-17”; 18 rétegű",
                    Code = "",
                    Price = "1403,33",
                },
                new KrpanTyre
                {
                    Id = 9,
                    Name = "500/50-17”; 18 rétegű (BKT)",
                    Code = "",
                    Price = "1616,33",
                }, new KrpanTyre
                {
                    Id = 10,
                    Name = "550/45-22,5”; 20 rétegű",
                    Code = "",
                    Price = "2989,17",
                },
                new KrpanTyre
                {
                    Id = 11,
                    Name = "550/45-22,5”; Traktorprofilú",
                    Code = "",
                    Price = "4014,29",
                },
                new KrpanTyre
                {
                    Id = 12,
                    Name = "600/50-22,5”; 16 rétegű",
                    Code = "",
                    Price = "3460,99",
                }
                );
        }
    }
}
