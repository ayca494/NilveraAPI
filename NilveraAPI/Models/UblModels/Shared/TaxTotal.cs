using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TaxTotal
    {
        private List<TaxSubtotal> _taxSubtotals;

        [XmlElement("TaxAmount")]
        public BaseCurrency TaxAmount { get; set; }

        [XmlElement("TaxSubtotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(TaxSubtotal))]
        public virtual List<TaxSubtotal> TaxSubtotals
        {
            get => _taxSubtotals;
            set
            {
                if (value != null)
                {
                    _taxSubtotals = value;
                }
                else
                {
                    _taxSubtotals = new List<TaxSubtotal>();
                }
            }
        }
    }
}
