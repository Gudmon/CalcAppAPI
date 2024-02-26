using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerOilTankConfig
    {
        public static void ConfigureMultiplePalmsOilTanks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OilTank>().HasData(
               new OilTank
               {
                   Id = 1,
                   Name = "95 l-es olajtartály",
                   Code = "T2",
                   Price = "1000",
                   TrailerOilCoolerId = 1
               },
               new OilTank
               {
                   Id = 2,
                   Name = "95 l-es olajtartály HVLP olajjal",
                   Code = "T2+",
                   Price = "1290",
                   TrailerOilCoolerId = 1
               },
               new OilTank
               {
                   Id = 3,
                   Name = "95 l-es olajtartály HVLP olajjal, elzáró csappal",
                   Code = "T2SOV",
                   Price = "1200",
                   TrailerOilCoolerId = null
               },
               new OilTank
               {
                   Id = 4,
                   Name = "95 l-es olajtartály HVLP olajjal, elzáró csappal, olajszűrővel",
                   Code = "T2SOV+",
                   Price = "1490",
                   TrailerOilCoolerId = null
               }
               );
        }
    }
}
