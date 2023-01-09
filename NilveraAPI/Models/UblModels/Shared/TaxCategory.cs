using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class TaxCategory
    {
        public string Name { get; set; }
        public string TaxExemptionReasonCode { get; set; } 
        public string TaxExemptionReason { get; set; } 
        public virtual TaxScheme TaxScheme { get; set; }
    }
}
