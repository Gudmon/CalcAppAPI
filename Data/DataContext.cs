using CalcAppAPI.Data.Extensions;
using CalcAppAPI.Models;
using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<Trailer> Trailer { get; set; }
        public DbSet<Stanchion> Stanchion { get; set; }
        public DbSet<Crane> Crane { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ConfigureMultiplePalmsTrailers();
            modelBuilder.ConfigureMultiplePalmsCranes();
            modelBuilder.ConfigureMultiplePalmsStanchions();


            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Crane)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("CraneTrailer")
                    .HasData
                    (
                        new { TrailerId = 1, CraneId = 1 },
                        new { TrailerId = 1, CraneId = 2 },
                        new { TrailerId = 2, CraneId = 1 },
                        new { TrailerId = 2, CraneId = 2 }
                    )
           
                );

            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Stanchion)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("StanchionTrailer")
                    .HasData
                    (
                        new { TrailerId = 1, StanchionId = 1 },
                        new { TrailerId = 1, StanchionId = 2 }
                    )

                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
