using CalcAppAPI.Models.Machine.Configurations.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using CalcAppAPI.Models.Machine.Palms.Cranes;

namespace CalcAppAPI.Models.Machine.Palms.Trailers
{
    public class Trailer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string BeamType { get; set; } = string.Empty;
        public string LoadingAreaCross { get; set; } = string.Empty;
        public string LoadingAreaLength { get; set; } = string.Empty;
        public string Frame { get; set; } = string.Empty;
        public string FrameExtensionLength { get; set; } = string.Empty;
        public string GrossWeight { get; set; } = string.Empty;
        public string CurbWeight { get; set; } = string.Empty;
        public string TotalLength { get; set; } = string.Empty;
        public string WidthWithStandardWheels { get; set; } = string.Empty;
        public string StandardWheelSize { get; set; } = string.Empty;
        public string MaxCraneSize { get; set; } = string.Empty;
        public string DrawbarControlCylinders { get; set; } = string.Empty;
        public IEnumerable<Crane> Crane { get; set; } = Enumerable.Empty<Crane>();
        public IEnumerable<Stanchion> Stanchion { get; set; } = Enumerable.Empty<Stanchion>();
        public IEnumerable<Brake> Brake { get; set; } = Enumerable.Empty<Brake>();
        public IEnumerable<Propulsion> Propulsion { get; set; } = Enumerable.Empty<Propulsion>();
        public IEnumerable<Drawbar> Drawbar { get; set; } = Enumerable.Empty<Drawbar>();
        public IEnumerable<Platform> Platform { get; set; } = Enumerable.Empty<Platform>();
        public IEnumerable<OilPump> OilPump { get; set; } = Enumerable.Empty<OilPump>();
        public IEnumerable<OilTank> OilTank { get; set; } = Enumerable.Empty<OilTank>();
        public TrailerOilCooler? TrailerOilCooler { get; set; }
        public int? TrailerOilCoolerId { get; set; }
        public IEnumerable<SupportLeg> SupportLeg { get; set; } = Enumerable.Empty<SupportLeg>();
        public IEnumerable<TrailerLights> Light { get; set; } = Enumerable.Empty<TrailerLights>();
        public IEnumerable<Tyre> Tyre { get; set; } = Enumerable.Empty<Tyre>();
        public BolsterLock? BolsterLock { get; set; }
        public int? BolsterLockId { get; set; }
        public BBox? BBox { get; set; }
        public int? BBoxId { get; set; }
        public DBox? DBox { get; set; }
        public int? DBoxId { get; set; }
        public HayBaleFrame? HayBaleFrame { get; set; }
        public int? HayBaleFrameId { get; set; }
        public WoodSorter? WoodSorter { get; set; }
        public int? WoodSorterId { get; set; }
        public HandBrake? HandBrake { get; set; }
        public int? HandBrakeId { get; set; }
        public ChainsawHolder? ChainsawHolder { get; set; }
        public int? ChainsawHolderId { get; set; }
        public UnderrunProtection? UnderrunProtection { get; set; }
        public int? UnderrunProtectionId { get; set; }
        public BunkAdapter? BunkAdapter { get; set; }
        public int? BunkAdapterId { get; set; }
        public BunkExtension? BunkExtension { get; set; }
        public int? BunkExtensionId { get; set; }
        public FrameExtension? FrameExtension { get; set; }
        public int? FrameExtensionId { get; set; }
        public Shipping? Shipping { get; set; }
        public int? ShippingId { get; set; }
        public MOT? MOT { get; set; }
        public int? MOTId { get; set; }
        public StanchionExtension? StanchionExtension { get; set; }
        public int? StanchionExtensionId { get; set; }
        public IEnumerable<HydroPack> HydroPack { get; set; } = Enumerable.Empty<HydroPack>();
        public HydroPackControl? HydropackControl { get; set; }
        public int? HydropackControlId { get; set; }
        public IEnumerable<SupplyFormat> SupplyFormat { get; set; } = Enumerable.Empty<SupplyFormat>();
        public Toolbox? Toolbox { get; set; }
        public int? ToolboxId { get; set; }
    }
}
