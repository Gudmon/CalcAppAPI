using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Trailers
{
    public static class KrpanFuelTankHolderConfig
    {
        public static void ConfigureMultipleKrpanFuelTankHolders(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanFuelTankHolder>().HasData(
                new KrpanFuelTankHolder
                {
                    Id = 1,
                    Name = "Üzemanyagtartály tartó",
                    Code = "300007925",
                    Price = "40",
                }
                );
        }
    }
}
