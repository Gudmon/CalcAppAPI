using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithChainsawHolder
    {
        public static void ConnectKrpanTrailerWithChainsawHolder(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanChainsawHolder>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanChainsawHolder)
                .HasForeignKey(o => o.KrpanChainsawHolderId)
                .IsRequired(false);
        }
    }
}
