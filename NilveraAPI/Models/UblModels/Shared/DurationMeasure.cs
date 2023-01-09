using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class DurationMeasure
    {
        public decimal Value { get; set; }
        public string UnitCode { get; set; }
    }
}
