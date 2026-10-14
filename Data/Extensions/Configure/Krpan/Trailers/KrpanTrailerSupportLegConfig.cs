using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanTrailerSupportLegConfig
    {
        public static void ConfigureMultipleKrpanTrailerSupportLegs(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanTrailerSupportLeg>().HasData(
                new KrpanTrailerSupportLeg
                {
                    Id = 1,
                    Name = "Mechanikus támasztóláb - fix",
                    Code = "",
                    Price = "0",
                },
                new KrpanTrailerSupportLeg
                {
                    Id = 2,
                    Name = "Mechanikus támasztóláb - állítható",
                    Code = "",
                    Price = "150,00",
                },
                new KrpanTrailerSupportLeg
                {
                    Id = 3,
                    Name = "Hidraulikus támasztóláb",
                    Code = "",
                    Price = "519,17",
                }
                );
        }
    }
}
