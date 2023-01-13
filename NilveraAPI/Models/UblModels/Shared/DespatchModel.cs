using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Despatch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DespatchModel
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("ActualDespatchDate")]
        public string ActualDespatchDate { get; set; }

        [XmlElement("ActualDespatchTime")]
        public string ActualDespatchTime { get; set; }

        [XmlElement("Instructions")]
        public string Instructions { get; set; }

        [XmlElement("DespatchAddress", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Address DespatchAddress { get; set; }

        [XmlElement("DespatchParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Party DespatchParty { get; set; }

        [XmlElement("Contact", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Contact Contact { get; set; }

        [XmlElement("EstimatedDespatchPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Period EstimatedDespatchPeriod { get; set; }
    }
}
