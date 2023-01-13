using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("PartyLegalEntity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PartyLegalEntity
    {
        [XmlElement("RegistrationName")]
        public string RegistrationName { get; set; }

        [XmlElement("CompanyID")]
        public IDType CompanyID { get; set; }

        [XmlElement("RegistrationDate")]
        public string RegistrationDate { get; set; }

        [XmlElement("SoleProprietorshipIndicator")]
        public string SoleProprietorshipIndicator { get; set; }

        [XmlElement("CorporateStockAmount")]
        public BaseCurrency CorporateStockAmount { get; set; }

        [XmlElement("FullyPaidSharesIndicator")]
        public string FullyPaidSharesIndicator { get; set; }

        [XmlElement("CorporateRegistrationScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CorporateRegistrationScheme CorporateRegistrationScheme { get; set; }

        [XmlElement("HeadOfficeParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Party HeadOfficeParty { get; set; }
    }
}
