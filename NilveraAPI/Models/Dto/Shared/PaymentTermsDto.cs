using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class PaymentTermsDto
    {
        public decimal? Percent { get; set; }
        public decimal? Amount { get; set; }
        public string Note { get; set; }
    }
}
