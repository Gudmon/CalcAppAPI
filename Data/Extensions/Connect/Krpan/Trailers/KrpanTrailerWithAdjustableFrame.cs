using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithAdjustableFrame
    {
        public static void ConnectKrpanTrailerWithMechanicalAdjustableFrame(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanMechanicalAdjustableFrame>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanMechanicalAdjustableFrame)
                .HasForeignKey(o => o.KrpanMechanicalAdjustableFrameId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
