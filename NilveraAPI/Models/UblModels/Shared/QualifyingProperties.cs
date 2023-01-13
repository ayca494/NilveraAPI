using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("QualifyingProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public class QualifyingProperties
    {
        [XmlAttribute("Target")]
        public string Target { get; set; }

        [XmlElement("SignedProperties")]
        public virtual SignedProperties SignedProperties { get; set; }
    }
}
