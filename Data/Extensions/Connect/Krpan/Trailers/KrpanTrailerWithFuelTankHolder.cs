using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithFuelTankHolder
    {
        public static void ConnectKrpanTrailerWithFuelTankHolder(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanFuelTankHolder>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanFuelTankHolder)
                .HasForeignKey(o => o.KrpanFuelTankHolderId)
                .IsRequired(false);
        }
    }
}
