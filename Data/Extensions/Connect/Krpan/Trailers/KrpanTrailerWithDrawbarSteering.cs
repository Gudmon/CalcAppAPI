using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithDrawbarSteering
    {
        public static void ConnectKrpanTrailerWithDrawbarSteering(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanDrawbarSteering>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanDrawbarSteering)
                .HasForeignKey(o => o.KrpanDrawbarSteeringId)
                .IsRequired(false);
        }
    }
}
