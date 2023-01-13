using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class Delivery
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("Quantity")]
        public BaseUnit Quantity { get; set; }

        [XmlElement("ActualDeliveryDate")]
        public string ActualDeliveryDate { get; set; }

        [XmlElement("ActualDeliveryTime")]
        public string ActualDeliveryTime { get; set; }

        [XmlElement("LatestDeliveryDate")]
        public string LatestDeliveryDate { get; set; }

        [XmlElement("LatestDeliveryTime")]
        public string LatestDeliveryTime { get; set; }

        [XmlElement("TrackingID")]
        public IDType TrackingID { get; set; }

        [XmlElement("DeliveryAddress", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Address DeliveryAddress { get; set; }

        [XmlElement("AlternativeDeliveryLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Location AlternativeDeliveryLocation { get; set; }

        [XmlElement("EstimatedDeliveryPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Period EstimatedDeliveryPeriod { get; set; }

        [XmlElement("CarrierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Party CarrierParty { get; set; }

        [XmlElement("DeliveryParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Party DeliveryParty { get; set; }

        [XmlElement("Despatch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DespatchModel Despatch { get; set; }

        [XmlElement("DeliveryTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<DeliveryTerms> DeliveryTerms { get; set; }

        [XmlElement("Shipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Shipment Shipment { get; set; }
    }
}
