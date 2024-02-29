using CalcAppAPI.Data.Extensions.Connect.Cranes;
using CalcAppAPI.Data.Extensions.Connect.Trailers;
using CalcAppAPI.Data.Extensions.Palms.Cranes;
using CalcAppAPI.Data.Extensions.Palms.Trailers;
using CalcAppAPI.Models;
using CalcAppAPI.Models.Machine.Configurations.Cranes;
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
        public DbSet<TrailerOilCooler> TrailerOilCooler { get; set; }
        public DbSet<BolsterLock> BolsterLock { get; set; }
        public DbSet<BBox> BBox { get; set; }
        public DbSet<WoodSorter> WoodSorter { get; set; }
        public DbSet<HandBrake> HandBrake { get; set; }
        public DbSet<ChainsawHolder> ChainsawHolder { get; set; }
        public DbSet<UnderrunProtection> UnderrunProtection { get; set; }
        public DbSet<SupportLeg> SupportLeg { get; set; }
        public DbSet<TrailerLights> TrailerLight { get; set; }
        public DbSet<Tyre> Tyre { get; set; }
        public DbSet<Crane> Crane { get; set; }
        public DbSet<FrameType> FrameType { get; set; }
        public DbSet<ControlBlock> ControlBlocks { get; set; }
        public DbSet<CraneControlBlock> CraneControlBlocks { get; set; }
        public DbSet<Rotator> Rotator { get; set; }
        public DbSet<Grapple> Grapple { get; set; }
        public DbSet<Winch> Winch { get; set; }
        public DbSet<ProtectionSleeves> ProtectionSleeves { get; set; }
        public DbSet<ElectricalFloating> ElectricalFloating { get; set; }
        public DbSet<ValveBlock> ValveBlock { get; set; }
        public DbSet<Damping> Damping { get; set; }
        public DbSet<CraneLight> CraneLight { get; set; }
        public DbSet<OperatorSeat> OperatorSeat { get; set; }
        public DbSet<CraneOilCooler> CraneOilCooler { get; set; }
        public DbSet<RotatorBrake> RotatorBrake { get; set; }
        public DbSet<JoystickHolder> JoystickHolder { get; set; }
        public DbSet<HoseGuard> HoseGuard { get; set; }
        public DbSet<TurningDeviceCounterPlate> TurningDeviceCounterPlate { get; set; }
        public DbSet<SupportLegCounterPlate> SupportLegCounterPlate { get; set; }
        public DbSet<BoomGuard> BoomGuard { get; set; }
        public DbSet<Cover> Cover { get; set; }
        public DbSet<WoodControl> WoodControl { get; set; }
        public DbSet<Linkage> Linkage { get; set; }
        public DbSet<TrailerCraneConfiguration> TrailerCraneConfigurations { get; set; }


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
            modelBuilder.ConfigureMultiplePalmsTrailerOilCoolers();
            modelBuilder.ConfigureMultiplePalmsBolsterLocks();
            modelBuilder.ConfigureMultiplePalmsBBoxes();
            modelBuilder.ConfigureMultiplePalmsWoodSorters();
            modelBuilder.ConfigureMultiplePalmsHandBrakes();
            modelBuilder.ConfigureMultiplePalmsChainsawHolders();
            modelBuilder.ConfigureMultiplePalmsUnderrunProtections();
            modelBuilder.ConfigureMultiplePalmsSupportLegs();
            modelBuilder.ConfigureMultiplePalmsTrailerLights();
            modelBuilder.ConfigureMultiplePalmsTyres();

            modelBuilder.ConfigureMultiplePalmsFrameTypes();
            modelBuilder.ConfigureMultiplePalmsControlBlocks();
            modelBuilder.ConfigureMultiplePalmsRotators();
            modelBuilder.ConfigureMultiplePalmsGrapples();
            modelBuilder.ConfigureMultiplePalmsWinches();
            modelBuilder.ConfigureMultiplePalmsProtectionSleeves();
            modelBuilder.ConfigureMultiplePalmsElectricalFloatings();
            modelBuilder.ConfigureMultiplePalmsValveBlocks();
            modelBuilder.ConfigureMultiplePalmsDampings();
            modelBuilder.ConfigureMultiplePalmsCraneLights();
            modelBuilder.ConfigureMultiplePalmsCraneOperatorSeats();
            modelBuilder.ConfigureMultiplePalmsCraneOilCoolers();
            modelBuilder.ConfigureMultiplePalmsCraneRotatorBrakes();
            modelBuilder.ConfigureMultiplePalmsCraneJoyStickHolders();
            modelBuilder.ConfigureMultiplePalmsCraneHoseGuards();
            modelBuilder.ConfigureMultiplePalmsCraneTurningDeviceCounterPlates();
            modelBuilder.ConfigureMultiplePalmsCraneSupportLegCounterPlates();
            modelBuilder.ConfigureMultiplePalmsCraneBoomGuards();
            modelBuilder.ConfigureMultiplePalmsCraneCovers();
            modelBuilder.ConfigureMultiplePalmsCraneWoodControls();
            modelBuilder.ConfigureMultiplePalmsCraneLinkages();

            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.CraneConfigurations)
                .WithOne(tc => tc.Trailer)
                .HasForeignKey(tc => tc.TrailerId);

            modelBuilder.Entity<Crane>()
                .HasMany(c => c.TrailerConfigurations)
                .WithOne(tc => tc.Crane)
                .HasForeignKey(tc => tc.CraneId);

            modelBuilder.Entity<TrailerCraneConfiguration>().HasData(
                new TrailerCraneConfiguration
                {
                    Id = 1,
                    TrailerId = 1,
                    CraneId = 1, 
                    SelectedFrameTypeId = 1 
                },
                new TrailerCraneConfiguration
                {
                    Id = 2,
                    TrailerId = 1,
                    CraneId = 1,
                    SelectedFrameTypeId = 2 
                },

                new TrailerCraneConfiguration
                {
                    Id = 3,
                    TrailerId = 1,
                    CraneId = 2, 
                    SelectedFrameTypeId = 1 
                },
                new TrailerCraneConfiguration
                {
                    Id = 4,
                    TrailerId = 1,
                    CraneId = 2,
                    SelectedFrameTypeId = 2
                },

                new TrailerCraneConfiguration
                {
                    Id = 5,
                    TrailerId = 1,
                    CraneId = 3,
                    SelectedFrameTypeId = 1
                },
                new TrailerCraneConfiguration
                {
                    Id = 6,
                    TrailerId = 1,
                    CraneId = 3,
                    SelectedFrameTypeId = 2
                },




                new TrailerCraneConfiguration
                {
                    Id = 7,
                    TrailerId = 2,
                    CraneId = 1,
                    SelectedFrameTypeId = 1
                },
                new TrailerCraneConfiguration
                {
                    Id = 8,
                    TrailerId = 2,
                    CraneId = 1,
                    SelectedFrameTypeId = 2
                },

                new TrailerCraneConfiguration
                {
                    Id = 9,
                    TrailerId = 2,
                    CraneId = 2,
                    SelectedFrameTypeId = 1
                },
                new TrailerCraneConfiguration
                {
                    Id = 10,
                    TrailerId = 2,
                    CraneId = 2,
                    SelectedFrameTypeId = 2
                },

                new TrailerCraneConfiguration
                {
                    Id = 11,
                    TrailerId = 2,
                    CraneId = 3,
                    SelectedFrameTypeId = 1
                },
                new TrailerCraneConfiguration
                {
                    Id = 12,
                    TrailerId = 2,
                    CraneId = 3,
                    SelectedFrameTypeId = 2
                },

                new TrailerCraneConfiguration
                {
                    Id = 13,
                    TrailerId = 2,
                    CraneId = 4,
                    SelectedFrameTypeId = 1
                },
                new TrailerCraneConfiguration
                {
                    Id = 14,
                    TrailerId = 2,
                    CraneId = 4,
                    SelectedFrameTypeId = 3
                },
                new TrailerCraneConfiguration
                {
                    Id = 15,
                    TrailerId = 2,
                    CraneId = 4,
                    SelectedFrameTypeId = 4
                }

            );

            modelBuilder.ConnectTrailersWithCranes();
            modelBuilder.ConnectTrailersWithStanchions();
            modelBuilder.ConnectTrailersWithBrakes();
            modelBuilder.ConnectTrailersWithPropulsions();
            modelBuilder.ConnectTrailersWithDrawbars();
            modelBuilder.ConnectTrailersWithPlatforms();
            modelBuilder.ConnectTrailersWithOilPumps();
            modelBuilder.ConnectTrailersWithOilTanks();

            //OIL TANK COOLER
            modelBuilder.Entity<TrailerOilCooler>()
                .HasMany(o => o.OilTank)
                .WithOne(o => o.TrailerOilCooler)
                .HasForeignKey(o => o.TrailerOilCoolerId)
                .IsRequired(false);

            //BOLSTER LOCK
            modelBuilder.Entity<BolsterLock>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.BolsterLock)
                .HasForeignKey(o => o.BolsterLockId)
                .IsRequired(false);

            //BBOX
            modelBuilder.Entity<BBox>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.BBox)
                .HasForeignKey(o => o.BBoxId)
                .IsRequired(false);

            //WOOD SORTER
            modelBuilder.Entity<WoodSorter>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.WoodSorter)
                .HasForeignKey(o => o.WoodSorterId)
                .IsRequired(false);

            //HANDBRAKES
            modelBuilder.Entity<HandBrake>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.HandBrake)
                .HasForeignKey(o => o.HandBrakeId)
                .IsRequired(false);

            //CHAINSAW HOLDERS
            modelBuilder.Entity<ChainsawHolder>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.ChainsawHolder)
                .HasForeignKey(o => o.ChainsawHolderId)
                .IsRequired(false);

            //UNDERRUN PROTECTION
            modelBuilder.Entity<UnderrunProtection>()
                .HasMany(o => o.Trailer)
                .WithOne(o => o.UnderrunProtection)
                .HasForeignKey(o => o.UnderrunProtectionId)
                .IsRequired(false);

            modelBuilder.ConnectTrailersWithSupportLegs();
            modelBuilder.ConnectTrailersWithLights();
            modelBuilder.ConnectTrailersWithTyres();


            modelBuilder.Entity<ControlBlock>()
                .HasMany(cb => cb.AvailableForFrameTypes)
                .WithMany();

            modelBuilder.ConnectCranesWithFrameTypes();
            modelBuilder.ConnectCranesWithFrameTypesAndControlBlocks();
            modelBuilder.ConnectCranesWithControlBlocks();
            modelBuilder.ConnectCranesWithRotators();
            modelBuilder.ConnectCranesWithGrapples();
            modelBuilder.ConnectCranesWithWinches();

            //PROTECTION SLEEVES
            modelBuilder.Entity<ProtectionSleeves>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.ProtectionSleeves)
                .HasForeignKey(o => o.ProtectionSleevesId)
                .IsRequired(false);

            //ELECTRICAL FLOATINGS
            modelBuilder.Entity<ElectricalFloating>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.ElectricalFloating)
                .HasForeignKey(o => o.ElectricalFloatingId)
                .IsRequired(false);

            //VALVE BLOCK
            modelBuilder.Entity<ValveBlock>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.ValveBlock)
                .HasForeignKey(o => o.ValveBlockId)
                .IsRequired(false);

            //DAMPINGS
            modelBuilder.ConnectCranesWithDampings();

            //LIGHT
            modelBuilder.Entity<CraneLight>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.Light)
                .HasForeignKey(o => o.LightId)
                .IsRequired(false);

            //OPERATOR SEAT
            modelBuilder.Entity<OperatorSeat>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.OperatorSeat)
                .HasForeignKey(o => o.OperatorSeatId)
                .IsRequired(false);

            //CRANE OILCOOLER
            modelBuilder.Entity<CraneOilCooler>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.CraneOilCooler)
                .HasForeignKey(o => o.CraneOilCoolerId)
                .IsRequired(false);

            //ROTATOR BRAKES
            modelBuilder.ConnectCranesWithRotatorBrakes();

            //CRANE OILCOOLER
            modelBuilder.Entity<CraneOilCooler>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.CraneOilCooler)
                .HasForeignKey(o => o.CraneOilCoolerId)
                .IsRequired(false);

            //JOYSTICK HOLDER
            modelBuilder.Entity<JoystickHolder>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.JoystickHolder)
                .HasForeignKey(o => o.JoystickHolderId)
                .IsRequired(false);

            //HOSE GUARDS
            modelBuilder.ConnectCranesWithHoseGuards();

            //TURNING DEVICE COUNTER PLATE
            modelBuilder.Entity<TurningDeviceCounterPlate>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.TurningDeviceCounterPlate)
                .HasForeignKey(o => o.TurningDeviceCounterPlateId)
                .IsRequired(false);

            //SUPPORT LEG COUNTER PLATE
            modelBuilder.Entity<SupportLegCounterPlate>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.SupportLegCounterPlate)
                .HasForeignKey(o => o.SupportLegCounterPlateId)
                .IsRequired(false);

            //BOOM GUARD
            modelBuilder.Entity<BoomGuard>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.BoomGuard)
                .HasForeignKey(o => o.BoomGuardId)
                .IsRequired(false);

            //COVER
            modelBuilder.Entity<Cover>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.Cover)
                .HasForeignKey(o => o.CoverId)
                .IsRequired(false);

            //WOOD CONTROL
            modelBuilder.Entity<WoodControl>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.WoodControl)
                .HasForeignKey(o => o.WoodControlId)
                .IsRequired(false);

            //LINKAGE
            modelBuilder.Entity<Linkage>()
                .HasMany(o => o.Crane)
                .WithOne(o => o.Linkage)
                .HasForeignKey(o => o.LinkageId)
                .IsRequired(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
