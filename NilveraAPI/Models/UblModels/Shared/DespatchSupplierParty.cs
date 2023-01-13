using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("DespatchSupplierParty")]
    public class DespatchSupplierParty
    {
        [XmlElement("Party", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(Party))]
        public virtual Party Party { get; set; }
    }
}
