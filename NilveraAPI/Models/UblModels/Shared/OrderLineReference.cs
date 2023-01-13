using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("OrderLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OrderLineReference
    {
        public IDType LineID { get; set; }

        public IDType SalesOrderLineID { get; set; }

        public string UUID { get; set; }

        public DocumentCurrencyCode LineStatusCode { get; set; }

        [XmlElement("OrderReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual OrderReference OrderReference { get; set; }
    }
}
