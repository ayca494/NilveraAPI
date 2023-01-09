using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class MonetaryTotal
    { 
        public BaseCurrency LineExtensionAmount { get; set; } 
        public BaseCurrency TaxExclusiveAmount { get; set; } 
        public BaseCurrency TaxInclusiveAmount { get; set; } 
        public BaseCurrency AllowanceTotalAmount { get; set; } 
        public BaseCurrency ChargeTotalAmount { get; set; } 
        public BaseCurrency PayableRoundingAmount { get; set; } 
        public BaseCurrency PayableAmount { get; set; }
    }
}
