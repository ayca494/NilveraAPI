using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("SignerRole")]
    public class SignerRole
    {
        [XmlElement("ClaimedRoles")]
        public virtual ClaimedRoles ClaimedRoles { get; set; }
    }
}
