using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("XAdESObject", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public class XAdESObject
    {
        [XmlElement("QualifyingProperties")]
        public virtual QualifyingProperties QualifyingProperties { get; set; }
    }
}
