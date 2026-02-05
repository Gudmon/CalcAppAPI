using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithHydroPacks
    {
        public static void ConnectTrailersWithHydropacks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trailer>()
               .HasMany(t => t.HydroPack)
               .WithMany(c => c.Trailer)
               .UsingEntity(j => j.ToTable("HydroPackTrailer")
                   .HasData
                   (
                       //PALMS 2D
                       new { TrailerId = 15, HydroPackId = 1 },
                       new { TrailerId = 15, HydroPackId = 2 },
                       new { TrailerId = 15, HydroPackId = 3 }
                   )
               );
        }
    }
}
