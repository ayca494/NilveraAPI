using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class PartyLegalEntity
    {
        public string RegistrationName { get; set; }
        public IDType CompanyID { get; set; }
        public string RegistrationDate { get; set; }
        public string SoleProprietorshipIndicator { get; set; }
        public BaseCurrency CorporateStockAmount { get; set; }
        public string FullyPaidSharesIndicator { get; set; }
        public CorporateRegistrationScheme CorporateRegistrationScheme { get; set; }
        public Party HeadOfficeParty { get; set; }
    }
}
