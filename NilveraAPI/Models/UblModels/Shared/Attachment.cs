using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Attachment")]
    public class Attachment
    {
        [XmlElement("ExternalReference")]
        public virtual ExternalReference ExternalReference { get; set; }

        [XmlElement("EmbeddedDocumentBinaryObject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EmbeddedDocumentBinaryObject EmbeddedDocumentBinaryObject { get; set; }
    }
}
