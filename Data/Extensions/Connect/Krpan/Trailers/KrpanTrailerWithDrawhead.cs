using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithDrawhead
    {
        public static void ConnectKrpanTrailerWithDrawhead(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanDrawhead>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanDrawHead)
                .HasForeignKey(o => o.KrpanDrawHeadId)
                .IsRequired(false);
        }
    }
}
