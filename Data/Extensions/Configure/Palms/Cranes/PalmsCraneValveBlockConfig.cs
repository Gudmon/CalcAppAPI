using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Cranes
{
    public static class PalmsCraneValveBlockConfig
    {
        public static void ConfigureMultiplePalmsValveBlocks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ValveBlock>().HasData(
              new ValveBlock
              {
                  Id = 1,
                  Name = "A21-A42 vezértömb a főgémhez erősítve",
                  Code = "AH",
                  Price = "0",
                  ImageUrls = ["PALMS-crane-valve-block-1", "PALMS-crane-valve-block-2"]
              }
              );
        }
    }
}
