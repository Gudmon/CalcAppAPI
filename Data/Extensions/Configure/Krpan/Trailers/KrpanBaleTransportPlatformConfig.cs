using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanBaleTransportPlatformConfig
    {
        public static void ConfigureMultipleKrpanBaleTransportPlatforms(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanBaleTransportPlatform>().HasData(
                // GP 8/9/10 DF
                new KrpanBaleTransportPlatform
                {
                    Id = 1,
                    Name = "Platform bálaszállításhoz",
                    Code = "300014965",
                    Price = "1897,50",
                },
                // GP 11 D
                new KrpanBaleTransportPlatform
                {
                    Id = 2,
                    Name = "Platform bálaszállításhoz",
                    Code = "300011152",
                    Price = "1897,50",
                },
                // GP 12 DF
                new KrpanBaleTransportPlatform
                {
                    Id = 3,
                    Name = "Platform bálaszállításhoz",
                    Code = "300023127",
                    Price = "1897,50",
                },
                // GP 14 DF
                new KrpanBaleTransportPlatform
                {
                    Id = 4,
                    Name = "Platform bálaszállításhoz",
                    Code = "300023255",
                    Price = "1897,50",
                },
                // GP 13 D
                new KrpanBaleTransportPlatform
                {
                    Id = 5,
                    Name = "Platform bálaszállításhoz",
                    Code = "300011151",
                    Price = "1897,50",
                },
                // GP 15 D
                new KrpanBaleTransportPlatform
                {
                    Id = 6,
                    Name = "Platform bálaszállításhoz",
                    Code = "300011149",
                    Price = "1897,50",
                }
                );
        }
    }
}
