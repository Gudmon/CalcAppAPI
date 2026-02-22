using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
{
    public static class PalmsTrailerBunkExtensionConfig
    {
        public static void ConfigureMultiplePalmsBunkExtensions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BunkExtension>().HasData(
               new BunkExtension
               {
                   Id = 1,
                   Name = "Forwarder típusú hidraulikus bunk szélesítés - 1 db",
                   Code = "PA-H",
                   Price = "1250",
                   ImageUrls = ["PALMS-trailer-bunk-extension-1", "PALMS-trailer-bunk-extension-2"],
                   VideoUrls = ["d8Ivy0QkSVU"]
               },
               new BunkExtension
               {
                   Id = 2,
                   Name = "Forwarder típusú hidraulikus bunk szélesítés - 1 db",
                   Code = "PA-H",
                   Price = "595",
                   ImageUrls = ["PALMS-trailer-bunk-extension-1", "PALMS-trailer-bunk-extension-2"],
                   VideoUrls = ["d8Ivy0QkSVU"]
               }
               );
        }
    }
}
