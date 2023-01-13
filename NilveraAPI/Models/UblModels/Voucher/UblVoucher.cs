using NilveraAPI.Models.UblModels.Shared;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Voucher
{
    [XmlRoot("Voucher", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Voucher-2")]
    public class UblVoucher
    {
        [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        //  public string schemaLocation = "urn:oasis:names:specification:ubl:schema:xsd:Voucher-2";

        private List<UBLExtension> _UBLExtensions;
        private List<string> _notes;
        private List<DocumentReference> _additionalDocumentReferences;
        private SupplierParty _accountingSupplierParty;
        private CustomerParty _accountingCustomerParty;
        private ExchangeRate _pricingExchangeRate;
        private List<TaxTotal> _taxTotals;
        private List<CustomSignature> _signatures;
        private List<TaxTotal> _withholdingTaxTotals;
        private MonetaryTotal _legalMonetaryTotal;

        private List<VoucherLine> _voucherLine;

        public UblVoucher()
        {
            UBLVersionID = "2.1";
            CustomizationID = "TR1.2";
            CopyIndicator = false;
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

        [XmlElement("CopyIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public bool CopyIndicator { get; set; }

        [XmlElement("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string UUID { get; set; }

        [XmlElement("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string IssueDate { get; set; }

        [XmlElement("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string IssueTime { get; set; }

        [XmlElement("CreditNoteTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string CreditNoteTypeCode { get; set; }

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

        [XmlElement("DocumentCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentCurrencyCode DocumentCurrencyCode { get; set; }

        [XmlElement("LineCountNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public int LineCountNumeric { get; set; }

        [XmlElement("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(DocumentReference))]
        public virtual List<DocumentReference> AdditionalDocumentReferences
        {
            get => _additionalDocumentReferences;
            set
            {
                if (value != null)
                {
                    _additionalDocumentReferences = value;
                }
                else
                {
                    _additionalDocumentReferences = new List<DocumentReference>();
                }
            }
        }
        [XmlElement("AccountingSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual SupplierParty AccountingSupplierParty
        {
            get => _accountingSupplierParty;
            set
            {
                if (value != null)
                {
                    _accountingSupplierParty = value;
                }
                else
                {
                    _accountingSupplierParty = new SupplierParty();
                }
            }
        }
        [XmlElement("AccountingCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual CustomerParty AccountingCustomerParty
        {
            get => _accountingCustomerParty;
            set
            {
                if (value != null)
                {
                    _accountingCustomerParty = value;
                }
                else
                {
                    _accountingCustomerParty = new CustomerParty();
                }
            }
        }

        [XmlElement("PricingExchangeRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual ExchangeRate PricingExchangeRate
        {
            get => _pricingExchangeRate;
            set
            {
                if (value != null)
                {
                    _pricingExchangeRate = value;
                }
                else
                {
                    _pricingExchangeRate = new ExchangeRate();
                }
            }
        }

        [XmlElement("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(TaxTotal))]
        public virtual List<TaxTotal> TaxTotals
        {
            get => _taxTotals;
            set
            {
                if (value != null)
                {
                    _taxTotals = value;
                }
                else
                {
                    _taxTotals = new List<TaxTotal>();
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

        [XmlElement("WithholdingTaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(TaxTotal))]
        public virtual List<TaxTotal> WithholdingTaxTotals
        {
            get => _withholdingTaxTotals;
            set
            {
                if (value != null)
                {
                    _withholdingTaxTotals = value;
                }
                else
                {
                    _withholdingTaxTotals = new List<TaxTotal>();
                }
            }
        }

        [XmlElement("WithholdingAllowance", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual WithholdingAllowance WithholdingAllowance { get; set; }

        [XmlElement("LegalMonetaryTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual MonetaryTotal LegalMonetaryTotal
        {
            get => _legalMonetaryTotal;
            set
            {
                if (value != null)
                {
                    _legalMonetaryTotal = value;
                }
                else
                {
                    _legalMonetaryTotal = new MonetaryTotal();
                }
            }
        }

        [XmlElement("VoucherLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(VoucherLine))]
        public virtual List<VoucherLine> VoucherLine
        {
            get => _voucherLine;
            set
            {
                if (value != null)
                {
                    _voucherLine = value;
                }
                else
                {
                    _voucherLine = new List<VoucherLine>();
                }
            }
        }
    }
}
