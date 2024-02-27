namespace CalcAppAPI.Models.Machine.Configurations.Cranes
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
