using CalcAppAPI.Models.Machine.Palms.Trailers;

namespace CalcAppAPI.Models.Machine.Configurations.Palms.Trailers
{
    public abstract class TrailerOption
    {
        public int Id { get; init; }
        public string Name { get; set; } = String.Empty;
        public string Code { get; set; } = String.Empty;
        public string Price { get; set; } = String.Empty;

        public IEnumerable<Trailer> Trailers { get; set; } = Enumerable.Empty<Trailer>();
    }
}
