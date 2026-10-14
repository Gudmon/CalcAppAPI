using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithGrappleLocation
    {
        public static void ConnectKrpanTrailerWithGrappleLocation(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanGrappleLocation>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanGrappleLocation)
                .HasForeignKey(o => o.KrpanGrappleLocationId)
                .IsRequired(false);
        }
    }
}
