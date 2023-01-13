using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("FinancialAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FinancialAccount
    {
        public IDType ID { get; set; }

        public string CurrencyCode { get; set; }

        public string PaymentNote { get; set; }

        [XmlElement("FinancialInstitutionBranch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(FinancialInstitutionBranch))]
        public virtual FinancialInstitutionBranch FinancialInstitutionBranch { get; set; }
    }
}
