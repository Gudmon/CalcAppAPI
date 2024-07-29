using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Trailers
{
    public static class KrpanTrailerSupportLegConfig
    {
        public static void ConfigureMultipleKrpanTrailerSupportLegs(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanTrailerSupportLeg>().HasData(
                new KrpanTrailerSupportLeg
                {
                    Id = 1,
                    Name = "Kitámasztó láb",
                    Code = "",
                    Price = "0",
                }
                );
        }
    }
}
