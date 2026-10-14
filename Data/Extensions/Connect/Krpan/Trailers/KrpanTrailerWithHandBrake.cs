using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithHandBrake
    {
        public static void ConnectKrpanTrailerWithHandBrake(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanHandBrake>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanHandBrake)
                .HasForeignKey(o => o.KrpanHandBrakeId)
                .IsRequired(false);
        }
    }
}
