using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using NilveraAPI.Models.Dto;
using NilveraAPI.Models.Dto.Shared;
using NilveraAPI.Models.Response;
using NilveraAPI.Models.UblModels.Producer;
using NilveraAPI.Models.UblModels.Shared;
using NilveraAPI.Serializer;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Request.E_Producer
{
    public class EProducerApi : IInvoiceApi<ProducerResponse>
    {
        private readonly IConfiguration configuration;
        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }
        public EProducerApi()
        {
            configuration = ServiceRegistration.Services.GetService<IConfiguration>();
            BaseUrl = configuration["BaseUrl"];
            ApiKey = configuration["ApiKey"];
        }
        public async Task<ProducerResponse> SendModel()
        {
            ProducerModel producerModel = new ProducerModel()
            {
                Producer = new ProducerDto()
                {
                    ProducerLines = new List<EProducerLineDto>()
                    {
                        new EProducerLineDto() {
                            Name = "Ürün",
                            Quantity = 1m,
                            Price = 10m,
                            UnitType =  "C62",
                            GVWithholdingPercent = 20m,
                            GVWithholdingAmount = 2m,
                            Taxes = new List<TaxDto>(){}
                        },
                    },
                    CustomerInfo = new PartyInfoDto()
                    {
                        TaxNumber = "12345678901",
                        Name = "FEVZİ FURKAN TATLISU",
                        TaxOffice = "Gevher Nesibe",
                        AgentPartyIdentifications = null,
                        PartyIdentifications = new List<IDTypeDto>(),
                        Address = "Mimarsinan Şirintepe Mah. Malazgirt Bulvarı 75.Yıl Sitesi Apt.",
                        District = "Melikgazi",
                        City = "Kayseri",
                        Country = "ülke",
                        PostalCode = "38100",
                        Phone = "05567894356",
                        Fax = "03523489208",
                        Mail = "furkantatlisu@gmail.com",
                        WebSite = "www.deneme.com"
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
                    ProducerInfo = new ProducerInfoDto()
                    {
                        UUID = Guid.Parse(Guid.NewGuid().ToString().ToLower()),
                        TemplateUUID = Guid.Parse("fe917cea-0461-4a1e-b301-6d9e1ad0b7e0"),
                        ProducerSerieOrNumber = "EMM",
                        IssueDate = DateTime.Now,
                        DeliveryDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")),
                        CurrencyCode = "TRY",
                        ExchangeRate = 1
                    },
                    Notes = new List<string>()
                    {
                        "Bu",
                        "bir",
                        "denemedir."
                    }

                }
            };

            var client = new RestClient(BaseUrl);
            var request = new RestRequest("/emm/Send/Model", Method.Post);
            request.AddHeader("Authorization", $"Bearer {ApiKey}");
            request.AddJsonBody(producerModel);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            var response = await client.ExecuteAsync(request);
            var model = JsonConvert.DeserializeObject<ProducerResponse>(response.Content);
            return model;
        }

        public async  Task<ProducerResponse> SendXml()
        {
            string file_path = AppDomain.CurrentDomain.BaseDirectory + "Dosyalar\\XML\\Fatura.xml";
            var client = new RestClient(BaseUrl);
            var request = new RestRequest("/emm/Send/Xml?Alias=urn:mail:defaultpk@nilvera.com", Method.Post);
            request.AddHeader("Authorization", $"Bearer {ApiKey}");     
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddFile("file", file_path, "application/xml");
            var response = await client.ExecuteAsync(request);
            var model = JsonConvert.DeserializeObject<ProducerResponse>(response.Content);
            return model;
        }

        public async Task<string> UblConvertXml()
        {

            string basePath = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net6.0", "BaseXslt\\Producer");
            string filePath = Path.Combine(basePath + "fe917cea-0461-4a1e-b301-6d9e1ad0b7e0.xslt");

            if (!File.Exists(filePath))
            {
                if (!Directory.Exists(basePath))
                    Directory.CreateDirectory(basePath);
            }
            var readTemplate = File.ReadAllText(filePath);

            var template = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(readTemplate.Substring(readTemplate.IndexOf("<"))));


            UblProducer producer = new UblProducer()
            {
                UBLVersionID = "2.1",
                CustomizationID = "TR1.2.1",
                CopyIndicator = false,
                ProfileID = "EARSIVBELGE",
                ID = "EMM",
                UUID = Guid.NewGuid().ToString().ToLower(),
                IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
                IssueTime = DateTime.Now.ToString("HH:mm:ss"),
                CreditNoteTypeCode = "MUSTAHSILMAKBUZ",
                Notes = new List<string>(),
                DocumentCurrencyCode = new DocumentCurrencyCode()
                {
                    Name = "TRY"
                },
                LineCountNumeric = 1,
                AdditionalDocumentReferences = new List<DocumentReference>()
                {
                    new DocumentReference()
                    {
                        Attachment = new Attachment()
                        {
                            EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObject()
                            {
                                CharacterSetCode = "UTF-8",
                                EncodingCode = "Base64",
                                Filename = "fe917cea-0461-4a1e-b301-6d9e1ad0b7e0.xslt",
                                MimeCode = "application/xml",
                                Name=template
                            }
                        },
                        DocumentType = "XSLT",
                        ID = new IDType()
                        {
                            Id = "fe917cea-0461-4a1e-b301-6d9e1ad0b7e0"
                        },
                        IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
                        DocumentDescription = "E-MM stil dosyası."

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
                            FirstName = "FEVZİ FURKAN",
                            FamilyName = "TATLISU"
                        },
                        WebSiteURI = "www.furkantatlisu.com",
                        AgentParty = null,
                        PartyIdentification = new List<PartyIdentification>()
                                    {
                                        new PartyIdentification() {ID = new IDType(){ Id="34918613960",SchemeId="TCKN"}},
                                    },
                        PostalAddress = new Address()
                        {
                            StreetName = "Mimarsinan Şirintepe Mah. Malazgirt Bulvarı 75.Yıl Sitesi Apt.",
                            CitySubdivisionName = "Melikgazi",
                            CityName = "Kayseri",
                            PostalZone = "38100",
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
                            Telefax = "03523489208",
                            Telephone = "05647865432"
                        },
                    }
                },
                Delivery = new List<Delivery>()
                {
                    new Delivery()
                    {
                        ActualDeliveryDate = DateTime.Now.ToString("yyyy-MM-dd"),
                    }
                },
                PricingExchangeRate = new ExchangeRate()
                {
                    SourceCurrencyCode = "TRY",
                    TargetCurrencyCode = "TRY",
                    CalculationRate = 19.5
                },
                TaxTotals = new List<TaxTotal>()
                {
                    new TaxTotal()
                    {
                        TaxAmount = new BaseCurrency()
                        {
                            CurrencyID = "TRY",
                            Value = 10m
                        },
                        TaxSubtotals = new List<TaxSubtotal>()
                        {
                            new TaxSubtotal()
                            {
                                CalculationSequenceNumeric = 1,
                                Percent = 1.6m,
                                TaxAmount = new BaseCurrency()
                                {
                                    CurrencyID = "TRY",
                                    Value = 10m
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
                                    Value = 600m
                                }
                            }
                        }
                    }
                },
                LegalMonetaryTotal = new MonetaryTotal()
                {
                    LineExtensionAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 600m },
                    TaxExclusiveAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 600m },
                    TaxInclusiveAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 600m },
                    PayableAmount = new BaseCurrency() { CurrencyID = "TRY", Value = 590.00m },
                },
                CreditNoteLine = new List<CreditNoteLine>()
                {
                    new CreditNoteLine()
                    {
                        ID=new IDType(){Id="1"},
                        CreditedQuantity = new BaseUnit()
                        {
                            UnitCode = "B32",
                            Value = 60
                        },
                        LineExtensionAmount = new BaseCurrency()
                        {
                            CurrencyID="TRY",
                            Value=600m
                        },
                        TaxTotal = new TaxTotal()
                        {
                            TaxAmount = new BaseCurrency()
                            {
                                CurrencyID = "TRY",
                                Value = 10.00m
                            },
                            TaxSubtotals = new List<TaxSubtotal>()
                            {
                                 new TaxSubtotal()
                                {
                                    TaxableAmount = new BaseCurrency()
                                    {
                                        CurrencyID = "TRY",
                                        Value = 600m
                                    },
                                    TaxAmount = new BaseCurrency()
                                    {
                                        CurrencyID = "TRY",
                                        Value = 10m
                                    },
                                    CalculationSequenceNumeric = 1,
                                    Percent = 1.6666666666666667m,
                                    TaxCategory = new TaxCategory()
                                    {
                                        TaxScheme = new TaxScheme()
                                        {
                                            Name = "GV. Stpj.",
                                            TaxTypeCode = "0003"
                                        }
                                    }
                                }
                            }
                        },
                        Item =new Item(){Name="Biber",},
                        Price = new Price()
                        {
                            PriceAmount = new BaseCurrency()
                            {
                                CurrencyID = "TRY",
                                Value = 10m
                            }
                        }
                    },
                     new CreditNoteLine()
                    {
                        ID=new IDType(){Id="2"},
                        CreditedQuantity = new BaseUnit()
                        {
                            UnitCode = "B32",
                            Value = 60
                        },
                        LineExtensionAmount = new BaseCurrency()
                        {
                            CurrencyID="TRY",
                            Value=600m
                        },
                        TaxTotal = new TaxTotal()
                        {
                            TaxAmount = new BaseCurrency()
                            {
                                CurrencyID = "TRY",
                                Value = 10.00m
                            },
                            TaxSubtotals = new List<TaxSubtotal>()
                            {
                                 new TaxSubtotal()
                                {
                                    TaxableAmount = new BaseCurrency()
                                    {
                                        CurrencyID = "TRY",
                                        Value = 600m
                                    },
                                    TaxAmount = new BaseCurrency()
                                    {
                                        CurrencyID = "TRY",
                                        Value = 10m
                                    },
                                    CalculationSequenceNumeric = 1,
                                    Percent = 1.6666666666666667m,
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
                                     TaxableAmount = new BaseCurrency()
                                     {
                                         CurrencyID = "TRY",
                                         Value = 100m
                                     },
                                     TaxAmount = new BaseCurrency()
                                     {
                                         CurrencyID = "TRY",
                                         Value = 150m
                                     },
                                     CalculationSequenceNumeric = 2,
                                     Percent = 15m,
                                     TaxCategory = new TaxCategory()
                                     {
                                         TaxScheme = new TaxScheme()
                                         {
                                             Name = "Mera Fonu",
                                             TaxTypeCode = "9040"
                                         }
                                     }
                                 }
                            }
                        },
                        Item =new Item(){Name="Biber",},
                        Price = new Price()
                        {
                            PriceAmount = new BaseCurrency()
                            {
                                CurrencyID = "TRY",
                                Value = 10m
                            }
                        }
                    }

                }
            };

            UblProducerSerializer ublProducerSerializer = new UblProducerSerializer();
            string content = await Serializer.Serializer.SerializeAsync(producer, ublProducerSerializer.xmlns);

            var newcontent = Serializer.Serializer.CleanXmlContent(content);

            return Serializer.Serializer.LoadOrCreateXml(newcontent);
        }
    }
}
