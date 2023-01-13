using System;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("DocumentIdentification")]
    public class DocumentIdentification
    {
        [XmlElement("Standard")]
        public string Standard { get; set; }

        [XmlElement("TypeVersion")]
        public string TypeVersion { get; set; }

        [XmlElement("InstanceIdentifier")]
        public Guid InstanceIdentifier { get; set; }

        [XmlElement("Type")]
        public string Type { get; set; }

        [XmlIgnore]
        public bool MultipleType { get; set; }

        [XmlElement("CreationDateAndTime")]
        public DateTime CreationDateAndTime { get; set; }
    }
}
