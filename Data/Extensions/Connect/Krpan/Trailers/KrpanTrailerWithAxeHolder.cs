using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithAxeHolder
    {
        public static void ConnectKrpanTrailerWithAxeHolder(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanAxeHolder>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanAxeHolder)
                .HasForeignKey(o => o.KrpanAxeHolderId)
                .IsRequired(false);
        }
    }
}
