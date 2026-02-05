using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Cranes
{
    public static class PalmsCraneJoystickHolderConfig
    {
        public static void ConfigureMultiplePalmsCraneJoyStickHolders(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JoystickHolder>().HasData(
              new JoystickHolder
              {
                  Id = 1,
                  Name = "Joystick tartó A11-A42 vezértömbhöz",
                  Code = "JL",
                  Price = "370"
              }
              );
        }
    }
}
