using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Scope")]
    public class Scope
    {
        [XmlElement("Type")]
        public string Type { get; set; }

        [XmlElement("InstanceIdentifier")]
        public string InstanceIdentifier { get; set; }

        [XmlElement("Identifier")]
        public string Identifier { get; set; }

        [XmlElement("ScopeInformation")]
        public object[] ScopeInformation { get; set; }
    }
}
