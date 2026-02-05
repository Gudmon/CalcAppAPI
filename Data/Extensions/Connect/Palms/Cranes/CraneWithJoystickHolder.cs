using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithJoystickHolder
    {
        public static void ConnectCranesWithJoystickHolder(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JoystickHolder>()
               .HasMany(o => o.Crane)
               .WithOne(o => o.JoystickHolder)
               .HasForeignKey(o => o.JoystickHolderId)
               .IsRequired(false);
        }
    }
}
