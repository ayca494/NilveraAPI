using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.UserAccount
{

    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.hr-xml.org/3")]
    [XmlRoot(Namespace = "http://www.hr-xml.org/3", IsNullable = false)]
    public partial class ProcessUserAccount
    {
        private ApplicationArea applicationAreaField;
        private ProcessUserAccountDataArea dataAreaField;
        private string releaseIDField;

        [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string schemaLocation = "http://www.hr-xml.org/3 ../HRXML/UserAccount.xsd         http://www.w3.org/2000/09/xmldsig# xmldsig-core-schema.xsd         http://uri.etsi.org/01903/v1.3.2# XAdES.xsd";



        [XmlElement(Namespace = "http://www.openapplications.org/oagis/9")]
        public ApplicationArea ApplicationArea
        {
            get => applicationAreaField;
            set => applicationAreaField = value;
        }


        public ProcessUserAccountDataArea DataArea
        {
            get => dataAreaField;
            set => dataAreaField = value;
        }


        [XmlAttributeAttribute()]
        public string releaseID
        {
            get => releaseIDField;
            set => releaseIDField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.openapplications.org/oagis/9")]
    [XmlRoot(Namespace = "http://www.openapplications.org/oagis/9", IsNullable = false)]
    public partial class ApplicationArea
    {

        private ApplicationAreaSender senderField;

        private object receiverField;

        private DateTime creationDateTimeField;

        private ApplicationAreaSignature signatureField;


        public ApplicationAreaSender Sender
        {
            get => senderField;
            set => senderField = value;
        }


        public object Receiver
        {
            get => receiverField;
            set => receiverField = value;
        }


        public DateTime CreationDateTime
        {
            get => creationDateTimeField;
            set => creationDateTimeField = value;
        }


        public ApplicationAreaSignature Signature
        {
            get => signatureField;
            set => signatureField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.openapplications.org/oagis/9")]
    public partial class ApplicationAreaSender
    {

        private string logicalIDField;


        public string LogicalID
        {
            get => logicalIDField;
            set => logicalIDField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.openapplications.org/oagis/9")]
    public partial class ApplicationAreaSignature
    {

        private Signature signatureField;


        [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Signature Signature
        {
            get => signatureField;
            set => signatureField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot(Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class Signature
    {

        private SignatureSignedInfo signedInfoField;

        private SignatureSignatureValue signatureValueField;

        private SignatureKeyInfo keyInfoField;

        private SignatureObject objectField;

        private string idField;


        public SignatureSignedInfo SignedInfo
        {
            get => signedInfoField;
            set => signedInfoField = value;
        }


        public SignatureSignatureValue SignatureValue
        {
            get => signatureValueField;
            set => signatureValueField = value;
        }


        public SignatureKeyInfo KeyInfo
        {
            get => keyInfoField;
            set => keyInfoField = value;
        }


        public SignatureObject Object
        {
            get => objectField;
            set => objectField = value;
        }


        [XmlAttributeAttribute()]
        public string Id
        {
            get => idField;
            set => idField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfo
    {

        private SignatureSignedInfoCanonicalizationMethod canonicalizationMethodField;

        private SignatureSignedInfoSignatureMethod signatureMethodField;

        private SignatureSignedInfoReference[] referenceField;

        private string idField;


        public SignatureSignedInfoCanonicalizationMethod CanonicalizationMethod
        {
            get => canonicalizationMethodField;
            set => canonicalizationMethodField = value;
        }


        public SignatureSignedInfoSignatureMethod SignatureMethod
        {
            get => signatureMethodField;
            set => signatureMethodField = value;
        }


        [XmlElement("Reference")]
        public SignatureSignedInfoReference[] Reference
        {
            get => referenceField;
            set => referenceField = value;
        }


        [XmlAttributeAttribute()]
        public string Id
        {
            get => idField;
            set => idField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoCanonicalizationMethod
    {

        private string algorithmField;


        [XmlAttributeAttribute()]
        public string Algorithm
        {
            get => algorithmField;
            set => algorithmField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoSignatureMethod
    {

        private string algorithmField;


        [XmlAttributeAttribute()]
        public string Algorithm
        {
            get => algorithmField;
            set => algorithmField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReference
    {

        private SignatureSignedInfoReferenceTransforms transformsField;

        private SignatureSignedInfoReferenceDigestMethod digestMethodField;

        private string digestValueField;

        private string uRIField;

        private string idField;

        private string typeField;


        public SignatureSignedInfoReferenceTransforms Transforms
        {
            get => transformsField;
            set => transformsField = value;
        }


        public SignatureSignedInfoReferenceDigestMethod DigestMethod
        {
            get => digestMethodField;
            set => digestMethodField = value;
        }


        public string DigestValue
        {
            get => digestValueField;
            set => digestValueField = value;
        }


        [XmlAttributeAttribute()]
        public string URI
        {
            get => uRIField;
            set => uRIField = value;
        }


        [XmlAttributeAttribute()]
        public string Id
        {
            get => idField;
            set => idField = value;
        }


        [XmlAttributeAttribute()]
        public string Type
        {
            get => typeField;
            set => typeField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReferenceTransforms
    {

        private SignatureSignedInfoReferenceTransformsTransform transformField;


        public SignatureSignedInfoReferenceTransformsTransform Transform
        {
            get => transformField;
            set => transformField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReferenceTransformsTransform
    {

        private string algorithmField;


        [XmlAttributeAttribute()]
        public string Algorithm
        {
            get => algorithmField;
            set => algorithmField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReferenceDigestMethod
    {

        private string algorithmField;


        [XmlAttributeAttribute()]
        public string Algorithm
        {
            get => algorithmField;
            set => algorithmField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignatureValue
    {

        private string idField;

        private string valueField;


        [XmlAttributeAttribute()]
        public string Id
        {
            get => idField;
            set => idField = value;
        }


        [XmlTextAttribute()]
        public string Value
        {
            get => valueField;
            set => valueField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureKeyInfo
    {

        private SignatureKeyInfoKeyValue keyValueField;

        private SignatureKeyInfoX509Data x509DataField;


        public SignatureKeyInfoKeyValue KeyValue
        {
            get => keyValueField;
            set => keyValueField = value;
        }


        public SignatureKeyInfoX509Data X509Data
        {
            get => x509DataField;
            set => x509DataField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureKeyInfoKeyValue
    {

        private SignatureKeyInfoKeyValueRSAKeyValue rSAKeyValueField;


        public SignatureKeyInfoKeyValueRSAKeyValue RSAKeyValue
        {
            get => rSAKeyValueField;
            set => rSAKeyValueField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureKeyInfoKeyValueRSAKeyValue
    {

        private string modulusField;

        private string exponentField;


        public string Modulus
        {
            get => modulusField;
            set => modulusField = value;
        }


        public string Exponent
        {
            get => exponentField;
            set => exponentField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureKeyInfoX509Data
    {

        private string x509SubjectNameField;

        private string x509CertificateField;


        public string X509SubjectName
        {
            get => x509SubjectNameField;
            set => x509SubjectNameField = value;
        }


        public string X509Certificate
        {
            get => x509CertificateField;
            set => x509CertificateField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureObject
    {

        private QualifyingProperties qualifyingPropertiesField;


        [XmlElement(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public QualifyingProperties QualifyingProperties
        {
            get => qualifyingPropertiesField;
            set => qualifyingPropertiesField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [XmlRoot(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class QualifyingProperties
    {

        private QualifyingPropertiesSignedProperties signedPropertiesField;

        private QualifyingPropertiesUnsignedProperties unsignedPropertiesField;

        private string targetField;


        public QualifyingPropertiesSignedProperties SignedProperties
        {
            get => signedPropertiesField;
            set => signedPropertiesField = value;
        }


        public QualifyingPropertiesUnsignedProperties UnsignedProperties
        {
            get => unsignedPropertiesField;
            set => unsignedPropertiesField = value;
        }


        [XmlAttributeAttribute()]
        public string Target
        {
            get => targetField;
            set => targetField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class QualifyingPropertiesSignedProperties
    {

        private QualifyingPropertiesSignedPropertiesSignedSignatureProperties signedSignaturePropertiesField;

        private string idField;


        public QualifyingPropertiesSignedPropertiesSignedSignatureProperties SignedSignatureProperties
        {
            get => signedSignaturePropertiesField;
            set => signedSignaturePropertiesField = value;
        }


        [XmlAttributeAttribute()]
        public string Id
        {
            get => idField;
            set => idField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class QualifyingPropertiesSignedPropertiesSignedSignatureProperties
    {

        private DateTime signingTimeField;

        private QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificate signingCertificateField;

        private QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSignerRole signerRoleField;


        public DateTime SigningTime
        {
            get => signingTimeField;
            set => signingTimeField = value;
        }


        public QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificate SigningCertificate
        {
            get => signingCertificateField;
            set => signingCertificateField = value;
        }


        public QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSignerRole SignerRole
        {
            get => signerRoleField;
            set => signerRoleField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificate
    {

        private QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCert certField;


        public QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCert Cert
        {
            get => certField;
            set => certField = value;
        }
    }


    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCert
    {

        private QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertCertDigest certDigestField;

        private QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertIssuerSerial issuerSerialField;


        public QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertCertDigest CertDigest
        {
            get => certDigestField;
            set => certDigestField = value;
        }


        public QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertIssuerSerial IssuerSerial
        {
            get => issuerSerialField;
            set => issuerSerialField = value;
        }
    }


    [SerializableAttribute()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertCertDigest
    {

        private DigestMethod digestMethodField;

        private string digestValueField;


        [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public DigestMethod DigestMethod
        {
            get => digestMethodField;
            set => digestMethodField = value;
        }


        [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public string DigestValue
        {
            get => digestValueField;
            set => digestValueField = value;
        }
    }


    [SerializableAttribute()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRoot(Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class DigestMethod
    {

        private string algorithmField;


        [XmlAttributeAttribute()]
        public string Algorithm
        {
            get => algorithmField;
            set => algorithmField = value;
        }
    }


    [SerializableAttribute()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertIssuerSerial
    {

        private string x509IssuerNameField;

        private ulong x509SerialNumberField;


        [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public string X509IssuerName
        {
            get => x509IssuerNameField;
            set => x509IssuerNameField = value;
        }


        [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public ulong X509SerialNumber
        {
            get => x509SerialNumberField;
            set => x509SerialNumberField = value;
        }
    }


    [SerializableAttribute()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSignerRole
    {

        private QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSignerRoleClaimedRoles claimedRolesField;


        public QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSignerRoleClaimedRoles ClaimedRoles
        {
            get => claimedRolesField;
            set => claimedRolesField = value;
        }
    }


    [SerializableAttribute()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSignerRoleClaimedRoles
    {

        private string claimedRoleField;


        public string ClaimedRole
        {
            get => claimedRoleField;
            set => claimedRoleField = value;
        }
    }


    [SerializableAttribute()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class QualifyingPropertiesUnsignedProperties
    {

        private QualifyingPropertiesUnsignedPropertiesUnsignedSignatureProperties unsignedSignaturePropertiesField;


        public QualifyingPropertiesUnsignedPropertiesUnsignedSignatureProperties UnsignedSignatureProperties
        {
            get => unsignedSignaturePropertiesField;
            set => unsignedSignaturePropertiesField = value;
        }
    }


    [SerializableAttribute()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class QualifyingPropertiesUnsignedPropertiesUnsignedSignatureProperties
    {

        private QualifyingPropertiesUnsignedPropertiesUnsignedSignaturePropertiesCounterSignature counterSignatureField;


        public QualifyingPropertiesUnsignedPropertiesUnsignedSignaturePropertiesCounterSignature CounterSignature
        {
            get => counterSignatureField;
            set => counterSignatureField = value;
        }
    }


    [SerializableAttribute()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class QualifyingPropertiesUnsignedPropertiesUnsignedSignaturePropertiesCounterSignature
    {

        private Signature signatureField;


        [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Signature Signature
        {
            get => signatureField;
            set => signatureField = value;
        }
    }


    [SerializableAttribute()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.hr-xml.org/3")]
    public partial class ProcessUserAccountDataArea
    {

        private object processField;
        private object cancelField;

        private ProcessUserAccountDataAreaUserAccount[] userAccountField;

        [XmlElement(Namespace = "http://www.openapplications.org/oagis/9")]
        public object Process
        {
            get => processField;
            set => processField = value;
        }
        [XmlElement(Namespace = "http://www.openapplications.org/oagis/9")]
        public object Cancel
        {
            get => cancelField;
            set => cancelField = value;
        }


        [XmlElement("UserAccount")]
        public ProcessUserAccountDataAreaUserAccount[] UserAccount
        {
            get => userAccountField;
            set => userAccountField = value;
        }
    }


    [SerializableAttribute()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.hr-xml.org/3")]
    public partial class ProcessUserAccountDataAreaUserAccount
    {

        private string userIDField;

        private ProcessUserAccountDataAreaUserAccountPersonName personNameField;

        private ProcessUserAccountDataAreaUserAccountUserRole userRoleField;

        private ProcessUserAccountDataAreaUserAccountAuthorizedWorkScope authorizedWorkScopeField;

        private ProcessUserAccountDataAreaUserAccountAccountConfiguration accountConfigurationField;


        public string UserID
        {
            get => userIDField;
            set => userIDField = value;
        }


        public ProcessUserAccountDataAreaUserAccountPersonName PersonName
        {
            get => personNameField;
            set => personNameField = value;
        }


        public ProcessUserAccountDataAreaUserAccountUserRole UserRole
        {
            get => userRoleField;
            set => userRoleField = value;
        }


        public ProcessUserAccountDataAreaUserAccountAuthorizedWorkScope AuthorizedWorkScope
        {
            get => authorizedWorkScopeField;
            set => authorizedWorkScopeField = value;
        }


        public ProcessUserAccountDataAreaUserAccountAccountConfiguration AccountConfiguration
        {
            get => accountConfigurationField;
            set => accountConfigurationField = value;
        }
    }


    [SerializableAttribute()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.hr-xml.org/3")]
    public partial class ProcessUserAccountDataAreaUserAccountPersonName
    {

        private string formattedNameField;

        private string givenNameField;

        private string middleNameField;

        private string familyNameField;


        public string FormattedName
        {
            get => formattedNameField;
            set => formattedNameField = value;
        }


        [XmlElement(Namespace = "http://www.openapplications.org/oagis/9")]
        public string GivenName
        {
            get => givenNameField;
            set => givenNameField = value;
        }


        public string MiddleName
        {
            get => middleNameField;
            set => middleNameField = value;
        }


        public string FamilyName
        {
            get => familyNameField;
            set => familyNameField = value;
        }
    }


    [SerializableAttribute()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.hr-xml.org/3")]
    public partial class ProcessUserAccountDataAreaUserAccountUserRole
    {

        private string roleCodeField;

        private string roleNameField;


        public string RoleCode
        {
            get => roleCodeField;
            set => roleCodeField = value;
        }


        public string RoleName
        {
            get => roleNameField;
            set => roleNameField = value;
        }
    }


    [SerializableAttribute()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.hr-xml.org/3")]
    public partial class ProcessUserAccountDataAreaUserAccountAuthorizedWorkScope
    {

        private string workScopeCodeField;

        private string workScopeNameField;


        public string WorkScopeCode
        {
            get => workScopeCodeField;
            set => workScopeCodeField = value;
        }


        public string WorkScopeName
        {
            get => workScopeNameField;
            set => workScopeNameField = value;
        }
    }


    [SerializableAttribute()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.hr-xml.org/3")]
    public partial class ProcessUserAccountDataAreaUserAccountAccountConfiguration
    {

        private byte userOptionCodeField;


        public byte UserOptionCode
        {
            get => userOptionCodeField;
            set => userOptionCodeField = value;
        }
    }


}