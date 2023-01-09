using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class FinancialAccount
    {
        public IDType ID { get; set; }
        public string CurrencyCode { get; set; }
        public string PaymentNote { get; set; }
        public virtual FinancialInstitutionBranch FinancialInstitutionBranch { get; set; }
    }
}
