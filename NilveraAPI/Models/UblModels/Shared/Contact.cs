using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Contact", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class Contact
    {
        private List<Communication> _otherCommunications;

        [XmlElement("Telephone")]
        public string Telephone { get; set; }

        [XmlElement("Telefax")]
        public string Telefax { get; set; }

        [XmlElement("ElectronicMail")]
        public string ElectronicMail { get; set; }

        [XmlElement("Note")]
        public string Note { get; set; }

        [XmlElement("OtherCommunication", Type = typeof(Communication))]
        public virtual List<Communication> OtherCommunications
        {
            get => _otherCommunications;
            set
            {
                if (value != null)
                {
                    _otherCommunications = value;
                }
                else
                {
                    _otherCommunications = new List<Communication>();
                }
            }
        }
    }
}
