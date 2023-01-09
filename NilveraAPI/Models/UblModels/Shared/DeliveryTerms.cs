using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class DeliveryTerms
    {
        public IDType ID { get; set; }
        public string SpecialTerms { get; set; }
        public BaseCurrency Amount { get; set; }
    }
}
