using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("GoodsItemContainer", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class GoodsItemContainer
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("Quantity")]
        public BaseUnit Quantity { get; set; }

        [XmlElement("TransportEquipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<TransportEquipment> TransportEquipment { get; set; }
    }
}
