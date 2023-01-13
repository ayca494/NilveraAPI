using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("RejectedQuantity")]
    public class RejectedQuantity
    {
        [XmlText]
        public decimal Quantity { get; set; }
        [XmlAttribute("unitCode")]
        public string UnitCode { get; set; }
    }
}