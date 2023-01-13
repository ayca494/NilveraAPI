using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.BillReport
{
    [XmlRoot(ElementName = "eArsivRaporu", Namespace = "http://earsiv.efatura.gov.tr")]
    public class UblBillReport
    {
        [XmlElement(ElementName = "baslik", Namespace = "http://earsiv.efatura.gov.tr")]
        public Header Header;

        [XmlElement(ElementName = "adisyon", Namespace = "http://earsiv.efatura.gov.tr")]
        public List<UblEBill> Bill;

        [XmlElement(ElementName = "adisyonIptal", Namespace = "http://earsiv.efatura.gov.tr")]
        public List<BillCancel> BillCancel;

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
    public class BillSignature
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
        public BillSignature BillSignature;
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

    [XmlRoot(ElementName = "adisyonIptal", Namespace = "http://earsiv.efatura.gov.tr")]
    public class BillCancel
    {
        [XmlElement(ElementName = "adisyonNo", Namespace = "http://earsiv.efatura.gov.tr")]
        public string BillNumber;

        [XmlElement(ElementName = "UUID", Namespace = "http://earsiv.efatura.gov.tr")]
        public string UUID;

        [XmlElement(ElementName = "iptalTarihi", Namespace = "http://earsiv.efatura.gov.tr")]
        public string CancelDate;
    }

    [XmlRoot(ElementName = "adisyon", Namespace = "http://earsiv.efatura.gov.tr")]
    public class UblEBill
    {
        [XmlElement(ElementName = "adisyonNo", Namespace = "http://earsiv.efatura.gov.tr")]
        public string BillNumber;

        [XmlElement(ElementName = "UUID", Namespace = "http://earsiv.efatura.gov.tr")]
        public string UUID;

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

        [XmlElement(ElementName = "aliciBilgileri", Namespace = "http://earsiv.efatura.gov.tr")]
        public ReceiverInfo ReceiverInfo;
    }
}
