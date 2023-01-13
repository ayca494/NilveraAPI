using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("BillingReferenceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BillingReferenceLine
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("Amount")]
        public BaseCurrency Amount { get; set; }

        [XmlElement("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual List<AllowanceCharge> AllowanceCharge { get; set; }
    }
}
