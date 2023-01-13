using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("XAdES")]
    public class XAdES
    {
        [XmlAttribute("Id")]
        public string Id { get; set; }

        [XmlElement("SignedInfo")]
        public virtual SignedInfo SignedInfo { get; set; }

        [XmlElement("SignatureValue")]
        public SignatureValue SignatureValue { get; set; }

        [XmlElement("KeyInfo")]
        public virtual KeyInfo KeyInfo { get; set; }

        [XmlElement("Object")]
        public virtual XAdESObject Object { get; set; }
    }
}
