using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using NilveraAPI.Enums;
using NilveraAPI.Models;
using NilveraAPI.Models.CheckGlobalCompany;
using NilveraAPI.Models.Dto.Shared;
using NilveraAPI.Models.Pagination;
using NilveraAPI.Models.Response;
using NilveraAPI.Models.UblModels.Despatch;
using NilveraAPI.Models.UblModels.Shared;
using NilveraAPI.Serializer;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Request.E_Despatch
{
    public class EDespatchApi : IInvoiceApi<DespatchResponse>
    {
        private readonly IConfiguration configuration;
        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }
        public EDespatchApi()
        {
            configuration = ServiceRegistration.Services.GetService<IConfiguration>();
            BaseUrl = configuration["BaseUrl"];
            ApiKey = configuration["ApiKey"];
        }

        public async Task<GeneralResponse<IEnumerable<GlobalCompanyInfoResponse>>> CheckGlobalCompany(string TaxNumber)
        {
            RestClient client = new RestClient(BaseUrl);
            var request = new RestRequest($"/general/GlobalCompany/Check/TaxNumber/{TaxNumber}", Method.Get);
            request.AddHeader("Authorization", $"Bearer {ApiKey}");
            request.AddQueryParameter("globalUserType", GlobalUserType.DespatchAdvice);
            var response = await client.ExecuteAsync<IEnumerable<GlobalCompanyInfoResponse>>(request);
            var generalResponse = response.Parse();
            return generalResponse;
        }

        public async Task<DespatchResponse> SendModel()
        {
            EDespatchModel eDespatch = new EDespatchModel()
            {
                EDespatch = new()
                {
                    DespatchSupplierInfo = new DespatchSupplierInfoDto
                    {
                        Address = "Kayseri sokak teknopark",
                        City = "Kayseri",
                        Country = "Türkiye",
                        District = "Talas",
                        Email = "kayseri@gmail.com",
                        Fax = "12345",
                        Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ",
                        PartyIdentifications = new List<IDTypeDto>(),
                        Phone = "02223334455",
                        PostalCode = "38000",
                        TaxNumber = "6310540565",
                        TaxOffice = "Melikgazi",
                        WebSite = "www.kayseri.com"
                    },
                    DeliveryCustomerInfo = new DeliveryCustomerInfoDto()
                    {
                        Address = "Kayseri sokak teknopark",
                        City = "Kayseri",
                        Country = "Türkiye",
                        District = "Talas",
                        Email = "kayseri@gmail.com",
                        Fax = "12345",
                        Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ",
                        PartyIdentifications = new List<IDTypeDto>(),
                        Phone = "02223334455",
                        PostalCode = "38000",
                        TaxNumber = "6310540565",
                        TaxOffice = "Melikgazi",
                        WebSite = "www.kayseri.com"
                    },
                    AdditionalDocumentReference = new List<AdditionalDocumentReferenceDto>(),
                    BuyerCustomerInfo = null,
                    DespatchInfo = new DespatchInfoDto()
                    {
                        UUID = Guid.NewGuid(),
                        IssueDate = DateTime.Now,
                        TemplateUUID = Guid.Parse("71940343-06c8-4daf-9f70-cd4023aa8f1e"),
                        ActualDespatchDateTime = DateTime.Now,
                        PayableAmount = 0,
                        CurrencyCode = "TRY",
                        DespatchType = DespatchType.SEVK,
                        DespatchProfile = DespatchProfile.TEMELIRSALIYE,
                        DespatchSerieOrNumber = "OPR",
                        MatbuIssueDate = null,
                        MatbuNumber = null
                    },
                    DespatchLines = new List<DespatchLineDto>()
                    {
                        new DespatchLineDto()
                        {
                            DeliveredUnitType="C62",
                            DeliveredUnitName="Adet",
                            Name="Ürün",
                            DeliveredQuantity=50,
                            QuantityPrice=(decimal)2.5,
                            LineTotal=(decimal)125.0
                        }
                    },
                    Notes = new List<string>(),
                    OrderReference = new OrderReferenceDto()
                    {
                        DocumentReference = null,
                        ID = "1235412",
                        IssueDate = DateTime.Now
                    },
                    OriginatorCustomerInfo = null,
                    SellerSupplierInfo = null,
                    ShipmentDetail = new ShipmentDetailDto()
                    {
                        ShipmentInfo = new ShipmentInfoDto()
                        {
                            DriverPerson = new List<DriverPersonDto>()
                            {
                                new DriverPersonDto()
                                {
                                    FirstName = "şoför",
                                    LastName = "şoför",
                                    TaxNumber= "12345678914"
                                }
                            },
                            LicensePlateID = "38fg456"
                        },
                        Delivery = new DeliveryDto()
                        {
                            AddressInfo = new AddressInfoDto()
                            {
                                Address = "Kayseri Teknopark",
                                District = "Melikgazi",
                                City = "Kayseri",
                                Country = "Türkiye",
                                PostalCode = "38000"
                            },
                            CarrierInfo = null
                        },
                        TransportEquipment = new List<string>()
                        {
                            "38fg456"
                        }
                    }
                },
                CustomerAlias = "urn:mail:defaultpk@nilvera.com"
            };


            var client = new RestClient(BaseUrl);
            var request = new RestRequest("/edespatch/Send/Model", Method.Post);
            request.AddHeader("Authorization", $"Bearer {ApiKey}"); 
            request.AddJsonBody(eDespatch);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            var response = await client.ExecuteAsync(request);
            var model = JsonConvert.DeserializeObject<DespatchResponse>(response.Content);
            return model;
        }

        public async Task<DespatchResponse> SendXml()
        {
            string file_path = AppDomain.CurrentDomain.BaseDirectory + "Dosyalar\\XML\\Fatura.xml";
            var client = new RestClient(BaseUrl);
            var request = new RestRequest("/edespatch/Send/Xml?Alias=urn:mail:defaultpk@nilvera.com", Method.Post);
            request.AddHeader("Authorization", $"Bearer {ApiKey}");     //Portaldan aldığınız API KEY giriniz.
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddFile("file", file_path, "application/xml");
            var response = await client.ExecuteAsync(request);
            var model = JsonConvert.DeserializeObject<DespatchResponse>(response.Content);
            return model;
        }

        public async Task<string> UblConvertXml()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net6.0", "BaseXslt\\Despatch");
            string filePath = Path.Combine(basePath + "71940343-06c8-4daf-9f70-cd4023aa8f1e.xslt");

            if (!File.Exists(filePath))
            {
                if (!Directory.Exists(basePath))
                    Directory.CreateDirectory(basePath);
            }
            var readTemplate = File.ReadAllText(filePath);

            var template = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(readTemplate.Substring(readTemplate.IndexOf("<"))));

            UblDespatch ublDespatch = new UblDespatch()
            {
                DespatchAdviceTypeCode = "SEVK",
                ID = "OPR",
                ProfileID = "TEMELIRSALIYE",
                IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
                IssueTime = DateTime.Now.ToString("HH:mm:ss"),
                UUID = Guid.NewGuid().ToString().ToLower(),
                LineCountNumeric = 1,
                DeliveryCustomerParty = new DeliveryCustomerParty()
                {
                    Party = new Party()
                    {
                        Contact = new Contact()
                        {
                            ElectronicMail = "kayseri@gmail.com",
                            Telephone = "02223334455",
                            Telefax = "12345"
                        },
                        PartyIdentification = new List<PartyIdentification>()
                        {
                            new PartyIdentification()
                            {
                                ID= new IDType()
                                {
                                    Id="6310540565",
                                    SchemeId = "VKN"
                                }
                            }
                        },
                        PartyName = new PartyName()
                        {
                            Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ"
                        },
                        PartyTaxScheme = new PartyTaxScheme()
                        {
                            TaxScheme = new TaxScheme()
                            {
                                Name = "Melikgazi"
                            }
                        },
                        PostalAddress = new Address()
                        {
                            Country = new Country() { Name = "Türkiye", IdentificationCode = "TR" },
                            CityName = "Kayseri",
                            CitySubdivisionName = "Talas",
                            StreetName = "Teknopark",
                            PostalZone = "38000"
                        },
                        WebSiteURI = "www.kayseri.com"
                    }
                },
                DespatchSupplierParty = new DespatchSupplierParty()
                {
                    Party = new Party()
                    {
                        Contact = new Contact()
                        {
                            ElectronicMail = "kayseri@gmail.com",
                            Telephone = "02223334455",
                            Telefax = "12345"
                        },
                        PartyIdentification = new List<PartyIdentification>()
                        {
                            new PartyIdentification()
                            {
                                ID= new IDType()
                                {
                                    Id="6310540565",
                                    SchemeId = "VKN"
                                }
                            }
                        },
                        PartyName = new PartyName()
                        {
                            Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ"
                        },
                        PartyTaxScheme = new PartyTaxScheme()
                        {
                            TaxScheme = new TaxScheme()
                            {
                                Name = "Melikgazi"
                            }
                        },
                        PostalAddress = new Address()
                        {
                            Country = new Country() { Name = "Türkiye" },
                            CityName = "Kayseri",
                            CitySubdivisionName = "Talas",
                            StreetName = "Teknopark",
                            PostalZone = "38000"
                        },
                        WebSiteURI = "www.kayseri.com"
                    }
                },
                DespatchLine = new List<DespatchLine>()
                {
                    new DespatchLine()
                    {
                        DeliveredQuantity = new DeliveredQuantity()
                        {
                            Quantity=50,
                            UnitCode="C62"
                        },
                        ID= new IDType()
                        {
                            Id="1"
                        },
                        Item = new Item()
                        {
                            Name="Ürün"
                        },
                        OrderLineReference = new OrderLineReference()
                        {
                            LineID= new IDType()
                            {
                                Id="1"
                            }
                        },
                        Shipment=new Shipment()
                        {
                            ID=new IDType(),
                            GoodsItem = new List<GoodsItem>()
                            {
                                new GoodsItem()
                                {
                                    InvoiceLine =new InvoiceLine()
                                    {
                                        ID=new IDType(),
                                        InvoicedQuantity= new BaseUnit()
                                        {
                                            Value=50
                                        },
                                        Item= new Item()
                                        {
                                            Name="Ürün"
                                        },
                                        LineExtensionAmount= new BaseCurrency()
                                        {
                                            CurrencyID="TRY",
                                            Value=125
                                        },
                                        Price= new Price()
                                        {
                                            PriceAmount=new BaseCurrency()
                                            {
                                                CurrencyID="TRY",
                                                Value=(decimal)2.5
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }

                },
                OrderReference = new OrderReference()
                {
                    IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
                    ID = new IDType()
                    {
                        Id = "1235412"
                    }
                },
                Shipment = new Shipment()
                {
                    Delivery = new Delivery()
                    {
                        DeliveryAddress = new Address()
                        {
                            CityName = "Kayseri",
                            CitySubdivisionName = "Melikgazi",
                            StreetName = "Kayseri Teknopark",
                            Country = new Country()
                            {
                                IdentificationCode = "TR",
                                Name = "Türkiye"
                            },
                            PostalZone = "38000"
                        },
                        Despatch = new DespatchModel()
                        {
                            ActualDespatchDate = DateTime.Now.ToString("yyyy-MM-dd"),
                            ActualDespatchTime = DateTime.Now.ToString("HH:mm:ss")
                        }
                    },
                    ID = new IDType(),
                    GoodsItem = new List<GoodsItem>()
                    {
                        new GoodsItem()
                        {
                            ValueAmount = new BaseCurrency()
                            {
                                CurrencyID="TRY",
                                Value=(decimal)125
                            }
                        }
                    },
                    ShipmentStage = new List<ShipmentStage>()
                    {
                        new ShipmentStage()
                        {
                            DriverPerson = new List<Person>()
                            {
                                new Person()
                                {
                                    FirstName = "Şoför",
                                    FamilyName="Şoför",
                                    Title = "Şoför",
                                    NationalityID= new IDType()
                                    {
                                        Id ="12345678914",
                                        SchemeId = "TCKN"
                                    }
                                }
                            },
                            TransportMeans = new TransportMeans()
                            {
                                RoadTransport = new List<RoadTransport>()
                                {
                                    new RoadTransport()
                                    {
                                        LicensePlateID = new IDType()
                                        {
                                            Id="38fg456",
                                            SchemeId="PLAKA"
                                        }
                                    }
                                }
                            }
                        }
                    },
                    TransportHandlingUnit = new List<TransportHandlingUnit>()
                    {
                        new TransportHandlingUnit()
                        {
                            TransportEquipment = new List<TransportEquipment>()
                            {
                                new TransportEquipment()
                                {
                                    Id=new IDType()
                                    {
                                        Id="38fg456",
                                        SchemeId="DORSEPLAKA"
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
                        ID= new IDType()
                        {
                            Id="71940343-06c8-4daf-9f70-cd4023aa8f1e"
                        },
                        IssueDate=DateTime.Now.ToString("yyyy-MM-dd"),
                        DocumentType= "XSLT",
                        DocumentDescription="E-İrsaliye stil dosyası.",
                        Attachment = new Attachment()
                        {
                            EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObject()
                            {
                                CharacterSetCode="UTF-8",
                                EncodingCode="Base64",
                                MimeCode="application/xml",
                                Filename="71940343-06c8-4daf-9f70-cd4023aa8f1e.xslt",
                                Name=template
                            }
                        }
                    }
                }
            };

            UblDespatchSerializer ublDespatchSerializer = new UblDespatchSerializer();
            string content = await Serializer.Serializer.SerializeAsync(ublDespatch, ublDespatchSerializer.xmlns);

            var newcontent = Serializer.Serializer.CleanXmlContent(content);

            return Serializer.Serializer.LoadOrCreateXml(newcontent);
        }
    }

}
