using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class TaxSubtotal
    {
        public virtual BaseCurrency TaxableAmount { get; set; } 
        public virtual BaseCurrency TaxAmount { get; set; } 
        public decimal? CalculationSequenceNumeric { get; set; }  
        public virtual BaseCurrency TransactionCurrencyTaxAmount { get; set; } 
        public decimal? Percent { get; set; } 
        public virtual BaseUnit BaseUnitMeasure { get; set; } 
        public virtual BaseCurrency PerUnitAmount { get; set; } 
        public virtual TaxCategory TaxCategory { get; set; }
    }
}
