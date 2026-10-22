using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanDrawbarSteeringConfig
    {
        public static void ConfigureMultipleKrpanDrawbarSteerings(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanDrawbarSteering>().HasData(
                new KrpanDrawbarSteering
                {
                    Id = 1,
                    Name = "Vonórúd kormányzási szöge ± 35˚",
                    Code = "",
                    Price = "0",
                },
                new KrpanDrawbarSteering
                {
                    Id = 2,
                    Name = "Vonórúd kormányzási szöge ± 40˚",
                    Code = "",
                    Price = "0",
                }
                );
        }
    }
}
