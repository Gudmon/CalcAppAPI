using CalcAppAPI.Models.Machine.Configurations.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Cranes
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
                  Price = "0"
              }
              );
        }
    }
}
