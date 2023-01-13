using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("TransportMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportMeans
    {
        [XmlElement("JourneyID")]
        public IDType JourneyID { get; set; }

        [XmlElement("RegistrationNationalityID")]
        public IDType RegistrationNationalityID { get; set; }

        [XmlElement("RegistrationNationality")]
        public List<string> RegistrationNationality { get; set; }

        [XmlElement("DirectionCode")]
        public DocumentCurrencyCode DirectionCode { get; set; }

        [XmlElement("TransportMeansTypeCode")]
        public DocumentCurrencyCode TransportMeansTypeCode { get; set; }

        [XmlElement("TradeServiceCode")]
        public DocumentCurrencyCode TradeServiceCode { get; set; }

        [XmlElement("Stowage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Stowage Stowage { get; set; }

        [XmlElement("AirTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AirTransport AirTransport { get; set; }

        [XmlElement("RoadTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<RoadTransport> RoadTransport { get; set; }

        [XmlElement("RailTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public RailTransport RailTransport { get; set; }

        [XmlElement("MaritimeTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public MaritimeTransport MaritimeTransport { get; set; }

        [XmlElement("OwnerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Party OwnerParty { get; set; }

        [XmlElement("MeasurementDimension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Dimension> MeasurementDimension { get; set; }
    }
}
