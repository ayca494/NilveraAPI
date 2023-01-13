using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("ReceiptLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReceiptLine
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("ReceivedQuantity")]
        public ReceivedQuantity ReceivedQuantity { get; set; }//Kabul

        [XmlElement("ShortQuantity")]
        public ShortQuantity ShortQuantity { get; set; } //Eksik

        [XmlElement("RejectedQuantity")]
        public RejectedQuantity RejectedQuantity { get; set; }//Redd 

        // [XmlElement("RejectReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        [XmlElement("RejectReason")]
        public string RejectReason { get; set; }//Redd Sebeb 

        [XmlElement("OversupplyQuantity")]
        public OversupplyQuantity OversupplyQuantity { get; set; }//Fazla

        [XmlElement("OrderLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public OrderLineReference OrderLineReference { get; set; }

        [XmlElement("DespatchLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public LineReferenceType DespatchLineReference { get; set; }

        [XmlElement("Item", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Item Item { get; set; }

        [XmlElement("Shipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Shipment Shipment { get; set; }









    }
}
