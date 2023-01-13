using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("OversupplyQuantity")]
    public class OversupplyQuantity
    {
        [XmlText]
        public decimal Quantity { get; set; }
        [XmlAttribute("unitCode")]
        public string UnitCode { get; set; }
    }
}