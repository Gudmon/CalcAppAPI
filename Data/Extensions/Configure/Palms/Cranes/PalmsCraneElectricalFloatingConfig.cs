using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Cranes
{
    public static class PalmsCraneElectricalFloatingConfig
    {
        public static void ConfigureMultiplePalmsElectricalFloatings(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ElectricalFloating>().HasData(
              new ElectricalFloating
              {
                  Id = 1,
                  Name = "Elektromos úszó pozíció emelő és fordító funkcióhoz (A11-A41 vezértömbhöz)",
                  Code = "FP",
                  Price = "1065"
              }
              );
        }
    }
}
