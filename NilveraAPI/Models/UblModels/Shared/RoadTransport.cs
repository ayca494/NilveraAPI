using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("RoadTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RoadTransport
    {
        [XmlElement("LicensePlateID")]
        public IDType LicensePlateID { get; set; }
    }
}
