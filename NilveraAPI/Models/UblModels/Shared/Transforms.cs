using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Transforms")]
    public class Transforms
    {
        public Transforms()
        {
            Transform = new XAdESMethod()
            {
                Algorithm = "http://www.w3.org/2000/09/xmldsig#enveloped-signature"
            };
        }

        [XmlElement("Transform")]
        public virtual XAdESMethod Transform { get; set; }
    }
}
