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
using NilveraAPI.Models.Pagination;
using NilveraAPI.Models.Pagination.EInvoiceModel;
using NilveraAPI.Models.CheckGlobalCompany;
using NilveraAPI.Request.E_Invocie;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using NilveraAPI.Request.E_Archive;
using NilveraAPI.Request.E_Despatch;
using NilveraAPI.Models.Response;
using NilveraAPI.Request.E_Producer;



//TC veya VKN kontrol edilerek E-Fatura ve E-İrsaliye Mükellefi olup olmadığını belirtir. 
#region Mükellef Sorgulama

//string TaxNumber = "57223294532";
//RestClient client = new RestClient();
//var request = new RestRequest($"https://apitest.nilvera.com/general/GlobalCompany/Check/TaxNumber/{TaxNumber}", Method.Get);
//request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");
//request.AddQueryParameter("globalUserType", GlobalUserType.Invoice); //E-İrsaliye kontrolü için GlobalUserType.DespatchAdvice olmalıdır.
//var response = await client.ExecuteAsync<IEnumerable<GlobalCompanyInfoResponse>>(request);
//var generalResponse = response.Parse();

//if (generalResponse.Content.Any())
//{
//    foreach (var item in generalResponse.Content)
//    {
//        Console.WriteLine($"{item.FirstCreatedTime} Tarihinden İtibaren Mükellef.");
//        Console.WriteLine($"Ünvan : {item.Title}");
//        Console.WriteLine($"Etiket : {item.Name}");
//        Console.WriteLine($"Tipi : {item.Type}");
//        Console.WriteLine($"Etiket Oluşturulma Tarihi : {item.CreationTime}");
//        Console.WriteLine("******************************************************");
//    }
//}
//else
//{
//    Console.WriteLine("Mükellef Değil");
//}
//Console.ReadLine();

#endregion

//E-Fatura Mükellefi ise yukarıda dönen etiketi kullanarak E-Fatura gönderilir.
#region E-Fatura

//#region Fatura model olarak gönderir.

//EInvoiceApi eInvoice = new EInvoiceApi();
//InvoiceResponse responseEInvoice = await eInvoice.SendModel();
//Console.WriteLine($"UUID: {responseEInvoice.UUID},\nFatura Numarası: {responseEInvoice.InvoiceNumber}");

//#endregion

//#region E-Faturanın Ubl Modelini Xml'e çevirme 

//var eInvoicePath = await eInvoice.UblConvertXml();
//Console.WriteLine("\nXml oluşturuldu. Dosya yolu: " + eInvoicePath);

//#endregion

//#region E-Fatura Xml olarak gönderir
//responseEInvoice = await eInvoice.SendXml();
//Console.WriteLine($"\nUUID: {responseEInvoice.UUID},\nFatura Numarası: {responseEInvoice.InvoiceNumber}");
//Console.ReadLine();
//#endregion
#endregion

//E-Fatura Mükellefi değilse e-arşiv gönderilir.
#region E-Arşiv

//#region E-Arşiv Model olarak gönderir.
//EArchiveApi eArchive = new EArchiveApi();
//InvoiceResponse responseEArchive = await eArchive.SendModel();
//Console.WriteLine($"UUID: {responseEArchive.UUID},\nFatura Numarası: {responseEArchive.InvoiceNumber}");
//#endregion


//#region E-Arşivin Ubl Modelini XML'e çevirme
//var eArchivePath = await eArchive.UblConvertXml();
//Console.WriteLine("\nXml oluşturuldu. Dosya yolu: " + eArchivePath);
//#endregion


//#region E-Arşiv Xml olarak gönderir
//responseEArchive = await eArchive.SendXml();
//Console.WriteLine($"UUID: {responseEArchive.UUID},\nFatura Numarası: {responseEArchive.InvoiceNumber}");
//Console.ReadLine();
//#endregion

#endregion


#region İrsaliye


//#region İrsaliyeyi Model olarak gönderir.
//EDespatchApi despatchApi = new EDespatchApi();
//DespatchResponse despatchResponse = await despatchApi.SendModel();
//Console.WriteLine($"UUID: {despatchResponse.UUID}, \nDespatch Number: {despatchResponse.DespatchNumber}");
//#endregion


//#region İrsaliye Ubl Modelini Xml'e Çevirme


//var despatchPath = await despatchApi.UblConvertXml();
//Console.WriteLine("\nXml oluşturuldu. Dosya yolu : " + despatchPath);
//#endregion


//#region İrsaliyeyi Xml olarak gönderir
//despatchResponse = await despatchApi.SendXml();
//Console.WriteLine($"UUID: {despatchResponse.UUID}, \nDespatch Number: {despatchResponse.DespatchNumber}");
//Console.ReadLine();
//#endregion

#endregion


#region Müstahsil

#region Müstahsil Model olarak gönderir.
EProducerApi producerApi = new EProducerApi();
ProducerResponse producerResponse = await producerApi.SendModel();
Console.WriteLine($"UUID: {producerResponse.UUID}, \nProducer Number: {producerResponse.ProducerNumber}");
#endregion


#region Müstahsil Ubl Modelini Xml'e Çevirme
var producerPath = await producerApi.UblConvertXml();
Console.WriteLine("\nXml oluşturuldu. Dosya yolu : " + producerPath);

#endregion


#region Müstahsil Xml olarak gönderir
producerResponse = await producerApi.SendXml();
Console.WriteLine($"UUID: {producerResponse.UUID}, \nDespatch Number: {producerResponse.ProducerNumber}");
Console.ReadLine();
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

//UblVoucherSerializer ublVoucherSerializer = new UblVoucherSerializer();

//string content = await Serializer.SerializeAsync(voucher, ublVoucherSerializer.xmlns);
//var newContent = Serializer.CleanXmlContent(content);
//Console.WriteLine("Xml oluşturuldu. Dosya yolu : " + Serializer.LoadOrCreateXml(newContent));
//Console.ReadLine();

#endregion


#region Serbest meslek makbuzu Xml olarak gönderir
//string file_path = AppDomain.CurrentDomain.BaseDirectory + "Dosyalar\\XML\\Fatura.xml";
//var client = new RestClient();
//var request = new RestRequest("https://apitest.nilvera.com/esmm/Send/Xml?Alias=urn:mail:defaultpk@nilvera.com", Method.Post);
//request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");     //Portaldan aldığınız API KEY giriniz.
//request.AddHeader("Content-Type", "multipart/form-data");
//request.AddFile("file", file_path, "application/xml");   
//var response = await client.ExecuteAsync(request);
//Console.WriteLine(response.Content);
//Console.ReadLine();
#endregion

#endregion


#region Giden E-Faturalar Listelenir (Pagination)

//var client = new RestClient();
//var request = new RestRequest("https://apitest.nilvera.com/einvoice/Sale", Method.Get);
//request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");
//request.RequestFormat = DataFormat.Json;
//request.AddQueryParameter("Page", 1);
//request.AddQueryParameter("PageSize", 30);
//request.AddQueryParameter("StartDate", DateTime.Now.AddDays(-7).ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));
//request.AddQueryParameter("EndDate", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));
//var response = await client.ExecuteAsync<Pagination<SaleInvoiceResponse>>(request);
//var generalResponse = response.Parse();

//Console.WriteLine("E-Faturalar : ");
//foreach (var item in generalResponse.Content.Content)
//{
//    Console.WriteLine($"UUID : {item.UUID}");
//    Console.WriteLine($"VKN : {item.TaxNumber}");
//    Console.WriteLine($"Fatura Numarası : {item.InvoiceNumber}");
//    Console.WriteLine($"Fatura Tarihi : {item.IssueDate}");
//    Console.WriteLine($"Fatura Tutarı : {item.PayableAmount}");
//    Console.WriteLine("*******************************************");
//}
////Console.WriteLine(response.Content);
//Console.ReadLine();

#endregion


#region E-Fatura Pdf indirir
//string UUID = "5b0a789b-1ec6-4e5a-911f-139c59985429"; //Faturanın UUID'si girilir.
//RestClient client = new RestClient();
//var request = new RestRequest($"https://apitest.nilvera.com/einvoice/Sale/{UUID}/pdf", Method.Get);
//request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");
//var response = await client.ExecuteAsync(request);

//var base64 = JsonConvert.DeserializeObject<string>(response.Content);

//var path = Serializer.LoadOrCreatePdf(base64);

//Console.WriteLine("Faturanın pdf'i oluşmuştur. Dosya yolu : " + path);
//Console.ReadLine();

#endregion


#region E-Fatura html indirir

//string UUID = "5b0a789b-1ec6-4e5a-911f-139c59985429";  //Faturanın UUID'si girilir.
//RestClient client = new RestClient();
//var request = new RestRequest($"https://apitest.nilvera.com/einvoice/Sale/{UUID}/html", Method.Get);
//request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");
//var response = await client.ExecuteAsync(request);

//var html = JsonConvert.DeserializeObject<string>(response.Content);

//var path = Serializer.LoadOrCreateHtml(html);

//Console.WriteLine("Faturanın html'i oluşmuştur. Dosya yolu : " + path);
//Console.ReadLine();

#endregion


#region E-Fatura xml indirir

//string UUID = "5b0a789b-1ec6-4e5a-911f-139c59985429";  //Faturanın UUID'si girilir.
//RestClient client = new RestClient();
//var request = new RestRequest($"https://apitest.nilvera.com/einvoice/Sale/{UUID}/xml", Method.Get);
//request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");
//var response = await client.ExecuteAsync(request);

//var xml = JsonConvert.DeserializeObject<string>(response.Content);

//var path = Serializer.LoadOrCreateXml(xml);

//Console.WriteLine(path);
//Console.ReadLine();

#endregion

