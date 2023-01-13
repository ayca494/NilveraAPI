using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("CombineId", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class IDType
    {
        [XmlText]
        public string Id { get; set; }

        [XmlAttribute("schemeID")]
        public string SchemeId { get; set; }
    }
}
