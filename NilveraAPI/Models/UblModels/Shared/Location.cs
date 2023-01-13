using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Location")]
    public class Location
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("Address", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Address Address { get; set; }
    }
}
