using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("SigningCertificate")]
    public class SigningCertificate
    {
        [XmlElement("Cert")]
        public virtual Cert Cert { get; set; }
    }
}
