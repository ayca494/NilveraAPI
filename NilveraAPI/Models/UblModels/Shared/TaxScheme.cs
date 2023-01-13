using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("TaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TaxScheme
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("TaxTypeCode")]
        public string TaxTypeCode { get; set; }
    }
}
