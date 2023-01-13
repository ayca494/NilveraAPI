using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("PartyIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PartyIdentification
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlAttribute("schemeID")]
        public string SchemeID { get; set; }
    }
}
