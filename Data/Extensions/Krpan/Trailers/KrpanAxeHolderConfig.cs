using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Trailers
{
    public static class KrpanAxeHolderConfig
    {
        public static void ConfigureMultipleKrpanAxeHolders(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanAxeHolder>().HasData(
                new KrpanAxeHolder
                {
                    Id = 1,
                    Name = "Csákány és fejsze tartó",
                    Code = "300015366",
                    Price = "40",
                }
                );
        }
    }
}
