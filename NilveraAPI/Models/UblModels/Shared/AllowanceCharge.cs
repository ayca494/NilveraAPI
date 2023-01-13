using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AllowanceCharge
    {
        [XmlElement("ChargeIndicator")]
        public bool? ChargeIndicator { get; set; }

        public bool ShouldSerializeChargeIndicator()
        {
            return ChargeIndicator.HasValue;
        }

        [XmlElement("AllowanceChargeReason")]
        public string AllowanceChargeReason { get; set; }

        [XmlElement("MultiplierFactorNumeric")]
        public string MultiplierFactorNumeric { get; set; }

        [XmlElement("SequenceNumeric")]
        public BaseCurrency SequenceNumeric { get; set; }

        [XmlElement("Amount")]
        public BaseCurrency Amount { get; set; }

        [XmlElement("BaseAmount")]
        public BaseCurrency BaseAmount { get; set; }

        [XmlElement("PerUnitAmount")]
        public BaseCurrency PerUnitAmount { get; set; }
    }
}
