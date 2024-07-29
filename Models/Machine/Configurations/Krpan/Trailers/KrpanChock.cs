using CalcAppAPI.Models.Machine.Krpan.Trailers;

namespace CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers
{
    public class KrpanChock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string? Price { get; set; }
        public IEnumerable<KrpanTrailer> KrpanTrailer { get; set; }
    }
}
