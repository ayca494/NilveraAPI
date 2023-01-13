using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("ItemPropertyGroup", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ItemPropertyGroup
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("ImportanceCode")]
        public string ImportanceCode { get; set; }
    }
}
