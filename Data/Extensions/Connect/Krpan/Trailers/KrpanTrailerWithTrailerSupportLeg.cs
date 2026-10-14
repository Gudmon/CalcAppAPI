using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithTrailerSupportLeg
    {
        public static void ConnectKrpanTrailerWithTrailerSupportLeg(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanTrailerSupportLeg>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanTrailerSupportLeg)
                .HasForeignKey(o => o.KrpanTrailerSupportLegId)
                .IsRequired(false);
        }
    }
}
