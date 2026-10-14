using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithChock
    {
        public static void ConnectKrpanTrailerWithChock(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanChock>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanChock)
                .HasForeignKey(o => o.KrpanChockId)
                .IsRequired(false);
        }
    }
}
