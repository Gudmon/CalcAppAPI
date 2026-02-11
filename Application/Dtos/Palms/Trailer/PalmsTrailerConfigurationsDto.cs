using CalcAppAPI.Application.Dtos.Palms.Common;
using CalcAppAPI.Application.Dtos.Palms.Trailer.Options;

namespace CalcAppAPI.Application.Dtos.Palms.Trailer
{
    public class PalmsTrailerConfigurationsDto
    {
        public IEnumerable<BrakeDto> Brakes { get; set; }
        public IEnumerable<StanchionDto> Stanchions { get; set; }
        public IEnumerable<PropulsionDto> Propulsions { get; set; }
        public IEnumerable<DrawbarDto> Drawbars { get; set; }
        public IEnumerable<PlatformDto> Platforms { get; set; }
        public IEnumerable<OilPumpDto> OilPumps { get; set; }
        public IEnumerable<OilTankDto> OilTanks { get; set; }
        public TrailerOilCoolerDto? TrailerOilCooler { get; set; }
        public IEnumerable<SupportLegDto> SupportLegs { get; set; }
        public IEnumerable<TrailerLightDto> TrailerLights { get; set; }
        public IEnumerable<TyreDto> Tyres { get; set; }
        public BolsterLockDto? BolsterLock { get; set; }
        public BBoxDto? BBox { get; set; }
        public DBoxDto? DBox { get; set; }
        public HayBaleFrameDto? HayBaleFrame { get; set; }
        public WoodSorterDto? WoodSorter { get; set; }
        public HandBrakeDto? HandBrake { get; set; }
        public ChainsawHolderDto? ChainsawHolder { get; set; }
        public UnderrunProtectionDto? UnderrunProtection { get; set; }
        public BunkAdapterDto? BunkAdapter { get; set; }
        public BunkExtensionDto? BunkExtension { get; set; }
        public ManualBunkExtensionDto? ManualBunkExtension { get; set; }
        public FrameExtensionDto? FrameExtension { get; set; }
        public ShippingDto? Shipping { get; set; }
        public MOTDto? MOT { get; set; }
        public StanchionExtensionDto? StanchionExtension { get; set; }
        public IEnumerable<HydroPackDto> HydroPacks { get; set; }
        public HydroPackControlDto? HydroPackControl { get; set; }
        public IEnumerable<SupplyFormatDto> SupplyFormats { get; set; }
        public ToolboxDto? Toolbox { get; set; }
    }
}