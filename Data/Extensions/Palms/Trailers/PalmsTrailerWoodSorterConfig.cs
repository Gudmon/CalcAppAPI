using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerWoodSorterConfig
    {
        public static void ConfigureMultiplePalmsWoodSorters(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WoodSorter>().HasData(
               new WoodSorter
               {
                   Id = 1,
                   Name = "Faosztályozó rövidebb fához (1db/rakonca, az ár 1 db-ra vonatkozik)",
                   Code = "WS",
                   Price = "65",
               });
        }
    }
}
