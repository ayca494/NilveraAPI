using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Elements")]
    public class PackageElement
    {
        [XmlElement("ElementType")]
        public string PackageElementType { get; set; }

        [XmlElement("ElementCount")]
        public int PackageElementCount { get; set; }

        [XmlElement("ElementList")]
        public string PackageElementLines { get; set; }
    }
}
