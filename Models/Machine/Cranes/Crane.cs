﻿
using System.ComponentModel.DataAnnotations;

namespace CalcAppAPI.Models
{
    public class Crane
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Series { get; set; }
        public string MaxReach { get; set; }
        public string LiftAtFullReach240Bar { get; set; }
        public string LiftAtFullReach215Bar { get; set; }
        public string LiftAtFullReach190Bar { get; set; }
        public string LiftAtFourMeters240Bar { get; set; }
        public string LiftAtFourMeters215Bar { get; set; }
        public string LiftAtFourMeters190Bar { get; set; }

        public string BrutLiftingTorque240Bar { get; set; }
        public string BrutLiftingTorque215Bar { get; set; }
        public string BrutLiftingTorque190Bar { get; set; }
        public string SlewingCylinder { get; set; }
        public string SlewingTorque { get; set; }
        public string WorkingPressure { get; set; }
        public string RotatorMaximumLoad { get; set; }
        public string CraneWeight { get; set; }
        public string PillarSlewingAngle { get; set; }
        public string RecommendedOilFLow { get; set; }
        public IEnumerable<Trailer> Trailer { get; set; }
    }
}
