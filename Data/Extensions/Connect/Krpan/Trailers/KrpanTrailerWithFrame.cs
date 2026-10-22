using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithFrame
    {
        public static void ConnectKrpanTrailersWithFrame(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanFrame>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanFrame)
                .HasForeignKey(o => o.KrpanFrameId)
                .IsRequired(false);
        }
    }
}
