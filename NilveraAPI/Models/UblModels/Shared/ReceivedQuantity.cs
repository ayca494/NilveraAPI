using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("ReceivedQuantity")]
    public class ReceivedQuantity
    {
        [XmlText]
        public decimal Quantity { get; set; }
        [XmlAttribute("unitCode")]
        public string UnitCode { get; set; }
    }
}
