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
        public DbSet<Brake> Brake { get; set; }
        public DbSet<Propulsion> Propulsion { get; set; }
        public DbSet<Drawbar> Drawbar { get; set; }
        public DbSet<Platform> Platform { get; set; }
        public DbSet<OilPump> OilPump { get; set; }
        public DbSet<OilTank> OilTank { get; set; }
        public DbSet<Crane> Crane { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureMultiplePalmsTrailers();
            modelBuilder.ConfigureMultiplePalmsCranes();

            modelBuilder.ConfigureMultiplePalmsStanchions();
            modelBuilder.ConfigureMultiplePalmsBrakes();
            modelBuilder.ConfigureMultiplePalmsDrawbars();
            modelBuilder.ConfigureMultiplePalmsPropulsions();
            modelBuilder.ConfigureMultiplePalmsPlatforms();
            modelBuilder.ConfigureMultiplePalmsOilPumps();
            modelBuilder.ConfigureMultiplePalmsOilTanks();


            // CRANES
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

            // STANCHIONS
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Stanchion)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("StanchionTrailer")
                    .HasData
                    (
                        //PALMS 6S
                        new { TrailerId = 1, StanchionId = 1 },
                        new { TrailerId = 1, StanchionId = 2 },

                        //PALMS 8SX
                        new { TrailerId = 2, StanchionId = 3 },
                        new { TrailerId = 2, StanchionId = 4 },
                        new { TrailerId = 2, StanchionId = 5 },
                        new { TrailerId = 2, StanchionId = 6 },

                        //PALMS 9SC
                        new { TrailerId = 3, StanchionId = 7 },
                        new { TrailerId = 3, StanchionId = 8 },
                        new { TrailerId = 3, StanchionId = 9 },
                        new { TrailerId = 3, StanchionId = 10 }
                    )

                );

            // BRAKES
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Brake)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("BrakeTrailer")
                    .HasData
                    (
                        new { TrailerId = 1, BrakeId = 1 },
                        new { TrailerId = 1, BrakeId = 2 }
                    )

                );

            // PROPULSIONS
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Propulsion)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("PropulsionTrailer")
                    .HasData
                    (
                        new { TrailerId = 3, PropulsionId = 1 },
                        new { TrailerId = 3, PropulsionId = 2 }
                    )

                );

            // DRAWBARS
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Drawbar)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("DrawbarTrailer")
                    .HasData
                    (
                        new { TrailerId = 1, DrawbarId = 4 },
                        new { TrailerId = 1, DrawbarId = 5 },
                        new { TrailerId = 1, DrawbarId = 9 },

                        new { TrailerId = 2, DrawbarId = 4 },
                        new { TrailerId = 2, DrawbarId = 5 },
                        new { TrailerId = 2, DrawbarId = 6 },
                        new { TrailerId = 2, DrawbarId = 7 },
                        new { TrailerId = 2, DrawbarId = 9 },

                        new { TrailerId = 3, DrawbarId = 4 },
                        new { TrailerId = 3, DrawbarId = 5 },
                        new { TrailerId = 3, DrawbarId = 6 },
                        new { TrailerId = 3, DrawbarId = 9 }
                    )

                );

            // PLATFORMS
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Platform)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("PlatformTrailer")
                    .HasData
                    (
                        new { TrailerId = 1, PlatformId = 1 },

                        new { TrailerId = 2, PlatformId = 1 },
                        new { TrailerId = 2, PlatformId = 2 },

                        new { TrailerId = 3, PlatformId = 1 },
                        new { TrailerId = 3, PlatformId = 2 }
                    )

                );

            // OIL PUMPS
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.OilPump)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("OilPumpTrailer")
                    .HasData
                    (
                        new { TrailerId = 2, OilPumpId = 1 },
                        new { TrailerId = 2, OilPumpId = 2 },
                        new { TrailerId = 2, OilPumpId = 3 },
                        new { TrailerId = 2, OilPumpId = 4 },
                        new { TrailerId = 2, OilPumpId = 5 },
                        new { TrailerId = 2, OilPumpId = 6 },
                        new { TrailerId = 2, OilPumpId = 7 },


                        new { TrailerId = 3, OilPumpId = 1 },
                        new { TrailerId = 3, OilPumpId = 2 },
                        new { TrailerId = 3, OilPumpId = 3 },
                        new { TrailerId = 3, OilPumpId = 4 },
                        new { TrailerId = 3, OilPumpId = 5 },
                        new { TrailerId = 3, OilPumpId = 6 },
                        new { TrailerId = 3, OilPumpId = 7 }
                    )

                );

            // OIL TANKS
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.OilTank)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("OilTankTrailer")
                    .HasData
                    (
                        new { TrailerId = 2, OilTankId = 1 },
                        new { TrailerId = 2, OilTankId = 2 },
                        new { TrailerId = 2, OilTankId = 3 },
                        new { TrailerId = 2, OilTankId = 4 },


                        new { TrailerId = 3, OilTankId = 1 },
                        new { TrailerId = 3, OilTankId = 2 },
                        new { TrailerId = 3, OilTankId = 3 },
                        new { TrailerId = 3, OilTankId = 4 }
                    )

                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
