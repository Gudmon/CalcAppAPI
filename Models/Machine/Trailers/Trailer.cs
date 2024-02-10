using CalcAppAPI.Models.Machine.Configurations.Trailers;
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
        public IEnumerable<Crane> Crane { get; set; }
        public IEnumerable<Stanchion> Stanchion { get; set; }
        public string LoadingAreaCross { get; set; }
        public string LoadingAreaLength { get; set; }
        public string Frame { get; set; }
        public string FrameExtensionLength { get; set; }
        public string GrossWeight { get; set; }
        public string CurbWeight { get; set; }
        public string TotalLength { get; set; }
        public string WidthWithStandardWheels { get; set; }
        public string StandardWheelSize { get; set; }
        public string MaxCraneSize { get; set; }
        public string DrawbarControlCylinders { get; set; }
        
    }
}
