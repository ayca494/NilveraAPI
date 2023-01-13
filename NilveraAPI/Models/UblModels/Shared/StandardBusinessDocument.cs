using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class UBLEnvelope
    {
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader", IsNullable = false)]
        public partial class StandardBusinessDocument
        {

            [System.Xml.Serialization.XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
            public string schemaLocation = @"http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader PackageProxy_1_2.xsd";
            private StandardBusinessDocumentStandardBusinessDocumentHeader standardBusinessDocumentHeaderField;

            private Package packageField;

            /// <remarks/>
            public StandardBusinessDocumentStandardBusinessDocumentHeader StandardBusinessDocumentHeader
            {
                get => standardBusinessDocumentHeaderField;
                set => standardBusinessDocumentHeaderField = value;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.efatura.gov.tr/package-namespace")]
            public Package Package
            {
                get => packageField;
                set => packageField = value;
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
        public partial class StandardBusinessDocumentStandardBusinessDocumentHeader
        {

            private string headerVersionField;

            private StandardBusinessDocumentStandardBusinessDocumentHeaderSender senderField;
            private StandardBusinessDocumentStandardBusinessDocumentHeaderReceiver receiverField;
            private StandardBusinessDocumentStandardBusinessDocumentHeaderDocumentIdentification documentIdentificationField;
            private StandardBusinessDocumentStandardBusinessDocumentHeaderManifest manifestField;

            /// <remarks/>
            public string HeaderVersion
            {
                get => headerVersionField;
                set => headerVersionField = value;
            }

            /// <remarks/>
            public StandardBusinessDocumentStandardBusinessDocumentHeaderSender Sender
            {
                get => senderField;
                set => senderField = value;
            }

            /// <remarks/>
            public StandardBusinessDocumentStandardBusinessDocumentHeaderReceiver Receiver
            {
                get => receiverField;
                set => receiverField = value;
            }

            /// <remarks/>
            public StandardBusinessDocumentStandardBusinessDocumentHeaderDocumentIdentification DocumentIdentification
            {
                get => documentIdentificationField;
                set => documentIdentificationField = value;
            }

            /// <remarks/>
            public StandardBusinessDocumentStandardBusinessDocumentHeaderManifest Manifest
            {
                get => manifestField;
                set => manifestField = value;
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
        public partial class StandardBusinessDocumentStandardBusinessDocumentHeaderSender
        {

            private string identifierField;

            private List<StandardBusinessDocumentStandardBusinessDocumentHeaderSenderContactInformation> contactInformationField;

            /// <remarks/>
            public string Identifier
            {
                get => identifierField;
                set => identifierField = value;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ContactInformation")]
            public List<StandardBusinessDocumentStandardBusinessDocumentHeaderSenderContactInformation> ContactInformation
            {
                get => contactInformationField;
                set => contactInformationField = value;
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
        public partial class StandardBusinessDocumentStandardBusinessDocumentHeaderSenderContactInformation
        {

            private string contactField;

            private string contactTypeIdentifierField;

            /// <remarks/>
            public string Contact
            {
                get => contactField;
                set => contactField = value;
            }

            /// <remarks/>
            public string ContactTypeIdentifier
            {
                get => contactTypeIdentifierField;
                set => contactTypeIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
        public partial class StandardBusinessDocumentStandardBusinessDocumentHeaderReceiver
        {

            private string identifierField;

            private List<StandardBusinessDocumentStandardBusinessDocumentHeaderReceiverContactInformation> contactInformationField;

            /// <remarks/>
            public string Identifier
            {
                get => identifierField;
                set => identifierField = value;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ContactInformation")]
            public List<StandardBusinessDocumentStandardBusinessDocumentHeaderReceiverContactInformation> ContactInformation
            {
                get => contactInformationField;
                set => contactInformationField = value;
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
        public partial class StandardBusinessDocumentStandardBusinessDocumentHeaderReceiverContactInformation
        {

            private string contactField;

            private string contactTypeIdentifierField;

            /// <remarks/>
            public string Contact
            {
                get => contactField;
                set => contactField = value;
            }

            /// <remarks/>
            public string ContactTypeIdentifier
            {
                get => contactTypeIdentifierField;
                set => contactTypeIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
        public partial class StandardBusinessDocumentStandardBusinessDocumentHeaderDocumentIdentification
        {

            private string standardField;

            private string typeVersionField;

            private string instanceIdentifierField;

            private string typeField;

            private System.DateTime creationDateAndTimeField;

            /// <remarks/>
            public string Standard
            {
                get => standardField;
                set => standardField = value;
            }

            /// <remarks/>
            public string TypeVersion
            {
                get => typeVersionField;
                set => typeVersionField = value;
            }

            /// <remarks/>
            public string InstanceIdentifier
            {
                get => instanceIdentifierField;
                set => instanceIdentifierField = value;
            }

            /// <remarks/>
            public string Type
            {
                get => typeField;
                set => typeField = value;
            }

            /// <remarks/>
            public System.DateTime CreationDateAndTime
            {
                get => creationDateAndTimeField;
                set => creationDateAndTimeField = value;
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
        public partial class StandardBusinessDocumentStandardBusinessDocumentHeaderManifest
        {

            private int numberOfItemsField;

            private StandardBusinessDocumentStandardBusinessDocumentHeaderManifestManifestItem manifestItemField;

            /// <remarks/>
            public int NumberOfItems
            {
                get => numberOfItemsField;
                set => numberOfItemsField = value;
            }

            /// <remarks/>
            public StandardBusinessDocumentStandardBusinessDocumentHeaderManifestManifestItem ManifestItem
            {
                get => manifestItemField;
                set => manifestItemField = value;
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
        public partial class StandardBusinessDocumentStandardBusinessDocumentHeaderManifestManifestItem
        {

            private string mimeTypeQualifierCodeField;

            private string uniformResourceIdentifierField;

            private string descriptionField;

            private string languageCodeField;

            /// <remarks/>
            public string MimeTypeQualifierCode
            {
                get => mimeTypeQualifierCodeField;
                set => mimeTypeQualifierCodeField = value;
            }

            /// <remarks/>
            public string UniformResourceIdentifier
            {
                get => uniformResourceIdentifierField;
                set => uniformResourceIdentifierField = value;
            }

            /// <remarks/>
            public string Description
            {
                get => descriptionField;
                set => descriptionField = value;
            }

            /// <remarks/>
            public string LanguageCode
            {
                get => languageCodeField;
                set => languageCodeField = value;
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.efatura.gov.tr/package-namespace")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.efatura.gov.tr/package-namespace", IsNullable = false)]
        public partial class Package
        {

            private Elements elementsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
            public Elements Elements
            {
                get => elementsField;
                set => elementsField = value;
            }
        }

        /// <remarks/> 
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Elements
        {

            private string elementTypeField;

            private int elementCountField;

            private string elementListField;

            /// <remarks/>
            public string ElementType
            {
                get => elementTypeField;
                set => elementTypeField = value;
            }

            /// <remarks/>
            public int ElementCount
            {
                get => elementCountField;
                set => elementCountField = value;
            }

            /// <remarks/>
            ///  
            public string ElementList
            {
                get => elementListField;
                set => elementListField = value;
            }
        }
    }
}
