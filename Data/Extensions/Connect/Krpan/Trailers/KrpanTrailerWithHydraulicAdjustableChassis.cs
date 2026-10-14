using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithHydraulicAdjustableChassis
    {
        public static void ConnectKrpanTrailerWithHydraulicAdjustableChassis(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanHydraulicAdjustableChassis>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanHydraulicAdjustableChassis)
                .HasForeignKey(o => o.KrpanHydraulicAdjustableChassisId)
                .IsRequired(false);
        }
     }
}
