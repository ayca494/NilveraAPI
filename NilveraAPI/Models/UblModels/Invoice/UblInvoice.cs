using NilveraAPI.Models.UblModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Invoice
{
    public class UblInvoice
    {
        public CustomerParty AccountingCustomerParty { get; set; }
        public SupplierParty AccountingSupplierParty { get; set; }
        public virtual CustomerParty BuyerCustomerParty { get; set; }
        public DocumentCurrencyCode DocumentCurrencyCode { get; set; }
        public virtual SupplierParty SellerSupplierParty { get; set; }
        public virtual Party TaxRepresentativeParty { get; set; }
        public List<InvoiceLine> InvoiceLines { get; set; }
        public virtual List<string> Notes { get; set; }
        public string UBLVersionID { get; set; } 
        public string CustomizationID { get; set; } 
        public string ProfileID { get; set; } 
        public string ID { get; set; } 
        public bool CopyIndicator { get; set; } 
        public string UUID { get; set; } 
        public string IssueDate { get; set; } 
        public string IssueTime { get; set; } 
        public string InvoiceTypeCode { get; set; }
        public DocumentCurrencyCode TaxCurrencyCode { get; set; }
        public DocumentCurrencyCode PricingCurrencyCode { get; set; } 
        public DocumentCurrencyCode PaymentCurrencyCode { get; set; } 
        public DocumentCurrencyCode PaymentAlternativeCurrencyCode { get; set; } 
        public string AccountingCost { get; set; } 
        public int LineCountNumeric { get; set; }
        public virtual Period InvoicePeriod { get; set; }
        public virtual OrderReference OrderReference { get; set; }
        public virtual List<DocumentReference> AdditionalDocumentReferences { get; set; }
        public virtual List<TaxTotal> TaxTotals { get; set; }
        public virtual List<TaxTotal> WithholdingTaxTotals { get; set; }
        public virtual MonetaryTotal LegalMonetaryTotal { get; set; }

    }
}
