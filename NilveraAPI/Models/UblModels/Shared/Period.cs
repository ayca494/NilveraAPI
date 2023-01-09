using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class Period
    {
        public string StartDate { get; set; }

        public string StartTime { get; set; }

        public string EndDate { get; set; }

        public string EndTime { get; set; }

        public DurationMeasure DurationMeasure { get; set; }

        public string Description { get; set; }
    }
}
