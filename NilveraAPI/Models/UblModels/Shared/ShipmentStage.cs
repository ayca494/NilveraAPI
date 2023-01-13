using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("ShipmentStage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ShipmentStage
    {
        [XmlElement("Id")]
        public IDType Id { get; set; }

        [XmlElement("TransportModeCode")]
        public DocumentCurrencyCode TransportModeCode { get; set; }

        [XmlElement("TransportMeansTypeCode")]
        public DocumentCurrencyCode TransportMeansTypeCode { get; set; }

        [XmlElement("TransitDirectionCode")]
        public DocumentCurrencyCode TransitDirectionCode { get; set; }

        [XmlElement("Instructions")]
        public List<string> Instructions { get; set; }

        [XmlElement("TransitPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Period TransitPeriod { get; set; }

        [XmlElement("TransportMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TransportMeans TransportMeans { get; set; }

        [XmlElement("DriverPerson", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Person> DriverPerson { get; set; }
    }
}
