using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using NilveraAPI.Enums;
using NilveraAPI.Models.Dto;
using NilveraAPI.Models.Dto.Shared;
using NilveraAPI.Models.Response;
using NilveraAPI.Models.UblModels.Shared;
using NilveraAPI.Models.UblModels.Voucher;
using NilveraAPI.Serializer;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Request.E_Voucher
{
    public class EVoucherApi : IInvoiceApi<VoucherResponse>
    {
        private readonly IConfiguration configuration;
        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }
        public EVoucherApi()
        {
            configuration = ServiceRegistration.Services.GetService<IConfiguration>();
            BaseUrl = configuration["BaseUrl"];
            ApiKey = configuration["ApiKey"];
        }

        public async Task<VoucherResponse> SendModel()
        {
            VoucherModel voucherModel = new VoucherModel()
            {
                Voucher = new VoucherDto()
                {
                    VoucherInfo = new VoucherInfoDto()
                    {
                        UUID = Guid.Parse(Guid.NewGuid().ToString().ToLower()),
                        TemplateUUID = Guid.Parse("4de2fa46-4612-46cd-88be-5d7258614616"),
                        VoucherSerieOrNumber = "SMM",
                        IssueDate = DateTime.Now,
                        CurrencyCode = "TRY",
                        ExchangeRate = 1,
                        SendType = SendType.ELEKTRONIK
                    },
                    CompanyInfo = new PartyInfoDto()
                    {
                        Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ",
                        TaxNumber = "6310540565",
                        TaxOffice = "Gevher Nesibe",
                        PartyIdentifications = new List<IDTypeDto>()
                        {
                            new IDTypeDto()
                            {
                                SchemeID = "MERSISNO",
                                Value="1122334455667788"
                            },
                            new IDTypeDto()
                            {
                                SchemeID = "TICARETSICILNO",
                                Value = "12345"
                            }
                        },
                        Address = "Yıldırım Beyazıt Mah. Aşıkveysel Bulvarı Erciyes Teknopark Binası 3",
                        District = "Melikgazi",
                        City = "Kayseri",
                        Country = "TÜRKİYE",
                        PostalCode = "38100",
                        Phone = "02166885100",
                        Fax = "0216 688 51 99",
                        Mail = "destek@nilvera.com",
                        WebSite = "www.nilvera.com"
                    },
                    CustomerInfo = new PartyInfoDto()
                    {
                        TaxNumber = "34918613960",
                        Name = "Feride Çolak",
                        TaxOffice = "Melikgazi Vergi Dairesi",
                        AgentPartyIdentifications = null,
                        PartyIdentifications = new List<IDTypeDto>(),
                        Address = "Teknopark 3",
                        District = "Melikgazi",
                        City = "Kayseri",
                        Country = "Türkiye",
                        PostalCode = "38050",
                        Phone = "05342354657",
                        Fax = "05342354657",
                        Mail = "deneme@gmail.com",
                        WebSite = "www.deneme.com",
                    },
                    VoucherLines = new List<EVoucherLineDto>()
                    {
                        new EVoucherLineDto
                        {
                            Name = "hizmet1",
                            GrossWage = 2840.91m,
                            Price = 0M,
                            GVWithholdingPercent = 20m,
                            KDVPercent = 8m,
                            Taxes = new List<TaxDto>()
                            {
                                new TaxDto()
                                {
                                    Percent = 20M,
                                    Total = 0m,
                                    ReasonCode = "616",
                                    TaxCode = "9015"
                                }
                            }
                        }
                    },
                    Notes = new List<string>()
                    {
                        "deneme",
                        "notu"
                    }
                }
            };

            var client = new RestClient(BaseUrl);
            var request = new RestRequest("/esmm/Send/Model", Method.Post);
            request.AddHeader("Authorization", $"Bearer {ApiKey}");
            request.AddJsonBody(voucherModel);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            var response = await client.ExecuteAsync(request);
            var model = JsonConvert.DeserializeObject<VoucherResponse>(response.Content);
            return model;
        }

        public async Task<VoucherResponse> SendXml()
        {
            string file_path = AppDomain.CurrentDomain.BaseDirectory + "Dosyalar\\XML\\Fatura.xml";
            var client = new RestClient(BaseUrl);
            var request = new RestRequest("/esmm/Send/Xml?Alias=urn:mail:defaultpk@nilvera.com", Method.Post);
            request.AddHeader("Authorization", $"Bearer {ApiKey}");
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddFile("file", file_path, "application/xml");
            var response = await client.ExecuteAsync(request);
            var model = JsonConvert.DeserializeObject<VoucherResponse>(response.Content);
            return model;
        }

        public async Task<string> UblConvertXml()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net6.0", "BaseXslt\\Voucher");
            string filePath = Path.Combine(basePath + "4de2fa46-4612-46cd-88be-5d7258614616.xslt");

            if (!File.Exists(filePath))
            {
                if (!Directory.Exists(basePath))
                    Directory.CreateDirectory(basePath);
            }

            var readTemplate = File.ReadAllText(filePath);

            var template = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(readTemplate));

            UblVoucher voucher = new UblVoucher()
            {
                UBLVersionID = "2.1",
                CustomizationID = "TR1.2",
                CopyIndicator = false,
                ProfileID = "EARSIVBELGE",
                ID = "SMM",
                UUID = Guid.NewGuid().ToString().ToLower(),
                IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
                IssueTime = DateTime.Now.ToString("HH:mm:ss"),
                CreditNoteTypeCode = "SERBESTMESLEKMAKBUZU",
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
                AdditionalDocumentReferences = new List<DocumentReference>()
                {
                    new DocumentReference
                    {
                        ID = new IDType(){Id = "ELEKTRONIK"},
                        IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
                        DocumentTypeCode ="SEND_TYPE"
                    },
                    new DocumentReference()
                    {
                        DocumentType = "XSLT",
                        DocumentDescription = "E-SMM stil dosyası.",
                        ID = new IDType() { Id = "4de2fa46-4612-46cd-88be-5d7258614616" },
                        IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
                        Attachment = new Attachment()
                        {
                            EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObject()
                            {
                                CharacterSetCode = "UTF-8",
                                EncodingCode = "Base64",
                                Filename = "4de2fa46-4612-46cd-88be-5d7258614616.xslt",
                                MimeCode = "application/xml",
                                Name = template
                            }
                        }
                    }
                },
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
                    Value = 3.68m
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
                            Value = 0m
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
                            Value = 46m
                        }
                    },
                    new TaxSubtotal()
                    {
                         CalculationSequenceNumeric = 2,
                        TaxableAmount = new BaseCurrency()
                        {
                            CurrencyID = "TRY",
                            Value = 3.68m
                        },
                        TaxAmount = new BaseCurrency()
                        {
                            CurrencyID = "TRY",
                            Value = 46m
                        },
                        Percent = 8m,
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
                WithholdingAllowance = new WithholdingAllowance()
                {
                    WithholdableAmount = new BaseCurrency()
                    {
                        CurrencyID = "TRY",
                        Value = 3.68m
                    },
                    WithholdingAmount = new BaseCurrency()
                    {
                        CurrencyID = "TRY",
                        Value = 0m
                    }
                },
                LegalMonetaryTotal = new MonetaryTotal()
                {
                    LineExtensionAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 46m },
                    TaxExclusiveAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 46m },
                    TaxInclusiveAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 46m },
                    PayableAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 49.68m },
                },
                VoucherLine = new List<VoucherLine>()
                {
                    new VoucherLine()
                    {
                        ID = new IDType(){ Id = "1"},
                        LineExtensionAmount= new BaseCurrency(){ CurrencyID="TRY", Value = 49.68m},
                        GrossWage = new GrossWage()
                        {
                            GrossWageAmount = new BaseCurrency()
                            {
                                CurrencyID = "TRY",
                                Value = 46m
                            }

                        },
                        Price = new Price()
                        {
                           PriceAmount = new BaseCurrency()
                           {
                                CurrencyID = "TRY",
                                Value =  46m
                           }
                        },
                        TaxTotal = new TaxTotal()
                        {
                            TaxAmount = new BaseCurrency()
                            {
                                CurrencyID = "TRY",
                                Value = 3.68m
                            },
                            TaxSubtotals = new List<TaxSubtotal>()
                            {

                                 new TaxSubtotal()
                                 {
                                      CalculationSequenceNumeric = 1,
                                     TaxableAmount = new BaseCurrency()
                                     {
                                         CurrencyID = "TRY",
                                         Value = 46m
                                     },
                                     TaxAmount = new BaseCurrency()
                                     {
                                         CurrencyID = "TRY",
                                         Value = 0m
                                     },
                                     Percent = 0m,
                                     TaxCategory = new TaxCategory()
                                     {
                                         TaxScheme = new TaxScheme()
                                         {
                                             Name = "GV. Stpj.",
                                             TaxTypeCode = "0003"
                                         }
                                     }
                                 },
                                 new TaxSubtotal()
                                 {
                                      CalculationSequenceNumeric = 2,
                                     TaxableAmount = new BaseCurrency()
                                     {
                                         CurrencyID = "TRY",
                                         Value = 46m
                                     },
                                     TaxAmount = new BaseCurrency()
                                     {
                                         CurrencyID = "TRY",
                                         Value = 3.68m
                                     },
                                     Percent = 8m,
                                     TaxCategory = new TaxCategory()
                                     {
                                         TaxScheme = new TaxScheme()
                                         {
                                             Name = "KDV",
                                             TaxTypeCode = "0015"
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

            UblVoucherSerializer ublVoucherSerializer = new UblVoucherSerializer();

            string content = await Serializer.Serializer.SerializeAsync(voucher, ublVoucherSerializer.xmlns);
            var newContent = Serializer.Serializer.CleanXmlContent(content);
            return Serializer.Serializer.LoadOrCreateXml(newContent);
           
        }
    }
}
