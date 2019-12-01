using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGK_3_nufungerdet.Models
{
    public class DateRange
    {

        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public bool Intersect(DateRange target)
        {
            return (((Start <= target.Start) && End >= target.Start)) || ((Start >= target.End) && End >= target.End) || ((Start >= target.Start) && (End <= target.End));
        }

    }
}
