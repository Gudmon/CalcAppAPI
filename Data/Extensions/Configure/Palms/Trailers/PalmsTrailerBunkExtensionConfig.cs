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
               },
               new BunkExtension
               {
                   Id = 2,
                   Name = "Forwarder típusú hidraulikus bunk szélesítés - 1 db",
                   Code = "PA-H",
                   Price = "595",
               }
               );
        }
    }
}
