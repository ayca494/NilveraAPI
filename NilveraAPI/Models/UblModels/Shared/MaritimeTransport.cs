using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("MaritimeTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MaritimeTransport
    {
        [XmlElement("VesselID")]
        public IDType VesselID { get; set; }

        [XmlElement("VesselName")]
        public string VesselName { get; set; }

        [XmlElement("RadioCallSignID")]
        public IDType RadioCallSignID { get; set; }

        [XmlElement("ShipsRequirements")]
        public List<string> ShipsRequirements { get; set; }

        [XmlElement("GrossTonnageMeasure")]
        public BaseUnit GrossTonnageMeasure { get; set; }

        [XmlElement("NetTonnageMeasure")]
        public BaseUnit NetTonnageMeasure { get; set; }

        [XmlElement("RegistryCertificateDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentReference RegistryCertificateDocumentReference { get; set; }

        [XmlElement("RegistryPortLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Location RegistryPortLocation { get; set; }
    }
}
