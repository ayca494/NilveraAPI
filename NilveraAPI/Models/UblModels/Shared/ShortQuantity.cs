using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("ShortQuantity")]
    public class ShortQuantity
    {
        [XmlText]
        public decimal Quantity { get; set; }
        [XmlAttribute("unitCode")]
        public string UnitCode { get; set; }
    }
}
