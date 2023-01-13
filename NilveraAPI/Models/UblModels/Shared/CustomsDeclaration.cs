using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("CustomsDeclaration", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CustomsDeclaration
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("IssuerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Party IssuerParty { get; set; }
    }
}
