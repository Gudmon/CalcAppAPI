using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithBBox
    {
        public static void ConnectKrpanTrailerWithBBox(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanBBox>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanBBox)
                .HasForeignKey(o => o.KrpanBBoxId)
                .IsRequired(false);
        }
    }
}
