using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Cranes
{
    public static class PalmsCraneGrappleConfig
    {
        public static void ConfigureMultiplePalmsGrapples(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grapple>().HasData(
              new Grapple
              {
                  Id = 1,
                  Name = "Rönkfogó kanál nélkül",
                  Code = "C0",
                  Price = "0",
                  Area = null,
                  Mass = null
              },
              new Grapple
              {
                  Id = 2,
                  Name = "Kanál 0,16 Palms (csapos rotátorhoz)",
                  Code = "C01",
                  Price = "1105",
                  Area = "0.16",
                  Mass = "69"
              },
              new Grapple
              {
                  Id = 3,
                  Name = "Kanál 0,16 Palms (FL)",
                  Code = "C02",
                  Price = "1085",
                  Area = "0.16",
                  Mass = "66"
              },
              new Grapple
              {
                  Id = 4,
                  Name = "Kanál 0,18 Palms (FL)",
                  Code = "C1",
                  Price = "1395",
                  Area = "0.18",
                  Mass = "88"
              },
              new Grapple
              {
                  Id = 5,
                  Name = "Kanál 0,23 Palms (FL)",
                  Code = "C3",
                  Price = "1745",
                  Area = "0.23",
                  Mass = "114"
              },
              new Grapple
              {
                  Id = 6,
                  Name = "Kanál 0,25 Grippen (FL)",
                  Code = "C5.1",
                  Price = "3015",
                  Area = "0.25",
                  Mass = null
              },
              new Grapple
              {
                  Id = 7,
                  Name = "Kanál 0,26 Palms (FL)",
                  Code = "C5.2",
                  Price = "3090",
                  Area = "0.26",
                  Mass = "174"
              },
              new Grapple
              {
                  Id = 8,
                  Name = "Biomasszás kanál 0,21 Palms (FL)",
                  Code = "C36",
                  Price = "2230",
                  Area = "0.21",
                  Mass = "127"
              },
              new Grapple
              {
                  Id = 9,
                  Name = "Biomasszás kanál 0,25 Grippen (FL)",
                  Code = "C7.1",
                  Price = "3345",
                  Area = "0.25",
                  Mass = null
              },
              new Grapple
              {
                  Id = 10,
                  Name = "Biomasszás kanál 0,23 Palms (FL)",
                  Code = "C7.2",
                  Price = "3020",
                  Area = "0.23",
                  Mass = "118"
              },
              new Grapple
              {
                  Id = 11,
                  Name = "Biomasszás kanál 0,25 Palms (FL)",
                  Code = "C11",
                  Price = "3450",
                  Area = "0.25",
                  Mass = "223"
              },
              new Grapple
              {
                  Id = 12,
                  Name = "Palms 0,28-as kanál (FL)",
                  Code = "C10",
                  Price = "3125",
                  Area = "0.28",
                  Mass = "205"
              },
              new Grapple
              {
                  Id = 13,
                  Name = "Palms vágó kanál a Nisula-tól",
                  Code = "C175",
                  Price = "6500",
                  Area = null,
                  Mass = null
              },
              new Grapple
              {
                  Id = 14,
                  Name = "Aprítékos kiegészítő C3-hoz",
                  Code = "GB3",
                  Price = "910",
                  Area = null,
                  Mass = "195"
              },
              new Grapple
              {
                  Id = 15,
                  Name = "Palms 0,09 kanál",
                  Code = "C009",
                  Price = "620",
                  Area = null,
                  Mass = null
              }
              );
        }
    }
}
