using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("TaxCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TaxCategory
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("TaxExemptionReasonCode")]
        public string TaxExemptionReasonCode { get; set; }

        [XmlElement("TaxExemptionReason")]
        public string TaxExemptionReason { get; set; }

        [XmlElement("TaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual TaxScheme TaxScheme { get; set; }
    }
}
