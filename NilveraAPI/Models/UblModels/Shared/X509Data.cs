using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class X509Data
    {
        [XmlElement("X509SubjectName")]
        public string X509SubjectName { get; set; }

        [XmlElement("X509Certificate")]
        public string X509Certificate { get; set; }

        [XmlElement("X509IssuerName")]
        public string X509IssuerName { get; set; }

        [XmlElement("X509SerialNumber")]
        public string X509SerialNumber { get; set; }
    }
}
