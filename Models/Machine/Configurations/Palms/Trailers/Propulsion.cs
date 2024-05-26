using CalcAppAPI.Models.Machine.Palms.Trailers;

namespace CalcAppAPI.Models.Machine.Configurations.Palms.Trailers
{
    public class Propulsion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public IEnumerable<Trailer> Trailer { get; set; }
    }
}
