using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
{
    public static class PalmsTrailerSupportLegConfig
    {
        public static void ConfigureMultiplePalmsSupportLegs(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupportLeg>().HasData(
               new SupportLeg
               {
                   Id = 1,
                   Name = "Csapszeggel állítható kitámasztó láb a vonórúdon",
                   Code = "SL",
                   Price = "0",
                   ImageUrls = ["PALMS-trailer-support-leg-SL"]
               },
               new SupportLeg
               {
                   Id = 2,
                   Name = "Csapszeggel állítható kitámasztó láb a vonórúdon",
                   Code = "SL",
                   Price = "75",
                   ImageUrls = ["PALMS-trailer-support-leg-SL"]
               },
               new SupportLeg
               {
                   Id = 3,
                   Name = "Tekerővel állítható kitámasztó láb a vonórúdon",
                   Code = "SJ",
                   Price = "420",
                   ImageUrls = ["PALMS-trailer-support-leg-SJ"]
               }
               );
        }
    }
}
