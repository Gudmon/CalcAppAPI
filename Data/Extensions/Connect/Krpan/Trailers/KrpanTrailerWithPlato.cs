using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithPlato
    {
        public static void ConnectKrpanTrailerWithPlato(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanPlato>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanPlato)
                .HasForeignKey(o => o.KrpanPlatoId)
                .IsRequired(false);
        }
    }
}
