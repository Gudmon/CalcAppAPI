using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
{
    public static class PalmsTrailerManualBunkExtentionConfig
    {
        public static void ConfigureMultiplePalmsManualBunkExtensions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ManualBunkExtension>().HasData(
               new ManualBunkExtension
               {
                   Id = 1,
                   Name = "Forwarder típusú manuális bunk szélesítés - 1 db",
                   Code = "PA-M",
                   Price = "160",
               });
        }
    }
}
