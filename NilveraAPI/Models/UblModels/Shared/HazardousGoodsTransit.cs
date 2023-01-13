using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("HazardousGoodsTransit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class HazardousGoodsTransit
    {
        [XmlElement("TransportEmergencyCardCode")]
        public DocumentCurrencyCode TransportEmergencyCardCode { get; set; }

        [XmlElement("PackingCriteriaCode")]
        public DocumentCurrencyCode PackingCriteriaCode { get; set; }

        [XmlElement("HazardousRegulationCode")]
        public DocumentCurrencyCode HazardousRegulationCode { get; set; }

        [XmlElement("InhalationToxicityZoneCode")]
        public DocumentCurrencyCode InhalationToxicityZoneCode { get; set; }

        [XmlElement("TransportAuthorizationCode")]
        public DocumentCurrencyCode TransportAuthorizationCode { get; set; }

        [XmlElement("MaximumTemperature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Temperature MaximumTemperature { get; set; }

        [XmlElement("MinimumTemperature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Temperature MinimumTemperature { get; set; }
    }
}
