using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("CommodityClassification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CommodityClassification
    {
        [XmlElement("ItemClassificationCode")]
        public DocumentCurrencyCode ItemClassificationCode { get; set; }
    }
}
