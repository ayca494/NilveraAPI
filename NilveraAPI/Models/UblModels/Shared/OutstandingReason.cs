using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class OutstandingReason
    {
        [XmlText]
        public string Description { get; set; }
    }
}
