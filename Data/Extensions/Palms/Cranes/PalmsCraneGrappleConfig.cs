using CalcAppAPI.Models.Machine.Configurations.Cranes;
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
              },
              new Grapple
              {
                  Id = 2,
                  Name = "Kanál 0,16 Palms (csapos rotátorhoz)",
                  Code = "C01",
                  Price = "1105",
              },
              new Grapple
              {
                  Id = 3,
                  Name = "Kanál 0,16 Palms (FL)",
                  Code = "C02",
                  Price = "1085",
              },
              new Grapple
              {
                  Id = 4,
                  Name = "Kanál 0,18 Palms (FL)",
                  Code = "C1",
                  Price = "1395",
              },
              new Grapple
              {
                  Id = 5,
                  Name = "Kanál 0,23 Palms (FL)",
                  Code = "C3",
                  Price = "1745",
              },
              new Grapple
              {
                  Id = 6,
                  Name = "Kanál 0,25 Grippen (FL)",
                  Code = "C5.1",
                  Price = "3015",
              },
              new Grapple
              {
                  Id = 7,
                  Name = "Kanál 0,26 Palms (FL)",
                  Code = "C5.2",
                  Price = "3090",
              });
        }
    }
}
