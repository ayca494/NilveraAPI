using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Partner")]
    public class Partner
    {
        private List<ContactInformation> _contactInformations;

        [XmlElement("Identifier")]
        public string Identifier { get; set; }

        [XmlElement("ContactInformation", Type = typeof(ContactInformation))]
        public virtual List<ContactInformation> ContactInformations
        {
            get => _contactInformations;
            set => _contactInformations = value ?? new List<ContactInformation>();
        }
    }
}
