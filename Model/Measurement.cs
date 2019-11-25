using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace NGK_Assignment_3.Model
{
    public class Measurement
    {
        public int MeasurementID { get; set; }
        public DateTimeOffset Date { get; set; }
        public MeasurementLocation Location { get; set; }
        public int MeasurementLocationID { get; set; }

        public double Temp { get; set; }

        public int Humidity { get; set; }

        public double Pressure { get; set; }

        public ApplicationUser User { get; set; }

    }
}
