using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using CalcAppAPI.Models.Machine.Palms.Cranes;
using System.ComponentModel.DataAnnotations;

namespace CalcAppAPI.Models.Machine.Configurations.Palms.Cranes
{
    public class ControlBlock
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public IEnumerable<Crane> Crane { get; set; }
    }
}
