using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("OrderReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OrderReference
    {
        public IDType ID { get; set; }

        public IDType SalesOrderID { get; set; }

        public string IssueDate { get; set; }

        public DocumentCurrencyCode OrderTypeCode { get; set; }

        [XmlElement("DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual DocumentReference DocumentReference { get; set; }
    }
}
