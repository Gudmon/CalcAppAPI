using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithAdjustableDrive
    {
        public static void ConnectKrpanTrailerWithAdjustableDrive(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanAdjustableDrive>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanAdjustableDrive)
                .HasForeignKey(o => o.KrpanAdjustableDriveId)
                .IsRequired(false);
        }
    }
}
