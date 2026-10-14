using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithToolBox
    {
        public static void ConnectKrpanTrailerWithToolBox(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanToolBox>()
                .HasMany(o => o.KrpanTrailer)
                .WithOne(o => o.KrpanToolBox)
                .HasForeignKey(o => o.KrpanToolBoxId)
                .IsRequired(false);
        }
    }
}
