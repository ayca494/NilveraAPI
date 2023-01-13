using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class OutstandingQuantity
    {
        [XmlText]
        public decimal Quantity { get; set; }
        [XmlAttribute("unitCode")]
        public string UnitCode { get; set; }
    }
}
