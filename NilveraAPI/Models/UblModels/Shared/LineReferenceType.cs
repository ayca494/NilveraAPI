using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("LineReferenceType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LineReferenceType
    {
        public IDType LineID { get; set; }

        public DocumentCurrencyCode LineStatusCode { get; set; }

        [XmlElement("DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual DocumentReference DocumentReference { get; set; }
    }
}
