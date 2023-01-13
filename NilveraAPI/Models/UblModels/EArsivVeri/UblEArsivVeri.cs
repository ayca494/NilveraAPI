using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.EArsivVeri
{
    [XmlRoot(ElementName = "eArsivVeri", Namespace = "http://earsiv.efatura.gov.tr")]
    public class UblEArsivVeri
    {
        private Header _header;
        private UblEVoucher _ublEVoucher;

        [XmlElement(ElementName = "baslik")]
        public Header Header
        {
            get => _header;
            set
            {
                if (value != null)
                {
                    _header = value;
                }
                else
                {
                    _header = new Header();
                }
            }
        }

        [XmlElement(ElementName = "serbestMeslekMakbuz")]
        public UblEVoucher Vouchers
        {
            get => _ublEVoucher;
            set
            {
                if (value != null)
                {
                    _ublEVoucher = value;
                }
                else
                {
                    _ublEVoucher = new UblEVoucher();
                }
            }
        }
    }

    [XmlRoot(ElementName = "baslik")]
    public class Header
    {
        [XmlElement(ElementName = "mukellef")]
        public TaxPayer TaxPayer { get; set; }

        [XmlElement(ElementName = "hazirlayan")]
        public Prepared Prepared { get; set; }
    }

    [XmlRoot(ElementName = "mukellef")]
    public class TaxPayer
    {
        [XmlElement(ElementName = "vkn")]
        public string vkn { get; set; }

        [XmlElement(ElementName = "tckn")]
        public string tckn { get; set; }
    }

    [XmlRoot(ElementName = "hazirlayan")]
    public class Prepared
    {
        [XmlElement(ElementName = "vkn")]
        public string vkn { get; set; }

        [XmlElement(ElementName = "tckn")]
        public string tckn { get; set; }
    }

    [XmlRoot(ElementName = "serbestMeslekMakbuz")]
    public class UblEVoucher
    {
        [XmlElement(ElementName = "makbuzNo")]
        public string VoucherNumber { get; set; }

        [XmlElement(ElementName = "ETTN")]
        public string UUID { get; set; }

        [XmlElement(ElementName = "gonderimSekli")]
        public string SendType { get; set; }

        [XmlElement(ElementName = "dosyaAdi")]
        public string DocumentName { get; set; }

        [XmlElement(ElementName = "belgeTarihi")]
        public string EditedDate { get; set; }

        [XmlElement(ElementName = "belgeZamani")]
        public string EditedTime { get; set; }

        [XmlElement(ElementName = "toplamTutar")]
        public decimal TotalAmount { get; set; }

        [XmlElement(ElementName = "odenecekTutar")]
        public decimal PayableAmount { get; set; }

        [XmlElement(ElementName = "paraBirimi")]
        public string CurrencyCode { get; set; }

        [XmlElement(ElementName = "kur")]
        public decimal ExchangeRate { get; set; }

        [XmlElement(ElementName = "vergiBilgisi")]
        public TaxInfo TaxInfo { get; set; }

        [XmlElement(ElementName = "aliciBilgileri")]
        public ReceiverInfo ReceiverInfo { get; set; }

        [XmlElement(ElementName = "ynOkcFisBilgisi")]
        public YnOkcReceiptInfo YnOkcReceiptInfo { get; set; }

        [XmlElement(ElementName = "malHizmetBilgisi")]
        public GoodsServiceInformation GoodsServiceInformation { get; set; }
    }

    [XmlRoot(ElementName = "vergiBilgisi")]
    public class TaxInfo
    {
        [XmlElement(ElementName = "vergilerToplami")]
        public decimal TaxTotal { get; set; }

        [XmlElement(ElementName = "vergi")]
        public List<Tax> Tax { get; set; }

        [XmlElement(ElementName = "tevkifat")]
        public List<Withholding> Withholding { get; set; }
    }

    [XmlRoot(ElementName = "vergi")]
    public class Tax
    {
        [XmlElement(ElementName = "matrah")]
        public decimal TaxBase { get; set; }

        [XmlElement(ElementName = "vergiKodu")]
        public string TaxCode { get; set; }

        [XmlElement(ElementName = "vergiTutari")]
        public decimal TaxAmount { get; set; }

        [XmlElement(ElementName = "vergiOrani")]
        public decimal TaxPercent { get; set; }
    }

    [XmlRoot(ElementName = "tevkifat")]
    public class Withholding
    {
        [XmlElement(ElementName = "tevkifatKodu")]
        public string WithholdingCode { get; set; }

        [XmlElement(ElementName = "tevkifatTutari")]
        public decimal WithholdingAmount { get; set; }

        [XmlElement(ElementName = "tevkifatOrani")]
        public decimal WithholdingPercent { get; set; }
    }

    [XmlRoot(ElementName = "tuzelKisi")]
    public class Company
    {
        [XmlElement(ElementName = "vkn")]
        public string TaxNumber { get; set; }

        [XmlElement(ElementName = "unvan")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "gercekKisi")]
    public class Person
    {
        [XmlElement(ElementName = "tckn")]
        public string TaxNumber { get; set; }

        [XmlElement(ElementName = "adiSoyadi")]
        public string NameSurname { get; set; }
    }

    [XmlRoot(ElementName = "aliciBilgileri")]
    public class ReceiverInfo
    {
        [XmlElement(ElementName = "tuzelKisi")]
        public Company Company { get; set; }

        [XmlElement(ElementName = "gercekKisi")]
        public Person Person { get; set; }

        [XmlElement(ElementName = "adres")]
        public Address Address { get; set; }
    }

    public class Address
    {
        [XmlElement(ElementName = "caddeSokak")]
        public string StreetName { get; set; }

        [XmlElement(ElementName = "binaAd")]
        public string BuildName { get; set; }

        [XmlElement(ElementName = "binaNo")]
        public string BuildNumber { get; set; }

        [XmlElement(ElementName = "kapiNo")]
        public string DoorNumber { get; set; }

        [XmlElement(ElementName = "kasabaKoy")]
        public string Village { get; set; }

        [XmlElement(ElementName = "semt")]
        public string CitySubDivision { get; set; }

        [XmlElement(ElementName = "sehir")]
        public string City { get; set; }

        [XmlElement(ElementName = "postaKod")]
        public string PostalCode { get; set; }

        [XmlElement(ElementName = "ulke")]
        public string Country { get; set; }

        [XmlElement(ElementName = "vDaire")]
        public string TaxOffice { get; set; }
    }

    [XmlRoot(ElementName = "ynOkcFisBilgisi")]
    public class YnOkcReceiptInfo
    {
        [XmlElement(ElementName = "okcSeriNo")]
        public string OkcSerialNumber { get; set; }

        [XmlElement(ElementName = "zNo")]
        public string ZNo { get; set; }

        [XmlElement(ElementName = "fisNo")]
        public string ReceiptNo { get; set; }

        [XmlElement(ElementName = "fisTip")]
        public string ReceiptType { get; set; }

        [XmlElement(ElementName = "fisTarih")]
        public DateTime ReceiptDate { get; set; }

        [XmlElement(ElementName = "fisZaman")]
        public DateTime ReceiptTime { get; set; }
    }

    [XmlRoot(ElementName = "malHizmetBilgisi")]
    public class GoodsServiceInformation
    {
        [XmlElement(ElementName ="malHizmet")]
        public List<GoodsService> GoodsServices { get; set; }
    }

    [XmlRoot(ElementName = "malHizmet")]
    public class GoodsService
    {
        [XmlElement(ElementName ="ad")]
        public string Name { get; set; }

        [XmlElement(ElementName = "vergiBilgisi")]
        public TaxInfo TaxInfo { get; set; }

        [XmlElement(ElementName ="burutUcret")]
        public decimal GrossWage { get; set; }
    }
}
