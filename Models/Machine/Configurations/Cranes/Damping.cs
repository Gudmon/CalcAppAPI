namespace CalcAppAPI.Models.Machine.Configurations.Cranes
{
    public class Damping
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
        public required string Price { get; set; }
        public IEnumerable<Crane> Crane { get; set; }
    }
}
