using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DespatchIDType
    {
        [XmlText]
        public string Id { get; set; }

        [XmlAttribute("schemeID")]
        public string SchemeId { get; set; }
    }
}
