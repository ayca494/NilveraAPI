using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("XAdESMethod")]
    public class XAdESMethod
    {
        [XmlAttribute("Algorithm")]
        public string Algorithm { get; set; }
    }
}
