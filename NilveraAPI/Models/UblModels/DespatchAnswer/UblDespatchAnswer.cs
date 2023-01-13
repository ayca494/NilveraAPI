using NilveraAPI.Models.UblModels.Shared;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.DespatchAnswer
{
    [XmlRoot("ReceiptAdvice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ReceiptAdvice-2")]
    public class UblDespatchAnswer
    {
        private List<UBLExtension> _UBLExtensions;
        private OrderReference _orderReference;
        private List<string> _notes;
        private List<DocumentReference> _additionalDocumentReferences;
        private List<DocumentReference> _despatchDocumentReferences;
        private DespatchSupplierParty _despatchSupplierParty;
        private DeliveryCustomerParty _deliveryCustomerParty;
        private BuyerCustomerParty _buyerCustomerParty;
        private SellerSupplierParty _sellerSupplierParty;
        private Shipment _shipment;
        private List<ReceiptLine> _receiptLine;

        public UblDespatchAnswer()
        {
            UBLVersionID = "2.1";
            CustomizationID = "TR1.2.1";
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

        [XmlElement("ReceiptAdviceTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string ReceiptAdviceTypeCode { get; set; }

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

        //[XmlElement("LineCountNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public int LineCountNumeric { get; set; } 

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

        [XmlElement("DespatchDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(DocumentReference))]
        public virtual List<DocumentReference> DespatchDocumentReference
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

        [XmlElement("DeliveryCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(DeliveryCustomerParty))]
        public virtual DeliveryCustomerParty DeliveryCustomerParty
        {
            get => _deliveryCustomerParty;
            set
            {
                if (value != null)
                {
                    _deliveryCustomerParty = value;
                }
                else
                {
                    _deliveryCustomerParty = new DeliveryCustomerParty();
                }
            }
        }

        [XmlElement("DespatchSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(DespatchSupplierParty))]
        public virtual DespatchSupplierParty DespatchSupplierParty
        {
            get => _despatchSupplierParty;
            set
            {
                if (value != null)
                {
                    _despatchSupplierParty = value;
                }
                else
                {
                    _despatchSupplierParty = new DespatchSupplierParty();
                }
            }
        }

        [XmlElement("BuyerCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(BuyerCustomerParty))]
        public virtual BuyerCustomerParty BuyerCustomerParty
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
                    _buyerCustomerParty = new BuyerCustomerParty();
                }
            }
        }

        [XmlElement("SellerSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(SellerSupplierParty))]
        public virtual SellerSupplierParty SellerSupplierParty
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
                    _sellerSupplierParty = new SellerSupplierParty();
                }
            }
        }

        [XmlElement("Shipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(Shipment))]
        public virtual Shipment Shipment
        {
            get => _shipment;
            set
            {
                if (value != null)
                {
                    _shipment = value;
                }
                else
                {
                    _shipment = new Shipment();
                }
            }
        }

        [XmlElement("ReceiptLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Type = typeof(ReceiptLine))]
        public virtual List<ReceiptLine> ReceiptLine
        {
            get => _receiptLine;
            set
            {
                if (value != null)
                {
                    _receiptLine = value;
                }
                else
                {
                    _receiptLine = new List<ReceiptLine>();
                }
            }
        }
    }
}
