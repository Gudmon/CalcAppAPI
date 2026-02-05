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
                    Name = "Hidraulikus fék 4 keréken",
                    Code = "",
                    Price = "0",
                },
                new KrpanBrake
                {
                    Id = 2,
                    Name = "Pneumatikus fék 4 keréken",
                    Code = "",
                    Price = "2160",
                },
                new KrpanBrake
                {
                    Id = 3,
                    Name = "Kombinált fék 4 keréken (hidraulikus és ráfutófék)",
                    Code = "",
                    Price = "2160",
                },
                new KrpanBrake
                {
                    Id = 4,
                    Name = "Kombinált fék 4 keréken (hidraulikus és pneumatikus)",
                    Code = "",
                    Price = "4140",
                }
                );
        }
    }
}
