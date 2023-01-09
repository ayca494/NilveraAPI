using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class PartyWithOutAgentParty
    {
        public string EndpointID { get; set; }
        public string WebSiteURI { get; set; }
        public DocumentCurrencyCode IndustryClassificationCode { get; set; }
        public virtual List<PartyIdentification> PartyIdentification { get; set; }
        public PartyName PartyName { get; set; }
        public virtual Address PostalAddress { get; set; }
        public virtual PartyTaxScheme PartyTaxScheme { get; set; }
        public virtual PartyLegalEntity PartyLegalEntity { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Person Person { get; set; }
    }
}
