using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanDrawbarConfig
    {
        public static void ConfigureMultipleKrpanDrawbars(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanDrawbar>().HasData(
                new KrpanDrawbar
                {
                    Id = 1,
                    Name = "Vonószem Ø 40 fix",
                    Code = "",
                    Price = "0",
                },
                new KrpanDrawbar
                {
                    Id = 2,
                    Name = "Vonószem Ø 50 fix",
                    Code = "300012585",
                    Price = "76,67",
                },
                new KrpanDrawbar
                {
                    Id = 3,
                    Name = "Vonószem Ø 50 forgó",
                    Code = "300018036",
                    Price = "248,33",
                },
                new KrpanDrawbar
                {
                    Id = 4,
                    Name = "Gömbfejes vonószerkezet K80",
                    Code = "300012588",
                    Price = "234,11",
                }
                );
        }
    }
}
