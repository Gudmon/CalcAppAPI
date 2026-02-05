using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithSupplyFormats
    {
        public static void ConnectTrailersWithSupplyFormats(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trailer>()
               .HasMany(t => t.SupplyFormat)
               .WithMany(c => c.Trailer)
               .UsingEntity(j => j.ToTable("SupplyFormatTrailer")
                   .HasData
                   (
                       //PALMS 2D
                       new { TrailerId = 15, SupplyFormatId = 1 },
                       new { TrailerId = 15, SupplyFormatId = 2 }
                   )
               );
        }
    }
}
