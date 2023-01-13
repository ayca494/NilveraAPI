using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("DurationMeasure")]
    public class DurationMeasure
    {
        [XmlText]
        public decimal Value { get; set; }

        [XmlAttribute("UnitCode")]
        public string UnitCode { get; set; }
    }
}
