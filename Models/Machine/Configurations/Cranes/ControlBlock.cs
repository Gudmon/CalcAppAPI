using CalcAppAPI.Models.Machine.Configurations.Trailers;
using System.ComponentModel.DataAnnotations;

namespace CalcAppAPI.Models.Machine.Configurations.Cranes
{
    public class ControlBlock
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Price { get; set; }
        public IEnumerable<CraneControlBlock> CraneControlBlocks { get; set; }
        public IEnumerable<FrameType> AvailableForFrameTypes { get; set; }
        public IEnumerable<Crane> Crane { get; set; }
    }
}
