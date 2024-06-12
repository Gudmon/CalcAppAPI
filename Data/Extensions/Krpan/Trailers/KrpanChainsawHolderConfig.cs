using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Trailers
{
    public static class KrpanChainsawHolderConfig
    {
        public static void ConfigureMultipleKrpanChainsawHolders(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanChainsawHolder>().HasData(
                new KrpanChainsawHolder
                {
                    Id = 1,
                    Name = "Motorfűrész tartó",
                    Code = "300015821",
                    Price = "45",
                }
                );
        }
    }
}
