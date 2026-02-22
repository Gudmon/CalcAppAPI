using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
{
    public static class PalmsTrailerBunkAdapterConfig
    {
        public static void ConfigureMultiplePalmsBunkAdapters(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BunkAdapter>().HasData(
               new BunkAdapter
               {
                   Id = 1,
                   Name = "Forwarder típusú bunk adapter a raktér szélesítéshez 300 mm - 1 db",
                   Code = "PA",
                   Price = "150",
                   ImageUrls = ["PALMS-trailer-bunk-adapter-1", "PALMS-trailer-bunk-adapter-2", "PALMS-trailer-bunk-adapter-3"]
               },
               new BunkAdapter
               {
                   Id = 2,
                   Name = "Forwarder típusú bunk adapter a raktér szélesítéshez 300 mm - 1 db",
                   Code = "PA",
                   Price = "140",
                   ImageUrls = ["PALMS-trailer-bunk-adapter-1", "PALMS-trailer-bunk-adapter-2", "PALMS-trailer-bunk-adapter-3"]
               }
               );

        }
    }
}
