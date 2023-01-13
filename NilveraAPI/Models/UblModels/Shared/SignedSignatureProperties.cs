using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("SignedSignatureProperties")]
    public class SignedSignatureProperties
    {
        [XmlElement("SigningTime")]
        public string SigningTime { get; set; }

        [XmlElement("SigningCertificate")]
        public virtual SigningCertificate SigningCertificate { get; set; }

        [XmlElement("SignerRole")]
        public virtual SignerRole SignerRole { get; set; }
    }
}
