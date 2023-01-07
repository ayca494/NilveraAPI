using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class ReturnInvoiceInfoDto
    {
        public string InvoiceNumber { get; set; }
        public DateTime IssueDate { get; set; }
    }
}
