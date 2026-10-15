using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanBrakeConfig
    {
        public static void ConfigureMultipleKrpanBrakes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanBrake>().HasData(
                new KrpanBrake
                {
                    Id = 1,
                    Name = "Hidraulikus fék 2 keréken",
                    Code = "",
                    Price = "0",
                },
                new KrpanBrake
                {
                    Id = 2,
                    Name = "Hidraulikus fék 4 keréken",
                    Code = "",
                    Price = "0",
                },
                new KrpanBrake
                {
                    Id = 3,
                    Name = "Hidraulikus fék 4 keréken",
                    Code = "",
                    Price = "383,33",
                },
                new KrpanBrake
                {
                    Id = 4,
                    Name = "Hidraulikus fék vészfék funkcióval",
                    Code = "",
                    Price = "620,00",
                },
                new KrpanBrake
                {
                    Id = 5,
                    Name = "Hidraulikus + ráfutófék 4 keréken",
                    Code = "",
                    Price = "1620,00",
                },
                new KrpanBrake
                {
                    Id = 6,
                    Name = "Pneumatikus fék 4 keréken",
                    Code = "",
                    Price = "1620,00",
                },
                new KrpanBrake
                {
                    Id = 7,
                    Name = "Hidraulikus fék vészfék funkcióval",
                    Code = "",
                    Price = "562,50",
                },
                new KrpanBrake
                {
                    Id = 8,
                    Name = "Kétkörös hidraulikus fékrendszer",
                    Code = "",
                    Price = "2884,00",
                },
                new KrpanBrake
                {
                    Id = 9,
                    Name = "Ráfutófék",
                    Code = "",
                    Price = "2118,33",
                },
                new KrpanBrake
                {
                    Id = 10,
                    Name = "Pneumatikus fék 4 keréken",
                    Code = "",
                    Price = "1722,00",
                },
                new KrpanBrake
                {
                    Id = 11,
                    Name = "Kombinált fék 4 keréken (hidraulikus + pneumatikus)",
                    Code = "",
                    Price = "3166,00",
                }
                );
        }
    }
}
