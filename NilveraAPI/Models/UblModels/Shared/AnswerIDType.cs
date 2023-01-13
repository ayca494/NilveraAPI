using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    //[XmlType("CombineId", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [XmlType("ReceiptLineId")]
    public class AnswerIDType
    {
        [XmlText]
        public string Id { get; set; }

        [XmlAttribute("schemeID")]
        public string SchemeId { get; set; }
    }
}
