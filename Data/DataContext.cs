using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.PortableExecutable;

namespace CalcAppAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<Trailer> Trailer { get; set; }
        public DbSet<Crane> Crane { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trailer>().HasData(
                new Trailer
                {
                    Id = 1,
                    StanchionNumber = "3",
                    Name = "PALMS 6S",
                    Description = "A PALMS 6S egyetlen gerendás erdészeti pótkocsi, melynek nominális teherbírása 6 tonna. Könnyű és kompakt kialakítása tökéletes választás kisebb traktorokhoz, ideális magán-erdőgazdálkodáshoz és gazdálkodóknak. A PALMS 6S hasonló technológiákat használ, mint nagyobb pótkocsijaink, beleértve a magas minőségű KTL és porfestési bevonatot, ami hosszabb élettartamot és nagyobb újraértékesítési értéket biztosít.",
                    Price = "5285",
                    LoadingAreaCross = "1.5",
                    LoadingAreaLength = "3000",
                    FrameExtensionLength = "-",
                    GrossWeight = "8500",
                    CurbWeight = "890",
                    TotalLength = "4900",
                    WidthWithStandardWheels = "1950",
                    StandardWheelSize = "400/60-15,5",
                    MaxCraneSize = "35",
                    DrawbarControlCylinders = "1",
                    BeamType = "Single",
                    Frame = "140x140x6"
                }
            );

            modelBuilder.Entity<Crane>().HasData(
                new Crane
                {
                    Id = 1,
                    Name = "PALMS 2.42",
                    Description = "Ideális választás azoknak a vásárlóknak, akik egyszerűséget, könnyűséget és kompakt méretet keresnek. Kompatibilis a PALMS 6S és 8SX pótkocsikkal.",
                    Price = "5165",
                    Series = "2",
                    MaxReach = "4.2",
                    LiftAtFullReach240Bar = "-",
                    LiftAtFullReach215Bar = "-",
                    LiftAtFullReach190Bar = "540",
                    LiftAtFourMeters240Bar = "-",
                    LiftAtFourMeters215Bar = "-",
                    LiftAtFourMeters190Bar = "570",
                    BrutLiftingTorque240Bar = "-",
                    BrutLiftingTorque215Bar = "-",
                    BrutLiftingTorque190Bar = "26",
                    SlewingCylinder = "4",
                    SlewingTorque = "7.8",
                    WorkingPressure = "190",
                    RotatorMaximumLoad = "45",
                    CraneWeight = "360",
                    PillarSlewingAngle = "370",
                    RecommendedOilFLow = "20-35",
                }
            );

            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Crane)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("CraneTrailer")
                    .HasData(new { TrailerId = 1, CraneId = 1 })
                );
        }
    }
}
