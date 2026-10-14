using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithExtension
    {
        public static void ConnectKrpanTrailerWithExtension(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanExtension>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanExtension)
                .HasForeignKey(o => o.KrpanExtensionId)
                .IsRequired(false);
        }
    }
}
