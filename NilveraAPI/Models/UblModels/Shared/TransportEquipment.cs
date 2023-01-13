using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("TransportEquipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportEquipment
    {
        [XmlElement("ID")]
        public IDType Id { get; set; }

        [XmlElement("TransportEquipmentTypeCode")]
        public DocumentCurrencyCode TransportEquipmentTypeCode { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }
    }
}
