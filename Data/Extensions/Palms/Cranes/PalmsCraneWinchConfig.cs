using CalcAppAPI.Models.Machine.Configurations.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Cranes
{
    public static class PalmsCraneWinchConfig
    {
        public static void ConfigureMultiplePalmsWinches(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Winch>().HasData(
              new Winch
              {
                  Id = 1,
                  Name = "Csörlő előkészítés a főgémen",
                  Code = "W0",
                  Price = "70"
              },
              new Winch
              {
                  Id = 2,
                  Name = "Rádió távvezérléső 1400-as csörlő (A11-A41 vezértömbhöz)",
                  Code = "W1",
                  Price = "2365"
              },
              new Winch
              {
                  Id = 3,
                  Name = "Rádió távvezérléső 2200-as csörlő (A11-A41 vezértömbhöz)",
                  Code = "W2",
                  Price = "2845"
              }
              );
        }
    }
}
