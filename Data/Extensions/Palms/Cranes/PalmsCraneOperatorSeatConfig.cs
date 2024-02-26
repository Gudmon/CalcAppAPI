using CalcAppAPI.Models.Machine.Configurations.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Cranes
{
    public static class PalmsCraneOperatorSeatConfig
    {
        public static void ConfigureMultiplePalmsCraneOperatorSeats(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OperatorSeat>().HasData(
              new OperatorSeat
              {
                  Id = 1,
                  Name = "Kezelő ülés a függőleges gém tetejére, csak A12-höz, nem kompatibilis a csörlővel",
                  Code = "HSB",
                  Price = "1890"
              }
              );
        }
    }
}
