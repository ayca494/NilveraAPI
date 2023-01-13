using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("EmbeddedDocumentBinaryObject")]
    public class EmbeddedDocumentBinaryObject
    {
        public EmbeddedDocumentBinaryObject()
        {
            CharacterSetCode = "UTF-8";
            EncodingCode = "Base64";
            MimeCode = "application/xml";
        }

        [XmlText]
        public string Name { get; set; }

        [XmlAttribute("characterSetCode")]
        public string CharacterSetCode { get; set; }

        [XmlAttribute("encodingCode")]
        public string EncodingCode { get; set; }

        [XmlAttribute("mimeCode")]
        public string MimeCode { get; set; }

        [XmlAttribute("filename")]
        public string Filename { get; set; }

        [XmlAttribute(DataType = "base64Binary")]
        public byte[] Value { get; set; }
    }
}
