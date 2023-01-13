using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("VoucherLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class VoucherLine
    {

        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("LineExtensionAmount")]
        public virtual BaseCurrency LineExtensionAmount { get; set; }

        [XmlElement("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual TaxTotal TaxTotal { get; set; }

        [XmlElement("WithholdingTaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual TaxTotal WithholdingTaxTotal { get; set; }

        [XmlElement("Item", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual Item Item { get; set; }

        [XmlElement("GrossWage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual GrossWage GrossWage { get; set; }

        [XmlElement("Price", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual Price Price { get; set; }
    }
}
