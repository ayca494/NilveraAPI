
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("KeyValue")]
    public class KeyValue
    {
        [XmlElement("RSAKeyValue")]
        public virtual RSAKeyValue RSAKeyValue { get; set; }
    }
}
