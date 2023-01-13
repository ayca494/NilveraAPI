using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("PaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PaymentTerms
    {
        [XmlElement("Note")]
        public string Note { get; set; }

        [XmlElement("PenaltySurchargePercent")]
        public decimal PenaltySurchargePercent { get; set; }

        [XmlElement("Amount")]
        public BaseCurrency Amount { get; set; }

        [XmlElement("PenaltyAmount")]
        public BaseCurrency PenaltyAmount { get; set; }

        [XmlElement("PaymentDueDate")]
        public string PaymentDueDate { get; set; }

        [XmlElement("SettlementPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Period SettlementPeriod { get; set; }
    }
}
