using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Country", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class Country
    {
        [XmlElement("IdentificationCode")]
        public string IdentificationCode { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }
    }
}
