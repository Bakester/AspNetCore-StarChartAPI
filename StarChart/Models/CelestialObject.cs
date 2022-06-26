using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace StarChart.Models
{
    public class CelestialObject
    {
        //ID for verification
        public int Id { get; set; }

        //Set name, with required attr, so that there's no empty obj
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        //Create nullable int for ID of Object "OrbitedObject", must allow null vals for user err/to catch
        public int? OrbitedObjectId { get; set; }

        //List of type CelestialObject that contains Satellites. 
        //Notmapped attr. as Satellites does not need to be created in the db/mapped to col
        [NotMapped]
        public List<CelestialObject> Satellites { get; set; }

        public TimeSpan OrbitalPeriod { get; set; }


    }
}
