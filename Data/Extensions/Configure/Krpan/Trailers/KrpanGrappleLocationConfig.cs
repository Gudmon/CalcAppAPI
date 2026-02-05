using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanGrappleLocationConfig
    {
        public static void ConfigureMultipleKrpanGrappleLocations(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanGrappleLocation>().HasData(
                new KrpanGrappleLocation
                {
                    Id = 1,
                    Name = "Kanál lerakási helyének megerősítése",
                    Code = "",
                    Price = "180",
                }
                );
        }
    }
}
