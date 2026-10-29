using CalcAppAPI.Models.Machine.Krpan.Cranes;

namespace CalcAppAPI.Models.Machine.Configurations.Krpan.Cranes
{
    public class KrpanCraneControl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string? Price { get; set; }
        public IEnumerable<KrpanCrane> KrpanCrane { get; set; }
    }
}
