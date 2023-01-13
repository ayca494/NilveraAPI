using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("DocumentCurrencyCode")]
    public class DocumentCurrencyCode
    {
        [XmlText]
        public string Name { get; set; }

        [XmlAttribute("listID")]
        public string ListID { get; set; }

        [XmlAttribute("listAgencyName")]
        public string ListAgencyName { get; set; }

        [XmlAttribute("listName")]
        public string ListName { get; set; }

        [XmlAttribute("listVersionID")]
        public string ListVersionID { get; set; }
    }
}
