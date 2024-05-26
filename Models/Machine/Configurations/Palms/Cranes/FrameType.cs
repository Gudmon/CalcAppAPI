using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using CalcAppAPI.Models.Machine.Palms.Cranes;

namespace CalcAppAPI.Models.Machine.Configurations.Palms.Cranes
{
    public class FrameType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mass { get; set; }
        public string Code { get; set; }
        public string Price { get; set; }
        public IEnumerable<TrailerFrameTypeConfiguration> TrailerConfigurations { get; set; }
        public IEnumerable<Crane> Crane { get; set; }
    }
}
