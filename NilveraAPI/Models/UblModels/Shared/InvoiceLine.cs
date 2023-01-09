using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class InvoiceLine
    {
        public IDType ID { get; set; }
        public List<string> Note { get; set; }
        public virtual BaseUnit InvoicedQuantity { get; set; }
        public virtual BaseCurrency LineExtensionAmount { get; set; }
        public virtual OrderLineReference OrderLineReference { get; set; }
        public virtual LineReferenceType DespatchLineReference { get; set; }
        public virtual LineReferenceType ReceiptLineReference { get; set; }
        public virtual List<Delivery> Delivery { get; set; }
        public virtual List<AllowanceCharge> AllowanceCharge { get; set; }
        public virtual TaxTotal TaxTotal { get; set; }
        public virtual List<TaxTotal> WithholdingTaxTotal { get; set; }
        public virtual Item Item { get; set; }
        public virtual Price Price { get; set; }
        public virtual List<InvoiceLine> SubInvoiceLine { get; set; }
    }
}
