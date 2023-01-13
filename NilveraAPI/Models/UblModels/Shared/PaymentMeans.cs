using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PaymentMeans
    {
        [XmlElement("PaymentMeansCode")]
        public string PaymentMeansCode { get; set; }

        [XmlElement("PaymentDueDate")]
        public string PaymentDueDate { get; set; }

        [XmlElement("PaymentChannelCode")]
        public string PaymentChannelCode { get; set; }

        [XmlElement("InstructionNote")]
        public string InstructionNote { get; set; }

        [XmlElement("PayerFinancialAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(FinancialAccount))]
        public virtual FinancialAccount PayerFinancialAccount { get; set; }

        [XmlElement("PayeeFinancialAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(FinancialAccount))]
        public virtual FinancialAccount PayeeFinancialAccount { get; set; }
    }
}
