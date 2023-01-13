using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class BillingReference
    {
        [XmlElement("InvoiceDocumentReference")]
        public virtual DocumentReference InvoiceDocumentReference { get; set; }

        [XmlElement("SelfBilledInvoiceDocumentReference")]
        public virtual DocumentReference SelfBilledInvoiceDocumentReference { get; set; }

        [XmlElement("CreditNoteDocumentReference")]
        public virtual DocumentReference CreditNoteDocumentReference { get; set; }

        [XmlElement("SelfBilledCreditNoteDocumentReference")]
        public virtual DocumentReference SelfBilledCreditNoteDocumentReference { get; set; }

        [XmlElement("DebitNoteDocumentReference")]
        public virtual DocumentReference DebitNoteDocumentReference { get; set; }

        [XmlElement("ReminderDocumentReference")]
        public virtual DocumentReference ReminderDocumentReference { get; set; }

        [XmlElement("AdditionalDocumentReference")]
        public virtual DocumentReference AdditionalDocumentReference { get; set; }

        [XmlElement("BillingReferenceLine")]
        public virtual BillingReferenceLine BillingReferenceLine { get; set; }
    }
}
