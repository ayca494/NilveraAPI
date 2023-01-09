using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class TaxTotal
    {
        public BaseCurrency TaxAmount { get; set; }
        public virtual List<TaxSubtotal> TaxSubtotals { get; set; }
    }
}
