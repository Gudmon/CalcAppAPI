using CalcAppAPI.Models.Machine.Configurations.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Common
{
    public static class PalmsShippingConfig
    {
        public static void ConfigureMultiplePalmsShippings(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shipping>().HasData(
              new Shipping
              {
                  Id = 1,
                  Name = "Pótkocsi szállítása Észtországból Magyarországra",
                  Code = "",
                  Price = "750"
              },
              new Shipping
              {
                  Id = 2,
                  Name = "Daru szállítása Észtországból Magyarországra",
                  Code = "",
                  Price = "750"
              }
              );
        }
    }
}
