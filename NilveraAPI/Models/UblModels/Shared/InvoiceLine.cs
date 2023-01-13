using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("InvoiceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class InvoiceLine
    {
        private List<Delivery> _delivery;

        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("Note")]
        public List<string> Note { get; set; }

        [XmlElement("InvoicedQuantity")]
        public virtual BaseUnit InvoicedQuantity { get; set; }

        [XmlElement("LineExtensionAmount")]
        public virtual BaseCurrency LineExtensionAmount { get; set; }

        [XmlElement("OrderLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual OrderLineReference OrderLineReference { get; set; }

        [XmlElement("DespatchLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual LineReferenceType DespatchLineReference { get; set; }

        [XmlElement("ReceiptLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual LineReferenceType ReceiptLineReference { get; set; }

        [XmlElement("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual List<Delivery> Delivery
        {
            get => _delivery;
            set
            {
                if (value != null)
                {
                    _delivery = value;
                }
                else
                {
                    _delivery = new List<Delivery>();
                }
            }
        }

        [XmlElement("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual List<AllowanceCharge> AllowanceCharge { get; set; }

        [XmlElement("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual TaxTotal TaxTotal { get; set; }

        [XmlElement("WithholdingTaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual List<TaxTotal> WithholdingTaxTotal { get; set; }

        [XmlElement("Item", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual Item Item { get; set; }

        [XmlElement("Price", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual Price Price { get; set; }

        [XmlElement("SubInvoiceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual List<InvoiceLine> SubInvoiceLine { get; set; }
    }
}
