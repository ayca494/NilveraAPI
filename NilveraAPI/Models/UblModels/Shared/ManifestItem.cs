using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("ManifestItem")]
    public class ManifestItem
    {
        [XmlElement("MimeTypeQualifierCode")]
        public string MimeTypeQualifierCode { get; set; }

        [XmlElement("UniformResourceIdentifier")]
        public string UniformResourceIdentifier { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("LanguageCode")]
        public string LanguageCode { get; set; }
    }
}
