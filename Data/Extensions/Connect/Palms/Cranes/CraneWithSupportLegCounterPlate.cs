using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithSupportLegCounterPlate
    {
        public static void ConnectCranesWithSupportLegCounterPlate(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupportLegCounterPlate>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.SupportLegCounterPlate)
                .HasForeignKey(o => o.SupportLegCounterPlateId)
                .IsRequired(false);
        }
    }
}
