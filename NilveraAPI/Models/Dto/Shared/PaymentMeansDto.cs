using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class PaymentMeansDto
    {
        public string Code { get; set; }
        public string ChannelCode { get; set; }
        public DateTime? DueDate { get; set; }
        public string PayeeFinancialAccountID { get; set; }
        public string Note { get; set; }
    }
}
