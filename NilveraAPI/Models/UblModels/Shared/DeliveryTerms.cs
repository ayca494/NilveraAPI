using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("DeliveryTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DeliveryTerms
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("SpecialTerms")]
        public string SpecialTerms { get; set; }

        [XmlElement("Amount")]
        public BaseCurrency Amount { get; set; }
    }
}
