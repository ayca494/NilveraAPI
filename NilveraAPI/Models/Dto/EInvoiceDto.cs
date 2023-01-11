using NilveraAPI.Models.Dto.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto
{
    public class EInvoiceDto
    {
        public InvoiceInfoDto InvoiceInfo { get; set; }
        public PartyInfoDto CompanyInfo { get; set; }
        public PartyInfoDto CustomerInfo { get; set; }
        public PartyInfoDto BuyerCustomerInfo { get; set; }
        public ExportCustomerInfoDto ExportCustomerInfo { get; set; }
        public TaxFreeInfoDto TaxFreeInfo { get; set; }
        public List<EInvoiceLineDto> InvoiceLines { get; set; }
        public List<string> Notes { get; set; }
       
    }
}
