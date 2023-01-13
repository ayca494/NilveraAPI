using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("CorporateRegistrationScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CorporateRegistrationScheme
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("CorporateRegistrationTypeCode")]
        public DocumentCurrencyCode CorporateRegistrationTypeCode { get; set; }

        [XmlElement("JurisdictionRegionAddress")]
        public List<Address> JurisdictionRegionAddress { get; set; }
    }
}
