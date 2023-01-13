using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class Reference
    {
        public Reference()
        {
            DigestMethod = new XAdESMethod()
            {
                Algorithm = "http://www.w3.org/2001/04/xmlenc#sha256"
            };
        }

        [XmlAttribute("Id")]
        public string Id { get; set; }

        [XmlAttribute("Type")]
        public string Type { get; set; }

        [XmlAttribute("URI")]
        public string URI { get; set; }

        [XmlElement("Transforms")]
        public virtual Transforms Transforms { get; set; }

        [XmlElement("DigestMethod")]
        public virtual XAdESMethod DigestMethod { get; set; }

        [XmlElement("DigestValue")]
        public string DigestValue { get; set; }
    }
}
