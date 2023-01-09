using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class BaseUnit
    {
        public string UnitCode { get; set; }
        public decimal Value { get; set; }
    }
}
