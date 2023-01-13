using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("RailTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RailTransport
    {
        [XmlElement("TrainID")]
        public IDType TrainID { get; set; }

        [XmlElement("RailCarID")]
        public IDType RailCarID { get; set; }
    }
}
