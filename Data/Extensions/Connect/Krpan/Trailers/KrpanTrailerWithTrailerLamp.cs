using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithTrailerLamp
    {
        public static void ConnectKrpanTrailerWithTrailerLamp(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanTrailerLamp>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanTrailerLamp)
                .HasForeignKey(o => o.KrpanTrailerLampId)
                .IsRequired(false);
        }
    }
}
