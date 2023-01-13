using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("SignedInfo")]
    public class SignedInfo
    {
        private List<Reference> _references;

        public SignedInfo()
        {
            CanonicalizationMethod = new XAdESMethod()
            {
                Algorithm = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315#WithComments"
            };
            SignatureMethod = new XAdESMethod()
            {
                Algorithm = "http://www.w3.org/2000/09/xmldsig#rsa-sha1"
            };
        }

        [XmlAttribute("Id")]
        public string Id { get; set; }

        [XmlElement("CanonicalizationMethod")]
        public virtual XAdESMethod CanonicalizationMethod { get; set; }

        [XmlElement("SignatureMethod")]
        public virtual XAdESMethod SignatureMethod { get; set; }

        [XmlElement("Reference", Type = typeof(Reference))]
        public virtual List<Reference> References
        {
            get => _references;
            set
            {
                if (value != null)
                {
                    _references = value;
                }
                else
                {
                    _references = new List<Reference>();
                }
            }
        }
    }
}
