using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("KeyInfo")]
    public class KeyInfo
    {
        [XmlElement("KeyValue")]
        public virtual KeyValue KeyValue { get; set; }

        [XmlElement("X509Data")]
        public virtual X509Data X509Data { get; set; }
    }
}
