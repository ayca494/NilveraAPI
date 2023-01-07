using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class FinancialAccountInfoDto
    {
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string ID { get; set; }
        public string CurrencyCode { get; set; }
        public string PaymentNote { get; set; }
    }
}
