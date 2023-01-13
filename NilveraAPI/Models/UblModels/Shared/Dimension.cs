using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class Dimension
    {
        [XmlElement("AttributeID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType AttributeID { get; set; }

        [XmlElement("Measure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public decimal Measure { get; set; }

        [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<string> Description { get; set; }

        [XmlElement("MinimumMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public decimal MinimumMeasure { get; set; }

        [XmlElement("MaximumMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public decimal MaximumMeasure { get; set; }
    }
}
