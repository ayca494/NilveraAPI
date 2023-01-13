using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("SignedProperties")]
    public class SignedProperties
    {
        [XmlAttribute("Id")]
        public string Id { get; set; }

        [XmlElement("SignedSignatureProperties")]
        public virtual SignedSignatureProperties SignedSignatureProperties { get; set; }
    }
}
