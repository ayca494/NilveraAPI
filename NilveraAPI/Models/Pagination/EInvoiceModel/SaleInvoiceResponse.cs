using NilveraAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Pagination.EInvoiceModel
{
    public class SaleInvoiceResponse
    {
        public string UUID { get; set; }
        public string TaxNumber { get; set; }
        public string ReceiverTaxNumber { get; set; }
        public string ReceiverName { get; set; }
        public string InvoiceNumber { get; set; }
        public InvoiceProfile InvoiceProfile { get; set; }
        public InvoiceType InvoiceType { get; set; }
        public DateTime IssueDate { get; set; }
        public string CurrencyCode { get; set; }
        public decimal PayableAmount { get; set; }
        public decimal TaxExclusiveAmount { get; set; }
        public decimal TaxTotalAmount { get; set; }
        public bool? IsRead { get; set; }
        public bool? IsPrint { get; set; }
        public bool? IsArchive { get; set; }
        public DateTime CreatedDate { get; set; }
        public StatusCode StatusCode { get; set; }
        public string StatusDetail { get; set; }
        public AnswerCode AnswerCode { get; set; }
        public string EnvelopeUUID { get; set; }
        public DateTime? EnvelopeDate { get; set; }
        public string Email { get; set; }
    }
}
