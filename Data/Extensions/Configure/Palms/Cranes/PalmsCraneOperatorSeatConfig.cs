using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Cranes
{
    public static class PalmsCraneOperatorSeatConfig
    {
        public static void ConfigureMultiplePalmsCraneOperatorSeats(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OperatorSeat>().HasData(
              new OperatorSeat
              {
                  Id = 1,
                  Name = "Kezelő ülés a függőleges gém tetejére, csak A12-es vezértömbhöz, nem kompatibilis a csörlővel",
                  Code = "HSB",
                  Price = "1955",
                  ImageUrls = ["PALMS-crane-operator-seat-1", "PALMS-crane-operator-seat-2"]
              }
              );
        }
    }
}
