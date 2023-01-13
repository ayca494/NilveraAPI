using NilveraAPI.Models.UblModels.Shared;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Invoice
{
    [XmlRoot("Invoice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
    public class UblInvoice
    {
        [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string schemaLocation = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2 UBL-Invoice-2.1.xsd";
        private List<UBLExtension> _UBLExtensions;
        private List<string> _notes;
        private Period _invoicePeriod;
        private OrderReference _orderReference;
        private List<BillingReference> _billingReference;
        private List<DocumentReference> _despatchDocumentReferences;
        private List<DocumentReference> _receiptDocumentReferences;
        private List<DocumentReference> _originatorDocumentReference;
        private List<DocumentReference> _contractDocumentReference;
        private List<DocumentReference> _additionalDocumentReferences;
        private List<CustomSignature> _signatures;
        private SupplierParty _accountingSupplierParty;
        private CustomerParty _accountingCustomerParty;
        private CustomerParty _buyerCustomerParty;
        private SupplierParty _sellerSupplierParty;
        private Party _taxRepresentativeParty;
        private List<Delivery> _delivery;
        private List<PaymentMeans> _paymentMeans;
        private PaymentTerms _paymentTerms;
        private List<AllowanceCharge> _allowanceCharge;
        private ExchangeRate _taxExchangeRate;
        private ExchangeRate _pricingExchangeRate;
        private ExchangeRate _paymentExchangeRate;
        private ExchangeRate _paymentAlternativeExchangeRate;
        private List<TaxTotal> _taxTotals;
        private List<TaxTotal> _withholdingTaxTotals;
        private MonetaryTotal _legalMonetaryTotal;
        private List<InvoiceLine> _invoiceLines;

        public UblInvoice()
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

        [XmlElement("InvoiceTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string InvoiceTypeCode { get; set; }

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

        [XmlElement("TaxCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentCurrencyCode TaxCurrencyCode { get; set; }

        [XmlElement("PricingCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentCurrencyCode PricingCurrencyCode { get; set; }

        [XmlElement("PaymentCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentCurrencyCode PaymentCurrencyCode { get; set; }

        [XmlElement("PaymentAlternativeCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentCurrencyCode PaymentAlternativeCurrencyCode { get; set; }

        [XmlElement("AccountingCost", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string AccountingCost { get; set; }

        [XmlElement("LineCountNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public int LineCountNumeric { get; set; }

        [XmlElement("InvoicePeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(Period))]
        public virtual Period InvoicePeriod
        {
            get => _invoicePeriod;
            set
            {
                if (value != null)
                {
                    _invoicePeriod = value;
                }
                else
                {
                    _invoicePeriod = new Period();
                }
            }
        }

        [XmlElement("OrderReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(OrderReference))]
        public virtual OrderReference OrderReference
        {
            get => _orderReference;
            set
            {
                if (value != null)
                {
                    _orderReference = value;
                }
                else
                {
                    _orderReference = new OrderReference();
                }
            }
        }

        [XmlElement("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(BillingReference))]
        public virtual List<BillingReference> BillingReference
        {
            get => _billingReference;
            set
            {
                if (value != null)
                {
                    _billingReference = value;
                }
                else
                {
                    _billingReference = new List<BillingReference>();
                }
            }
        }

        [XmlElement("DespatchDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(DocumentReference))]
        public virtual List<DocumentReference> DespatchDocumentReferences
        {
            get => _despatchDocumentReferences;
            set
            {
                if (value != null)
                {
                    _despatchDocumentReferences = value;
                }
                else
                {
                    _despatchDocumentReferences = new List<DocumentReference>();
                }
            }
        }

        [XmlElement("ReceiptDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(DocumentReference))]
        public virtual List<DocumentReference> ReceiptDocumentReferences
        {
            get => _receiptDocumentReferences;
            set
            {
                if (value != null)
                {
                    _receiptDocumentReferences = value;
                }
                else
                {
                    _receiptDocumentReferences = new List<DocumentReference>();
                }
            }
        }

        [XmlElement("OriginatorDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(DocumentReference))]
        public virtual List<DocumentReference> OriginatorDocumentReference
        {
            get => _originatorDocumentReference;
            set
            {
                if (value != null)
                {
                    _originatorDocumentReference = value;
                }
                else
                {
                    _originatorDocumentReference = new List<DocumentReference>();
                }
            }
        }

        [XmlElement("ContractDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(DocumentReference))]
        public virtual List<DocumentReference> ContractDocumentReference
        {
            get => _contractDocumentReference;
            set
            {
                if (value != null)
                {
                    _contractDocumentReference = value;
                }
                else
                {
                    _contractDocumentReference = new List<DocumentReference>();
                }
            }
        }

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

        [XmlElement("BuyerCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual CustomerParty BuyerCustomerParty
        {
            get => _buyerCustomerParty;
            set
            {
                if (value != null)
                {
                    _buyerCustomerParty = value;
                }
                else
                {
                    _buyerCustomerParty = new CustomerParty();
                }
            }
        }

        [XmlElement("SellerSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual SupplierParty SellerSupplierParty
        {
            get => _sellerSupplierParty;
            set
            {
                if (value != null)
                {
                    _sellerSupplierParty = value;
                }
                else
                {
                    _sellerSupplierParty = new SupplierParty();
                }
            }
        }

        [XmlElement("TaxRepresentativeParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual Party TaxRepresentativeParty
        {
            get => _taxRepresentativeParty;
            set
            {
                if (value != null)
                {
                    _taxRepresentativeParty = value;
                }
                else
                {
                    _taxRepresentativeParty = new Party();
                }
            }
        }

        [XmlElement("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual List<Delivery> Delivery
        {
            get => _delivery;
            set
            {
                if (value != null)
                {
                    _delivery = value;
                }
                else
                {
                    _delivery = new List<Delivery>();
                }
            }
        }

        [XmlElement("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(PaymentMeans))]
        public virtual List<PaymentMeans> PaymentMeans
        {
            get => _paymentMeans;
            set
            {
                if (value != null)
                {
                    _paymentMeans = value;
                }
                else
                {
                    _paymentMeans = new List<PaymentMeans>();
                }
            }
        }

        [XmlElement("PaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(PaymentTerms))]
        public virtual PaymentTerms PaymentTerms
        {
            get => _paymentTerms;
            set
            {
                if (value != null)
                {
                    _paymentTerms = value;
                }
                else
                {
                    _paymentTerms = new PaymentTerms();
                }
            }
        }

        [XmlElement("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual List<AllowanceCharge> AllowanceCharge
        {
            get => _allowanceCharge;
            set
            {
                if (value != null)
                {
                    _allowanceCharge = value;
                }
                else
                {
                    _allowanceCharge = new List<AllowanceCharge>();
                }
            }
        }

        [XmlElement("TaxExchangeRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual ExchangeRate TaxExchangeRate
        {
            get => _taxExchangeRate;
            set
            {
                if (value != null)
                {
                    _taxExchangeRate = value;
                }
                else
                {
                    _taxExchangeRate = new ExchangeRate();
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

        [XmlElement("PaymentExchangeRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual ExchangeRate PaymentExchangeRate
        {
            get => _paymentExchangeRate;
            set
            {
                if (value != null)
                {
                    _paymentExchangeRate = value;
                }
                else
                {
                    _paymentExchangeRate = new ExchangeRate();
                }
            }
        }

        [XmlElement("PaymentAlternativeExchangeRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual ExchangeRate PaymentAlternativeExchangeRate
        {
            get => _paymentAlternativeExchangeRate;
            set
            {
                if (value != null)
                {
                    _paymentAlternativeExchangeRate = value;
                }
                else
                {
                    _paymentAlternativeExchangeRate = new ExchangeRate();
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

        [XmlElement("InvoiceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(InvoiceLine))]
        public virtual List<InvoiceLine> InvoiceLines
        {
            get => _invoiceLines;
            set
            {
                if (value != null)
                {
                    _invoiceLines = value;
                }
                else
                {
                    _invoiceLines = new List<InvoiceLine>();
                }
            }
        }
    }
}
