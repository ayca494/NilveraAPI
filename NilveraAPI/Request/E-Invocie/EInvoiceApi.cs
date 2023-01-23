using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using NilveraAPI.Models;
using NilveraAPI.Models.Dto;
using NilveraAPI.Models.Response;
using NilveraAPI.Models.UblModels.Invoice;
using NilveraAPI.Models.UblModels.Shared;
using NilveraAPI.Serializer;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Request.E_Invocie
{
    public class EInvoiceApi : IInvoiceApi<InvoiceResponse>
    {
        #region Faturayı Model olarak gönderir.
        public async Task<InvoiceResponse> SendModel()
        {
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
                        UUID = Guid.Parse(Guid.NewGuid().ToString().ToLower()),
                        TemplateUUID = Guid.Parse("4e482e2c-da6b-4c4b-b834-4dd444915c78"),
                        InvoiceProfile = NilveraAPI.Enums.InvoiceProfile.TEMELFATURA,
                        InvoiceType = NilveraAPI.Enums.InvoiceType.SATIS,
                        InvoiceSerieOrNumber = "BPU",
                        IssueDate = DateTime.Now,
                        CurrencyCode = "TRY",
                        ExchangeRate = 1,
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
            var model=JsonConvert.DeserializeObject<InvoiceResponse>(response.Content);
            return model;
        }
        #endregion



        #region E-Faturanın Ubl Modelini Xml'e çevirme
        public async Task<string> UblConvertXml()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net6.0", "BaseXslt\\E-Invoice");
            string filePath = Path.Combine(basePath + "ca747ee5-9c0d-4410-9378-02bc4a5e31fa.xslt");

            if (!File.Exists(filePath))
            {
                if (!Directory.Exists(basePath))
                    Directory.CreateDirectory(basePath);
            }
            var readTemplate = File.ReadAllText(filePath);

            var template = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(readTemplate.Substring(readTemplate.IndexOf("<"))));


            UblInvoice ublInvoice = new UblInvoice()
            {
                ID = "MTT",
                InvoiceTypeCode = "SATIS",
                IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
                IssueTime = DateTime.Now.ToString("HH:mm:ss"),
                ProfileID = "TICARIFATURA",
                UUID = Guid.NewGuid().ToString().ToLower(),
                AccountingCustomerParty = new CustomerParty()
                {
                    Party = new Party()
                    {
                        Contact = new Contact()
                        {
                            ElectronicMail = "kayseri@gmail.com",
                            Telephone = "02223334455",
                            Telefax = "12344"
                        },
                        PostalAddress = new Address()
                        {
                            Country = new Country() { Name = "Türkiye" },
                            CityName = "Kayseri",
                            CitySubdivisionName = "Talas",
                            StreetName = "Teknopark"
                        },
                        PartyName = new PartyName()
                        {
                            Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ"
                        },
                        PartyIdentification = new List<PartyIdentification>()
                    {
                        new PartyIdentification()
                        {
                            ID = new IDType() { Id = "6310540565", SchemeId = "VKN" }
                        }
                    }
                    }
                },
                AccountingSupplierParty = new SupplierParty()
                {
                    Party = new Party()
                    {
                        Contact = new Contact()
                        {
                            ElectronicMail = "kayseri@gmail.com",
                            Telephone = "02223334455",
                            Telefax = "12344"
                        },
                        PostalAddress = new Address()
                        {
                            Country = new Country() { Name = "Türkiye" },
                            CityName = "Kayseri",
                            CitySubdivisionName = "Talas",
                            StreetName = "Teknopark"
                        },
                        PartyName = new PartyName()
                        {
                            Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ"
                        },
                        PartyIdentification = new List<PartyIdentification>()
                    {
                        new PartyIdentification()
                        {
                            ID = new IDType() { Id = "6310540565", SchemeId = "VKN" }
                        }
                    }
                    }
                },
                AllowanceCharge = new List<AllowanceCharge>()
            {
                new AllowanceCharge()
                {
                    Amount = new BaseCurrency()
                    {
                        CurrencyID = "TRY",
                        Value = 5
                    },
                    ChargeIndicator = false
                }
            },
                DocumentCurrencyCode = new DocumentCurrencyCode()
                {
                    Name = "TRY"
                },
                InvoiceLines = new List<InvoiceLine>()
            {
                new InvoiceLine()
                {
                    AllowanceCharge = new List<AllowanceCharge>()
                    {
                        new AllowanceCharge()
                        {
                            Amount = new BaseCurrency() { CurrencyID = "TRY", Value = 5 },
                            BaseAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 100 },
                            MultiplierFactorNumeric = "0.05",
                            ChargeIndicator = false
                        }
                    },
                    ID = new IDType() { Id = "1" },
                    InvoicedQuantity = new BaseUnit()
                    {
                        UnitCode = "C62",
                        Value = 1
                    },
                    Item = new Item()
                    {
                        Name = "Ürün"
                    },
                    LineExtensionAmount = new BaseCurrency()
                    {
                        CurrencyID = "TRY",
                        Value = 95
                    },
                    Price = new Price()
                    {
                        PriceAmount = new BaseCurrency()
                        {
                            CurrencyID = "TRY",
                            Value = 100
                        }
                    },
                    TaxTotal = new TaxTotal()
                    {
                        TaxAmount = new BaseCurrency()
                        {
                            CurrencyID = "TRY",
                            Value = (Decimal)17.1
                        },
                        TaxSubtotals = new List<TaxSubtotal>()
                        {
                            new TaxSubtotal()
                            {
                                Percent = 18,
                                TaxableAmount = new BaseCurrency()
                                {
                                    CurrencyID = "TRY",
                                    Value = 95
                                },
                                CalculationSequenceNumeric = 1,
                                TaxAmount = new BaseCurrency()
                                {
                                    CurrencyID = "TRY",
                                    Value = (decimal)17.1
                                },
                                TaxCategory = new TaxCategory()
                                {
                                    TaxScheme = new TaxScheme()
                                    {
                                        Name = "KDV",
                                        TaxTypeCode = "0015"
                                    }
                                }
                            }
                        }
                    }

                }
            },
                LegalMonetaryTotal = new MonetaryTotal()
                {
                    AllowanceTotalAmount = new BaseCurrency()
                    {
                        CurrencyID = "TRY",
                        Value = 5
                    },
                    LineExtensionAmount = new BaseCurrency()
                    {
                        CurrencyID = "TRY",
                        Value = 100
                    },
                    PayableAmount = new BaseCurrency()
                    {
                        CurrencyID = "TRY",
                        Value = (decimal)112.1
                    },
                    TaxExclusiveAmount = new BaseCurrency()
                    {
                        CurrencyID = "TRY",
                        Value = 95
                    },
                    TaxInclusiveAmount = new BaseCurrency()
                    {
                        CurrencyID = "TRY",
                        Value = (decimal)112.1
                    }
                },
                LineCountNumeric = 1,
                Notes = new List<string>()
            {
                "YALNIZ : YÜZONİKİ TL ON Kr."
            },
                TaxTotals = new List<TaxTotal>()
            {
                new TaxTotal()
                {
                    TaxAmount = new BaseCurrency()
                    {
                        CurrencyID = "TRY",
                        Value = (decimal)17.1
                    },
                    TaxSubtotals = new List<TaxSubtotal>()
                    {
                        new TaxSubtotal()
                        {
                            CalculationSequenceNumeric = 1,
                            Percent = 18,
                            TaxAmount = new BaseCurrency()
                            {
                                CurrencyID = "TRY",
                                Value = (decimal)17.1
                            },
                            TaxableAmount = new BaseCurrency()
                            {
                                CurrencyID = "TRY",
                                Value = 95
                            },
                            TaxCategory = new TaxCategory()
                            {
                                TaxScheme = new TaxScheme()
                                {
                                    Name = "KDV",
                                    TaxTypeCode = "0015"
                                }
                            }
                        }
                    }
                }
            },
                AdditionalDocumentReferences = new List<DocumentReference>()
            {
                new DocumentReference()
                {
                    DocumentType = "XSLT",
                    DocumentDescription = "E-Fatura stil dosyası.",
                    ID = new IDType() { Id = "ca747ee5-9c0d-4410-9378-02bc4a5e31fa" },
                    IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
                    Attachment = new Attachment()
                    {
                        EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObject()
                        {
                            CharacterSetCode = "UTF-8",
                            EncodingCode = "Base64",
                            Filename = "ca747ee5-9c0d-4410-9378-02bc4a5e31fa.xslt",
                            MimeCode = "application/xml",
                            Name = template
                        }
                    }
                }
            }


            };

            UblInvoiceSerializer ublInvoiceSerializer = new UblInvoiceSerializer();
            string content = await Serializer.Serializer.SerializeAsync(ublInvoice, ublInvoiceSerializer.xmlns);

            var newcontent = Serializer.Serializer.CleanXmlContent(content);

            return Serializer.Serializer.LoadOrCreateXml(newcontent);
        }
        #endregion



        #region Faturayı XML olarak gönderir.
        public async Task<InvoiceResponse> SendXml()
        {
            string file_path = AppDomain.CurrentDomain.BaseDirectory + "Dosyalar\\XML\\Fatura.xml";
            var client = new RestClient();
            var request = new RestRequest("https://apitest.nilvera.com/einvoice/Send/Xml?Alias=urn:mail:defaultpk@nilvera.com", Method.Post);
            request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");     //Portaldan aldığınız API KEY giriniz.
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddFile("file", file_path, "application/xml");
            var response = await client.ExecuteAsync(request);
            var model = JsonConvert.DeserializeObject<InvoiceResponse>(response.Content);
            return model;
        }
        #endregion
    }
}
