using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerBunkExtensionConfig
    {
        public static void ConfigureMultiplePalmsBunkExtensions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BunkExtension>().HasData(
               new BunkExtension
               {
                   Id = 1,
                   Name = "Forwarder típusú bunk kiterjesztés (az ár 1 db-ra vonatkozik)",
                   Code = "PA-H",
                   Price = "625",
               });
        }
    }
}
