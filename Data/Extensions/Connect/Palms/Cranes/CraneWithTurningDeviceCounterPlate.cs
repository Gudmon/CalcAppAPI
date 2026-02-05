using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithTurningDeviceCounterPlate
    {
        public static void ConnectCranesWithTurningDeviceCounterPlate(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TurningDeviceCounterPlate>()
               .HasMany(o => o.Crane)
               .WithOne(o => o.TurningDeviceCounterPlate)
               .HasForeignKey(o => o.TurningDeviceCounterPlateId)
               .IsRequired(false);
        }
    }
}
