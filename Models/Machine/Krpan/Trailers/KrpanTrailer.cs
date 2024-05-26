﻿using CalcAppAPI.Models.Machine.Krpan.Cranes;
using System.ComponentModel.DataAnnotations;

namespace CalcAppAPI.Models.Machine.Krpan.Trailers
{
    public class KrpanTrailer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string LoadCapacity { get; set; }
        public string CentralBeams { get; set; }
        public string LoadingLength { get; set; }
        public string LoadingLengthWithExtension { get; set; }
        public string TotalLength { get; set; }
        public string TotalLengthWithExtension { get; set; }
        public string TotalWidth { get; set; }
        public string Weight { get; set; }
        public string FrameSteeringCylinders { get; set; }
        public string DrawbarAngle { get; set; }
        public IEnumerable<KrpanCrane> KrpanCrane { get; set; }
    }
}