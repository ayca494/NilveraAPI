using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Party")]
    public class Party
    {
        private List<PartyIdentification> _partyIdentification;

        [XmlElement("EndpointID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string EndpointID { get; set; }

        [XmlElement("WebsiteURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string WebSiteURI { get; set; }

        [XmlElement("IndustryClassificationCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentCurrencyCode IndustryClassificationCode { get; set; }

        [XmlElement("PartyIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(PartyIdentification))]
        public virtual List<PartyIdentification> PartyIdentification
        {
            get => _partyIdentification;
            set
            {
                if (value != null)
                {
                    _partyIdentification = value;
                }
                else
                {
                    _partyIdentification = new List<PartyIdentification>();
                }
            }
        }

        [XmlElement("PartyName")]
        public PartyName PartyName { get; set; }

        [XmlElement("PostalAddress")]
        public virtual Address PostalAddress { get; set; }

        [XmlElement("PartyTaxScheme")]
        public virtual PartyTaxScheme PartyTaxScheme { get; set; }

        [XmlElement("PartyLegalEntity")]
        public virtual PartyLegalEntity PartyLegalEntity { get; set; }

        [XmlElement("Contact")]
        public virtual Contact Contact { get; set; }

        [XmlElement("Person")]
        public virtual Person Person { get; set; }

        [XmlElement("AgentParty")]
        public virtual PartyWithOutAgentParty AgentParty { get; set; }
    }
}
