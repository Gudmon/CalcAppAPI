using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Trailers
{
    public static class KrpanCargoSpaceExtensionConfig
    {
        public static void ConfigureMultipleKrpanCargoSpaceExtensions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanCargoSpaceExtension>().HasData(
                new KrpanCargoSpaceExtension
                {
                    Id = 1,
                    Name = "Raktér hosszabbítás (80 cm)",
                    Code = "300014961",
                    Price = "0",
                },
                new KrpanCargoSpaceExtension
                {
                    Id = 2,
                    Name = "Raktér hosszabbítás (80 cm)",
                    Code = "300014961",
                    Price = "490",
                }
                );
        }
    }
}
