using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
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
                   Price = "1000"
               },
               new OilTank
               {
                   Id = 2,
                   Name = "95 l-es olajtartály HVLP olajjal",
                   Code = "T2+",
                   Price = "1290"
               },
               new OilTank
               {
                   Id = 3,
                   Name = "95 l-es olajtartály HVLP olajjal, elzáró csappal",
                   Code = "T2SOV",
                   Price = "1200"
               },
               new OilTank
               {
                   Id = 4,
                   Name = "95 l-es olajtartály HVLP olajjal, elzáró csappal, olajszűrővel",
                   Code = "T2SOV+",
                   Price = "1490"
               },
               new OilTank
               {
                   Id = 5,
                   Name = "95 l-es olajtartály HVLP olajjal",
                   Code = "T2+",
                   Price = "1295"
               },
               new OilTank
               {
                   Id = 6,
                   Name = "95 l-es olajtartály HVLP olajjal, elzáró csappal, olajszűrővel",
                   Code = "T2SOV+",
                   Price = "1495"
               },
               new OilTank
               {
                   Id = 7,
                   Name = "100 l-es olajtartály HVLP olajjal",
                   Code = "T4+",
                   Price = "1610"
               }
               );
        }
    }
}
