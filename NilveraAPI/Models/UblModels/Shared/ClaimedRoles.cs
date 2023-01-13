using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("ClaimedRoles")]
    public class ClaimedRoles
    {
        [XmlElement("ClaimedRole")]
        public string ClaimedRole { get; set; }
    }
}
