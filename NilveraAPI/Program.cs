// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using NilveraAPI.Models.Dto;
using NilveraAPI.Models.UblModels.Invoice;
using NilveraAPI.Models.UblModels.Shared;
using RestSharp;



EInvoiceDto EInvoice = new EInvoiceDto()
{
    CustomerInfo = new NilveraAPI.Models.Dto.Shared.PartyInfoDto()
    {
        TaxNumber = "6310540565",
        Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ",
        TaxOffice = "kayseri vergi dairesi",
        AgentPartyIdentifications = new List<NilveraAPI.Models.Dto.Shared.IDTypeDto>(),
        Address = "Kayseri sokak teknopark",
        District = "Talas",
        City = "Kayseri",
        Country = "Türkiye",
        PostalCode = "38000",
        Phone = "02223334455",
        Fax = "12345",
        Mail = "kayseri@gmail.com",
        WebSite = "www.kayseri.com"
    },
    CompanyInfo = new NilveraAPI.Models.Dto.Shared.PartyInfoDto()
    {
        Name = "TEST KURUM - 01",
        TaxNumber = "1234567801",
        TaxOffice = "ÇEKMEKÖY",
        PartyIdentifications = new List<NilveraAPI.Models.Dto.Shared.IDTypeDto>()
        {
                        new NilveraAPI.Models.Dto.Shared.IDTypeDto()
                        {
                            SchemeID = "TICARETSICILNO",
                            Value = "213123"
                        }
                    },
        AgentPartyIdentifications = new List<NilveraAPI.Models.Dto.Shared.IDTypeDto>()
        {
                        new NilveraAPI.Models.Dto.Shared.IDTypeDto()
                        {
                            SchemeID = "DISTRIBUTORNO",
                            Value = "2112"
                        }
                    },
        Address = "BARBAROS MAH. AK ZAMBAK SOK. UPHILL TOWERS A BLOK K : 16 / 92",
        District = "ATAŞEHİR",
        City = "İstanbul",
        Country = "TÜRKİYE",
        PostalCode = "34704",
        Phone = "02166885100",
        Fax = "0216 688 51 99",
        Mail = "info@nesbilgi.com.tr",
        WebSite = "whttps://nesbilgi.com.tr"
    },
    InvoiceInfo = new NilveraAPI.Models.Dto.Shared.InvoiceInfoDto()
    {
        UUID = Guid.Parse("4047a513-066c-493e-b817-c33e6a7ab04b"),
        TemplateUUID = Guid.Parse("f51f9840-5022-4b29-9867-0bc8af7a5d7b"),
        InvoiceProfile = NilveraAPI.Enums.InvoiceProfile.TEMELFATURA,
        InvoiceType = NilveraAPI.Enums.InvoiceType.ISTISNA,
        InvoiceSerieOrNumber = "EFT",
        IssueDate = DateTime.Parse("2022-09-05T17:08:37.452Z"),
        CurrencyCode = "TRY",
        ExchangeRate = null,
        DespatchDocumentReference = new List<NilveraAPI.Models.Dto.Shared.KeyValueDto>(),
        OrderReference = null,
        OrderReferenceDocument = null,
        AdditionalDocumentReferences = new List<NilveraAPI.Models.Dto.Shared.AdditionalDocumentReferenceDto>(),
        TaxExemptionReasonInfo = new NilveraAPI.Models.Dto.Shared.TaxExemptionReasonInfoDto()
        {
            KDVExemptionReasonCode = "",
            OTVExemptionReasonCode = "",
            AccommodationTaxExemptionReasonCode = "001"
        },
        PaymentTermsInfo = new NilveraAPI.Models.Dto.Shared.PaymentTermsDto()
        {
            Amount = null,
            Note = null,
            Percent = null
        },
        PaymentMeansInfo = null,
        OKCInfo = null,
        ReturnInvoiceInfo = new List<NilveraAPI.Models.Dto.Shared.ReturnInvoiceInfoDto>(),
        Expenses = new List<NilveraAPI.Models.Dto.Shared.ExpensesDto>()
    },
    InvoiceLines = new List<NilveraAPI.Models.Dto.Shared.EInvoiceLineDto>()
    {
                    new NilveraAPI.Models.Dto.Shared.EInvoiceLineDto(){
                        SellerCode = "",
                        BuyerCode = "",
                        Name = "Konaklama",
                        Description = "",
                        Quantity = 1,
                        UnitType = "C62",
                        Price = 500,
                        AllowanceTotal = 0M,
                        KDVPercent = 8M,
                        KDVTotal = 0M,
                        Taxes = new List<NilveraAPI.Models.Dto.Shared.TaxDto>()
                        {
                            new NilveraAPI.Models.Dto.Shared.TaxDto()
                            {
                                Percent = 0,
                                Total = 0,
                                TaxCode = "0059"
                            }
                        },
                        ManufacturerCode = "",
                        BrandName = "",
                        ModelName = "",
                        Note = "",
                        OzelMatrahReason = null,
                        OzelMatrahTotal = null,
                        AdditionalItemIdentification = new NilveraAPI.Models.Dto.Shared.AdditionalItemIdentificationDto()
                    },
                },
    Notes = new List<string>()
                {
                    "Bu",
                    "bir",
                    "denemedir.",
                    "notlar"
                }
};




UblInvoice ublInvoice = new UblInvoice()
{
    UBLVersionID = "2.1",
    CustomizationID = "TR1.2.1",
    CopyIndicator = false,
    ProfileID = "EARSIVBELGE",
    ID = "EFT",
    UUID = "c076ee64-4190-4774-ac90-8f5e73a28ab5",
    IssueDate = "2022-09-21",
    IssueTime = "10:21:00",
    Notes = new List<string>()
    {
        "deneme",
        "notu"
    },
    DocumentCurrencyCode = new DocumentCurrencyCode()
    {
        Name = "TRY"
    },
    LineCountNumeric = 1,
    AdditionalDocumentReferences = new List<DocumentReference>() { new DocumentReference {
        ID = new IDType(){Id = "ELEKTRONIK" , SchemeId = "ELK"},
        IssueDate = "2022-09-21",
        DocumentTypeCode ="SEND_TYPE"
    } },
    AccountingSupplierParty = new SupplierParty()
    {
        Party = new Party()
        {
            WebSiteURI = "www.nilvera.com",
            PartyIdentification = new List<PartyIdentification>()
            {
                new PartyIdentification() { ID = new IDType() { Id = "6310540565", SchemeId = "VKN" } },
                new PartyIdentification() { ID = new IDType() { Id = "1122334455667788", SchemeId = "MERSISNO" } },
                new PartyIdentification() { ID = new IDType() { Id = "12345", SchemeId = "TICARETSICILNO" } },
            },
            PartyName = new PartyName() { Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ" },
            PostalAddress = new Address()
            {
                StreetName = "Yıldırım Beyazıt Mah. Aşıkveysel Bulv. Erciyes Teknopark 3",
                CitySubdivisionName = "Melikgazi",
                CityName = "Kayseri",
                PostalZone = "34704",
                Country = new Country() { Name = "Türkiye" }
            },
            PartyTaxScheme = new PartyTaxScheme()
            {
                TaxScheme = new TaxScheme()
                {
                    Name = "ERCİYES"
                }
            },
            Contact = new Contact()
            {
                Telephone = "08502514010",
                ElectronicMail = "info@nilvera.com"
            },
        },
    },
    AccountingCustomerParty = new CustomerParty()
    {
        Party = new Party()
        {
            Person = new Person()
            {
                FirstName = "Feride",
                FamilyName = "Çolak"
            },
            WebSiteURI = "www.deneme.com",
            AgentParty = null,
            PartyIdentification = new List<PartyIdentification>()
            {
                new PartyIdentification() {ID = new IDType(){ Id="12345678902",SchemeId="TCKN"}},
            },
            PostalAddress = new Address()
            {
                StreetName = "Yıldırım Beyazıt Mah.",
                CitySubdivisionName = "Melikgazi",
                CityName = "Kayseri",
                PostalZone = "38050",

                Country = new Country() { Name = "Türkiye" }
            },
            PartyTaxScheme = new PartyTaxScheme()
            {
                TaxScheme = new TaxScheme()
                {
                    Name = "Melikgazi Vergi Dairesi"
                }
            },
            Contact = new Contact()
            {
                Telefax = "05342354657",
                Telephone = "05342354657"
            },
        }
    },
    TaxTotals = new List<TaxTotal>() { new TaxTotal {
        TaxAmount = new BaseCurrency()
        {
            CurrencyID = "TRY",
            Value = 30.80m
        },
        TaxSubtotals = new List<TaxSubtotal>()
        {
            new TaxSubtotal()
            {
                CalculationSequenceNumeric = 1,
                Percent = 20m,
                TaxAmount = new BaseCurrency()
                {
                    CurrencyID = "TRY",
                    Value = 20m
                },
                TaxCategory = new TaxCategory()
                {
                    TaxScheme = new TaxScheme()
                    {
                        TaxTypeCode = "0003",
                        Name = "GV. Stpj."
                    }
                },
                TaxableAmount = new BaseCurrency()
                {
                    CurrencyID ="TRY",
                    Value = 100m
                }
            },
            new TaxSubtotal()
            {
                 CalculationSequenceNumeric = 2,
                TaxableAmount = new BaseCurrency()
                {
                    CurrencyID = "TRY",
                    Value = 100
                },
                TaxAmount = new BaseCurrency()
                {
                    CurrencyID = "TRY",
                    Value = 18m
                },
                Percent = 18m,
                TaxCategory = new TaxCategory()
                {
                    TaxScheme = new TaxScheme()
                    {
                        Name = "KDV",
                        TaxTypeCode = "0015"
                    }
                }
            },
        }
    } },
    WithholdingTaxTotals = new List<TaxTotal>()
    {
        new TaxTotal()
        {
            TaxAmount = new BaseCurrency()
            {
                CurrencyID = "TRY",
                Value = 7.2m
            },
            TaxSubtotals = new List<TaxSubtotal>()
            {
                new TaxSubtotal()
                {
                     CalculationSequenceNumeric = 1,
                     Percent = 40m,
                     TaxAmount = new BaseCurrency()
                     {
                         CurrencyID = "TRY",
                         Value = 7.2m
                     },
                     TaxCategory = new TaxCategory()
                     {
                         TaxScheme = new TaxScheme()
                         {
                             TaxTypeCode = "601",
                             Name = "601 - Yapım İşleri İle Bu İşlerle Birlikte İfa Edilen Mühendislik-Mimarlık ve Etüt-Proje Hizmetleri [GT 117-Bölüm (3.2.1)]"
                         }
                     },
                     TaxableAmount = new BaseCurrency()
                     {
                         CurrencyID ="TRY",
                         Value = 18m
                     }
                },
            }
        }
    },
    LegalMonetaryTotal = new MonetaryTotal()
    {
        LineExtensionAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 2800m },
        TaxInclusiveAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 6577m },
        PayableAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 3209.5m },
    },
    InvoiceLines = new List<InvoiceLine>()
    {
        new InvoiceLine()
        {
            ID = new IDType(){ Id = "1"},
            Price = new Price()
            {
               PriceAmount = new BaseCurrency()
               {
                    CurrencyID = "TRY",
                    Value =  80m
               }
            },
            TaxTotal = new TaxTotal()
            {
                TaxAmount = new BaseCurrency()
                {
                    CurrencyID = "TRY",
                    Value = 30.8m
                },
                TaxSubtotals = new List<TaxSubtotal>()
                {
                     new TaxSubtotal()
                     {
                          CalculationSequenceNumeric = 1,
                         TaxableAmount = new BaseCurrency()
                         {
                             CurrencyID = "TRY",
                             Value = 100m
                         },
                         TaxAmount = new BaseCurrency()
                         {
                             CurrencyID = "TRY",
                             Value = 18m
                         },
                         Percent = 18m,
                         TaxCategory = new TaxCategory()
                         {
                             TaxScheme = new TaxScheme()
                             {
                                 Name = "KDV",
                                 TaxTypeCode = "0015"
                             }
                         }
                     },
                     new TaxSubtotal()
                     {
                          CalculationSequenceNumeric = 2,
                         TaxableAmount = new BaseCurrency()
                         {
                             CurrencyID = "TRY",
                             Value = 100m
                         },
                         TaxAmount = new BaseCurrency()
                         {
                             CurrencyID = "TRY",
                             Value = 20m
                         },
                         Percent = 20m,
                         TaxCategory = new TaxCategory()
                         {
                             TaxScheme = new TaxScheme()
                             {
                                 Name = "GV Stopaj",
                                 TaxTypeCode = "0003"
                             }
                         }
                     }
                },
            },           
            Item = new Item()
            {
                Name = "hizmet"
            }
        }
    }
};


var text = Directory.GetCurrentDirectory();
//using (StreamReader reader = new StreamReader(text))
//{
//    string result = reader.ReadToEnd();
//}

var client = new RestClient("https://apitest.nilvera.com/einvoice/Send/Xml?Alias=urn:mail:defaultpk@ayca.com");
//client.Timeout = -1;
var request = new RestRequest(text, Method.Post);
request.AddHeader("Content-Type", "multipart/form-data");
request.AddHeader("Accept", "text/plain");
request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");
request.AddFile("deneme", text);
var response = client.Execute(request);
Console.WriteLine(response.Content);



