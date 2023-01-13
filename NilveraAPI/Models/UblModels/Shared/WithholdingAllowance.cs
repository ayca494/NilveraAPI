using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("WithholdingAllowance", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class WithholdingAllowance
    {
        [XmlElement("WithholdableAmount")]
        public virtual BaseCurrency WithholdableAmount { get; set; }

        [XmlElement("WithholdingAmount")]
        public virtual BaseCurrency WithholdingAmount { get; set; }

    }
}
