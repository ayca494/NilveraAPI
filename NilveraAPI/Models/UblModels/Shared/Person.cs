using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Person", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class Person
    {
        public string FirstName { get; set; }

        public string FamilyName { get; set; }

        public string Title { get; set; }

        public string MiddleName { get; set; }

        public string NameSuffix { get; set; }

        public IDType NationalityID { get; set; }

        [XmlElement("FinancialAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(FinancialAccount))]
        public virtual FinancialAccount FinancialAccount { get; set; }

        [XmlElement("IdentityDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(DocumentReference))]
        public virtual DocumentReference IdentityDocumentReference { get; set; }
    }
}
