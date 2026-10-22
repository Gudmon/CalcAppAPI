using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanChainsawHolderConfig
    {
        public static void ConfigureMultipleKrpanChainsawHolders(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanChainsawHolder>().HasData(
                new KrpanChainsawHolder
                {
                    Id = 1,
                    Name = "Láncfűrész tartó",
                    Code = "300015821",
                    Price = "0",
                },
                new KrpanChainsawHolder
                {
                    Id = 2,
                    Name = "Láncfűrész tartó",
                    Code = "300015821",
                    Price = "40,00",
                }
                );
        }
    }
}
