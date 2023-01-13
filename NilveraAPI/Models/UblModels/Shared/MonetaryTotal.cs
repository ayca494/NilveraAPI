using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("MonetaryTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MonetaryTotal
    {
        [XmlElement("LineExtensionAmount")]
        public BaseCurrency LineExtensionAmount { get; set; }

        [XmlElement("TaxExclusiveAmount")]
        public BaseCurrency TaxExclusiveAmount { get; set; }

        [XmlElement("TaxInclusiveAmount")]
        public BaseCurrency TaxInclusiveAmount { get; set; }

        [XmlElement("AllowanceTotalAmount")]
        public BaseCurrency AllowanceTotalAmount { get; set; }

        [XmlElement("ChargeTotalAmount")]
        public BaseCurrency ChargeTotalAmount { get; set; }

        [XmlElement("PayableRoundingAmount")]
        public BaseCurrency PayableRoundingAmount { get; set; }

        [XmlElement("PayableAmount")]
        public BaseCurrency PayableAmount { get; set; }
    }
}
