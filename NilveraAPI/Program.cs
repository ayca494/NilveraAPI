// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using NilveraAPI;
using NilveraAPI.Models;
using NilveraAPI.Models.Dto;
using RestSharp;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

EInvoiceModel eInvoiceModel = new EInvoiceModel()
{
    EInvoice = new EInvoiceDto()
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
            Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ",
            TaxNumber = "6310540565",
            TaxOffice = "kayseri vergi dairesi",
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
            Address = "Yıldırım Beyazıt Mah. Aşıkveysel Bulvarı Erciyes Teknopark Binası 3",
            District = "Talas",
            City = "Kayseri",
            Country = "TÜRKİYE",
            PostalCode = "38000",
            Phone = "08502514010",
            Fax = "",
            Mail = "destek@nilvera.com",
            WebSite = "https://nilvera.com/"
        },
        InvoiceInfo = new NilveraAPI.Models.Dto.Shared.InvoiceInfoDto()
        {
            UUID = Guid.Parse("3247a513-066c-493e-b817-c33e6a7ab04b"),
            TemplateUUID = Guid.Parse("4e482e2c-da6b-4c4b-b834-4dd444915c78"),
            InvoiceProfile = NilveraAPI.Enums.InvoiceProfile.TEMELFATURA,
            InvoiceType = NilveraAPI.Enums.InvoiceType.SATIS,
            InvoiceSerieOrNumber = "BPU",
            IssueDate = DateTime.Parse("2023-01-11T17:08:37.452Z"),
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
                        Name = "Kalem",
                        Description = "",
                        Quantity = 1,
                        UnitType = "C62",
                        Price = 500,
                        AllowanceTotal = 0M,
                        KDVPercent = 18M,
                        KDVTotal = 0M,
                        Taxes = new List<NilveraAPI.Models.Dto.Shared.TaxDto>()
                        {
                            new NilveraAPI.Models.Dto.Shared.TaxDto()
                            {
                                Percent = 0,
                                Total = 0,
                                TaxCode = ""
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
    },
    CustomerAlias = "urn:mail:defaultpk@nilvera.com"
};

var client = new RestClient();
var request = new RestRequest("https://apitest.nilvera.com/einvoice/Send/Model", Method.Post);
request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");
request.AddJsonBody(eInvoiceModel);
request.AddHeader("Content-Type", "application/json");
request.AddHeader("Accept", "application/json");
var response = await client.ExecuteAsync(request);
Console.WriteLine(response.Content);
Console.ReadLine();





//var client = new RestClient();
//var request = new RestRequest("https://apitest.nilvera.com/einvoice/Send/Xml?Alias=<alicipostakutusuetiketi>", Method.Post); 
//request.AddHeader("Authorization", "Bearer <API Key>");     //Portaldan aldığınız API KEY giriniz.
//request.AddHeader("Content-Type", "multipart/form-data");
//request.AddFile("file", "/path/to/file", "application/xml");   // "/path/to/file" XML'in path giriniz.
//var response = await client.ExecuteAsync(request);
//Console.WriteLine(response.Content);
//Console.ReadLine();




