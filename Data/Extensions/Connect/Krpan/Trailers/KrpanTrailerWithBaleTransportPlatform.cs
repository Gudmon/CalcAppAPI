using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithBaleTransportPlatform
    {
        public static void ConnectKrpanTrailerWithBaleTransportPlatform(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanBaleTransportPlatform>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanBaleTransportPlatform)
                .HasForeignKey(o => o.KrpanBaleTransportPlatformId)
                .IsRequired(false);
        }
    }
}
