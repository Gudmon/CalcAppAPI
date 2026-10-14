using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithCardanShaft
    {
        public static void ConnectKrpanTrailerWithCardanShaft(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanCardanShaft>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanCardanShaft)
                .HasForeignKey(o => o.KrpanCardanShaftId)
                .IsRequired(false);
        }
    }
}
