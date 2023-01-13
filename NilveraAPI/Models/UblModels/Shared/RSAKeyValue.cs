using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("RSAKeyValue")]
    public class RSAKeyValue
    {
        [XmlElement("Modulus")]
        public string Modulus { get; set; }

        [XmlElement("Exponent")]
        public string Exponent { get; set; }
    }
}
