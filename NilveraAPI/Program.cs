// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using NilveraAPI;
using NilveraAPI.Models.Dto;
using RestSharp;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

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




var client = new RestClient();
var request = new RestRequest("https://apitest.nilvera.com/einvoice/Send/Xml?Alias=urn:mail:defaultpk@ayca.com", Method.Post);
request.AddHeader("Authorization", "Bearer 8AB2B31C36CD88AC20F244C3AD5578E9CD31FAB9E07F6B3D42709172B4E54638");
request.AddFile("file", "C:\\Users\\Tunahan\\Downloads\\AYCA.xml", "application/xml");
request.AddHeader("Content-Type", "multipart/form-data");
var response =await client.ExecuteAsync(request);
Console.WriteLine(response.Content);
Console.ReadLine();




//var client = new RestClient();
//var request = new RestRequest("https://apitest.nilvera.com/einvoice/Send/Xml?Alias=<alicipostakutusuetiketi>", Method.Post); 
//request.AddHeader("Authorization", "Bearer <API Key>");     //Portaldan aldığınız API KEY giriniz.
//request.AddFile("file", "/path/to/file", "application/xml");   // "/path/to/file" XML'in path giriniz.
//request.AddHeader("Content-Type", "multipart/form-data");
//var response = await client.ExecuteAsync(request);
//Console.WriteLine(response);








//var url = "https://apitest.nilvera.com/einvoice/Send/Model";
//var client = new RestClient(url);
//var request = new RestRequest(url,Method.Post);
//request.AddHeader("Authorization", "Bearer 8AB2B31C36CD88AC20F244C3AD5578E9CD31FAB9E07F6B3D42709172B4E54638");
//request.AddHeader("Content-Type", "application/json");
//var body = @"{
//  ""EInvoice"": {
//    ""InvoiceInfo"": {
//      ""UUID"": ""cf2f0db6-8b1c-47b6-b818-a2a254b1740c"",
//      ""TemplateUUID"": ""1bff418a-58fc-41e3-a241-576d131c06d5"",
//      ""TemplateBase64String"": null,
//      ""InvoiceType"": ""SATIS"",
//      ""InvoiceSerieOrNumber"": ""EFT"",
//      ""IssueDate"": ""2023-01-10T10:02:38.1855254+03:00"",
//      ""CurrencyCode"": ""TRY"",
//      ""ExchangeRate"": null,
//      ""InvoiceProfile"": ""TICARIFATURA"",
//      ""DespatchDocumentReference"": null,
//      ""OrderReference"": null,
//      ""OrderReferenceDocument"": null,
//      ""AdditionalDocumentReferences"": null,
//      ""TaxExemptionReasonInfo"": null,
//      ""PaymentTermsInfo"": null,
//      ""PaymentMeansInfo"": null,
//      ""OKCInfo"": null,
//      ""ReturnInvoiceInfo"": null,
//      ""AccountingCost"": null,
//      ""InvoicePeriod"": null,
//      ""SGKInfo"": null,
//      ""Expenses"": null,
//      ""LineExtensionAmount"": 0,
//      ""GeneralKDV1Total"": 0,
//      ""GeneralKDV8Total"": 0,
//      ""GeneralKDV18Total"": 0,
//      ""GeneralAllowanceTotal"": 0,
//      ""PayableAmount"": 0,
//      ""KdvTotal"": 0
//    },
//    ""CompanyInfo"": {
//      ""TaxNumber"": ""57223294532"",
//      ""Name"": ""Ayça Türkmen"",
//      ""TaxOffice"": ""Erciyes"",
//      ""PartyIdentifications"": null,
//      ""AgentPartyIdentifications"": null,
//      ""Address"": ""Adres"",
//      ""District"": ""Melikgazi"",
//      ""City"": ""Kayseri"",
//      ""Country"": ""Türkiye"",
//      ""PostalCode"": ""38038"",
//      ""Phone"": ""08502514010"",
//      ""Fax"": null,
//      ""Mail"": ""info@nilvera.com"",
//      ""WebSite"": ""htts://nilvera.com""
//    },
//    ""CustomerInfo"": {
//      ""TaxNumber"": ""57223294532"",
//      ""Name"": ""Ayça Türkmen"",
//      ""TaxOffice"": null,
//      ""PartyIdentifications"": null,
//      ""AgentPartyIdentifications"": null,
//      ""Address"": ""Papatya Caddesi Yasemin Sokak No21"",
//      ""District"": ""Melikgazi"",
//      ""City"": ""Kayseri"",
//      ""Country"": ""Türkiye"",
//      ""PostalCode"": ""38038"",
//      ""Phone"": null,
//      ""Fax"": null,
//      ""Mail"": null,
//      ""WebSite"": null
//    },
//    ""BuyerCustomerInfo"": null,
//    ""ExportCustomerInfo"": null,
//    ""TaxFreeInfo"": null,
//    ""InvoiceLines"": [
//      {
//        ""Index"": null,
//        ""SellerCode"": null,
//        ""BuyerCode"": null,
//        ""Name"": ""Laptop"",
//        ""Description"": null,
//        ""Quantity"": 1,
//        ""UnitType"": ""C62"",
//        ""Price"": 100,
//        ""AllowanceTotal"": 0,
//        ""KDVPercent"": 18,
//        ""KDVTotal"": 0,
//        ""Taxes"": null,
//        ""DeliveryInfo"": null,
//        ""ManufacturerCode"": null,
//        ""BrandName"": null,
//        ""ModelName"": null,
//        ""Note"": null,
//        ""OzelMatrahReason"": null,
//        ""OzelMatrahTotal"": null,
//        ""AdditionalItemIdentification"": null
//      }
//    ],
//    ""Notes"": [
//      ""Note 1"",
//      ""Note 2""
//    ]
//  },
//  ""CustomerAlias"": ""urn:mail:defaultpk@ayca.com""
//}}";
//request.AddParameter("application/json", body, ParameterType.RequestBody);
//var response = client.ExecuteAsync(request);
//Console.WriteLine(response);


