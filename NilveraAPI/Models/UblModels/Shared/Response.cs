using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Response", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class Response
    {
        [XmlElement("ReferenceID")]
        public string ReferenceID { get; set; }

        [XmlElement("ResponseCode")]
        public string ResponseCode { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

    }
}
