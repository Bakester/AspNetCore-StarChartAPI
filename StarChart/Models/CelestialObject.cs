using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace StarChart.Models
{
    public class CelestialObject
    {
        //ID used to 
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        //Create nullable int for ID of Object "OrbitedObject"
        public int? OrbitedObjectId { get; set; }

        //List of type CelestialObject that contains Satellites
        public List<CelestialObject> Satellites { get; set; }

        public TimeSpan OrbitalPeriod { get; set; }


    }
}
