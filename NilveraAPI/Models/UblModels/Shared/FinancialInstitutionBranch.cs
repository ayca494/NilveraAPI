using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("FinancialInstitutionBranch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FinancialInstitutionBranch
    {
        public string Name { get; set; }

        [XmlElement("FinancialInstitution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(FinancialInstitution))]
        public FinancialInstitution FinancialInstitution { get; set; }
    }
}
