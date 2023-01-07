// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using NilveraAPI.Models.Dto;
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



var client = new RestClient("https://apitest.nilvera.com/einvoice/Send/Xml?Alias=alicipostakutusuetiketi");
//client.Timeout = -1;
var request = new RestRequest(,Method.Post);
request.AddHeader("Content-Type", "multipart/form-data");
request.AddHeader("Accept", "text/plain");
request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");
request.AddFile("file", "/path/to/file");
var response = client.Execute(request);
Console.WriteLine(response.Content);

