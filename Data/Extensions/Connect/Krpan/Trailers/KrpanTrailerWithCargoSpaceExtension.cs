using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithCargoSpaceExtension
    {
        public static void ConnectKrpanTrailerWithCargoSpaceExtension(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanCargoSpaceExtension>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanCargoSpaceExtension)
                .HasForeignKey(o => o.KrpanCargoSpaceExtensionId)
                .IsRequired(false);
        }
    }
}
