using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using CalcAppAPI.Models.Machine.Palms.Cranes;
using CalcAppAPI.Models.Machine.Palms.Trailers;
using System.ComponentModel.DataAnnotations;

namespace CalcAppAPI.Models.Machine.Configurations.Palms.Trailers
{
    public class TrailerCraneConfiguration
    {
        [Key]
        public int Id { get; set; }
        public int TrailerId { get; set; }
        public Trailer Trailer { get; set; }

        public int CraneId { get; set; }
        public Crane Crane { get; set; }

        // Navigation property
        public int SelectedFrameTypeId { get; set; }
        public FrameType SelectedFrameType { get; set; }
    }
}
