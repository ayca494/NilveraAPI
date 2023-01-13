using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Consignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class Consignment
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("TotalInvoiceAmount")]
        public BaseCurrency TotalInvoiceAmount { get; set; }
    }
}
