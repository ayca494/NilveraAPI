using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class Person
    {
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public string Title { get; set; }
        public string MiddleName { get; set; }
        public string NameSuffix { get; set; }
        public IDType NationalityID { get; set; }        
        public virtual FinancialAccount FinancialAccount { get; set; }
        public virtual DocumentReference IdentityDocumentReference { get; set; }
    }
}
