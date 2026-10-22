using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithWheelChock
    {
        public static void ConnectKrpanTrailerWithWheelChock(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanWheelChock>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanWheelChock)
                .HasForeignKey(o => o.KrpanWheelChockId)
                .IsRequired(false);
        }
    }
}
