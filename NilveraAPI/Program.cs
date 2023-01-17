// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NilveraAPI;
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
//string basePath = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net6.0", "BaseXslt");
//string filePath = Path.Combine(basePath + "ca747ee5-9c0d-4410-9378-02bc4a5e31fa.xslt");

//if (!File.Exists(filePath))
//{
//    if (!Directory.Exists(basePath))
//        Directory.CreateDirectory(basePath);
//}
//var templateBytes = File.ReadAllText(filePath);

//var template = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(templateBytes.Substring(templateBytes.IndexOf("<"))));


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
//var templateBytes = File.ReadAllText(filePath);

//var template = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(templateBytes.Substring(templateBytes.IndexOf("<"))));


//UblInvoice ublEArchiveInvoice = new UblInvoice()
//{
//    ID = "NIL",
//    InvoiceTypeCode = "SATIS",
//    IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
//    IssueTime = DateTime.Now.ToString("HH:mm:ss"),
//    //IssueTime = "10:20:10",
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
//request.AddFile("file", "C:\\Users\\Tunahan\\source\\repos\\NilveraAPI\\NilveraAPI\\bin\\Debug\\net6.0\\XML\\Fatura.xml", "application/xml");   // "/path/to/file" XML'in path giriniz.
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
//var templateBytes = File.ReadAllText(filePath);

//var template = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(templateBytes.Substring(templateBytes.IndexOf("<"))));

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


