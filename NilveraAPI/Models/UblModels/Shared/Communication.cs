using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Communication", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class Communication
    {
        public string ChannelCode { get; set; }

        public string Channel { get; set; }

        public string Value { get; set; }
    }
}
