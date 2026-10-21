using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanStanchionConfig
    {
        public static void ConfigureMultipleKrpanStanchions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanStanchion>().HasData(
                // GP 6XS - GP 10 S
                new KrpanStanchion
                {
                    Id = 1,
                    Name = "3 pár rakonca",
                    Code = "",
                    Price = "0",
                },
                // GP 6XS - GP 10 S
                new KrpanStanchion
                {
                    Id = 2,
                    Name = "4 pár rakonca",
                    Code = "300032726",
                    Price = "711,50",
                },
                // GP 8 DF - GP 10 DF
                new KrpanStanchion
                {
                    Id = 3,
                    Name = "4 pár rakonca",
                    Code = "2× 300011090",
                    Price = "532,50",
                },
                // GP 8 DF - GP 10 DF
                new KrpanStanchion
                {
                    Id = 4,
                    Name = "3 pár forwarder rakonca",
                    Code = "",
                    Price = "995,01",
                },
                // GP 8 DF - GP 10 DF
                new KrpanStanchion
                {
                    Id = 5,
                    Name = "4 pár forwarder rakonca",
                    Code = "2× 300031886",
                    Price = "1859,18",
                },
                // GP 12 DF / GP 14 DF
                new KrpanStanchion
                {
                    Id = 6,
                    Name = "3 pár forwarder rakonca",
                    Code = "",
                    Price = "1417,50",
                },
                // GP 12 DF / GP 14 DF
                new KrpanStanchion
                {
                    Id = 7,
                    Name = "4 pár forwarder rakonca",
                    Code = "2× 300021851",
                    Price = "2422,50",
                },
                // GP 13 D / GP 15 D
                new KrpanStanchion
                {
                    Id = 8,
                    Name = "4 pár rakonca",
                    Code = "",
                    Price = "0",
                },
                // GP 13 D / GP 15 D
                new KrpanStanchion
                {
                    Id = 9,
                    Name = "5 pár rakonca",
                    Code = "",
                    Price = "532,50",
                },
                // GP 13 D / GP 15 D
                new KrpanStanchion
                {
                    Id = 10,
                    Name = "4 pár forwarder rakonca",
                    Code = "",
                    Price = "1890,00",
                },
                // GP 13 D / GP 15 D
                new KrpanStanchion
                {
                    Id = 11,
                    Name = "5 pár forwarder rakonca",
                    Code = "300021851",
                    Price = "2895,00",
                }
                );
        }
    }
}
