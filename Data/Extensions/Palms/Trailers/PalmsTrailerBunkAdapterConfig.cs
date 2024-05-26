using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerBunkAdapterConfig
    {
        public static void ConfigureMultiplePalmsBunkAdapters(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BunkAdapter>().HasData(
               new BunkAdapter
               {
                   Id = 1,
                   Name = "Forwarder típusú bunk adapter a szélesebb rakodó felületért (az ár 1 db-ra vonatkozik)",
                   Code = "PA",
                   Price = "150",
               },
               new BunkAdapter
               {
                   Id = 2,
                   Name = "Forwarder típusú bunk adapter a szélesebb rakodó felületért (az ár 1 db-ra vonatkozik)",
                   Code = "PA",
                   Price = "140",
               }
               );

        }
    }
}
