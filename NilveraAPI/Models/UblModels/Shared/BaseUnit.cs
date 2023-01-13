using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class BaseUnit
    {
        [XmlAttribute("unitCode")]
        public string UnitCode { get; set; }

        [XmlText]
        public decimal Value { get; set; }
    }
}
