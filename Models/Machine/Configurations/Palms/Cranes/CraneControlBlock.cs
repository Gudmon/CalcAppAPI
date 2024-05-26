using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CalcAppAPI.Models.Machine.Palms.Cranes;

namespace CalcAppAPI.Models.Machine.Configurations.Palms.Cranes
{
    public class CraneControlBlock
    {
        [Key]
        public int Id { get; set; }
        public int CraneId { get; set; }
        public Crane Crane { get; set; }
        public int ControlBlockId { get; set; }
        public ControlBlock ControlBlock { get; set; }
        public int FrameTypeId { get; set; }
    }
}
