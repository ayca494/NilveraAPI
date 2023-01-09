using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class Party
    {
        public string EndpointID { get; set; }
        public string WebSiteURI { get; set; }
        public DocumentCurrencyCode IndustryClassificationCode { get; set; }       
        public  List<PartyIdentification> PartyIdentification { get; set; }
        public PartyName PartyName { get; set; }
        public  Address PostalAddress { get; set; }
        public  PartyTaxScheme PartyTaxScheme { get; set; }
        public  PartyLegalEntity PartyLegalEntity { get; set; }
        public  Contact Contact { get; set; }
        public  Person Person { get; set; }
        public  PartyWithOutAgentParty AgentParty { get; set; }
    }
}   
