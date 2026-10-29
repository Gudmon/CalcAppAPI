using CalcAppAPI.Models.Machine.Configurations.Krpan.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Cranes
{
    public static class KrpanCranesWithControlLevelProtection
    {
        public static void ConnectKrpanCranesControlLevelProtection(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanCraneControlLeverProtection>()
                .HasMany(o => o.KrpanCranes)
                .WithOne(c => c.KrpanCraneControlLeverProtection)
                .HasForeignKey(c => c.KrpanCraneControlLeverProtectionId)
                .IsRequired(false);
        }
    }
}
