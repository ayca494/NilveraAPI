using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("ExchangeRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExchangeRate
    {
        public string SourceCurrencyCode { get; set; }

        public string TargetCurrencyCode { get; set; }

        public double CalculationRate { get; set; }

        public string Date { get; set; }
    }
}
