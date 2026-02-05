using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanBaleTransportPlatformConfig
    {
        public static void ConfigureMultipleKrpanBaleTransportPlatforms(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanBaleTransportPlatform>().HasData(
                new KrpanBaleTransportPlatform
                {
                    Id = 1,
                    Name = "Platform bálaszállításhoz",
                    Code = "300014965",
                    Price = "1935",
                },
                new KrpanBaleTransportPlatform
                {
                    Id = 2,
                    Name = "Platform bálaszállításhoz",
                    Code = "300011152",
                    Price = "1935",
                },
                new KrpanBaleTransportPlatform
                {
                    Id = 3,
                    Name = "Platform bálaszállításhoz",
                    Code = "300011151",
                    Price = "1935",
                },
                new KrpanBaleTransportPlatform
                {
                    Id = 4,
                    Name = "Platform bálaszállításhoz",
                    Code = "300011149",
                    Price = "1935",
                }
                );
        }
    }
}
