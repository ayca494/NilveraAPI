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
//        {
//                        new NilveraAPI.Models.Dto.Shared.IDTypeDto()
//                        {
//                            SchemeID = "TICARETSICILNO",
//                            Value = "213123"
//                        }
//                    },
//            AgentPartyIdentifications = new List<NilveraAPI.Models.Dto.Shared.IDTypeDto>()
//        {
//                        new NilveraAPI.Models.Dto.Shared.IDTypeDto()
//                        {
//                            SchemeID = "DISTRIBUTORNO",
//                            Value = "2112"
//                        }
//                    },
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
//            UUID = Guid.Parse("3247a513-066c-493e-b817-c33e6a7ab03b"),
//            TemplateUUID = Guid.Parse("4e482e2c-da6b-4c4b-b834-4dd444915c78"),
//            InvoiceProfile = NilveraAPI.Enums.InvoiceProfile.TEMELFATURA,
//            InvoiceType = NilveraAPI.Enums.InvoiceType.SATIS,
//            InvoiceSerieOrNumber = "BPU",
//            IssueDate = DateTime.Parse("2023-01-11T17:08:37.452Z"),
//            CurrencyCode = "TRY",
//            ExchangeRate = null,
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
//    {
//                    new NilveraAPI.Models.Dto.Shared.EInvoiceLineDto(){
//                        SellerCode = "",
//                        BuyerCode = "",
//                        Name = "Kalem",
//                        Description = "",
//                        Quantity = 1,
//                        UnitType = "C62",
//                        Price = 500,
//                        AllowanceTotal = 0M,
//                        KDVPercent = 18M,
//                        KDVTotal = 0M,
//                        Taxes = new List<NilveraAPI.Models.Dto.Shared.TaxDto>()
//                        {
//                            new NilveraAPI.Models.Dto.Shared.TaxDto()
//                            {
//                                Percent = 0,
//                                Total = 0,
//                                TaxCode = ""
//                            }
//                        },
//                        ManufacturerCode = "",
//                        BrandName = "",
//                        ModelName = "",
//                        Note = "",
//                        OzelMatrahReason = null,
//                        OzelMatrahTotal = null,
//                        AdditionalItemIdentification = new NilveraAPI.Models.Dto.Shared.AdditionalItemIdentificationDto()
//                    },
//                },
//        Notes = new List<string>()
//                {
//                    "Bu",
//                    "bir",
//                    "denemedir.",
//                    "notlar"
//                }
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


#region Faturayı XML olarak gönderir.
//var client = new RestClient();
//var request = new RestRequest("https://apitest.nilvera.com/einvoice/Send/Xml?Alias=<alicipostakutusuetiketi>", Method.Post);
//request.AddHeader("Authorization", "Bearer <API Key>");     //Portaldan aldığınız API KEY giriniz.
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
//            UUID = Guid.Parse("2fa85f64-5717-4562-b3fc-2c963f66afa6"),
//            TemplateUUID = Guid.Parse("72813487-e592-4758-87da-be08ed199197"),
//            InvoiceType = NilveraAPI.Enums.InvoiceType.SATIS,
//            InvoiceSerieOrNumber = "NIL",
//            IssueDate = DateTime.Parse("2023-01-12T12:16:07.732Z"),
//            CurrencyCode = "TRY",
//            ExchangeRate = 1,
//            Expenses = new List<ExpensesDto>()
//                        {
//                            new ExpensesDto()
//                            {
//                                Amount = 12,
//                                ExpenseType = NilveraAPI.Enums.ExpenseType.HKSKOMISYON
//                            }
//                        },
//            SendType= SendType.KAGIT,
//            SalesPlatform=SalesPlatform.NORMAL
//        },
//        InvoiceLines = new List<EArchiveInvoiceLineDto>()
//                    {
//                        new EArchiveInvoiceLineDto()
//                        {
//                            Name = "Deneme",
//                            Price = 12,
//                            Quantity = 125,
//                            UnitType = "C62",
//                            AllowanceTotal = 195,
//                            KDVPercent = 18,
//                            AdditionalItemIdentification = new AdditionalItemIdentificationDto()
//                            {
//                                TagNumber = "1231231231231231231",
//                                OwnerName = "deneme",
//                                OwnerTaxNumber = "22040521512"
//                            }
//                        }
//                    }
//    }
//};

//ArchiveInvoiceModel archiveInvoiceDto = new()
//{
//    ArchiveInvoice = new ArchiveInvoiceDto()
//    {
//        CompanyInfo = new PartyInfoDto()
//        {
//            Address = "",
//            City = "",
//            Country = "",
//            District = "",
//            Fax = "",
//            Name = "         dasda dasdada      ",
//            PartyIdentifications = new List<IDTypeDto>(),
//            Phone = "",
//            PostalCode = "",
//            TaxNumber = "1234567890",
//            TaxOffice = "",
//            WebSite = ""
//        },
//        CustomerInfo = new PartyInfoDto()
//        {
//            Address = "",
//            City = "",
//            Country = "",
//            District = "",
//            Fax = "",
//            Name = "         dasda dasdada      ",
//            PartyIdentifications = new List<IDTypeDto>(),
//            Phone = "",
//            PostalCode = "",
//            TaxNumber = "1234567890",
//            TaxOffice = "",
//            WebSite = ""
//        },
//        InvoiceInfo = new ArchiveInvoiceInfoDto()
//        {
//            TaxExemptionReasonInfo = new TaxExemptionReasonInfoDto(),
//            InvoiceType = NilveraAPI.Enums.InvoiceType.HKSSATIS,
//            CurrencyCode = "TRY",
//            Expenses = new List<ExpensesDto>()
//                    {
//                        new ExpensesDto()
//                        {
//                            Amount = 12,
//                            ExpenseType = NilveraAPI.Enums.ExpenseType.HKSKOMISYON
//                        }
//                    }
//        },
//        InvoiceLines = new List<EArchiveInvoiceLineDto>()
//                {
//                    new EArchiveInvoiceLineDto()
//                    {
//                        Name = "Deneme",
//                        Price = 12,
//                        Quantity = 125,
//                        UnitType = "C62",
//                        AllowanceTotal = 195,
//                        KDVPercent = 18,
//                        AdditionalItemIdentification = new AdditionalItemIdentificationDto()
//                        {
//                            TagNumber = "1231231231231231231",
//                            OwnerName = "deneme",
//                            OwnerTaxNumber = "22040521512"
//                        },
//                    }
//                },
//        Notes = new List<string>()
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
var client = new RestClient();
var request = new RestRequest("https://apitest.nilvera.com/earchive/Send/Xml?Alias=urn:mail:defaultpk@nilvera.com", Method.Post);
request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");     //Portaldan aldığınız API KEY giriniz.
request.AddHeader("Content-Type", "multipart/form-data");
request.AddFile("file", "C:\\Users\\Tunahan\\Downloads\\MOHAMMAD ALAJATI-NIL.xml", "application/xml");   // "/path/to/file" XML'in path giriniz.
var response = await client.ExecuteAsync(request);
Console.WriteLine(response.Content);
Console.ReadLine();
#endregion


