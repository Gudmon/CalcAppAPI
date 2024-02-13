using CalcAppAPI.Data.Extensions;
using CalcAppAPI.Models;
using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

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
        public DbSet<OilTankCooler> OilTankCooler { get; set; }
        public DbSet<BolsterLock> BolsterLock { get; set; }
        public DbSet<BBox> BBox { get; set; }
        public DbSet<WoodSorter> WoodSorter { get; set; }
        public DbSet<HandBrake> HandBrake { get; set; }
        public DbSet<ChainsawHolder> ChainsawHolder { get; set; }
        public DbSet<UnderrunProtection> UnderrunProtection { get; set; }
        public DbSet<SupportLeg> SupportLeg { get; set; }
        public DbSet<Light> Light { get; set; }
        public DbSet<Tyre> Tyre { get; set; }
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
            modelBuilder.ConfigureMultiplePalmsOilTankCoolers();

            modelBuilder.ConfigureMultiplePalmsBolsterLocks();
            modelBuilder.ConfigureMultiplePalmsBBoxes();
            modelBuilder.ConfigureMultiplePalmsWoodSorters();
            modelBuilder.ConfigureMultiplePalmsHandBrakes();
            modelBuilder.ConfigureMultiplePalmsChainsawHolders();
            modelBuilder.ConfigureMultiplePalmsUnderrunProtections();
            modelBuilder.ConfigureMultiplePalmsSupportLegs();
            modelBuilder.ConfigureMultiplePalmsLights();
            modelBuilder.ConfigureMultiplePalmsTyres();


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
                        new { TrailerId = 1, BrakeId = 2 },
                        new { TrailerId = 1, BrakeId = 3 },
                        new { TrailerId = 1, BrakeId = 4 },
                        new { TrailerId = 1, BrakeId = 5 },
                        new { TrailerId = 1, BrakeId = 6 },
                        new { TrailerId = 1, BrakeId = 7 },

                        new { TrailerId = 2, BrakeId = 1 },
                        new { TrailerId = 2, BrakeId = 2 },
                        new { TrailerId = 2, BrakeId = 3 },
                        new { TrailerId = 2, BrakeId = 4 },
                        new { TrailerId = 2, BrakeId = 5 },
                        new { TrailerId = 2, BrakeId = 6 },
                        new { TrailerId = 2, BrakeId = 7 },

                        new { TrailerId = 3, BrakeId = 1 },
                        new { TrailerId = 3, BrakeId = 2 },
                        new { TrailerId = 3, BrakeId = 3 },
                        new { TrailerId = 3, BrakeId = 4 },
                        new { TrailerId = 3, BrakeId = 5 },
                        new { TrailerId = 3, BrakeId = 6 },
                        new { TrailerId = 3, BrakeId = 7 }
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

            // OIL TANK COOLER
            modelBuilder.Entity<OilTankCooler>()
                .HasMany(o => o.OilTank)
                .WithOne(o => o.OilTankCooler)
                .HasForeignKey(o => o.OilTankCoolerId)
                .IsRequired(false);

            // BOLSTER LOCK
            modelBuilder.Entity<BolsterLock>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.BolsterLock)
                .HasForeignKey(o => o.BolsterLockId)
                .IsRequired(false);

            // BBOX
            modelBuilder.Entity<BBox>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.BBox)
                .HasForeignKey(o => o.BBoxId)
                .IsRequired(false);

            // WOOD SORTER
            modelBuilder.Entity<WoodSorter>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.WoodSorter)
                .HasForeignKey(o => o.WoodSorterId)
                .IsRequired(false);

            // HANDBRAKES
            modelBuilder.Entity<HandBrake>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.HandBrake)
                .HasForeignKey(o => o.HandBrakeId)
                .IsRequired(false);

            // HANDBRAKES
            modelBuilder.Entity<ChainsawHolder>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.ChainsawHolder)
                .HasForeignKey(o => o.ChainsawHolderId)
                .IsRequired(false);

            // UNDERRUN PROTECTION
            modelBuilder.Entity<UnderrunProtection>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.UnderrunProtection)
                .HasForeignKey(o => o.UnderrunProtectionId)
                .IsRequired(false);

            // SUPPORT LEG
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.SupportLeg)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("SupportLegTrailer")
                    .HasData
                    (
                        new { TrailerId = 1, SupportLegId = 1 },

                        new { TrailerId = 2, SupportLegId = 2 },
                        new { TrailerId = 2, SupportLegId = 3 },

                        new { TrailerId = 3, SupportLegId = 2 },
                        new { TrailerId = 3, SupportLegId = 3 }
                    )
                );

            // LIGHT
            modelBuilder.Entity<Trailer>()
               .HasMany(t => t.Light)
               .WithMany(c => c.Trailer)
               .UsingEntity(j => j.ToTable("LightTrailer")
                   .HasData
                   (
                       new { TrailerId = 1, LightId = 1 },
                       new { TrailerId = 1, LightId = 2 },
                       new { TrailerId = 1, LightId = 3 },

                       new { TrailerId = 2, LightId = 2 },
                       new { TrailerId = 2, LightId = 3 },

                       new { TrailerId = 3, LightId = 1 },
                       new { TrailerId = 3, LightId = 2 },
                       new { TrailerId = 3, LightId = 3 }
                   )
               );

            // TYRE
            modelBuilder.Entity<Trailer>()
               .HasMany(t => t.Tyre)
               .WithMany(c => c.Trailer)
               .UsingEntity(j => j.ToTable("TyreTrailer")
                   .HasData
                   (
                       new { TrailerId = 1, TyreId = 1 },
                       new { TrailerId = 1, TyreId = 2 },

                       new { TrailerId = 2, TyreId = 1 },
                       new { TrailerId = 2, TyreId = 2 },
                       new { TrailerId = 2, TyreId = 3 },

                       new { TrailerId = 3, TyreId = 1 },
                       new { TrailerId = 3, TyreId = 2 },
                       new { TrailerId = 3, TyreId = 3 },
                       new { TrailerId = 3, TyreId = 5 },
                       new { TrailerId = 3, TyreId = 8 }
                   )

               );

            base.OnModelCreating(modelBuilder);
        }
    }
}
