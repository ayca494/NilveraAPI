using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("LineResponse")]
    public class LineResponse
    {
        [XmlElement("LineReference")]
        public virtual LineReference LineReference { get; set; }

        [XmlElement("Response")]
        public virtual Response Response { get; set; }
    }
}
