using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("ItemInstance", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ItemInstance
    {
        [XmlElement("ProductTraceID")]
        public IDType ProductTraceID { get; set; }

        [XmlElement("ManufactureDate")]
        public string ManufactureDate { get; set; }

        [XmlElement("ManufactureTime")]
        public string ManufactureTime { get; set; }

        [XmlElement("BestBeforeDate")]
        public string BestBeforeDate { get; set; }

        [XmlElement("RegistrationID")]
        public IDType RegistrationID { get; set; }

        [XmlElement("SerialID")]
        public IDType SerialID { get; set; }

        [XmlElement("AdditionalItemProperty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ItemProperty AdditionalItemProperty { get; set; }

        [XmlElement("LotIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public LotIdentification LotIdentification { get; set; }
    }
}
