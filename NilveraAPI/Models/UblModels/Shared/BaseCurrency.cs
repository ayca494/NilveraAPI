using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Amount")]
    public class BaseCurrency
    {
        [XmlAttribute("currencyID")]
        public string CurrencyID { get; set; }

        [XmlText]
        public decimal Value { get; set; }
    }
}
