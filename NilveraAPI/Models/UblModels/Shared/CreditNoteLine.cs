using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("CreditNoteLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CreditNoteLine
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("CreditedQuantity")]
        public virtual BaseUnit CreditedQuantity { get; set; }

        [XmlElement("LineExtensionAmount")]
        public virtual BaseCurrency LineExtensionAmount { get; set; }

        [XmlElement("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual TaxTotal TaxTotal { get; set; }

        [XmlElement("Item", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual Item Item { get; set; }

        [XmlElement("Price", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual Price Price { get; set; }
    }
}
