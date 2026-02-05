using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
{
    public static class PalmsTrailerStanchionExtensionConfig
    {
        public static void ConfigureMultiplePalmsStanchionExtensions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StanchionExtension>().HasData(
               new StanchionExtension
               {
                   Id = 1,
                   Name = "Rakonca hosszabbítás (az ár 1 db-ra vonatkozik)",
                   Code = "PE",
                   Price = "55",
               });
        }
    }
}
