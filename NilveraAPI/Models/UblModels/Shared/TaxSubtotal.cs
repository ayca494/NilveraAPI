using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("TaxSubtotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TaxSubtotal
    {
        [XmlElement("TaxableAmount")]
        public virtual BaseCurrency TaxableAmount { get; set; }

        [XmlElement("TaxAmount")]
        public virtual BaseCurrency TaxAmount { get; set; }

        [XmlElement("CalculationSequenceNumeric")]
        public decimal? CalculationSequenceNumeric { get; set; }

        public bool ShouldSerializeCalculationSequenceNumeric()
        {
            return CalculationSequenceNumeric.HasValue;
        }

        [XmlElement("TransactionCurrencyTaxAmount")]
        public virtual BaseCurrency TransactionCurrencyTaxAmount { get; set; }

        [XmlElement("Percent")]
        public decimal? Percent { get; set; }

        public bool ShouldSerializePercent()
        {
            return Percent.HasValue;
        }

        [XmlElement("BaseUnitMeasure")]
        public virtual BaseUnit BaseUnitMeasure { get; set; }

        [XmlElement("PerUnitAmount")]
        public virtual BaseCurrency PerUnitAmount { get; set; }

        [XmlElement("TaxCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual TaxCategory TaxCategory { get; set; }
    }
}

