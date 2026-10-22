using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanTrailerBrakeLampConfig
    {
        public static void ConfigureMultipleKrpanTrailerBrakeLamps(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanTrailerBrakeLamp>().HasData(
                new KrpanTrailerBrakeLamp
                {
                    Id = 1,
                    Name = "LED féklámpák ROM",
                    Code = "",
                    Price = "0",
                },
                new KrpanTrailerBrakeLamp
                {
                    Id = 2,
                    Name = "LED féklámpák RIO",
                    Code = "",
                    Price = "104,16",
                },
                new KrpanTrailerBrakeLamp
                {
                    Id = 3,
                    Name = "LED féklámpák RIO",
                    Code = "",
                    Price = "0",
                });
        }
    }
}
