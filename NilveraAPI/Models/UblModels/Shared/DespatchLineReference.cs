using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("DespatchLineReference")]
    public class DespatchLineReference
    {
        public IDType LineID { get; set; }
    }
}