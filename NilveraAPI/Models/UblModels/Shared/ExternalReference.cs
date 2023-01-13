using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("ExternalReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExternalReference
    {
        [XmlElement("URI")]
        public string URI { get; set; }
    }
}
