using NilveraAPI.Models.UblModels.Shared;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.ApplicationResponse
{
    [XmlRoot("ApplicationResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2")]
    public class UblApplicationResponse
    {
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();
        [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string schemaLocation = "urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2 ../xsd/maindoc/UBL-ApplicationResponse-2.1.xsd";
        private List<UBLExtension> _UBLExtensions;
        private List<string> _notes;
        private List<CustomSignature> _signatures;
        private Party _senderParty;
        private Party _receiverParty;
        private DocumentResponse _documentResponse;

        public UblApplicationResponse()
        {
            xmlns.Add("", "urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2");
            xmlns.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            xmlns.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
            xmlns.Add("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
            UBLVersionID = "2.1";
            CustomizationID = "TR1.2";
        }

        [XmlElement("UBLExtensions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", Type = typeof(List<UBLExtension>))]
        public virtual List<UBLExtension> UBLExtensions
        {
            get => _UBLExtensions;
            set
            {
                if (value != null)
                {
                    _UBLExtensions = value;
                }
                else
                {
                    _UBLExtensions = new List<UBLExtension>();
                }
            }
        }

        [XmlElement("UBLVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string UBLVersionID { get; set; }

        [XmlElement("CustomizationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string CustomizationID { get; set; }

        [XmlElement("ProfileID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ProfileID { get; set; }

        [XmlElement("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ID { get; set; }

        [XmlElement("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string UUID { get; set; }

        [XmlElement("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string IssueDate { get; set; }

        [XmlElement("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string IssueTime { get; set; }

        [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Type = typeof(string))]
        public virtual List<string> Notes
        {
            get => _notes;
            set
            {
                if (value != null)
                {
                    _notes = value;
                }
                else
                {
                    _notes = new List<string>();
                }
            }
        }

        [XmlElement("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(CustomSignature))]
        public virtual List<CustomSignature> Signatures
        {
            get => _signatures;
            set
            {
                if (value != null)
                {
                    _signatures = value;
                }
                else
                {
                    _signatures = new List<CustomSignature>();
                }
            }
        }

        [XmlElement("SenderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual Party SenderParty
        {
            get => _senderParty;
            set
            {
                if (value != null)
                {
                    _senderParty = value;
                }
                else
                {
                    _senderParty = new Party();
                }
            }
        }

        [XmlElement("ReceiverParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual Party ReceiverParty
        {
            get => _receiverParty;
            set
            {
                if (value != null)
                {
                    _receiverParty = value;
                }
                else
                {
                    _receiverParty = new Party();
                }
            }
        }

        [XmlElement("DocumentResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual DocumentResponse DocumentResponse
        {
            get => _documentResponse;
            set
            {
                if (value != null)
                {
                    _documentResponse = value;
                }
                else
                {
                    _documentResponse = new DocumentResponse();
                }
            }
        }
    }
}
