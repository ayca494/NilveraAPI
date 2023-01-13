using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("GrossWage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class GrossWage
    {
        [XmlElement("GrossWageAmount")]
        public BaseCurrency GrossWageAmount { get; set; }
    }
}
