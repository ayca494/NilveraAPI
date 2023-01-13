using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.VoucherReport
{
    [XmlRoot(ElementName = "eArsivRaporu", Namespace = "http://earsiv.efatura.gov.tr")]
    public class UblVoucherReport
    {
        [XmlElement(ElementName = "baslik", Namespace = "http://earsiv.efatura.gov.tr")]
        public Header Header;
                
        [XmlElement(ElementName = "serbestMeslekMakbuz", Namespace = "http://earsiv.efatura.gov.tr")]
        public List<UblEVoucher> Voucher;

        [XmlElement(ElementName = "serbestMeslekMakbuzIptal", Namespace = "http://earsiv.efatura.gov.tr")]
        public List<VoucherCancel> VoucherCancel;

        [XmlElement(ElementName = "serbestMeslekMakbuzItiraz", Namespace = "http://earsiv.efatura.gov.tr")]
        public List<VoucherObjection> VoucherObjection;

        [XmlAttribute(AttributeName = "xmlns", Namespace = "")]
        public string Xmlns;

        [XmlText]
        public string Text;
    }

    [XmlRoot(ElementName = "mukellef", Namespace = "http://earsiv.efatura.gov.tr")]
    public class TaxPayer
    {
        [XmlElement(ElementName = "vkn", Namespace = "http://earsiv.efatura.gov.tr")]
        public string vkn;
        [XmlElement(ElementName = "tckn", Namespace = "http://earsiv.efatura.gov.tr")]
        public string tckn;
    }

    [XmlRoot(ElementName = "hazirlayan", Namespace = "http://earsiv.efatura.gov.tr")]
    public class Prepared
    {
        [XmlElement(ElementName = "vkn", Namespace = "http://earsiv.efatura.gov.tr")]
        public string vkn;
        [XmlElement(ElementName = "tckn", Namespace = "http://earsiv.efatura.gov.tr")]
        public string tckn;
    }

    [XmlRoot(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class VoucherSignature
    {
        [XmlAttribute(AttributeName = "Id", Namespace = "")]
        public string Id;

        [XmlAttribute(AttributeName = "xmlns", Namespace = "")]
        public string Xmlns;
    }

    [XmlRoot(ElementName = "baslik", Namespace = "http://earsiv.efatura.gov.tr")]
    public class Header
    {
        [XmlElement(ElementName = "versiyon", Namespace = "http://earsiv.efatura.gov.tr")]
        public string Version = "1.0";

        [XmlElement(ElementName = "mukellef", Namespace = "http://earsiv.efatura.gov.tr")]
        public TaxPayer TaxPayer;

        [XmlElement(ElementName = "hazirlayan", Namespace = "http://earsiv.efatura.gov.tr")]
        public Prepared Prepared;

        [XmlElement(ElementName = "raporNo", Namespace = "http://earsiv.efatura.gov.tr")]
        public string ReportNo;

        [XmlElement(ElementName = "donemBaslangicTarihi", Namespace = "http://earsiv.efatura.gov.tr")]
        public string PeriodStartDate;

        [XmlElement(ElementName = "donemBitisTarihi", Namespace = "http://earsiv.efatura.gov.tr")]
        public string PeriodEndDate;

        [XmlElement(ElementName = "bolumBaslangicTarihi", Namespace = "http://earsiv.efatura.gov.tr")]
        public string SectionStartDate;

        [XmlElement(ElementName = "bolumBitisTarihi", Namespace = "http://earsiv.efatura.gov.tr")]
        public string SectionEndDate;

        [XmlElement(ElementName = "bolumNo", Namespace = "http://earsiv.efatura.gov.tr")]
        public int SectionNumber;

        [XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public VoucherSignature VoucherSignature;
    }

    [XmlRoot(ElementName = "vergiBilgisi", Namespace = "http://earsiv.efatura.gov.tr")]
    public class TaxInfo
    {
        [XmlElement(ElementName = "vergilerToplami", Namespace = "http://earsiv.efatura.gov.tr")]
        public decimal TaxTotal;

        [XmlElement(ElementName = "vergi", Namespace = "http://earsiv.efatura.gov.tr")]
        public List<Tax> Tax;

        [XmlElement(ElementName = "tevkifat", Namespace = "http://earsiv.efatura.gov.tr")]
        public List<Withholding> Withholding;
    }

    [XmlRoot(ElementName = "vergi", Namespace = "http://earsiv.efatura.gov.tr")]
    public class Tax
    {
        [XmlElement(ElementName = "matrah", Namespace = "http://earsiv.efatura.gov.tr")]
        public decimal TaxBase;

        [XmlElement(ElementName = "vergiKodu", Namespace = "http://earsiv.efatura.gov.tr")]
        public string TaxCode;

        [XmlElement(ElementName = "vergiTutari", Namespace = "http://earsiv.efatura.gov.tr")]
        public decimal TaxAmount;

        [XmlElement(ElementName = "vergiOrani", Namespace = "http://earsiv.efatura.gov.tr")]
        public decimal TaxPercent;
    }

    [XmlRoot(ElementName = "tevkifat", Namespace = "http://earsiv.efatura.gov.tr")]
    public class Withholding
    {
        [XmlElement(ElementName = "tevkifatKodu", Namespace = "http://earsiv.efatura.gov.tr")]
        public string WithholdingCode;

        [XmlElement(ElementName = "tevkifatTutari", Namespace = "http://earsiv.efatura.gov.tr")]
        public decimal WithholdingAmount;

        [XmlElement(ElementName = "tevkifatOrani", Namespace = "http://earsiv.efatura.gov.tr")]
        public decimal WithholdingPercent;
    }

    [XmlRoot(ElementName = "tuzelKisi", Namespace = "http://earsiv.efatura.gov.tr")]
    public class Company
    {
        [XmlElement(ElementName = "vkn", Namespace = "http://earsiv.efatura.gov.tr")]
        public string TaxNumber;

        [XmlElement(ElementName = "unvan", Namespace = "http://earsiv.efatura.gov.tr")]
        public string Name;
    }

    [XmlRoot(ElementName = "gercekKisi", Namespace = "http://earsiv.efatura.gov.tr")]
    public class Person
    {
        [XmlElement(ElementName = "tckn", Namespace = "http://earsiv.efatura.gov.tr")]
        public string TaxNumber;

        [XmlElement(ElementName = "adiSoyadi", Namespace = "http://earsiv.efatura.gov.tr")]
        public string NameSurname;
    }

    [XmlRoot(ElementName = "aliciBilgileri", Namespace = "http://earsiv.efatura.gov.tr")]
    public class ReceiverInfo
    {
        [XmlElement(ElementName = "gercekKisi", Namespace = "http://earsiv.efatura.gov.tr")]
        public Person Person;

        [XmlElement(ElementName = "tuzelKisi", Namespace = "http://earsiv.efatura.gov.tr")]
        public Company Company;
    }

    [XmlRoot(ElementName = "ynOkcFisBilgisi", Namespace = "http://earsiv.efatura.gov.tr")]
    public class YnOkcReceiptInfo
    {
        [XmlElement(ElementName = "okcSeriNo", Namespace = "http://earsiv.efatura.gov.tr")]
        public string OkcSerialNumber;

        [XmlElement(ElementName = "zNo", Namespace = "http://earsiv.efatura.gov.tr")]
        public string ZNo;

        [XmlElement(ElementName = "fisNo", Namespace = "http://earsiv.efatura.gov.tr")]
        public string ReceiptNo;

        [XmlElement(ElementName = "fisTip", Namespace = "http://earsiv.efatura.gov.tr")]
        public string ReceiptType;

        [XmlElement(ElementName = "fisTarih", Namespace = "http://earsiv.efatura.gov.tr")]
        public DateTime ReceiptDate;

        [XmlElement(ElementName = "fisZaman", Namespace = "http://earsiv.efatura.gov.tr")]
        public DateTime ReceiptTime;
    }

    [XmlRoot(ElementName = "serbestMeslekMakbuz", Namespace = "http://earsiv.efatura.gov.tr")]
    public class UblEVoucher
    {
        [XmlElement(ElementName = "makbuzNo", Namespace = "http://earsiv.efatura.gov.tr")]
        public string VoucherNumber;

        [XmlElement(ElementName = "gonderimSekli", Namespace = "http://earsiv.efatura.gov.tr")]
        public string SendType;

        [XmlElement(ElementName = "dosyaAdi", Namespace = "http://earsiv.efatura.gov.tr")]
        public string DocumentName;

        [XmlElement(ElementName = "ozetDeger", Namespace = "http://earsiv.efatura.gov.tr")]
        public string SummaryValue;

        [XmlElement(ElementName = "duzenlenmeTarihi", Namespace = "http://earsiv.efatura.gov.tr")]
        public string EditedDate;

        [XmlElement(ElementName = "duzenlenmeZamani", Namespace = "http://earsiv.efatura.gov.tr")]
        public string EditedTime;

        [XmlElement(ElementName = "toplamTutar", Namespace = "http://earsiv.efatura.gov.tr")]
        public decimal TotalAmount;

        [XmlElement(ElementName = "odenecekTutar", Namespace = "http://earsiv.efatura.gov.tr")]
        public decimal PayableAmount;

        [XmlElement(ElementName = "paraBirimi", Namespace = "http://earsiv.efatura.gov.tr")]
        public string CurrencyCode;

        [XmlElement(ElementName = "dovizKuru", Namespace = "http://earsiv.efatura.gov.tr")]
        public decimal ExchangeRate;

        [XmlElement(ElementName = "vergiBilgisi", Namespace = "http://earsiv.efatura.gov.tr")]
        public TaxInfo TaxInfo;

        [XmlElement(ElementName = "aliciBilgileri", Namespace = "http://earsiv.efatura.gov.tr")]
        public ReceiverInfo ReceiverInfo;

        [XmlElement(ElementName = "ynOkcFisBilgisi", Namespace = "http://earsiv.efatura.gov.tr")]
        public List<YnOkcReceiptInfo> YnOkcReceiptInfo;
    }

    [XmlRoot(ElementName = "serbestMeslekMakbuzIptal", Namespace = "http://earsiv.efatura.gov.tr")]
    public class VoucherCancel
    {
        [XmlElement(ElementName = "makbuzNo", Namespace = "http://earsiv.efatura.gov.tr")]
        public string VoucherNumber;

        [XmlElement(ElementName = "iptalTarihi", Namespace = "http://earsiv.efatura.gov.tr")]
        public string CancelDate;

        [XmlElement(ElementName = "toplamTutar", Namespace = "http://earsiv.efatura.gov.tr")]
        public decimal TotalAmount;
    }

    [XmlRoot(ElementName = "serbestMeslekMakbuzItiraz", Namespace = "http://earsiv.efatura.gov.tr")]
    public class VoucherObjection
    {
        [XmlElement(ElementName = "belgeNo", Namespace = "http://earsiv.efatura.gov.tr")]
        public string DocumentNumber;

        [XmlElement(ElementName = "itirazBelgeTarihi", Namespace = "http://earsiv.efatura.gov.tr")]
        public DateTime ObjectionDocumentDate;

        [XmlElement(ElementName = "itirazBelgeNo", Namespace = "http://earsiv.efatura.gov.tr")]
        public string ObjectionDocumentNumber;

        [XmlElement(ElementName = "itirazYontemi", Namespace = "http://earsiv.efatura.gov.tr")]
        public string ObjectionMethod;

        [XmlElement(ElementName = "aciklama", Namespace = "http://earsiv.efatura.gov.tr")]
        public string Description;
    }
}
