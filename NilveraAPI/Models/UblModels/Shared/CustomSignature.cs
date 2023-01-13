using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CustomSignature
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("SignatoryParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual Party SignatoryParty { get; set; }

        [XmlElement("DigitalSignatureAttachment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual Attachment DigitalSignatureAttachment { get; set; }
    }
}
