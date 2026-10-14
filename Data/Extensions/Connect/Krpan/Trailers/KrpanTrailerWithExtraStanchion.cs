using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithExtraStanchion
    {
        public static void ConnectKrpanTrailerWithExtraStanchion(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanExtraStanchion>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanExtraStanchion)
                .HasForeignKey(o => o.KrpanExtraStanchionId)
                .IsRequired(false);
        }
    }
}
