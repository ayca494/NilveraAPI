using Newtonsoft.Json;
using NilveraAPI.Enums;
using NilveraAPI.Models;
using NilveraAPI.Models.Dto;
using NilveraAPI.Models.Dto.Shared;
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

namespace NilveraAPI.Request.E_Archive
{
    public class EArchiveApi : IInvoiceApi<InvoiceResponse> 
    {
        public async Task<InvoiceResponse> SendModel()
        {
            ArchiveInvoiceModel archiveInvoiceModel = new ArchiveInvoiceModel()
            {
                ArchiveInvoice = new ArchiveInvoiceDto()
                {
                    CompanyInfo = new PartyInfoDto()
                    {
                        TaxNumber = "6310540565",
                        Name = "NİLVERA YAZILIM VE BİLİŞİM HİZMETLERİ TİCARET LİMİTED ŞİRKETİ",
                        TaxOffice = "",
                        PartyIdentifications = new List<NilveraAPI.Models.Dto.Shared.IDTypeDto>()
                        {
                            new NilveraAPI.Models.Dto.Shared.IDTypeDto()
                            {
                                SchemeID = "MERSISNO",
                                Value = "1122334455667788 "
                            },
                            new NilveraAPI.Models.Dto.Shared.IDTypeDto()
                            {
                                SchemeID = "TICARETSICILNO",
                                Value = "12345"
                            }
                        },
                        Address = "adres",
                        District = "Melikgazi",
                        City = "Kayseri",
                        Country = "Türkiye",
                        PostalCode = "",
                        Phone = "",
                        Fax = "12345",
                        Mail = "",
                        WebSite = ""
                    },
                    CustomerInfo = new PartyInfoDto()
                    {
                        TaxOffice = "Melikgazi",
                        Address = "Sahabiye Mahallesi Bor Sok. Soylu İş Merkz. No:10",
                        District = "Kocasinan",
                        City = "Kayseri",
                        Country = "Türkiye",
                        Fax = "",
                        Name = "MOHAMMAD ALAJATI",
                        PartyIdentifications = new List<IDTypeDto>(),
                        Phone = "",
                        PostalCode = "",
                        TaxNumber = "99347391094",
                        WebSite = ""
                    },
                    InvoiceInfo = new ArchiveInvoiceInfoDto()
                    {
                        UUID = Guid.Parse(Guid.NewGuid().ToString().ToLower()),
                        TemplateUUID = Guid.Parse("72813487-e592-4758-87da-be08ed199197"),
                        InvoiceType = NilveraAPI.Enums.InvoiceType.SATIS,
                        InvoiceSerieOrNumber = "NIL",
                        IssueDate = DateTime.Now,
                        CurrencyCode = "TRY",
                        ExchangeRate = 1,
                        Expenses = new List<ExpensesDto>()
                        {
                            new ExpensesDto()
                            {
                                Amount = 12,
                                ExpenseType = NilveraAPI.Enums.ExpenseType.HKSKOMISYON
                            }
                        },
                        SendType = SendType.KAGIT,
                        SalesPlatform = SalesPlatform.NORMAL
                    },
                    InvoiceLines = new List<EArchiveInvoiceLineDto>()
                    {
                        new EArchiveInvoiceLineDto()
                        {
                            Name = "Deneme",
                            Price = 12,
                            Quantity = 125,
                            UnitType = "C62",
                            AllowanceTotal = 195,
                            KDVPercent = 18,
                            AdditionalItemIdentification = new AdditionalItemIdentificationDto()
                            {
                                TagNumber = "1231231231231231231",
                                OwnerName = "deneme",
                                OwnerTaxNumber = "22040521512"
                            }
                        }
                    }
                }
            };

            var client = new RestClient();
            var request = new RestRequest("https://apitest.nilvera.com/earchive/Send/Model", Method.Post);
            request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");
            request.AddJsonBody(archiveInvoiceModel);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            var response = await client.ExecuteAsync(request);
            var model = JsonConvert.DeserializeObject<InvoiceResponse>(response.Content);
            return model;
        }

        public async Task<InvoiceResponse> SendXml()
        {
            string file_path = AppDomain.CurrentDomain.BaseDirectory + "Dosyalar\\XML\\Fatura.xml";
            var client = new RestClient();
            var request = new RestRequest("https://apitest.nilvera.com/earchive/Send/Xml?Alias=urn:mail:defaultpk@nilvera.com", Method.Post);
            request.AddHeader("Authorization", "Bearer 9F9FFF28D59C0B99019C66F322BC1C2350F3D25174C99052B9DCFA3956AAA66B");     //Portaldan aldığınız API KEY giriniz.
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddFile("file", file_path, "application/xml");
            var response = await client.ExecuteAsync(request);
            var model = JsonConvert.DeserializeObject<InvoiceResponse>(response.Content);
            return model;
        }

        public async Task<string> UblConvertXml()
        {
           
            string basePath = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net6.0", "BaseXslt\\E-Archive");
            string filePath = Path.Combine(basePath + "3bad4083-fa25-4bb8-82a3-65e8369c8280.xslt");

            if (!File.Exists(filePath))
            {
                if (!Directory.Exists(basePath))
                    Directory.CreateDirectory(basePath);
            }
            var readTemplate = File.ReadAllText(filePath);

            var template = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(readTemplate.Substring(readTemplate.IndexOf("<"))));


            UblInvoice ublEArchiveInvoice = new UblInvoice()
            {
                ID = "NIL",
                InvoiceTypeCode = "SATIS",
                IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
                IssueTime = DateTime.Now.ToString("HH:mm:ss"),
                ProfileID = "EARSIVFATURA",
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
                        Person = new Person()
                        {
                            FirstName = "MOHAMMAD",
                            FamilyName = "ALAJATI"

                        },
                        PartyIdentification = new List<PartyIdentification>()
                        {
                            new PartyIdentification()
                            {
                                ID = new IDType() { Id = "99347391094", SchemeId = "TCKN" }
                            }
                        },
                        PartyTaxScheme = new PartyTaxScheme()
                        {
                            TaxScheme = new TaxScheme()
                            {
                                Name = "Melikgazi"
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
                        DocumentDescription = "E-Arşiv stil dosyası.",
                        ID = new IDType() { Id = "3bad4083-fa25-4bb8-82a3-65e8369c8280" },
                        IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
                        Attachment = new Attachment()
                        {
                            EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObject()
                            {
                                CharacterSetCode = "UTF-8",
                                EncodingCode = "Base64",
                                Filename = "3bad4083-fa25-4bb8-82a3-65e8369c8280.xslt",
                                MimeCode = "application/xml",
                                Name = template
                            }
                        }
                    },
                    new DocumentReference()
                    {
                        ID = new IDType(){ Id="ELEKTRONIK"},
                        DocumentTypeCode="SEND_TYPE",
                        IssueDate=DateTime.Now.ToString("yyyy-MM-dd")
                    }
                }


            };

            UblInvoiceSerializer ublInvoiceSerializer = new UblInvoiceSerializer();
            string content = await Serializer.Serializer.SerializeAsync(ublEArchiveInvoice, ublInvoiceSerializer.xmlns);

            var newcontent = Serializer.Serializer.CleanXmlContent(content);

            return Serializer.Serializer.LoadOrCreateXml(newcontent);
        }
    }
}
