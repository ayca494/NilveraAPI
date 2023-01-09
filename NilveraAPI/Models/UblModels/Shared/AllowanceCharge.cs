using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class AllowanceCharge
    {
        public bool? ChargeIndicator { get; set; } 
        public string AllowanceChargeReason { get; set; } 
        public string MultiplierFactorNumeric { get; set; } 
        public BaseCurrency SequenceNumeric { get; set; } 
        public BaseCurrency Amount { get; set; } 
        public BaseCurrency BaseAmount { get; set; } 
        public BaseCurrency PerUnitAmount { get; set; }
    }
}
