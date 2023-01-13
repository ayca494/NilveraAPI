using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.UserAccount
{

    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.hr-xml.org/3")]
    [XmlRoot(Namespace = "http://www.hr-xml.org/3", IsNullable = false)]
    public partial class CancelUserAccount
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
}