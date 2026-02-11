using CalcAppAPI.Models.Machine.Configurations.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;

namespace CalcAppAPI.Models.Machine.Configurations.Palms.Trailers
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
        public ICollection<Crane> Crane { get; set; } = new List<Crane>();
        public ICollection<Stanchion> Stanchion { get; set; } = new List<Stanchion>();
        public ICollection<Brake> Brake { get; set; } = new List<Brake>();
        public ICollection<Propulsion> Propulsion { get; set; } = new List<Propulsion>();
        public ICollection<Drawbar> Drawbar { get; set; } = new List<Drawbar>();
        public ICollection<Platform> Platform { get; set; } = new List<Platform>();
        public ICollection<OilPump> OilPump { get; set; } = new List<OilPump>();
        public ICollection<OilTank> OilTank { get; set; } = new List<OilTank>();
        public TrailerOilCooler? TrailerOilCooler { get; set; }
        public int? TrailerOilCoolerId { get; set; }
        public ICollection<SupportLeg> SupportLeg { get; set; } = new List<SupportLeg>();
        public ICollection<TrailerLight> Light { get; set; } = new List<TrailerLight>();
        public ICollection<Tyre> Tyre { get; set; } = new List<Tyre>();
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
        public ICollection<HydroPack> HydroPack { get; set; } = new List<HydroPack>();
        public HydroPackControl? HydropackControl { get; set; }
        public int? HydropackControlId { get; set; }
        public ICollection<SupplyFormat> SupplyFormat { get; set; } = new List<SupplyFormat>();
        public Toolbox? Toolbox { get; set; }
        public int? ToolboxId { get; set; }
        public string[] ImageUrls { get; set; } = Array.Empty<string>();
        public string[] VideoUrls { get; set; } = Array.Empty<string>();
    }
}
