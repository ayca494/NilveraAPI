using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Temperature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class Temperature
    {
        [XmlElement("AttributeID")]
        public IDType AttributeID { get; set; }

        [XmlElement("Measure")]
        public BaseUnit Measure { get; set; }

        [XmlElement("Note")]
        public List<string> Note { get; set; }
    }
}
