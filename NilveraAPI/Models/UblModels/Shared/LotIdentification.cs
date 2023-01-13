using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class LotIdentification
    {
        [XmlElement("LotNumberID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType LotNumberID { get; set; }

        [XmlElement("ExpiryDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ExpiryDate { get; set; }

        [XmlElement("AdditionalItemProperty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ItemProperty AdditionalItemProperty { get; set; }
    }
}
