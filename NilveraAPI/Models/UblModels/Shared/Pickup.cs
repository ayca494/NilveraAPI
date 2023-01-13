using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Pickup", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class Pickup
    {
        [XmlElement("Id")]
        public IDType Id { get; set; }

        [XmlElement("ActualPickupDate")]
        public string ActualPickupDate { get; set; }

        [XmlElement("ActualPickupTime")]
        public string ActualPickupTime { get; set; }

        [XmlElement("EarliestPickupDate")]
        public string EarliestPickupDate { get; set; }

        [XmlElement("EarliestPickupTime")]
        public string EarliestPickupTime { get; set; }

        [XmlElement("LatestPickupDate")]
        public string LatestPickupDate { get; set; }

        [XmlElement("LatestPickupTime")]
        public string LatestPickupTime { get; set; }

        [XmlElement("PickupLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Location PickupLocation { get; set; }

        [XmlElement("PickupParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Party PickupParty { get; set; }
    }
}
