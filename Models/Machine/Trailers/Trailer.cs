using CalcAppAPI.Models.Machine.Configurations.Trailers;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace CalcAppAPI.Models
{
    public class Trailer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; } 
        public string BeamType { get; set; } 
        public string LoadingAreaCross { get; set; }
        public string LoadingAreaLength { get; set; } 
        public string Frame { get; set; } = string.Empty;
        public string FrameExtensionLength { get; set; } 
        public string GrossWeight { get; set; } 
        public string CurbWeight { get; set; } 
        public string TotalLength { get; set; }
        public string WidthWithStandardWheels { get; set; }
        public string StandardWheelSize { get; set; }
        public string MaxCraneSize { get; set; }
        public string DrawbarControlCylinders { get; set; }
        public IEnumerable<Crane> Crane { get; set; }
        public IEnumerable<Stanchion> Stanchion { get; set; } 
        public IEnumerable<Brake> Brake { get; set; }
        public IEnumerable<Propulsion> Propulsion { get; set; }
        public IEnumerable<Drawbar> Drawbar { get; set; }
        public IEnumerable<Platform> Platform { get; set; }
        public IEnumerable<OilPump> OilPump { get; set; }
        public IEnumerable<OilTank> OilTank { get; set; }
        public IEnumerable<SupportLeg> SupportLeg { get; set; }
        public IEnumerable<TrailerLights> Light { get; set; }
        public IEnumerable<Tyre> Tyre { get; set; }
        public BolsterLock? BolsterLock { get; set; }
        public int? BolsterLockId { get; set; }
        public BBox? BBox { get; set; }
        public int? BBoxId { get; set; }
        public WoodSorter? WoodSorter { get; set; }
        public int? WoodSorterId { get; set; }
        public HandBrake? HandBrake { get; set; }
        public int? HandBrakeId { get; set; }
        public ChainsawHolder? ChainsawHolder { get; set; }
        public int? ChainsawHolderId { get; set; }
        public UnderrunProtection? UnderrunProtection { get; set; }
        public int? UnderrunProtectionId { get; set; }

        public IEnumerable<TrailerCraneConfiguration> CraneConfigurations { get; set; }
    }
}
