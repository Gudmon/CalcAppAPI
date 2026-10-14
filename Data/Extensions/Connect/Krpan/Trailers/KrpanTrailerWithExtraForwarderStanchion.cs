using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithExtraForwarderStanchion
    {
        public static void ConnectKrpanTrailerWithExtraForwarderStanchion(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanExtraForwarderStanchion>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanExtraForwarderStanchion)
                .HasForeignKey(o => o.KrpanExtraForwarderStanchionId)
                .IsRequired(false);
        }
    }
}
