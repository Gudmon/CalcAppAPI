using CalcAppAPI.Models.Machine.Palms.Cranes;

namespace CalcAppAPI.Models.Machine.Configurations.Palms.Cranes
{
    public class RotatorBrake
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
        public required string Price { get; set; }
        public string? Description { get; set; }
        public IEnumerable<Crane> Crane { get; set; }
    }
}
