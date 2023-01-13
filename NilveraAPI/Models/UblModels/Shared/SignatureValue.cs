using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("SignatureValue")]
    public class SignatureValue
    {
        [XmlAttribute("Id")]
        public string Id { get; set; }

        [XmlText]
        public string Name { get; set; }
    }
}
