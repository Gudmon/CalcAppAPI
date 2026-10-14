using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithHydraulicSupportLeg
    {
        public static void ConnectKrpanTrailerWithHydraulicSupportLeg(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanHydraulicSupportLeg>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanHydraulicSupportLeg)
                .HasForeignKey(o => o.KrpanHydraulicSupportLegId)
                .IsRequired(false);
        }
    }
}
