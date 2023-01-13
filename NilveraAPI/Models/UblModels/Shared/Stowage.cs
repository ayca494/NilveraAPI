using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Stowage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class Stowage
    {
        [XmlElement("LocationID")]
        public IDType LocationID { get; set; }

        [XmlElement("Location")]
        public List<string> Location { get; set; }

        [XmlElement("MeasurementDimension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Dimension> MeasurementDimension { get; set; }
    }
}
