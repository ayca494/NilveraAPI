using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("ItemPropertyRange", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ItemPropertyRange
    {
        [XmlElement("MinimumValue")]
        public string MinimumValue { get; set; }

        [XmlElement("MaximumValue")]
        public string MaximumValue { get; set; }
    }
}
