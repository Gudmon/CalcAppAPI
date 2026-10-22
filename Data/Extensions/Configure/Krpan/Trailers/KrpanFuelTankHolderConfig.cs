using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanFuelTankHolderConfig
    {
        public static void ConfigureMultipleKrpanFuelTankHolders(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanFuelTankHolder>().HasData(
                new KrpanFuelTankHolder
                {
                    Id = 1,
                    Name = "Üzemanyag kanna tartó",
                    Code = "300020894",
                    Price = "0",
                },
                new KrpanFuelTankHolder
                {
                    Id = 2,
                    Name = "Üzemanyag kanna tartó",
                    Code = "300020894",
                    Price = "36,67",
                }
                );
        }
    }
}
