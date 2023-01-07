using NilveraAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class InvoiceInfoDto
    {
        public Guid UUID { get; set; }
        public Guid TemplateUUID { get; set; }
        public string TemplateBase64String { get; set; }

        public InvoiceType? InvoiceType { get; set; }
        public string InvoiceSerieOrNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? ExchangeRate { get; set; }
        public InvoiceProfile? InvoiceProfile { get; set; }
        public List<KeyValueDto> DespatchDocumentReference { get; set; }
        public KeyValueDto OrderReference { get; set; }
        public AdditionalDocumentReferenceDto OrderReferenceDocument { get; set; }
        public List<AdditionalDocumentReferenceDto> AdditionalDocumentReferences { get; set; }
        public TaxExemptionReasonInfoDto TaxExemptionReasonInfo { get; set; }
        public PaymentTermsDto PaymentTermsInfo { get; set; }
        public PaymentMeansDto PaymentMeansInfo { get; set; }
        public OKCInfoDto OKCInfo { get; set; }
        public List<ReturnInvoiceInfoDto> ReturnInvoiceInfo { get; set; }
        public string AccountingCost { get; set; }
        public InvoicePeriodDto InvoicePeriod { get; set; }
        public SGKInfoDto SGKInfo { get; set; }
        public List<ExpensesDto> Expenses { get; set; }
        public decimal LineExtensionAmount { get; set; }
        public decimal GeneralKDV1Total { get; set; }
        public decimal GeneralKDV8Total { get; set; }
        public decimal GeneralKDV18Total { get; set; }
        public decimal GeneralAllowanceTotal { get; set; }
        public decimal PayableAmount { get; set; }
        public decimal KdvTotal { get; set; }

    }
}
