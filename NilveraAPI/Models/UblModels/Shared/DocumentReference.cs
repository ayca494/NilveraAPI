using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DocumentReference
    {
        [XmlElement("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID { get; set; }

        [XmlElement("IssueDate")]
        public string IssueDate { get; set; }

        [XmlElement("DocumentTypeCode")]
        public string DocumentTypeCode { get; set; }

        [XmlElement("DocumentType")]
        public string DocumentType { get; set; }

        [XmlElement("DocumentDescription")]
        public string DocumentDescription { get; set; }

        [XmlElement("Attachment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual Attachment Attachment { get; set; }

        [XmlElement("ValidityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual Period ValidityPeriod { get; set; }

        [XmlElement("IssuerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual Party IssuerParty { get; set; }
    }
}
