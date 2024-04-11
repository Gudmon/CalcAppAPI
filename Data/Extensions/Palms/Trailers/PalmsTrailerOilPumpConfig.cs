using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerOilPumpConfig
    {
        public static void ConfigureMultiplePalmsOilPumps(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OilPump>().HasData(
               new OilPump
               {
                   Id = 1,
                   Name = "Szivattyú adapter a vonórúdon",
                   Code = "P01",
                   Price = "60",
               },
               new OilPump
               {
                   Id = 2,
                   Name = "P1 101 cm3 dugattyús olajmpumpa a vonórúdon, 650 p/min - 65 l/min",
                   Code = "P1",
                   Price = "1155",
               },
               new OilPump
               {
                   Id = 3,
                   Name = "P2 130 cm3 dugattyús olajmpuma a vonórúdon, 650 p/min - 82 l/min",
                   Code = "P2",
                   Price = "1575",
               },
               new OilPump
               {
                   Id = 4,
                   Name = "61 cm3 dugattyús olajpumpa multiplikátorral a vonórúdon, 650 p/min - 98 l/min",
                   Code = "P4",
                   Price = "1995",
               },
               new OilPump
               {
                   Id = 5,
                   Name = "P4 olajmpumla PTO-val 650 p/min - 98 l/min (rögzítő konzol nélkül)",
                   Code = "P4PTO",
                   Price = "1995",
               },
               new OilPump
               {
                   Id = 6,
                   Name = "LS fajtájú olajmpumpa multiplikátorral, 650 p/min - 120 l/min",
                   Code = "P6",
                   Price = "4305",
               },
               new OilPump
               {
                   Id = 7,
                   Name = "P6 olajpumpa PTO-val 650 p/min - 120 l/min (rögzítő konzol nélkül)",
                   Code = "P6PTO",
                   Price = "4305",
               },
               new OilPump
               {
                   Id = 8,
                   Name = "LS fajtájú olajmpumpa multiplikátorral, 500 p/min - 118 l/min",
                   Code = "P6",
                   Price = "5190",
               }
               );
        }
    }
}
