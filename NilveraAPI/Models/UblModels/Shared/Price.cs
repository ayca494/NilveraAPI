using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Price", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class Price
    {
        [XmlElement("PriceAmount")]
        public BaseCurrency PriceAmount { get; set; }
    }
}
