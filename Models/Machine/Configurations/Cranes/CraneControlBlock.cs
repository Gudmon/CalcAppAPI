using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalcAppAPI.Models.Machine.Configurations.Cranes
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
