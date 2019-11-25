using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;



namespace NGK_Assignment_3.Model
{
    public class MeasurementLocation
    {
       [Key]
       public long MeasurementLocationId { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set;  }
        public List<Measurement> MeasurementsList { get; set; }
    }
}
