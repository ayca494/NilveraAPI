using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("AirTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AirTransport
    {
        [XmlElement("AircraftID")]
        public IDType AircraftID { get; set; }
    }
}
