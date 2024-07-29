using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Trailers
{
    public static class KrpanDrawbarSteeringConfig
    {
        public static void ConfigureMultipleKrpanDrawbarSteerings(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanDrawbarSteering>().HasData(
                new KrpanDrawbarSteering
                {
                    Id = 1,
                    Name = "Vonórúd kormányzás + 40°",
                    Code = "",
                    Price = "0",
                }
                );
        }
    }
}
