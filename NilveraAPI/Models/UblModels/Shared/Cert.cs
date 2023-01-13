using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Cert")]
    public class Cert
    {
        [XmlElement("CertDigest")]
        public virtual Reference CertDigest { get; set; }

        [XmlElement("IssuerSerial")]
        public virtual X509Data IssuerSerial { get; set; }
    }
}
