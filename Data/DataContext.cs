using CalcAppAPI.Data.Extensions.Configure.Krpan;
using CalcAppAPI.Data.Extensions.Configure.Palms.Cranes;
using CalcAppAPI.Data.Extensions.Configure.Palms.Trailers;
using CalcAppAPI.Data.Extensions.Connect.Palms.Cranes;
using CalcAppAPI.Data.Extensions.Connect.Palms.Trailers;
using CalcAppAPI.Models.Machine.Configurations.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using CalcAppAPI.Models.Machine.Krpan.Cranes;
using CalcAppAPI.Models.Machine.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // PALMS
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
        public DbSet<DBox> DBox { get; set; }
        public DbSet<HayBaleFrame> HayBaleFrame { get; set; }
        public DbSet<WoodSorter> WoodSorter { get; set; }
        public DbSet<HandBrake> HandBrake { get; set; }
        public DbSet<ChainsawHolder> ChainsawHolder { get; set; }
        public DbSet<UnderrunProtection> UnderrunProtection { get; set; }
        public DbSet<SupportLeg> SupportLeg { get; set; }
        public DbSet<TrailerLight> TrailerLight { get; set; }
        public DbSet<Tyre> Tyre { get; set; }
        public DbSet<Crane> Crane { get; set; }
        public DbSet<FrameType> FrameType { get; set; }
        public DbSet<ControlBlock> ControlBlocks { get; set; }
        public DbSet<Rotator> Rotator { get; set; }
        public DbSet<Grapple> Grapple { get; set; }
        public DbSet<Winch> Winch { get; set; }
        public DbSet<ProtectionSleeves> ProtectionSleeves { get; set; }
        public DbSet<ElectricalFloating> ElectricalFloating { get; set; }
        public DbSet<ValveBlock> ValveBlock { get; set; }
        public DbSet<Damping> Damping { get; set; }
        public DbSet<CraneLight> CraneLight { get; set; }
        public DbSet<OperatorSeat> OperatorSeat { get; set; }
        public DbSet<HighPerformanceOilFilter> HighPerformanceOilFilter { get; set; }
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
        public DbSet<BunkAdapter> BunkAdapter { get; set; }
        public DbSet<BunkExtension> BunkExtension { get; set; }
        public DbSet<ManualBunkExtension> ManualBunkExtension { get; set; }
        public DbSet<FrameExtension> FrameExtension { get; set; }
        public DbSet<Shipping> Shipping { get; set; }
        public DbSet<MOT> MOT { get; set; }
        public DbSet<StanchionExtension> StanchionExtension { get; set; }
        public DbSet<HydroPack> HydroPack { get; set; }
        public DbSet<HydroPackControl> HydroPackControl { get; set; }
        public DbSet<SupplyFormat> SupplyFormat { get; set; }
        public DbSet<Toolbox> Toolbox { get; set; }
        public DbSet<SupportBracket> SupportBracket { get; set; }

        // KRPAN
        public DbSet<KrpanTrailer> KrpanTrailer { get; set; }
        public DbSet<KrpanHydraulicAdjustableChassis> KrpanHydraulicAdjustableChassis { get; set; }
        public DbSet<KrpanTrailerLamp> KrpanTrailerLamp { get; set; }
        public DbSet<KrpanChock> KrpanChock { get; set; }
        public DbSet<KrpanDrawbarSteering> KrpanDrawbarSteering { get; set; }
        public DbSet<KrpanTrailerSupportLeg> KrpanTrailerSupportLeg { get; set; }
        public DbSet<KrpanPropulsion> KrpanPropulsion { get; set; }
        public DbSet<KrpanAdjustableDrive> KrpanAdjustableDrive { get; set; }
        public DbSet<KrpanTyre> KrpanTyre { get; set; }
        public DbSet<KrpanBrake> KrpanBrake { get; set; }
        public DbSet<KrpanHandBrake> KrpanHandBrake { get; set; }
        public DbSet<KrpanExtraStanchion> KrpanExtraStanchion { get; set; }
        public DbSet<KrpanExtraForwarderStanchion> KrpanExtraForwarderStanchion { get; set; }
        public DbSet<KrpanTopConnection> KrpanTopConnection { get; set; }
        public DbSet<KrpanClutch> KrpanClutch { get; set; }
        public DbSet<KrpanDrawhead> KrpanDrawHead { get; set; }
        public DbSet<KrpanDrawbar> KrpanDrawbar { get; set; }
        public DbSet<KrpanCardanShaft> KrpanCardanShaft { get; set; }
        public DbSet<KrpanBBox> KrpanBBox { get; set; }
        public DbSet<KrpanBaleTransportPlatform> KrpanBaleTransportPlatform { get; set; }
        public DbSet<KrpanCargoSpaceExtension> KrpanCargoSpaceExtension { get; set; }
        public DbSet<KrpanAxeHolder> KrpanAxeHolder { get; set; }
        public DbSet<KrpanChainsawHolder> KrpanChainsawHolder { get; set; }
        public DbSet<KrpanFuelTankHolder> KrpanFuelTankHolder { get; set; }
        public DbSet<KrpanToolBox> KrpanToolBox { get; set; }
        public DbSet<KrpanPlato> KrpanPlato { get; set; }
        public DbSet<KrpanExtension> KrpanExtension { get; set; }
        public DbSet<KrpanHydraulicSupportLeg> KrpanHydraulicSupportLeg { get; set; }
        public DbSet<KrpanGrappleLocation> KrpanGrappleLocation { get; set; }
        public DbSet<KrpanCrane> KrpanCrane { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureAllPalmsTrailerOptions();
            modelBuilder.ConfigureAllPalmsCraneOptions();
            modelBuilder.ConnectAllPalmsTrailerOptions();
            modelBuilder.ConnectAllPalmsCraneOptions();

            modelBuilder.ConfigureAllKrpanMachineOptions();

            base.OnModelCreating(modelBuilder);
        }
    }
}
