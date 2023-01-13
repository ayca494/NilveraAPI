using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("StandardBusinessDocumentHeader")]
    public class StandardBusinessDocumentHeader
    {
        private List<Partner> _senders;
        private List<Partner> _receivers;
        private DocumentIdentification _documentIdentification;
        private Manifest _manifest;
        private List<Scope> _businessScopes;

        public StandardBusinessDocumentHeader()
        {
            HeaderVersion = "1.2";
        }

        [XmlElement("HeaderVersion")]
        public string HeaderVersion { get; set; }

        [XmlElement("Sender", Type = typeof(Partner))]
        public virtual List<Partner> Senders
        {
            get => _senders;
            set => _senders = value ?? new List<Partner>();
        }

        [XmlElement("Receiver", Type = typeof(Partner))]
        public virtual List<Partner> Receivers
        {
            get => _receivers;
            set => _receivers = value ?? new List<Partner>();
        }

        [XmlElement("DocumentIdentification")]
        public virtual DocumentIdentification DocumentIdentification
        {
            get => _documentIdentification;
            set => _documentIdentification = value ?? new DocumentIdentification();
        }

        [XmlElement("Manifest")]
        public virtual Manifest Manifest
        {
            get => _manifest;
            set => _manifest = value ?? new Manifest();
        }

        [XmlElement("BusinessScope", Type = typeof(Scope))]
        public virtual List<Scope> BusinessScopes
        {
            get => _businessScopes;
            set => _businessScopes = value ?? new List<Scope>();
        }
    }
}
