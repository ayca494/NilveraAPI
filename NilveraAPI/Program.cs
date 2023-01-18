// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NilveraAPI.Enums;
using NilveraAPI.Models;
using NilveraAPI.Models.Dto;
using NilveraAPI.Models.Dto.Shared;
using RestSharp;
using System;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Numerics;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Text;
using NilveraAPI.Models.UblModels.Invoice;
using NilveraAPI.Models.UblModels.Shared;
using NilveraAPI.Models.UblModels.Despatch;
using System.Reflection;
using NilveraAPI.Models.UblModels.Producer;
using NilveraAPI.Models.UblModels.Voucher;
using NilveraAPI.Serializer;


#region E-Fatura

#region Faturayı Model olarak gönderir.
//EInvoiceModel eInvoiceModel = new EInvoiceModel()
//{
//    EInvoice = new EInvoiceDto()
//    {
//        CustomerInfo = new NilveraAPI.Models.Dto.Shared.PartyInfoDto()
//        {
//            TaxNumber = "6310540565",
//            Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ",
//            TaxOffice = "kayseri vergi dairesi",
//            AgentPartyIdentifications = new List<NilveraAPI.Models.Dto.Shared.IDTypeDto>(),
//            Address = "Kayseri sokak teknopark",
//            District = "Talas",
//            City = "Kayseri",
//            Country = "Türkiye",
//            PostalCode = "38000",
//            Phone = "02223334455",
//            Fax = "12345",
//            Mail = "kayseri@gmail.com",
//            WebSite = "www.kayseri.com"
//        },
//        CompanyInfo = new NilveraAPI.Models.Dto.Shared.PartyInfoDto()
//        {
//            Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ",
//            TaxNumber = "6310540565",
//            TaxOffice = "kayseri vergi dairesi",
//            PartyIdentifications = new List<NilveraAPI.Models.Dto.Shared.IDTypeDto>()
//            {
//                new NilveraAPI.Models.Dto.Shared.IDTypeDto()
//                {
//                     SchemeID = "TICARETSICILNO",
//                     Value = "213123"
//                }
//            },
//            AgentPartyIdentifications = new List<NilveraAPI.Models.Dto.Shared.IDTypeDto>()
//            {
//                new NilveraAPI.Models.Dto.Shared.IDTypeDto()
//                {
//                     SchemeID = "DISTRIBUTORNO",
//                     Value = "2112"
//                }
//            },
//            Address = "Yıldırım Beyazıt Mah. Aşıkveysel Bulvarı Erciyes Teknopark Binası 3",
//            District = "Talas",
//            City = "Kayseri",
//            Country = "TÜRKİYE",
//            PostalCode = "38000",
//            Phone = "08502514010",
//            Fax = "",
//            Mail = "destek@nilvera.com",
//            WebSite = "https://nilvera.com/"
//        },
//        InvoiceInfo = new NilveraAPI.Models.Dto.Shared.InvoiceInfoDto()
//        {
//            UUID = Guid.Parse(Guid.NewGuid().ToString().ToLower()),
//            TemplateUUID = Guid.Parse("4e482e2c-da6b-4c4b-b834-4dd444915c78"),
//            InvoiceProfile = NilveraAPI.Enums.InvoiceProfile.TEMELFATURA,
//            InvoiceType = NilveraAPI.Enums.InvoiceType.SATIS,
//            InvoiceSerieOrNumber = "BPU",
//            IssueDate = DateTime.Now,
//            CurrencyCode = "TRY",
//            ExchangeRate = 1,
//            DespatchDocumentReference = new List<NilveraAPI.Models.Dto.Shared.KeyValueDto>(),
//            OrderReference = null,
//            OrderReferenceDocument = null,
//            AdditionalDocumentReferences = new List<NilveraAPI.Models.Dto.Shared.AdditionalDocumentReferenceDto>(),
//            TaxExemptionReasonInfo = new NilveraAPI.Models.Dto.Shared.TaxExemptionReasonInfoDto()
//            {
//                KDVExemptionReasonCode = "",
//                OTVExemptionReasonCode = "",
//                AccommodationTaxExemptionReasonCode = "001"
//            },
//            PaymentTermsInfo = new NilveraAPI.Models.Dto.Shared.PaymentTermsDto()
//            {
//                Amount = null,
//                Note = null,
//                Percent = null
//            },
//            PaymentMeansInfo = null,
//            OKCInfo = null,
//            ReturnInvoiceInfo = new List<NilveraAPI.Models.Dto.Shared.ReturnInvoiceInfoDto>(),
//            Expenses = new List<NilveraAPI.Models.Dto.Shared.ExpensesDto>()
//        },
//        InvoiceLines = new List<NilveraAPI.Models.Dto.Shared.EInvoiceLineDto>()
//        {
//            new NilveraAPI.Models.Dto.Shared.EInvoiceLineDto(){
//                SellerCode = "",
//                BuyerCode = "",
//                Name = "Kalem",
//                Description = "",
//                Quantity = 1,
//                UnitType = "C62",
//                Price = 500,
//                AllowanceTotal = 0M,
//                KDVPercent = 18M,
//                KDVTotal = 0M,
//                Taxes = new List<NilveraAPI.Models.Dto.Shared.TaxDto>()
//                {
//                    new NilveraAPI.Models.Dto.Shared.TaxDto()
//                    {
//                        Percent = 0,
//                        Total = 0,
//                        TaxCode = ""
//                    }
//                },
//                ManufacturerCode = "",
//                BrandName = "",
//                ModelName = "",
//                Note = "",
//                OzelMatrahReason = null,
//                OzelMatrahTotal = null,
//                AdditionalItemIdentification = new NilveraAPI.Models.Dto.Shared.AdditionalItemIdentificationDto()
//            },
//        },
//        Notes = new List<string>()
//        {
//            "Bu",
//            "bir",
//            "denemedir.",
//            "notlar"
//        }
//    },
//    CustomerAlias = "urn:mail:defaultpk@nilvera.com"
//};

//var client = new RestClient();
//var request = new RestRequest("https://apitest.nilvera.com/einvoice/Send/Model", Method.Post);
//request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");
//request.AddJsonBody(eInvoiceModel);
//request.AddHeader("Content-Type", "application/json");
//request.AddHeader("Accept", "application/json");
//var response = await client.ExecuteAsync(request);
//Console.WriteLine(response.Content);
//Console.ReadLine();
#endregion



#region E-Faturanın Ubl Modelini Xml'e çevirme
//string basePath = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net6.0", "BaseXslt\\E-Invoice");
//string filePath = Path.Combine(basePath + "ca747ee5-9c0d-4410-9378-02bc4a5e31fa.xslt");

//if (!File.Exists(filePath))
//{
//    if (!Directory.Exists(basePath))
//        Directory.CreateDirectory(basePath);
//}
//var readTemplate = File.ReadAllText(filePath);

//var template = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(readTemplate.Substring(readTemplate.IndexOf("<"))));


//UblInvoice ublInvoice = new UblInvoice()
//{
//    ID = "MTT",
//    InvoiceTypeCode = "SATIS",
//    IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
//    IssueTime = DateTime.Now.ToString("HH:mm:ss"),
//    ProfileID = "TICARIFATURA",
//    UUID = Guid.NewGuid().ToString().ToLower(),
//    AccountingCustomerParty = new CustomerParty()
//    {
//        Party = new Party()
//        {
//            Contact = new Contact()
//            {
//                ElectronicMail = "kayseri@gmail.com",
//                Telephone = "02223334455",
//                Telefax = "12344"
//            },
//            PostalAddress = new Address()
//            {
//                Country = new Country() { Name = "Türkiye" },
//                CityName = "Kayseri",
//                CitySubdivisionName = "Talas",
//                StreetName = "Teknopark"
//            },
//            PartyName = new PartyName()
//            {
//                Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ"
//            },
//            PartyIdentification = new List<PartyIdentification>()
//            {
//                new PartyIdentification()
//                {
//                    ID = new IDType() { Id = "6310540565", SchemeId = "VKN" }
//                }
//            }
//        }
//    },
//    AccountingSupplierParty = new SupplierParty()
//    {
//        Party = new Party()
//        {
//            Contact = new Contact()
//            {
//                ElectronicMail = "kayseri@gmail.com",
//                Telephone = "02223334455",
//                Telefax = "12344"
//            },
//            PostalAddress = new Address()
//            {
//                Country = new Country() { Name = "Türkiye" },
//                CityName = "Kayseri",
//                CitySubdivisionName = "Talas",
//                StreetName = "Teknopark"
//            },
//            PartyName = new PartyName()
//            {
//                Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ"
//            },
//            PartyIdentification = new List<PartyIdentification>()
//            {
//                new PartyIdentification()
//                {
//                    ID = new IDType() { Id = "6310540565", SchemeId = "VKN" }
//                }
//            }
//        }
//    },
//    AllowanceCharge = new List<AllowanceCharge>()
//    {
//        new AllowanceCharge()
//        {
//            Amount = new BaseCurrency()
//            {
//                CurrencyID = "TRY",
//                Value = 5
//            },
//            ChargeIndicator = false
//        }
//    },
//    DocumentCurrencyCode = new DocumentCurrencyCode()
//    {
//        Name = "TRY"
//    },
//    InvoiceLines = new List<InvoiceLine>()
//    {
//        new InvoiceLine()
//        {
//            AllowanceCharge = new List<AllowanceCharge>()
//            {
//                new AllowanceCharge()
//                {
//                    Amount = new BaseCurrency() { CurrencyID = "TRY", Value = 5 },
//                    BaseAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 100 },
//                    MultiplierFactorNumeric = "0.05",
//                    ChargeIndicator = false
//                }
//            },
//            ID = new IDType() { Id = "1" },
//            InvoicedQuantity = new BaseUnit()
//            {
//                UnitCode = "C62",
//                Value = 1
//            },
//            Item = new Item()
//            {
//                Name = "Ürün"
//            },
//            LineExtensionAmount = new BaseCurrency()
//            {
//                CurrencyID = "TRY",
//                Value = 95
//            },
//            Price = new Price()
//            {
//                PriceAmount = new BaseCurrency()
//                {
//                    CurrencyID = "TRY",
//                    Value = 100
//                }
//            },
//            TaxTotal = new TaxTotal()
//            {
//                TaxAmount = new BaseCurrency()
//                {
//                    CurrencyID = "TRY",
//                    Value = (Decimal)17.1
//                },
//                TaxSubtotals = new List<TaxSubtotal>()
//                {
//                    new TaxSubtotal()
//                    {
//                        Percent = 18,
//                        TaxableAmount = new BaseCurrency()
//                        {
//                            CurrencyID = "TRY",
//                            Value = 95
//                        },
//                        CalculationSequenceNumeric = 1,
//                        TaxAmount = new BaseCurrency()
//                        {
//                            CurrencyID = "TRY",
//                            Value = (decimal)17.1
//                        },
//                        TaxCategory = new TaxCategory()
//                        {
//                            TaxScheme = new TaxScheme()
//                            {
//                                Name = "KDV",
//                                TaxTypeCode = "0015"
//                            }
//                        }
//                    }
//                }
//            }

//        }
//    },
//    LegalMonetaryTotal = new MonetaryTotal()
//    {
//        AllowanceTotalAmount = new BaseCurrency()
//        {
//            CurrencyID = "TRY",
//            Value = 5
//        },
//        LineExtensionAmount = new BaseCurrency()
//        {
//            CurrencyID = "TRY",
//            Value = 100
//        },
//        PayableAmount = new BaseCurrency()
//        {
//            CurrencyID = "TRY",
//            Value = (decimal)112.1
//        },
//        TaxExclusiveAmount = new BaseCurrency()
//        {
//            CurrencyID = "TRY",
//            Value = 95
//        },
//        TaxInclusiveAmount = new BaseCurrency()
//        {
//            CurrencyID = "TRY",
//            Value = (decimal)112.1
//        }
//    },
//    LineCountNumeric = 1,
//    Notes = new List<string>()
//    {
//        "YALNIZ : YÜZONİKİ TL ON Kr."
//    },
//    TaxTotals = new List<TaxTotal>()
//    {
//        new TaxTotal()
//        {
//            TaxAmount = new BaseCurrency()
//            {
//                CurrencyID = "TRY",
//                Value = (decimal)17.1
//            },
//            TaxSubtotals = new List<TaxSubtotal>()
//            {
//                new TaxSubtotal()
//                {
//                    CalculationSequenceNumeric = 1,
//                    Percent = 18,
//                    TaxAmount = new BaseCurrency()
//                    {
//                        CurrencyID = "TRY",
//                        Value = (decimal)17.1
//                    },
//                    TaxableAmount = new BaseCurrency()
//                    {
//                        CurrencyID = "TRY",
//                        Value = 95
//                    },
//                    TaxCategory = new TaxCategory()
//                    {
//                        TaxScheme = new TaxScheme()
//                        {
//                            Name = "KDV",
//                            TaxTypeCode = "0015"
//                        }
//                    }
//                }
//            }
//        }
//    },
//    AdditionalDocumentReferences = new List<DocumentReference>()
//    {
//        new DocumentReference()
//        {
//            DocumentType = "XSLT",
//            DocumentDescription = "E-Fatura stil dosyası.",
//            ID = new IDType() { Id = "ca747ee5-9c0d-4410-9378-02bc4a5e31fa" },
//            IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
//            Attachment = new Attachment()
//            {
//                EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObject()
//                {
//                    CharacterSetCode = "UTF-8",
//                    EncodingCode = "Base64",
//                    Filename = "ca747ee5-9c0d-4410-9378-02bc4a5e31fa.xslt",
//                    MimeCode = "application/xml",
//                    Name = template
//                }
//            }
//        }
//    }


//};

//UblInvoiceSerializer ublInvoiceSerializer = new UblInvoiceSerializer();
//string content = await ublInvoiceSerializer.SerializeAsync(ublInvoice, ublInvoiceSerializer.xmlns);

//var newcontent = ublInvoiceSerializer.CleanXmlContent(content);

//Console.WriteLine("Xml oluşturuldu. Dosya yolu : " + ublInvoiceSerializer.LoadOrCreateXML(newcontent));
//Console.ReadLine();
#endregion



#region Faturayı XML olarak gönderir.
//var client = new RestClient();
//var request = new RestRequest("https://apitest.nilvera.com/einvoice/Send/Xml?Alias=urn:mail:defaultpk@nilvera.com", Method.Post);
//request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");     //Portaldan aldığınız API KEY giriniz.
//request.AddHeader("Content-Type", "multipart/form-data");
//request.AddFile("file", "/path/to/file", "application/xml");   // "/path/to/file" XML'in path giriniz.
//var response = await client.ExecuteAsync(request);
//Console.WriteLine(response.Content);
//Console.ReadLine();
#endregion

#endregion


#region E-Arşiv

#region E-Arşiv Model olarak gönderir.
//ArchiveInvoiceModel archiveInvoiceModel = new ArchiveInvoiceModel()
//{
//    ArchiveInvoice = new ArchiveInvoiceDto()
//    {
//        CompanyInfo = new PartyInfoDto()
//        {
//            TaxNumber = "6310540565",
//            Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ",
//            TaxOffice = "",
//            PartyIdentifications = new List<NilveraAPI.Models.Dto.Shared.IDTypeDto>()
//            {
//                new NilveraAPI.Models.Dto.Shared.IDTypeDto()
//                {
//                    SchemeID = "MERSISNO",
//                    Value = "1122334455667788 "
//                },
//                new NilveraAPI.Models.Dto.Shared.IDTypeDto()
//                {
//                    SchemeID = "TICARETSICILNO",
//                    Value = "12345"
//                }
//            },
//            Address = "adres",
//            District = "Melikgazi",
//            City = "Kayseri",
//            Country = "Türkiye",
//            PostalCode = "",
//            Phone = "",
//            Fax = "12345",
//            Mail = "",
//            WebSite = ""
//        },
//        CustomerInfo = new PartyInfoDto()
//        {
//            TaxOffice = "Melikgazi",
//            Address = "Sahabiye Mahallesi Bor Sok. Soylu İş Merkz. No:10",
//            District = "Kocasinan",
//            City = "Kayseri",
//            Country = "Türkiye",
//            Fax = "",
//            Name = "MOHAMMAD ALAJATI",
//            PartyIdentifications = new List<IDTypeDto>(),
//            Phone = "",
//            PostalCode = "",
//            TaxNumber = "99347391094",
//            WebSite = ""
//        },
//        InvoiceInfo = new ArchiveInvoiceInfoDto()
//        {
//            UUID = Guid.Parse(Guid.NewGuid().ToString().ToLower()),
//            TemplateUUID = Guid.Parse("72813487-e592-4758-87da-be08ed199197"),
//            InvoiceType = NilveraAPI.Enums.InvoiceType.SATIS,
//            InvoiceSerieOrNumber = "NIL",
//            IssueDate = DateTime.Now,
//            CurrencyCode = "TRY",
//            ExchangeRate = 1,
//            Expenses = new List<ExpensesDto>()
//            {
//                new ExpensesDto()
//                {
//                    Amount = 12,
//                    ExpenseType = NilveraAPI.Enums.ExpenseType.HKSKOMISYON
//                }
//            },
//            SendType = SendType.KAGIT,
//            SalesPlatform = SalesPlatform.NORMAL
//        },
//        InvoiceLines = new List<EArchiveInvoiceLineDto>()
//        {
//            new EArchiveInvoiceLineDto()
//            {
//                Name = "Deneme",
//                Price = 12,
//                Quantity = 125,
//                UnitType = "C62",
//                AllowanceTotal = 195,
//                KDVPercent = 18,
//                AdditionalItemIdentification = new AdditionalItemIdentificationDto()
//                {
//                    TagNumber = "1231231231231231231",
//                    OwnerName = "deneme",
//                    OwnerTaxNumber = "22040521512"
//                }
//            }
//        }
//    }
//};

//var client = new RestClient();
//var request = new RestRequest("https://apitest.nilvera.com/earchive/Send/Model", Method.Post);
//request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");
//request.AddJsonBody(archiveInvoiceModel);
//request.AddHeader("Content-Type", "application/json");
//request.AddHeader("Accept", "application/json");
//var response = await client.ExecuteAsync(request);
//Console.WriteLine(response.Content);
//Console.ReadLine();

#endregion


#region E-Arşiv Xml olarak gönderir.
//var client = new RestClient();
//var request = new RestRequest("https://apitest.nilvera.com/earchive/Send/Xml?Alias=urn:mail:defaultpk@nilvera.com", Method.Post);
//request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");     //Portaldan aldığınız API KEY giriniz.
//request.AddHeader("Content-Type", "multipart/form-data");
//request.AddFile("file", "C:\\Users\\Tunahan\\Downloads\\MOHAMMAD ALAJATI-NIL.xml", "application/xml");   // "/path/to/file" XML'in path giriniz.
//var response = await client.ExecuteAsync(request);
//Console.WriteLine(response.Content);
//Console.ReadLine();
#endregion


#region E-Arşivin Ubl Modelini XML'e çevirme

//string basePath = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net6.0", "BaseXslt\\E-Archive");
//string filePath = Path.Combine(basePath + "3bad4083-fa25-4bb8-82a3-65e8369c8280.xslt");

//if (!File.Exists(filePath))
//{
//    if (!Directory.Exists(basePath))
//        Directory.CreateDirectory(basePath);
//}
//var readTemplate = File.ReadAllText(filePath);

//var template = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(readTemplate.Substring(readTemplate.IndexOf("<"))));


//UblInvoice ublEArchiveInvoice = new UblInvoice()
//{
//    ID = "NIL",
//    InvoiceTypeCode = "SATIS",
//    IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
//    IssueTime = DateTime.Now.ToString("HH:mm:ss"),
//    ProfileID = "EARSIVFATURA",
//    UUID = Guid.NewGuid().ToString().ToLower(),
//    AccountingCustomerParty = new CustomerParty()
//    {
//        Party = new Party()
//        {
//            Contact = new Contact()
//            {
//                ElectronicMail = "kayseri@gmail.com",
//                Telephone = "02223334455",
//                Telefax = "12344"
//            },
//            PostalAddress = new Address()
//            {
//                Country = new Country() { Name = "Türkiye" },
//                CityName = "Kayseri",
//                CitySubdivisionName = "Talas",
//                StreetName = "Teknopark"
//            },
//            Person = new Person()
//            {
//                FirstName = "MOHAMMAD",
//                FamilyName = "ALAJATI"

//            },
//            PartyIdentification = new List<PartyIdentification>()
//            {
//                new PartyIdentification()
//                {
//                    ID = new IDType() { Id = "99347391094", SchemeId = "TCKN" }
//                }
//            },
//            PartyTaxScheme = new PartyTaxScheme()
//            {
//                TaxScheme = new TaxScheme()
//                {
//                    Name = "Melikgazi"
//                }
//            }
//        }
//    },
//    AccountingSupplierParty = new SupplierParty()
//    {
//        Party = new Party()
//        {
//            Contact = new Contact()
//            {
//                ElectronicMail = "kayseri@gmail.com",
//                Telephone = "02223334455",
//                Telefax = "12344"
//            },
//            PostalAddress = new Address()
//            {
//                Country = new Country() { Name = "Türkiye" },
//                CityName = "Kayseri",
//                CitySubdivisionName = "Talas",
//                StreetName = "Teknopark"
//            },
//            PartyName = new PartyName()
//            {
//                Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ"
//            },
//            PartyIdentification = new List<PartyIdentification>()
//            {
//                new PartyIdentification()
//                {
//                    ID = new IDType() { Id = "6310540565", SchemeId = "VKN" }
//                }
//            }
//        }
//    },
//    AllowanceCharge = new List<AllowanceCharge>()
//    {
//        new AllowanceCharge()
//        {
//            Amount = new BaseCurrency()
//            {
//                CurrencyID = "TRY",
//                Value = 5
//            },
//            ChargeIndicator = false
//        }
//    },
//    DocumentCurrencyCode = new DocumentCurrencyCode()
//    {
//        Name = "TRY"
//    },
//    InvoiceLines = new List<InvoiceLine>()
//    {
//        new InvoiceLine()
//        {
//            AllowanceCharge = new List<AllowanceCharge>()
//            {
//                new AllowanceCharge()
//                {
//                    Amount = new BaseCurrency() { CurrencyID = "TRY", Value = 5 },
//                    BaseAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 100 },
//                    MultiplierFactorNumeric = "0.05",
//                    ChargeIndicator = false
//                }
//            },
//            ID = new IDType() { Id = "1" },
//            InvoicedQuantity = new BaseUnit()
//            {
//                UnitCode = "C62",
//                Value = 1
//            },
//            Item = new Item()
//            {
//                Name = "Ürün"
//            },
//            LineExtensionAmount = new BaseCurrency()
//            {
//                CurrencyID = "TRY",
//                Value = 95
//            },
//            Price = new Price()
//            {
//                PriceAmount = new BaseCurrency()
//                {
//                    CurrencyID = "TRY",
//                    Value = 100
//                }
//            },
//            TaxTotal = new TaxTotal()
//            {
//                TaxAmount = new BaseCurrency()
//                {
//                    CurrencyID = "TRY",
//                    Value = (Decimal)17.1
//                },
//                TaxSubtotals = new List<TaxSubtotal>()
//                {
//                    new TaxSubtotal()
//                    {
//                        Percent = 18,
//                        TaxableAmount = new BaseCurrency()
//                        {
//                            CurrencyID = "TRY",
//                            Value = 95
//                        },
//                        CalculationSequenceNumeric = 1,
//                        TaxAmount = new BaseCurrency()
//                        {
//                            CurrencyID = "TRY",
//                            Value = (decimal)17.1
//                        },
//                        TaxCategory = new TaxCategory()
//                        {
//                            TaxScheme = new TaxScheme()
//                            {
//                                Name = "KDV",
//                                TaxTypeCode = "0015"
//                            }
//                        }
//                    }
//                }
//            }

//        }
//    },
//    LegalMonetaryTotal = new MonetaryTotal()
//    {
//        AllowanceTotalAmount = new BaseCurrency()
//        {
//            CurrencyID = "TRY",
//            Value = 5
//        },
//        LineExtensionAmount = new BaseCurrency()
//        {
//            CurrencyID = "TRY",
//            Value = 100
//        },
//        PayableAmount = new BaseCurrency()
//        {
//            CurrencyID = "TRY",
//            Value = (decimal)112.1
//        },
//        TaxExclusiveAmount = new BaseCurrency()
//        {
//            CurrencyID = "TRY",
//            Value = 95
//        },
//        TaxInclusiveAmount = new BaseCurrency()
//        {
//            CurrencyID = "TRY",
//            Value = (decimal)112.1
//        }
//    },
//    LineCountNumeric = 1,
//    Notes = new List<string>()
//    {
//        "YALNIZ : YÜZONİKİ TL ON Kr."
//    },
//    TaxTotals = new List<TaxTotal>()
//    {
//        new TaxTotal()
//        {
//            TaxAmount = new BaseCurrency()
//            {
//                CurrencyID = "TRY",
//                Value = (decimal)17.1
//            },
//            TaxSubtotals = new List<TaxSubtotal>()
//            {
//                new TaxSubtotal()
//                {
//                    CalculationSequenceNumeric = 1,
//                    Percent = 18,
//                    TaxAmount = new BaseCurrency()
//                    {
//                        CurrencyID = "TRY",
//                        Value = (decimal)17.1
//                    },
//                    TaxableAmount = new BaseCurrency()
//                    {
//                        CurrencyID = "TRY",
//                        Value = 95
//                    },
//                    TaxCategory = new TaxCategory()
//                    {
//                        TaxScheme = new TaxScheme()
//                        {
//                            Name = "KDV",
//                            TaxTypeCode = "0015"
//                        }
//                    }
//                }
//            }
//        }
//    },
//    AdditionalDocumentReferences = new List<DocumentReference>()
//    {
//        new DocumentReference()
//        {
//            DocumentType = "XSLT",
//            DocumentDescription = "E-Arşiv stil dosyası.",
//            ID = new IDType() { Id = "3bad4083-fa25-4bb8-82a3-65e8369c8280" },
//            IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
//            Attachment = new Attachment()
//            {
//                EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObject()
//                {
//                    CharacterSetCode = "UTF-8",
//                    EncodingCode = "Base64",
//                    Filename = "3bad4083-fa25-4bb8-82a3-65e8369c8280.xslt",
//                    MimeCode = "application/xml",
//                    Name = template
//                }
//            }
//        },
//        new DocumentReference()
//        {
//            ID = new IDType(){ Id="ELEKTRONIK"},
//            DocumentTypeCode="SEND_TYPE",
//            IssueDate=DateTime.Now.ToString("yyyy-MM-dd")
//        }
//    }


//};

//UblInvoiceSerializer ublInvoiceSerializer = new UblInvoiceSerializer();
//string content = await ublInvoiceSerializer.SerializeAsync(ublEArchiveInvoice, ublInvoiceSerializer.xmlns);

//var newcontent = ublInvoiceSerializer.CleanXmlContent(content);

//Console.WriteLine("Xml oluşturuldu. Dosya yolu : " + ublInvoiceSerializer.LoadOrCreateXML(newcontent));
//Console.ReadLine();
#endregion

#endregion


#region İrsaliye

#region İrsaliyeyi Model olarak gönderir.
//EDespatchModel eDespatch = new EDespatchModel()
//{
//    EDespatch = new()
//    {
//        DespatchSupplierInfo = new DespatchSupplierInfoDto
//        {
//            Address = "Kayseri sokak teknopark",
//            City = "Kayseri",
//            Country = "Türkiye",
//            District = "Talas",
//            Email = "kayseri@gmail.com",
//            Fax = "12345",
//            Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ",
//            PartyIdentifications = new List<IDTypeDto>(),
//            Phone = "02223334455",
//            PostalCode = "38000",
//            TaxNumber = "6310540565",
//            TaxOffice = "Melikgazi",
//            WebSite = "www.kayseri.com"
//        },
//        DeliveryCustomerInfo = new DeliveryCustomerInfoDto()
//        {
//            Address = "Kayseri sokak teknopark",
//            City = "Kayseri",
//            Country = "Türkiye",
//            District = "Talas",
//            Email = "kayseri@gmail.com",
//            Fax = "12345",
//            Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ",
//            PartyIdentifications = new List<IDTypeDto>(),
//            Phone = "02223334455",
//            PostalCode = "38000",
//            TaxNumber = "6310540565",
//            TaxOffice = "Melikgazi",
//            WebSite = "www.kayseri.com"
//        },
//        AdditionalDocumentReference = new List<AdditionalDocumentReferenceDto>(),
//        BuyerCustomerInfo = null,
//        DespatchInfo = new DespatchInfoDto() 
//        { 
//            UUID= Guid.NewGuid(),
//            IssueDate= DateTime.Now,
//            TemplateUUID = Guid.Parse("71940343-06c8-4daf-9f70-cd4023aa8f1e"),
//            ActualDespatchDateTime=DateTime.Now,
//            PayableAmount=0,
//            CurrencyCode="TRY",
//            DespatchType = DespatchType.SEVK,
//            DespatchProfile = DespatchProfile.TEMELIRSALIYE,
//            DespatchSerieOrNumber="OPR",
//            MatbuIssueDate=null,
//            MatbuNumber=null
//        },
//        DespatchLines = new List<DespatchLineDto>()
//        {
//            new DespatchLineDto()
//            {
//                DeliveredUnitType="C62",
//                DeliveredUnitName="Adet",
//                Name="Ürün",
//                DeliveredQuantity=50,
//                QuantityPrice=(decimal)2.5,
//                LineTotal=(decimal)125.0
//            }
//        },
//        Notes = new List<string>(),
//        OrderReference = new OrderReferenceDto()
//        {
//            DocumentReference = null,
//            ID = "1235412",
//            IssueDate = DateTime.Now
//        },
//        OriginatorCustomerInfo = null,
//        SellerSupplierInfo = null,
//        ShipmentDetail = new ShipmentDetailDto()
//        {
//            ShipmentInfo = new ShipmentInfoDto()
//            {
//                DriverPerson = new List<DriverPersonDto>()
//                {
//                    new DriverPersonDto()
//                    {
//                        FirstName = "şoför",
//                        LastName = "şoför",
//                        TaxNumber= "12345678914"
//                    }                
//                },
//                LicensePlateID= "38fg456"
//            },
//            Delivery= new DeliveryDto()
//            {
//                AddressInfo= new AddressInfoDto()
//                {
//                    Address="Kayseri Teknopark",
//                    District="Melikgazi",
//                    City="Kayseri",
//                    Country="Türkiye",
//                    PostalCode="38000"
//                },
//                CarrierInfo=null
//            },
//            TransportEquipment= new List<string>()
//            {
//                "38fg456"
//            }
//        }
//},
//    CustomerAlias="urn:mail:defaultpk@nilvera.com"
//};


//var client = new RestClient();
//var request = new RestRequest("https://apitest.nilvera.com/edespatch/Send/Model", Method.Post);
//request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");
//request.AddJsonBody(eDespatch);
//request.AddHeader("Content-Type", "application/json");
//request.AddHeader("Accept", "application/json");
//var response = await client.ExecuteAsync(request);
//Console.WriteLine(response.Content);
//Console.ReadLine();
#endregion


#region İrsaliyeyi Xml olarak gönderir
//var client = new RestClient();
//var request = new RestRequest("https://apitest.nilvera.com/edespatch/Send/Xml?Alias=urn:mail:defaultpk@nilvera.com", Method.Post);
//request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");     //Portaldan aldığınız API KEY giriniz.
//request.AddHeader("Content-Type", "multipart/form-data");
//request.AddFile("file", "C:\\Users\\Tunahan\\Downloads\\Fatura.xml", "application/xml");   // "/path/to/file" XML'in path giriniz.
//var response = await client.ExecuteAsync(request);
//Console.WriteLine(response.Content);
//Console.ReadLine();
#endregion


#region İrsaliye Ubl Modelini Xml'e Çevirme
//string basePath = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net6.0", "BaseXslt\\Despatch");
//string filePath = Path.Combine(basePath + "71940343-06c8-4daf-9f70-cd4023aa8f1e.xslt");

//if (!File.Exists(filePath))
//{
//    if (!Directory.Exists(basePath))
//        Directory.CreateDirectory(basePath);
//}
//var readTemplate = File.ReadAllText(filePath);

//var template = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(readTemplate.Substring(readTemplate.IndexOf("<"))));

//UblDespatch UblDespatch = new UblDespatch()
//{
//    DespatchAdviceTypeCode = "SEVK",
//    ID = "OPR",
//    ProfileID = "TEMELIRSALIYE",
//    IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
//    IssueTime = DateTime.Now.ToString("HH:mm:ss"),
//    UUID = Guid.NewGuid().ToString().ToLower(),
//    LineCountNumeric = 1,
//    DeliveryCustomerParty = new DeliveryCustomerParty()
//    {
//        Party = new Party()
//        {
//            Contact = new Contact()
//            {
//                ElectronicMail = "kayseri@gmail.com",
//                Telephone = "02223334455",
//                Telefax = "12345"
//            },
//            PartyIdentification = new List<PartyIdentification>()
//            {
//                new PartyIdentification()
//                {
//                    ID= new IDType()
//                    {
//                        Id="6310540565",
//                        SchemeId = "VKN"
//                    }
//                }
//            },
//            PartyName = new PartyName()
//            {
//                Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ"
//            },
//            PartyTaxScheme = new PartyTaxScheme()
//            {
//                TaxScheme = new TaxScheme()
//                {
//                    Name = "Melikgazi"
//                }
//            },
//            PostalAddress = new Address()
//            {
//                Country = new Country() { Name = "Türkiye", IdentificationCode = "TR" },
//                CityName = "Kayseri",
//                CitySubdivisionName = "Talas",
//                StreetName = "Teknopark",
//                PostalZone = "38000"
//            },
//            WebSiteURI = "www.kayseri.com"
//        }
//    },
//    DespatchSupplierParty = new DespatchSupplierParty()
//    {
//        Party = new Party()
//        {
//            Contact = new Contact()
//            {
//                ElectronicMail = "kayseri@gmail.com",
//                Telephone = "02223334455",
//                Telefax = "12345"
//            },
//            PartyIdentification = new List<PartyIdentification>()
//            {
//                new PartyIdentification()
//                {
//                    ID= new IDType()
//                    {
//                        Id="6310540565",
//                        SchemeId = "VKN"
//                    }
//                }
//            },
//            PartyName = new PartyName()
//            {
//                Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ"
//            },
//            PartyTaxScheme = new PartyTaxScheme()
//            {
//                TaxScheme = new TaxScheme()
//                {
//                    Name = "Melikgazi"
//                }
//            },
//            PostalAddress = new Address()
//            {
//                Country = new Country() { Name = "Türkiye" },
//                CityName = "Kayseri",
//                CitySubdivisionName = "Talas",
//                StreetName = "Teknopark",
//                PostalZone = "38000"
//            },
//            WebSiteURI = "www.kayseri.com"
//        }
//    },
//    DespatchLine = new List<DespatchLine>()
//    {
//        new DespatchLine()
//        {
//            DeliveredQuantity = new DeliveredQuantity()
//            {
//                Quantity=50,
//                UnitCode="C62"
//            },
//            ID= new IDType()
//            {
//                Id="1"
//            },
//            Item = new Item()
//            {
//                Name="Ürün"
//            },
//            OrderLineReference = new OrderLineReference()
//            {
//                LineID= new IDType()
//                {
//                    Id="1"
//                }
//            },
//            Shipment=new Shipment()
//            {
//                ID=new IDType(),
//                GoodsItem = new List<GoodsItem>()
//                {
//                    new GoodsItem()
//                    {
//                        InvoiceLine =new InvoiceLine()
//                        {
//                            ID=new IDType(),
//                            InvoicedQuantity= new BaseUnit()
//                            {
//                                Value=50
//                            },
//                            Item= new Item()
//                            {
//                                Name="Ürün"
//                            },
//                            LineExtensionAmount= new BaseCurrency()
//                            {
//                                CurrencyID="TRY",
//                                Value=125
//                            },
//                            Price= new Price()
//                            {
//                                PriceAmount=new BaseCurrency()
//                                {
//                                    CurrencyID="TRY",
//                                    Value=(decimal)2.5
//                                }
//                            }

//                        }
//                    }
//                }
//            }
//        }

//    },
//    OrderReference = new OrderReference()
//    {
//        IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
//        ID = new IDType()
//        {
//            Id = "1235412"
//        }
//    },
//    Shipment = new Shipment()
//    {
//        Delivery = new Delivery()
//        {
//            DeliveryAddress = new Address()
//            {
//                CityName = "Kayseri",
//                CitySubdivisionName = "Melikgazi",
//                StreetName = "Kayseri Teknopark",
//                Country = new Country()
//                {
//                    IdentificationCode = "TR",
//                    Name = "Türkiye"
//                },
//                PostalZone = "38000"
//            },
//            Despatch = new DespatchModel()
//            {
//                ActualDespatchDate = DateTime.Now.ToString("yyyy-MM-dd"),
//                ActualDespatchTime = DateTime.Now.ToString("HH:mm:ss")
//            }
//        },
//        ID = new IDType(),
//        GoodsItem = new List<GoodsItem>()
//        {
//            new GoodsItem()
//            {
//                ValueAmount = new BaseCurrency()
//                {
//                    CurrencyID="TRY",
//                    Value=(decimal)125
//                }
//            }
//        },
//        ShipmentStage = new List<ShipmentStage>()
//        {
//            new ShipmentStage()
//            {
//                DriverPerson = new List<Person>()
//                {
//                    new Person()
//                    {
//                        FirstName = "Şoför",
//                        FamilyName="Şoför",
//                        Title = "Şoför",
//                        NationalityID= new IDType()
//                        {
//                            Id ="12345678914",
//                            SchemeId = "TCKN"
//                        }
//                    }
//                },
//                TransportMeans = new TransportMeans()
//                {
//                    RoadTransport = new List<RoadTransport>()
//                    {
//                        new RoadTransport()
//                        {
//                            LicensePlateID = new IDType()
//                            {
//                                Id="38fg456",
//                                SchemeId="PLAKA"
//                            }
//                        }
//                    }
//                }
//            }
//        },
//        TransportHandlingUnit = new List<TransportHandlingUnit>()
//        {
//            new TransportHandlingUnit()
//            {
//                TransportEquipment = new List<TransportEquipment>()
//                {
//                    new TransportEquipment()
//                    {
//                        Id=new IDType()
//                        {
//                            Id="38fg456",
//                            SchemeId="DORSEPLAKA"
//                        }
//                    }
//                }
//            }
//        }
//    },
//    AdditionalDocumentReferences = new List<DocumentReference>()
//    {
//        new DocumentReference()
//        {
//            ID= new IDType()
//            {
//                Id="71940343-06c8-4daf-9f70-cd4023aa8f1e"
//            },
//            IssueDate=DateTime.Now.ToString("yyyy-MM-dd"),
//            DocumentType= "XSLT",
//            DocumentDescription="E-İrsaliye stil dosyası.",
//            Attachment = new Attachment()
//            {
//                EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObject()
//                {
//                    CharacterSetCode="UTF-8",
//                    EncodingCode="Base64",
//                    MimeCode="application/xml",
//                    Filename="71940343-06c8-4daf-9f70-cd4023aa8f1e.xslt",
//                    Name=template
//                }
//            }
//        }
//    }
//};

//UblInvoiceSerializer ublInvoiceSerializer = new UblInvoiceSerializer();
//UblDespatchSerializer ublDespatchSerializer = new UblDespatchSerializer();
//string content = await ublInvoiceSerializer.SerializeAsync(UblDespatch, ublDespatchSerializer.xmlns);

//var newcontent = ublInvoiceSerializer.CleanXmlContent(content);

//Console.WriteLine("Xml oluşturuldu. Dosya yolu : " + ublInvoiceSerializer.LoadOrCreateXML(newcontent));
//Console.ReadLine();
#endregion

#endregion


#region Müstahsil

#region Müstahsil Model olarak gönderir.

//ProducerModel producerModel = new ProducerModel()
//{
//    Producer = new ProducerDto()
//    {
//        ProducerLines = new List<EProducerLineDto>()
//        {
//            new EProducerLineDto() {
//                Name = "Ürün",
//                Quantity = 1m,
//                Price = 10m,
//                UnitType =  "C62",
//                GVWithholdingPercent = 20m,
//                GVWithholdingAmount = 2m,
//                Taxes = new List<TaxDto>(){}
//            },
//        },
//        CustomerInfo = new PartyInfoDto()
//        {
//            TaxNumber = "12345678901",
//            Name = "FEVZİ FURKAN TATLISU",
//            TaxOffice = "Gevher Nesibe",
//            AgentPartyIdentifications = null,
//            PartyIdentifications = new List<IDTypeDto>(),
//            Address = "Mimarsinan Şirintepe Mah. Malazgirt Bulvarı 75.Yıl Sitesi Apt.",
//            District = "Melikgazi",
//            City = "Kayseri",
//            Country = "ülke",
//            PostalCode = "38100",
//            Phone = "05567894356",
//            Fax = "03523489208",
//            Mail = "furkantatlisu@gmail.com",
//            WebSite = "www.deneme.com"
//        },
//        CompanyInfo = new PartyInfoDto()
//        {
//            Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ",
//            TaxNumber = "6310540565",
//            TaxOffice = "Gevher Nesibe",
//            PartyIdentifications = new List<IDTypeDto>()
//            {
//                new IDTypeDto()
//                {
//                    SchemeID = "MERSISNO",
//                    Value="1122334455667788"
//                },
//                new IDTypeDto()
//                {
//                    SchemeID = "TICARETSICILNO",
//                    Value = "12345"
//                }
//            },
//            Address = "Yıldırım Beyazıt Mah. Aşıkveysel Bulvarı Erciyes Teknopark Binası 3",
//            District = "Melikgazi",
//            City = "Kayseri",
//            Country = "TÜRKİYE",
//            PostalCode = "38100",
//            Phone = "02166885100",
//            Fax = "0216 688 51 99",
//            Mail = "destek@nilvera.com",
//            WebSite = "www.nilvera.com"
//        },
//        ProducerInfo = new ProducerInfoDto()
//        {
//            UUID = Guid.Parse(Guid.NewGuid().ToString().ToLower()),
//            TemplateUUID = Guid.Parse("fe917cea-0461-4a1e-b301-6d9e1ad0b7e0"),
//            ProducerSerieOrNumber = "EMM",
//            IssueDate = DateTime.Now,
//            DeliveryDate =DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")),
//            CurrencyCode = "TRY",
//            ExchangeRate = 1
//        },
//        Notes = new List<string>()
//        {
//            "Bu",
//            "bir",
//            "denemedir."
//        }

//    }
//};

//var client = new RestClient();
//var request = new RestRequest("https://apitest.nilvera.com/emm/Send/Model", Method.Post);
//request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");
//request.AddJsonBody(producerModel);
//request.AddHeader("Content-Type", "application/json");
//request.AddHeader("Accept", "application/json");
//var response = await client.ExecuteAsync(request);
//Console.WriteLine(response.Content);
//Console.ReadLine();
#endregion


#region Müstahsil Xml olarak gönderir
//var client = new RestClient();
//var request = new RestRequest("https://apitest.nilvera.com/emm/Send/Xml?Alias=urn:mail:defaultpk@nilvera.com", Method.Post);
//request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");     //Portaldan aldığınız API KEY giriniz.
//request.AddHeader("Content-Type", "multipart/form-data");
//request.AddFile("file", "C:\\Users\\Tunahan\\Downloads\\Fatura.xml", "application/xml");   // "/path/to/file" XML'in path giriniz.
//var response = await client.ExecuteAsync(request);
//Console.WriteLine(response.Content);
//Console.ReadLine();
#endregion


#region Müstahsil Ubl Modelini Xml'e Çevirme

//string basePath = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net6.0", "BaseXslt\\Producer");
//string filePath = Path.Combine(basePath + "fe917cea-0461-4a1e-b301-6d9e1ad0b7e0.xslt");

//if (!File.Exists(filePath))
//{
//    if (!Directory.Exists(basePath))
//        Directory.CreateDirectory(basePath);
//}
//var readTemplate = File.ReadAllText(filePath);

//var template = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(readTemplate.Substring(readTemplate.IndexOf("<"))));


//UblProducer producer = new UblProducer()
//{
//    UBLVersionID = "2.1",
//    CustomizationID = "TR1.2.1",
//    CopyIndicator = false,
//    ProfileID = "EARSIVBELGE",
//    ID = "EMM",
//    UUID = Guid.NewGuid().ToString().ToLower(),
//    IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
//    IssueTime = DateTime.Now.ToString("HH:mm:ss"),
//    CreditNoteTypeCode = "MUSTAHSILMAKBUZ",
//    Notes = new List<string>(),
//    DocumentCurrencyCode = new DocumentCurrencyCode()
//    {
//        Name = "TRY"
//    },
//    LineCountNumeric = 1,
//    AdditionalDocumentReferences = new List<DocumentReference>()
//    {
//        new DocumentReference()
//        {
//            Attachment = new Attachment()
//            {
//                EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObject()
//                {
//                    CharacterSetCode = "UTF-8",
//                    EncodingCode = "Base64",
//                    Filename = "fe917cea-0461-4a1e-b301-6d9e1ad0b7e0.xslt",
//                    MimeCode = "application/xml",
//                    Name=template
//                }
//            },
//            DocumentType = "XSLT",
//            ID = new IDType()
//            {
//                Id = "fe917cea-0461-4a1e-b301-6d9e1ad0b7e0"
//            },
//            IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
//            DocumentDescription = "E-MM stil dosyası."

//        }
//    },
//    AccountingSupplierParty = new SupplierParty()
//    {
//        Party = new Party()
//        {
//            WebSiteURI = "www.nilvera.com",
//            PartyIdentification = new List<PartyIdentification>()
//                        {
//                            new PartyIdentification() { ID = new IDType() { Id = "6310540565", SchemeId = "VKN" } },
//                            new PartyIdentification() { ID = new IDType() { Id = "1122334455667788", SchemeId = "MERSISNO" } },
//                            new PartyIdentification() { ID = new IDType() { Id = "12345", SchemeId = "TICARETSICILNO" } },
//                        },
//            PartyName = new PartyName() { Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ" },
//            PostalAddress = new Address()
//            {
//                StreetName = "Yıldırım Beyazıt Mah. Aşıkveysel Bulv. Erciyes Teknopark 3",
//                CitySubdivisionName = "Melikgazi",
//                CityName = "Kayseri",
//                PostalZone = "34704",
//                Country = new Country() { Name = "Türkiye" }
//            },
//            PartyTaxScheme = new PartyTaxScheme()
//            {
//                TaxScheme = new TaxScheme()
//                {
//                    Name = "ERCİYES"
//                }
//            },
//            Contact = new Contact()
//            {
//                Telephone = "08502514010",
//                ElectronicMail = "info@nilvera.com"
//            },
//        },
//    },
//    AccountingCustomerParty = new CustomerParty()
//    {
//        Party = new Party()
//        {
//            Person = new Person()
//            {
//                FirstName = "FEVZİ FURKAN",
//                FamilyName = "TATLISU"
//            },
//            WebSiteURI = "www.furkantatlisu.com",
//            AgentParty = null,
//            PartyIdentification = new List<PartyIdentification>()
//                        {
//                            new PartyIdentification() {ID = new IDType(){ Id="34918613960",SchemeId="TCKN"}},
//                        },
//            PostalAddress = new Address()
//            {
//                StreetName = "Mimarsinan Şirintepe Mah. Malazgirt Bulvarı 75.Yıl Sitesi Apt.",
//                CitySubdivisionName = "Melikgazi",
//                CityName = "Kayseri",
//                PostalZone = "38100",
//                Country = new Country() { Name = "Türkiye" }
//            },
//            PartyTaxScheme = new PartyTaxScheme()
//            {
//                TaxScheme = new TaxScheme()
//                {
//                    Name = "ERCİYES"
//                }
//            },
//            Contact = new Contact()
//            {
//                Telefax = "03523489208",
//                Telephone = "05647865432"
//            },
//        }
//    },
//    Delivery = new List<Delivery>()
//    {
//        new Delivery()
//        {
//            ActualDeliveryDate = DateTime.Now.ToString("yyyy-MM-dd"),
//        }
//    },
//    PricingExchangeRate = new ExchangeRate()
//    {
//        SourceCurrencyCode = "TRY",
//        TargetCurrencyCode = "TRY",
//        CalculationRate = 19.5
//    },
//    TaxTotals = new List<TaxTotal>()
//    {
//        new TaxTotal()
//        {
//            TaxAmount = new BaseCurrency()
//            {
//                CurrencyID = "TRY",
//                Value = 10m
//            },
//            TaxSubtotals = new List<TaxSubtotal>()
//            {
//                new TaxSubtotal()
//                {
//                    CalculationSequenceNumeric = 1,
//                    Percent = 1.6m,
//                    TaxAmount = new BaseCurrency()
//                    {
//                        CurrencyID = "TRY",
//                        Value = 10m
//                    },
//                    TaxCategory = new TaxCategory()
//                    {
//                        TaxScheme = new TaxScheme()
//                        {
//                            TaxTypeCode = "0003",
//                            Name = "GV. Stpj."
//                        }
//                    },
//                    TaxableAmount = new BaseCurrency()
//                    {
//                        CurrencyID ="TRY",
//                        Value = 600m
//                    }
//                }
//            }
//        }
//    },
//    LegalMonetaryTotal = new MonetaryTotal()
//    {
//        LineExtensionAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 600m },
//        TaxExclusiveAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 600m },
//        TaxInclusiveAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 600m },
//        PayableAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 590.00m },
//    },
//    CreditNoteLine = new List<CreditNoteLine>()
//    {
//        new CreditNoteLine()
//        {
//            ID=new IDType(){Id="1"},
//            CreditedQuantity = new BaseUnit()
//            {
//                UnitCode = "B32",
//                Value = 60
//            },
//            LineExtensionAmount = new BaseCurrency()
//            {
//                CurrencyID="TRY",
//                Value=600m
//            },
//            TaxTotal = new TaxTotal()
//            {
//                TaxAmount = new BaseCurrency()
//                {
//                    CurrencyID = "TRY",
//                    Value = 10.00m
//                },
//                TaxSubtotals = new List<TaxSubtotal>()
//                {
//                     new TaxSubtotal()
//                    {
//                        TaxableAmount = new BaseCurrency()
//                        {
//                            CurrencyID = "TRY",
//                            Value = 600m
//                        },
//                        TaxAmount = new BaseCurrency()
//                        {
//                            CurrencyID = "TRY",
//                            Value = 10m
//                        },
//                        CalculationSequenceNumeric = 1,
//                        Percent = 1.6666666666666667m,
//                        TaxCategory = new TaxCategory()
//                        {
//                            TaxScheme = new TaxScheme()
//                            {
//                                Name = "GV. Stpj.",
//                                TaxTypeCode = "0003"
//                            }
//                        }
//                    }
//                }
//            },
//            Item =new Item(){Name="Biber",},
//            Price = new Price()
//            {
//                PriceAmount = new BaseCurrency()
//                {
//                    CurrencyID = "TRY",
//                    Value = 10m
//                }
//            }
//        },
//         new CreditNoteLine()
//        {
//            ID=new IDType(){Id="2"},
//            CreditedQuantity = new BaseUnit()
//            {
//                UnitCode = "B32",
//                Value = 60
//            },
//            LineExtensionAmount = new BaseCurrency()
//            {
//                CurrencyID="TRY",
//                Value=600m
//            },
//            TaxTotal = new TaxTotal()
//            {
//                TaxAmount = new BaseCurrency()
//                {
//                    CurrencyID = "TRY",
//                    Value = 10.00m
//                },
//                TaxSubtotals = new List<TaxSubtotal>()
//                {
//                     new TaxSubtotal()
//                    {
//                        TaxableAmount = new BaseCurrency()
//                        {
//                            CurrencyID = "TRY",
//                            Value = 600m
//                        },
//                        TaxAmount = new BaseCurrency()
//                        {
//                            CurrencyID = "TRY",
//                            Value = 10m
//                        },
//                        CalculationSequenceNumeric = 1,
//                        Percent = 1.6666666666666667m,
//                        TaxCategory = new TaxCategory()
//                        {
//                            TaxScheme = new TaxScheme()
//                            {
//                                Name = "GV. Stpj.",
//                                TaxTypeCode = "0003"
//                            }
//                        }
//                    },
//                     new TaxSubtotal()
//                     {
//                         TaxableAmount = new BaseCurrency()
//                         {
//                             CurrencyID = "TRY",
//                             Value = 100m
//                         },
//                         TaxAmount = new BaseCurrency()
//                         {
//                             CurrencyID = "TRY",
//                             Value = 150m
//                         },
//                         CalculationSequenceNumeric = 2,
//                         Percent = 15m,
//                         TaxCategory = new TaxCategory()
//                         {
//                             TaxScheme = new TaxScheme()
//                             {
//                                 Name = "Mera Fonu",
//                                 TaxTypeCode = "9040"
//                             }
//                         }
//                     }
//                }
//            },
//            Item =new Item(){Name="Biber",},
//            Price = new Price()
//            {
//                PriceAmount = new BaseCurrency()
//                {
//                    CurrencyID = "TRY",
//                    Value = 10m
//                }
//            }
//        }

//    }
//};

//UblInvoiceSerializer ublInvoiceSerializer = new UblInvoiceSerializer();
//UblProducerSerializer ublProducerSerializer = new UblProducerSerializer();
//string content = await ublInvoiceSerializer.SerializeAsync(producer, ublProducerSerializer.xmlns);

//var newcontent = ublInvoiceSerializer.CleanXmlContent(content);

//Console.WriteLine("Xml oluşturuldu. Dosya yolu : " + ublInvoiceSerializer.LoadOrCreateXML(newcontent));
//Console.ReadLine();


#endregion

#endregion


#region Serbest Meslek Makbuzu

#region Serbest meslek makbuzu Model olarak gönderir
//VoucherModel voucherModel = new VoucherModel()
//{
//    Voucher = new VoucherDto()
//    {
//        VoucherInfo = new VoucherInfoDto()
//        {
//            UUID = Guid.Parse(Guid.NewGuid().ToString().ToLower()),
//            TemplateUUID = Guid.Parse("4de2fa46-4612-46cd-88be-5d7258614616"),
//            VoucherSerieOrNumber = "SMM",
//            IssueDate = DateTime.Now,
//            CurrencyCode = "TRY",
//            ExchangeRate = 1,
//            SendType = SendType.ELEKTRONIK
//        },
//        CompanyInfo = new PartyInfoDto()
//        {
//            Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ",
//            TaxNumber = "6310540565",
//            TaxOffice = "Gevher Nesibe",
//            PartyIdentifications = new List<IDTypeDto>()
//            {
//                new IDTypeDto()
//                {
//                    SchemeID = "MERSISNO",
//                    Value="1122334455667788"
//                },
//                new IDTypeDto()
//                {
//                    SchemeID = "TICARETSICILNO",
//                    Value = "12345"
//                }
//            },
//            Address = "Yıldırım Beyazıt Mah. Aşıkveysel Bulvarı Erciyes Teknopark Binası 3",
//            District = "Melikgazi",
//            City = "Kayseri",
//            Country = "TÜRKİYE",
//            PostalCode = "38100",
//            Phone = "02166885100",
//            Fax = "0216 688 51 99",
//            Mail = "destek@nilvera.com",
//            WebSite = "www.nilvera.com"
//        },
//        CustomerInfo = new PartyInfoDto()
//        {
//            TaxNumber = "34918613960",
//            Name = "Feride Çolak",
//            TaxOffice = "Melikgazi Vergi Dairesi",
//            AgentPartyIdentifications = null,
//            PartyIdentifications = new List<IDTypeDto>(),
//            Address = "Teknopark 3",
//            District = "Melikgazi",
//            City = "Kayseri",
//            Country = "Türkiye",
//            PostalCode = "38050",
//            Phone = "05342354657",
//            Fax = "05342354657",
//            Mail = "deneme@gmail.com",
//            WebSite = "www.deneme.com",
//        },
//        VoucherLines = new List<EVoucherLineDto>()
//        {
//            new EVoucherLineDto
//            {
//                Name = "hizmet1",
//                GrossWage = 2840.91m,
//                Price = 0M,
//                GVWithholdingPercent = 20m,
//                KDVPercent = 8m,
//                Taxes = new List<TaxDto>()
//                {
//                    new TaxDto()
//                    {
//                        Percent = 20M,
//                        Total = 0m,
//                        ReasonCode = "616",
//                        TaxCode = "9015"
//                    }
//                }
//            }
//        },
//        Notes = new List<string>()
//        {
//            "deneme",
//            "notu"
//        }
//    }
//};

//var client = new RestClient();
//var request = new RestRequest("https://apitest.nilvera.com/esmm/Send/Model", Method.Post);
//request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");
//request.AddJsonBody(voucherModel);
//request.AddHeader("Content-Type", "application/json");
//request.AddHeader("Accept", "application/json");
//var response = await client.ExecuteAsync(request);
//Console.WriteLine(response.Content);
//Console.ReadLine();
#endregion


#region Serbest meslek makbuzu Xml olarak gönderir
//var client = new RestClient();
//var request = new RestRequest("https://apitest.nilvera.com/esmm/Send/Xml?Alias=urn:mail:defaultpk@nilvera.com", Method.Post);
//request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");     //Portaldan aldığınız API KEY giriniz.
//request.AddHeader("Content-Type", "multipart/form-data");
//request.AddFile("file", "C:\\Users\\Tunahan\\Downloads\\Fatura.xml", "application/xml");   // "/path/to/file" XML'in path giriniz.
//var response = await client.ExecuteAsync(request);
//Console.WriteLine(response.Content);
//Console.ReadLine();
#endregion


#region Serbest meslek makbuzu Ubl Modelini Xml'e çevirme 

//string basePath = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net6.0", "BaseXslt\\Voucher");
//string filePath = Path.Combine(basePath + "4de2fa46-4612-46cd-88be-5d7258614616.xslt");

//if (!File.Exists(filePath))
//{
//    if (!Directory.Exists(basePath))
//        Directory.CreateDirectory(basePath);
//}

//var readTemplate = File.ReadAllText(filePath);

//var template = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(readTemplate));

//UblVoucher voucher = new UblVoucher()
//{
//    UBLVersionID = "2.1",
//    CustomizationID = "TR1.2",
//    CopyIndicator = false,
//    ProfileID = "EARSIVBELGE",
//    ID = "SMM",
//    UUID = Guid.NewGuid().ToString().ToLower(),
//    IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
//    IssueTime = DateTime.Now.ToString("HH:mm:ss"),
//    CreditNoteTypeCode = "SERBESTMESLEKMAKBUZU",
//    Notes = new List<string>()
//    {
//        "deneme",
//        "notu"
//    },
//    DocumentCurrencyCode = new DocumentCurrencyCode()
//    {
//        Name = "TRY"
//    },
//    LineCountNumeric = 1,
//    AdditionalDocumentReferences = new List<DocumentReference>()
//    {
//        new DocumentReference
//        {
//            ID = new IDType(){Id = "ELEKTRONIK"},
//            IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
//            DocumentTypeCode ="SEND_TYPE"
//        },
//        new DocumentReference()
//        {
//            DocumentType = "XSLT",
//            DocumentDescription = "E-SMM stil dosyası.",
//            ID = new IDType() { Id = "4de2fa46-4612-46cd-88be-5d7258614616" },
//            IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
//            Attachment = new Attachment()
//            {
//                EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObject()
//                {
//                    CharacterSetCode = "UTF-8",
//                    EncodingCode = "Base64",
//                    Filename = "4de2fa46-4612-46cd-88be-5d7258614616.xslt",
//                    MimeCode = "application/xml",
//                    Name = template
//                }
//            }
//        }
//    },
//    AccountingSupplierParty = new SupplierParty()
//    {
//        Party = new Party()
//        {
//            WebSiteURI = "www.nilvera.com",
//            PartyIdentification = new List<PartyIdentification>()
//                        {
//                            new PartyIdentification() { ID = new IDType() { Id = "6310540565", SchemeId = "VKN" } },
//                            new PartyIdentification() { ID = new IDType() { Id = "1122334455667788", SchemeId = "MERSISNO" } },
//                            new PartyIdentification() { ID = new IDType() { Id = "12345", SchemeId = "TICARETSICILNO" } },
//                        },
//            PartyName = new PartyName() { Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ" },
//            PostalAddress = new Address()
//            {
//                StreetName = "Yıldırım Beyazıt Mah. Aşıkveysel Bulv. Erciyes Teknopark 3",
//                CitySubdivisionName = "Melikgazi",
//                CityName = "Kayseri",
//                PostalZone = "34704",
//                Country = new Country() { Name = "Türkiye" }
//            },
//            PartyTaxScheme = new PartyTaxScheme()
//            {
//                TaxScheme = new TaxScheme()
//                {
//                    Name = "ERCİYES"
//                }
//            },
//            Contact = new Contact()
//            {
//                Telephone = "08502514010",
//                ElectronicMail = "info@nilvera.com"
//            },
//        },
//    },
//    AccountingCustomerParty = new CustomerParty()
//    {
//        Party = new Party()
//        {
//            Person = new Person()
//            {
//                FirstName = "Feride",
//                FamilyName = "Çolak"
//            },
//            WebSiteURI = "www.deneme.com",
//            AgentParty = null,
//            PartyIdentification = new List<PartyIdentification>()
//                        {
//                            new PartyIdentification() {ID = new IDType(){ Id="12345678902",SchemeId="TCKN"}},
//                        },
//            PostalAddress = new Address()
//            {
//                StreetName = "Yıldırım Beyazıt Mah.",
//                CitySubdivisionName = "Melikgazi",
//                CityName = "Kayseri",
//                PostalZone = "38050",

//                Country = new Country() { Name = "Türkiye" }
//            },
//            PartyTaxScheme = new PartyTaxScheme()
//            {
//                TaxScheme = new TaxScheme()
//                {
//                    Name = "Melikgazi Vergi Dairesi"
//                }
//            },
//            Contact = new Contact()
//            {
//                Telefax = "05342354657",
//                Telephone = "05342354657"
//            },
//        }
//    },
//    TaxTotals = new List<TaxTotal>() { new TaxTotal {
//    TaxAmount = new BaseCurrency()
//    {
//        Value = 3.68m
//    },
//    TaxSubtotals = new List<TaxSubtotal>()
//    {
//        new TaxSubtotal()
//        {
//            CalculationSequenceNumeric = 1,
//            Percent = 20m,
//            TaxAmount = new BaseCurrency()
//            {
//                CurrencyID = "TRY",
//                Value = 0m
//            },
//            TaxCategory = new TaxCategory()
//            {
//                TaxScheme = new TaxScheme()
//                {
//                    TaxTypeCode = "0003",
//                    Name = "GV. Stpj."
//                }
//            },
//            TaxableAmount = new BaseCurrency()
//            {
//                CurrencyID ="TRY",
//                Value = 46m
//            }
//        },
//        new TaxSubtotal()
//        {
//             CalculationSequenceNumeric = 2,
//            TaxableAmount = new BaseCurrency()
//            {
//                CurrencyID = "TRY",
//                Value = 3.68m
//            },
//            TaxAmount = new BaseCurrency()
//            {
//                CurrencyID = "TRY",
//                Value = 46m
//            },
//            Percent = 8m,
//            TaxCategory = new TaxCategory()
//            {
//                TaxScheme = new TaxScheme()
//                {
//                    Name = "KDV",
//                    TaxTypeCode = "0015"
//                }
//            }
//        },
//    }
//    } },
//    WithholdingAllowance = new WithholdingAllowance()
//    {
//        WithholdableAmount = new BaseCurrency()
//        {
//            CurrencyID = "TRY",
//            Value = 3.68m
//        },
//        WithholdingAmount = new BaseCurrency()
//        {
//            CurrencyID = "TRY",
//            Value = 0m
//        }
//    },
//    LegalMonetaryTotal = new MonetaryTotal()
//    {
//        LineExtensionAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 46m },
//        TaxExclusiveAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 46m },
//        TaxInclusiveAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 46m },
//        PayableAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 49.68m },
//    },
//    VoucherLine = new List<VoucherLine>()
//    {
//        new VoucherLine()
//        {
//            ID = new IDType(){ Id = "1"},
//            LineExtensionAmount= new BaseCurrency(){ CurrencyID="TRY", Value = 49.68m},
//            GrossWage = new GrossWage()
//            {
//                GrossWageAmount = new BaseCurrency()
//                {
//                    CurrencyID = "TRY",
//                    Value = 46m
//                }

//            },
//            Price = new Price()
//            {
//               PriceAmount = new BaseCurrency()
//               {
//                    CurrencyID = "TRY",
//                    Value =  46m
//               }
//            },
//            TaxTotal = new TaxTotal()
//            {
//                TaxAmount = new BaseCurrency()
//                {
//                    CurrencyID = "TRY",
//                    Value = 3.68m
//                },
//                TaxSubtotals = new List<TaxSubtotal>()
//                {

//                     new TaxSubtotal()
//                     {
//                          CalculationSequenceNumeric = 1,
//                         TaxableAmount = new BaseCurrency()
//                         {
//                             CurrencyID = "TRY",
//                             Value = 46m
//                         },
//                         TaxAmount = new BaseCurrency()
//                         {
//                             CurrencyID = "TRY",
//                             Value = 0m
//                         },
//                         Percent = 0m,
//                         TaxCategory = new TaxCategory()
//                         {
//                             TaxScheme = new TaxScheme()
//                             {
//                                 Name = "GV. Stpj.",
//                                 TaxTypeCode = "0003"
//                             }
//                         }
//                     },
//                     new TaxSubtotal()
//                     {
//                          CalculationSequenceNumeric = 2,
//                         TaxableAmount = new BaseCurrency()
//                         {
//                             CurrencyID = "TRY",
//                             Value = 46m
//                         },
//                         TaxAmount = new BaseCurrency()
//                         {
//                             CurrencyID = "TRY",
//                             Value = 3.68m
//                         },
//                         Percent = 8m,
//                         TaxCategory = new TaxCategory()
//                         {
//                             TaxScheme = new TaxScheme()
//                             {
//                                 Name = "KDV",
//                                 TaxTypeCode = "0015"
//                             }
//                         }
//                     }
//                },
//            },
//            Item = new Item()
//            {
//                Name = "hizmet"
//            }
//        }
//    }
//};

//UblInvoiceSerializer ublInvoiceSerializer = new UblInvoiceSerializer();
//UblVoucherSerializer ublVoucherSerializer = new UblVoucherSerializer();

//string content = await ublInvoiceSerializer.SerializeAsync(voucher, ublVoucherSerializer.xmlns);
//var newContent = ublInvoiceSerializer.CleanXmlContent(content);
//Console.WriteLine("Xml oluşturuldu. Dosya yolu : " + ublInvoiceSerializer.LoadOrCreateXML(newContent));
//Console.ReadLine();
#endregion

#endregion


