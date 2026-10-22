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
                    Name = "A rakfelület-hosszabbítás teherbírásának megerősítése a markoló elhelyezéséhez",
                    Code = "300029549",
                    Price = "193,27",
                }
                );
        }
    }
}
