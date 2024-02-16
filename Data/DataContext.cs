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

                        //PALMS 8D
                        new { TrailerId = 3, StanchionId = 7 },
                        new { TrailerId = 3, StanchionId = 8 },
                        new { TrailerId = 3, StanchionId = 9 },
                        new { TrailerId = 3, StanchionId = 10 },

                        //PALMS 8DWD
                        new { TrailerId = 4, StanchionId = 11 },
                        new { TrailerId = 4, StanchionId = 12 },
                        new { TrailerId = 4, StanchionId = 13 },
                        new { TrailerId = 4, StanchionId = 14 },

                        //PALMS 9SC
                        new { TrailerId = 5, StanchionId = 15 },
                        new { TrailerId = 5, StanchionId = 16 },
                        new { TrailerId = 5, StanchionId = 17 },
                        new { TrailerId = 5, StanchionId = 18 },

                        //PALMS 10D
                        new { TrailerId = 6, StanchionId = 19 },
                        new { TrailerId = 6, StanchionId = 20 },
                        new { TrailerId = 6, StanchionId = 21 },
                        new { TrailerId = 6, StanchionId = 22 },

                        //PALMS 10DWD
                        new { TrailerId = 7, StanchionId = 23 },
                        new { TrailerId = 7, StanchionId = 24 },
                        new { TrailerId = 7, StanchionId = 25 },
                        new { TrailerId = 7, StanchionId = 26 },

                        //PALMS 12D
                        new { TrailerId = 8, StanchionId = 27 },
                        new { TrailerId = 8, StanchionId = 28 },
                        new { TrailerId = 8, StanchionId = 29 },
                        new { TrailerId = 8, StanchionId = 30 },

                        //PALMS 12DWD
                        new { TrailerId = 9, StanchionId = 31 },
                        new { TrailerId = 9, StanchionId = 32 },
                        new { TrailerId = 9, StanchionId = 33 },
                        new { TrailerId = 9, StanchionId = 34 },

                        //PALMS 14D
                        new { TrailerId = 10, StanchionId = 35 },
                        new { TrailerId = 10, StanchionId = 36 },
                        new { TrailerId = 10, StanchionId = 37 },
                        new { TrailerId = 10, StanchionId = 38 },

                        //PALMS 14DWD
                        new { TrailerId = 11, StanchionId = 39 },
                        new { TrailerId = 11, StanchionId = 40 },
                        new { TrailerId = 11, StanchionId = 41 },
                        new { TrailerId = 11, StanchionId = 42 }
                    )                     

                );

            // BRAKES
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Brake)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("BrakeTrailer")
                    .HasData
                    ( 
                        //PALMS 6S
                        new { TrailerId = 1, BrakeId = 1 },
                        new { TrailerId = 1, BrakeId = 2 },
                        new { TrailerId = 1, BrakeId = 3 },
                        new { TrailerId = 1, BrakeId = 4 },
                        new { TrailerId = 1, BrakeId = 5 },
                        new { TrailerId = 1, BrakeId = 6 },
                        new { TrailerId = 1, BrakeId = 7 },

                        //PALMS 8SX
                        new { TrailerId = 2, BrakeId = 1 },
                        new { TrailerId = 2, BrakeId = 2 },
                        new { TrailerId = 2, BrakeId = 3 },
                        new { TrailerId = 2, BrakeId = 4 },
                        new { TrailerId = 2, BrakeId = 5 },
                        new { TrailerId = 2, BrakeId = 6 },
                        new { TrailerId = 2, BrakeId = 7 },

                        //PALMS 8D
                        new { TrailerId = 3, BrakeId = 1 },
                        new { TrailerId = 3, BrakeId = 2 },
                        new { TrailerId = 3, BrakeId = 3 },
                        new { TrailerId = 3, BrakeId = 4 },
                        new { TrailerId = 3, BrakeId = 5 },
                        new { TrailerId = 3, BrakeId = 8 },
                        new { TrailerId = 3, BrakeId = 9 },

                        //PALMS 8DWD
                        new { TrailerId = 4, BrakeId = 1 },
                        new { TrailerId = 4, BrakeId = 10 },
                        new { TrailerId = 4, BrakeId = 11 },
                        new { TrailerId = 4, BrakeId = 12 },
                        new { TrailerId = 4, BrakeId = 13 },
                        new { TrailerId = 4, BrakeId = 14 },
                        new { TrailerId = 4, BrakeId = 15 },

                        //PALMS 9SC
                        new { TrailerId = 5, BrakeId = 1 },
                        new { TrailerId = 5, BrakeId = 2 },
                        new { TrailerId = 5, BrakeId = 3 },
                        new { TrailerId = 5, BrakeId = 4 },
                        new { TrailerId = 5, BrakeId = 5 },
                        new { TrailerId = 5, BrakeId = 6 },
                        new { TrailerId = 5, BrakeId = 7 },

                        //PALMS 10D
                        new { TrailerId = 6, BrakeId = 1 },
                        new { TrailerId = 6, BrakeId = 2 },
                        new { TrailerId = 6, BrakeId = 3 },
                        new { TrailerId = 6, BrakeId = 4 },
                        new { TrailerId = 6, BrakeId = 5 },
                        new { TrailerId = 6, BrakeId = 8 },
                        new { TrailerId = 6, BrakeId = 9 },

                        //PALMS 10DWD
                        new { TrailerId = 7, BrakeId = 1 },
                        new { TrailerId = 7, BrakeId = 10 },
                        new { TrailerId = 7, BrakeId = 11 },
                        new { TrailerId = 7, BrakeId = 12 },
                        new { TrailerId = 7, BrakeId = 13 },
                        new { TrailerId = 7, BrakeId = 14 },
                        new { TrailerId = 7, BrakeId = 15 },

                        //PALMS 12D
                        new { TrailerId = 8, BrakeId = 1 },
                        new { TrailerId = 8, BrakeId = 10 },
                        new { TrailerId = 8, BrakeId = 16 },
                        new { TrailerId = 8, BrakeId = 12 },
                        new { TrailerId = 8, BrakeId = 17 },
                        new { TrailerId = 8, BrakeId = 18 },
                        new { TrailerId = 8, BrakeId = 19 },

                        //PALMS 12DWD
                        new { TrailerId = 9, BrakeId = 1 },
                        new { TrailerId = 9, BrakeId = 10 },
                        new { TrailerId = 9, BrakeId = 11 },
                        new { TrailerId = 9, BrakeId = 12 },
                        new { TrailerId = 9, BrakeId = 13 },
                        new { TrailerId = 9, BrakeId = 14 },
                        new { TrailerId = 9, BrakeId = 15 },

                        //PALMS 14D
                        new { TrailerId = 10, BrakeId = 1 },
                        new { TrailerId = 10, BrakeId = 10 },
                        new { TrailerId = 10, BrakeId = 16 },
                        new { TrailerId = 10, BrakeId = 12 },
                        new { TrailerId = 10, BrakeId = 17 },
                        new { TrailerId = 10, BrakeId = 18 },
                        new { TrailerId = 10, BrakeId = 19 },

                        //PALMS 14DWD
                        new { TrailerId = 11, BrakeId = 1 },
                        new { TrailerId = 11, BrakeId = 10 },
                        new { TrailerId = 11, BrakeId = 11 },
                        new { TrailerId = 11, BrakeId = 12 },
                        new { TrailerId = 11, BrakeId = 13 },
                        new { TrailerId = 11, BrakeId = 14 },
                        new { TrailerId = 11, BrakeId = 15 }
                    )
                );

            // PROPULSIONS
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Propulsion)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("PropulsionTrailer")
                    .HasData
                    (
                        //PALMS 8D
                        new { TrailerId = 3, PropulsionId = 1 },
                        new { TrailerId = 3, PropulsionId = 2 },

                        //PALMS 8DWD
                        new { TrailerId = 4, PropulsionId = 3 },
                        new { TrailerId = 4, PropulsionId = 4 },

                        //PALMS 9SC
                        new { TrailerId = 5, PropulsionId = 1 },
                        new { TrailerId = 5, PropulsionId = 2 },

                        //PALMS 10D
                        new { TrailerId = 6, PropulsionId = 5 },
                        new { TrailerId = 6, PropulsionId = 6 },

                        //PALMS 10DWD
                        new { TrailerId = 7, PropulsionId = 3 },
                        new { TrailerId = 7, PropulsionId = 4 },

                        //PALMS 12D
                        new { TrailerId = 8, PropulsionId = 5 },
                        new { TrailerId = 8, PropulsionId = 6 },

                        //PALMS 12DWD
                        new { TrailerId = 9, PropulsionId = 3 },
                        new { TrailerId = 9, PropulsionId = 4 },

                        //PALMS 14D
                        new { TrailerId = 10, PropulsionId = 5 },
                        new { TrailerId = 10, PropulsionId = 6 },

                        //PALMS 14DWD
                        new { TrailerId = 11, PropulsionId = 3 },
                        new { TrailerId = 11, PropulsionId = 4 }

                    )

                );

            // DRAWBARS
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Drawbar)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("DrawbarTrailer")
                    .HasData
                    (
                        //PALMS 6S
                        new { TrailerId = 1, DrawbarId = 1 },
                        new { TrailerId = 1, DrawbarId = 2 },
                        new { TrailerId = 1, DrawbarId = 3 },
                        new { TrailerId = 1, DrawbarId = 4 },
                        new { TrailerId = 1, DrawbarId = 5 },
                        new { TrailerId = 1, DrawbarId = 9 },

                        //PALMS 8SX
                        new { TrailerId = 2, DrawbarId = 1 },
                        new { TrailerId = 2, DrawbarId = 2 },
                        new { TrailerId = 2, DrawbarId = 3 },
                        new { TrailerId = 2, DrawbarId = 4 },
                        new { TrailerId = 2, DrawbarId = 5 },
                        new { TrailerId = 2, DrawbarId = 6 },
                        new { TrailerId = 2, DrawbarId = 7 },
                        new { TrailerId = 2, DrawbarId = 9 },

                        //PALMS 8D
                        new { TrailerId = 3, DrawbarId = 1 },
                        new { TrailerId = 3, DrawbarId = 2 },
                        new { TrailerId = 3, DrawbarId = 3 },
                        new { TrailerId = 3, DrawbarId = 4 },
                        new { TrailerId = 3, DrawbarId = 5 },
                        new { TrailerId = 3, DrawbarId = 6 },
                        new { TrailerId = 3, DrawbarId = 9 },

                        //PALMS 8DWD
                        new { TrailerId = 4, DrawbarId = 1 },
                        new { TrailerId = 4, DrawbarId = 2 },
                        new { TrailerId = 4, DrawbarId = 3 },
                        new { TrailerId = 4, DrawbarId = 4 },
                        new { TrailerId = 4, DrawbarId = 5 },
                        new { TrailerId = 4, DrawbarId = 6 },
                        new { TrailerId = 4, DrawbarId = 9 },

                        //PALMS 9SC
                        new { TrailerId = 5, DrawbarId = 1 },
                        new { TrailerId = 5, DrawbarId = 2 },
                        new { TrailerId = 5, DrawbarId = 3 },
                        new { TrailerId = 5, DrawbarId = 4 },
                        new { TrailerId = 5, DrawbarId = 5 },
                        new { TrailerId = 5, DrawbarId = 6 },
                        new { TrailerId = 5, DrawbarId = 9 },

                        //PALMS 10D
                        new { TrailerId = 6, DrawbarId = 1 },
                        new { TrailerId = 6, DrawbarId = 2 },
                        new { TrailerId = 6, DrawbarId = 3 },
                        new { TrailerId = 6, DrawbarId = 4 },
                        new { TrailerId = 6, DrawbarId = 5 },
                        new { TrailerId = 6, DrawbarId = 6 },
                        new { TrailerId = 6, DrawbarId = 9 },

                        //PALMS 10DWD
                        new { TrailerId = 7, DrawbarId = 1 },
                        new { TrailerId = 7, DrawbarId = 2 },
                        new { TrailerId = 7, DrawbarId = 3 },
                        new { TrailerId = 7, DrawbarId = 4 },
                        new { TrailerId = 7, DrawbarId = 5 },
                        new { TrailerId = 7, DrawbarId = 6 },
                        new { TrailerId = 7, DrawbarId = 9 },

                        //PALMS 12D
                        new { TrailerId = 8, DrawbarId = 1 },
                        new { TrailerId = 8, DrawbarId = 2 },
                        new { TrailerId = 8, DrawbarId = 3 },
                        new { TrailerId = 8, DrawbarId = 4 },
                        new { TrailerId = 8, DrawbarId = 5 },
                        new { TrailerId = 8, DrawbarId = 6 },
                        new { TrailerId = 8, DrawbarId = 8 },
                        new { TrailerId = 8, DrawbarId = 9 },

                        //PALMS 12DWD
                        new { TrailerId = 9, DrawbarId = 1 },
                        new { TrailerId = 9, DrawbarId = 2 },
                        new { TrailerId = 9, DrawbarId = 3 },
                        new { TrailerId = 9, DrawbarId = 4 },
                        new { TrailerId = 9, DrawbarId = 5 },
                        new { TrailerId = 9, DrawbarId = 6 },
                        new { TrailerId = 9, DrawbarId = 8 },
                        new { TrailerId = 9, DrawbarId = 9 },

                        //PALMS 14D
                        new { TrailerId = 10, DrawbarId = 1 },
                        new { TrailerId = 10, DrawbarId = 2 },
                        new { TrailerId = 10, DrawbarId = 3 },
                        new { TrailerId = 10, DrawbarId = 4 },
                        new { TrailerId = 10, DrawbarId = 5 },
                        new { TrailerId = 10, DrawbarId = 6 },
                        new { TrailerId = 10, DrawbarId = 8 },
                        new { TrailerId = 10, DrawbarId = 9 },

                        //PALMS 14DWD
                        new { TrailerId = 11, DrawbarId = 1 },
                        new { TrailerId = 11, DrawbarId = 2 },
                        new { TrailerId = 11, DrawbarId = 3 },
                        new { TrailerId = 11, DrawbarId = 4 },
                        new { TrailerId = 11, DrawbarId = 5 },
                        new { TrailerId = 11, DrawbarId = 6 },
                        new { TrailerId = 11, DrawbarId = 8 },
                        new { TrailerId = 11, DrawbarId = 9 }
                    )                     

                );

            // PLATFORMS
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Platform)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("PlatformTrailer")
                    .HasData
                    (
                        //PALMS 6S
                        new { TrailerId = 1, PlatformId = 1 },

                        //PALMS 8SX
                        new { TrailerId = 2, PlatformId = 1 },
                        new { TrailerId = 2, PlatformId = 2 },

                        //PALMS 8D
                        new { TrailerId = 3, PlatformId = 1 },
                        new { TrailerId = 3, PlatformId = 2 },

                        //PALMS 8DWD
                        new { TrailerId = 4, PlatformId = 1 },
                        new { TrailerId = 4, PlatformId = 2 },

                        //PALMS 9SC
                        new { TrailerId = 5, PlatformId = 1 },

                        //PALMS 10D
                        new { TrailerId = 6, PlatformId = 1 },

                        //PALMS 10DWD
                        new { TrailerId = 7, PlatformId = 1 },

                        //PALMS 12D
                        new { TrailerId = 8, PlatformId = 1 },
                                
                        //PALMS 12DWD
                        new { TrailerId = 9, PlatformId = 1 },

                        //PALMS 14D
                        new { TrailerId = 10, PlatformId = 1 },

                        //PALMS 14DWD
                        new { TrailerId = 11, PlatformId = 1 }
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
                        new { TrailerId = 3, OilPumpId = 7 },

                        new { TrailerId = 4, OilPumpId = 1 },
                        new { TrailerId = 4, OilPumpId = 2 },
                        new { TrailerId = 4, OilPumpId = 3 },
                        new { TrailerId = 4, OilPumpId = 4 },
                        new { TrailerId = 4, OilPumpId = 5 },
                        new { TrailerId = 4, OilPumpId = 6 },
                        new { TrailerId = 4, OilPumpId = 7 },

                        new { TrailerId = 5, OilPumpId = 1 },
                        new { TrailerId = 5, OilPumpId = 2 },
                        new { TrailerId = 5, OilPumpId = 3 },
                        new { TrailerId = 5, OilPumpId = 4 },
                        new { TrailerId = 5, OilPumpId = 5 },
                        new { TrailerId = 5, OilPumpId = 6 },
                        new { TrailerId = 5, OilPumpId = 7 },

                        new { TrailerId = 6, OilPumpId = 1 },
                        new { TrailerId = 6, OilPumpId = 2 },
                        new { TrailerId = 6, OilPumpId = 3 },
                        new { TrailerId = 6, OilPumpId = 4 },
                        new { TrailerId = 6, OilPumpId = 5 },
                        new { TrailerId = 6, OilPumpId = 6 },
                        new { TrailerId = 6, OilPumpId = 7 },

                        new { TrailerId = 7, OilPumpId = 1 },
                        new { TrailerId = 7, OilPumpId = 2 },
                        new { TrailerId = 7, OilPumpId = 3 },
                        new { TrailerId = 7, OilPumpId = 4 },
                        new { TrailerId = 7, OilPumpId = 5 },
                        new { TrailerId = 7, OilPumpId = 6 },
                        new { TrailerId = 7, OilPumpId = 7 },

                        new { TrailerId = 8, OilPumpId = 1 },
                        new { TrailerId = 8, OilPumpId = 2 },
                        new { TrailerId = 8, OilPumpId = 3 },
                        new { TrailerId = 8, OilPumpId = 4 },
                        new { TrailerId = 8, OilPumpId = 5 },
                        new { TrailerId = 8, OilPumpId = 6 },
                        new { TrailerId = 8, OilPumpId = 7 },

                        new { TrailerId = 9, OilPumpId = 1 },
                        new { TrailerId = 9, OilPumpId = 2 },
                        new { TrailerId = 9, OilPumpId = 3 },
                        new { TrailerId = 9, OilPumpId = 4 },
                        new { TrailerId = 9, OilPumpId = 5 },
                        new { TrailerId = 9, OilPumpId = 6 },
                        new { TrailerId = 9, OilPumpId = 7 },

                        new { TrailerId = 10, OilPumpId = 1 },
                        new { TrailerId = 10, OilPumpId = 2 },
                        new { TrailerId = 10, OilPumpId = 3 },
                        new { TrailerId = 10, OilPumpId = 4 },
                        new { TrailerId = 10, OilPumpId = 5 },
                        new { TrailerId = 10, OilPumpId = 6 },
                        new { TrailerId = 10, OilPumpId = 7 },

                        new { TrailerId = 11, OilPumpId = 1 },
                        new { TrailerId = 11, OilPumpId = 2 },
                        new { TrailerId = 11, OilPumpId = 3 },
                        new { TrailerId = 11, OilPumpId = 4 },
                        new { TrailerId = 11, OilPumpId = 5 },
                        new { TrailerId = 11, OilPumpId = 6 },
                        new { TrailerId = 11, OilPumpId = 7 }
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
                        new { TrailerId = 3, OilTankId = 4 },

                        new { TrailerId = 4, OilTankId = 1 },
                        new { TrailerId = 4, OilTankId = 2 },
                        new { TrailerId = 4, OilTankId = 3 },
                        new { TrailerId = 4, OilTankId = 4 },


                        new { TrailerId = 5, OilTankId = 1 },
                        new { TrailerId = 5, OilTankId = 2 },
                        new { TrailerId = 5, OilTankId = 3 },
                        new { TrailerId = 5, OilTankId = 4 },

                        new { TrailerId = 6, OilTankId = 1 },
                        new { TrailerId = 6, OilTankId = 2 },
                        new { TrailerId = 6, OilTankId = 3 },
                        new { TrailerId = 6, OilTankId = 4 },


                        new { TrailerId = 7, OilTankId = 1 },
                        new { TrailerId = 7, OilTankId = 2 },
                        new { TrailerId = 7, OilTankId = 3 },
                        new { TrailerId = 7, OilTankId = 4 },

                        new { TrailerId = 8, OilTankId = 1 },
                        new { TrailerId = 8, OilTankId = 2 },
                        new { TrailerId = 8, OilTankId = 3 },
                        new { TrailerId = 8, OilTankId = 4 },


                        new { TrailerId = 9, OilTankId = 1 },
                        new { TrailerId = 9, OilTankId = 2 },
                        new { TrailerId = 9, OilTankId = 3 },
                        new { TrailerId = 9, OilTankId = 4 },

                        new { TrailerId = 10, OilTankId = 1 },
                        new { TrailerId = 10, OilTankId = 2 },
                        new { TrailerId = 10, OilTankId = 3 },
                        new { TrailerId = 10, OilTankId = 4 },


                        new { TrailerId = 11, OilTankId = 1 },
                        new { TrailerId = 11, OilTankId = 2 },
                        new { TrailerId = 11, OilTankId = 3 },
                        new { TrailerId = 11, OilTankId = 4 }
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
                        new { TrailerId = 3, SupportLegId = 3 },

                        new { TrailerId = 4, SupportLegId = 2 },
                        new { TrailerId = 4, SupportLegId = 3 },

                        new { TrailerId = 5, SupportLegId = 2 },
                        new { TrailerId = 5, SupportLegId = 3 },

                        new { TrailerId = 6, SupportLegId = 2 },
                        new { TrailerId = 6, SupportLegId = 3 },

                        new { TrailerId = 7, SupportLegId = 2 },
                        new { TrailerId = 7, SupportLegId = 3 },

                        new { TrailerId = 8, SupportLegId = 2 },
                        new { TrailerId = 8, SupportLegId = 3 },

                        new { TrailerId = 9, SupportLegId = 2 },
                        new { TrailerId = 9, SupportLegId = 3 },

                        new { TrailerId = 10, SupportLegId = 2 },
                        new { TrailerId = 10, SupportLegId = 3 },

                        new { TrailerId = 11, SupportLegId = 2 },
                        new { TrailerId = 11, SupportLegId = 3 }
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
                       new { TrailerId = 3, LightId = 3 },

                       new { TrailerId = 4, LightId = 1 },
                       new { TrailerId = 4, LightId = 2 },
                       new { TrailerId = 4, LightId = 3 },

                       new { TrailerId = 5, LightId = 1 },
                       new { TrailerId = 5, LightId = 2 },
                       new { TrailerId = 5, LightId = 3 },

                       new { TrailerId = 6, LightId = 1 },
                       new { TrailerId = 6, LightId = 2 },
                       new { TrailerId = 6, LightId = 3 },

                       new { TrailerId = 7, LightId = 1 },
                       new { TrailerId = 7, LightId = 2 },
                       new { TrailerId = 7, LightId = 3 },

                       new { TrailerId = 8, LightId = 1 },
                       new { TrailerId = 8, LightId = 2 },
                       new { TrailerId = 8, LightId = 3 },

                       new { TrailerId = 9, LightId = 1 },
                       new { TrailerId = 9, LightId = 2 },
                       new { TrailerId = 9, LightId = 3 },

                       new { TrailerId = 10, LightId = 1 },
                       new { TrailerId = 10, LightId = 2 },
                       new { TrailerId = 10, LightId = 3 },

                       new { TrailerId = 11, LightId = 1 },
                       new { TrailerId = 11, LightId = 2 },
                       new { TrailerId = 11, LightId = 3 }
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
