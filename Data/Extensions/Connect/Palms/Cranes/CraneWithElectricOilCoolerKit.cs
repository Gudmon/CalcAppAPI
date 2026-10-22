using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Cranes
{
    public static class CraneWithElectricOilCoolerKit
    {
        public static void ConnectCranesWithElectricOilCoolerKit(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CraneElectricOilCoolerKit>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.CraneElectricOilCoolerKit)
                .HasForeignKey(o => o.CraneElectricOilCoolerKitId)
                .IsRequired(false);
        }
    }
}
