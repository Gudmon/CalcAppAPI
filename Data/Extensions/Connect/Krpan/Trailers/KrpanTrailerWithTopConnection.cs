using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithTopConnection
    {
        public static void ConnectKrpanTrailerWithTopConnection(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanTopConnection>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanTopConnection)
                .HasForeignKey(o => o.KrpanTopConnectionId)
                .IsRequired(false);
        }
    }
}
