using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Trailers
{
    public static class KrpanTrailerLampConfig
    {
        public static void ConfigureMultipleKrpanTrailerLamps(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanTrailerLamp>().HasData(
                new KrpanTrailerLamp
                {
                    Id = 1,
                    Name = "Lámpa",
                    Code = "",
                    Price = "0",
                }
                );
        }
    }
}
