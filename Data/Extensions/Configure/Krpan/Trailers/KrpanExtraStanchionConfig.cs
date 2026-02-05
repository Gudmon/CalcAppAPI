using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanExtraStanchionConfig
    {
        public static void ConfigureMultipleKrpanExtraStanchions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanExtraStanchion>().HasData(
                new KrpanExtraStanchion
                {
                    Id = 1,
                    Name = "Extra rakonca pár (3 pár széria)",
                    Code = "300011090",
                    Price = "545",
                },
                new KrpanExtraStanchion
                {
                    Id = 2,
                    Name = "Extra rakonca pár (4 pár széria)",
                    Code = "300010875",
                    Price = "545",
                }
                );
        }
    }
}
