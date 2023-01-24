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
using NilveraAPI.Request.E_Voucher;
using NilveraAPI;
using Microsoft.Extensions.DependencyInjection;

ServiceRegistration.Main(args);

#region Mükellef Sorgulama
Console.WriteLine("TCKN ya da VKN giriniz : ");
var taxNumber = Console.ReadLine();
EInvoiceApi checkGlobalcompany = new EInvoiceApi();
var generalResponse = await checkGlobalcompany.CheckGlobalCompany(taxNumber);

if (generalResponse.Content.Any())
{
    foreach (var item in generalResponse.Content)
    {
        Console.WriteLine($"\n{item.FirstCreatedTime} Tarihinden İtibaren E-Fatura Mükellefidir.");
        Console.WriteLine($"Ünvan : {item.Title}");
        Console.WriteLine($"Etiket : {item.Name}");
        Console.WriteLine($"Tipi : {item.Type}");
        Console.WriteLine($"Etiket Oluşturulma Tarihi : {item.CreationTime}");
        Console.WriteLine("******************************************************");
    }
}
else
{
    Console.WriteLine("\nE-Fatura Mükellefi Değildir.\n");
}
Console.ReadLine();
#endregion


#region E-Fatura Mükellefi ise yukarıda dönen etiketi kullanarak E-Fatura gönderilir.

#region Fatura model olarak gönderir.

EInvoiceApi eInvoice = new EInvoiceApi();
InvoiceResponse responseEInvoice = await eInvoice.SendModel();
Console.WriteLine($"UUID: {responseEInvoice.UUID},\nFatura Numarası: {responseEInvoice.InvoiceNumber}");

#endregion


#region E-Faturanın Ubl Modelini Xml'e çevirme 

var eInvoicePath = await eInvoice.UblConvertXml();
Console.WriteLine("\nXml oluşturuldu. Dosya yolu: " + eInvoicePath);

#endregion


#region E-Fatura Xml olarak gönderir

responseEInvoice = await eInvoice.SendXml();
Console.WriteLine($"\nUUID: {responseEInvoice.UUID},\nFatura Numarası: {responseEInvoice.InvoiceNumber}");
Console.ReadLine();

#endregion


#region Giden E-Faturalar Listelenir (Pagination)
EInvoiceApi pagination = new EInvoiceApi();
var paginationResponse = await pagination.Pagination();

Console.WriteLine("E-Faturalar : ");
foreach (var item in paginationResponse.Content.Content)
{
    Console.WriteLine($"UUID : {item.UUID}");
    Console.WriteLine($"VKN : {item.TaxNumber}");
    Console.WriteLine($"Fatura Numarası : {item.InvoiceNumber}");
    Console.WriteLine($"Fatura Tarihi : {item.IssueDate}");
    Console.WriteLine($"Fatura Tutarı : {item.PayableAmount}");
    Console.WriteLine("*******************************************");
}
Console.ReadLine();

#endregion


#region Giden E-Fatura Pdf, Html ve Xml İndirme 

EInvoiceApi eInvoiceDownload = new EInvoiceApi();
string UUID = "d90c2c7e-ec3f-4626-a680-a2b9cf8c863d"; //Faturanın UUID'si girilir.

#region Giden E-Fatura Pdf indirilir

var pdfPath = await eInvoiceDownload.DownloadPdf(UUID);
Console.WriteLine("Faturanın pdf'i indirildi. Dosya yolu : " + pdfPath);
Console.ReadLine();

#endregion


#region Giden E-Fatura html indirilir

var htmlPath = await eInvoiceDownload.DownloadHtml(UUID);
Console.WriteLine("Faturanın html'i indirildi. Dosya yolu : " + htmlPath);
Console.ReadLine();

#endregion


#region Giden E-Fatura xml indirilir

var xmlPath = await eInvoiceDownload.DownloadXml(UUID);
Console.WriteLine("Faturanın xml'i indirildi. Dosya yolu : " + xmlPath);
Console.ReadLine();

#endregion

#endregion

#endregion


#region E-Arşiv (E-Fatura Mükellefi değilse E-Arşiv gönderilir)

//EArchiveApi eArchive = new EArchiveApi();
//InvoiceResponse responseEArchive;

#region E-Arşiv Model olarak gönderir.
//responseEArchive = await eArchive.SendModel();
//Console.WriteLine($"UUID: {responseEArchive.UUID},\nFatura Numarası: {responseEArchive.InvoiceNumber}");
//Console.ReadLine();
#endregion


#region E-Arşivin Ubl Modelini XML'e çevirme
//var eArchivePath = await eArchive.UblConvertXml();
//Console.WriteLine("\nXml oluşturuldu. Dosya yolu: " + eArchivePath);
#endregion


#region E-Arşiv Xml olarak gönderir
//responseEArchive = await eArchive.SendXml();
//Console.WriteLine($"UUID: {responseEArchive.UUID},\nFatura Numarası: {responseEArchive.InvoiceNumber}");
//Console.ReadLine();
#endregion

#endregion


#region İrsaliye

//EDespatchApi despatchApi = new EDespatchApi();
//DespatchResponse despatchResponse;

#region Mükellef Sorgulama

//Console.WriteLine("TCKN ya da VKN giriniz : ");
//var TaxNumber = Console.ReadLine();
//var despatch = await despatchApi.CheckGlobalCompany(TaxNumber);

//if (despatch.Content.Any())
//{
//    foreach (var item in despatch.Content)
//    {
//        Console.WriteLine($"\n{item.FirstCreatedTime} Tarihinden İtibaren E-İrsaliye Mükellefidir.");
//        Console.WriteLine($"Ünvan : {item.Title}");
//        Console.WriteLine($"Etiket : {item.Name}");
//        Console.WriteLine($"Tipi : {item.Type}");
//        Console.WriteLine($"Etiket Oluşturulma Tarihi : {item.CreationTime}");
//        Console.WriteLine("******************************************************");
//    }
//}
//else
//{
//    Console.WriteLine("\nE-İrsaliye Mükellefi Değildir.\n");
//}
//Console.ReadLine();

#endregion

#region İrsaliyeyi Model olarak gönderir.
//despatchResponse = await despatchApi.SendModel();
//Console.WriteLine($"UUID: {despatchResponse.UUID}, \nDespatch Number: {despatchResponse.DespatchNumber}");
#endregion


#region İrsaliye Ubl Modelini Xml'e Çevirme

//var despatchPath = await despatchApi.UblConvertXml();
//Console.WriteLine("\nXml oluşturuldu. Dosya yolu : " + despatchPath);

#endregion


#region İrsaliyeyi Xml olarak gönderir

//despatchResponse = await despatchApi.SendXml();
//Console.WriteLine($"UUID: {despatchResponse.UUID}, \nDespatch Number: {despatchResponse.DespatchNumber}");
//Console.ReadLine();

#endregion

#endregion


#region Müstahsil

//EProducerApi producerApi = new EProducerApi();
//ProducerResponse producerResponse;

#region Müstahsil Model olarak gönderir.

//producerResponse = await producerApi.SendModel();
//Console.WriteLine($"UUID: {producerResponse.UUID}, \nProducer Number: {producerResponse.ProducerNumber}");

#endregion


#region Müstahsil Ubl Modelini Xml'e Çevirme

//var producerPath = await producerApi.UblConvertXml();
//Console.WriteLine("\nXml oluşturuldu. Dosya yolu : " + producerPath);

#endregion


#region Müstahsil Xml olarak gönderir

//producerResponse = await producerApi.SendXml();
//Console.WriteLine($"UUID: {producerResponse.UUID}, \nProducer Number: {producerResponse.ProducerNumber}");
//Console.ReadLine();

#endregion

#endregion


#region Serbest Meslek Makbuzu

//EVoucherApi voucherApi = new EVoucherApi();
//VoucherResponse voucherResponse;

#region Serbest meslek makbuzu Model olarak gönderir

//voucherResponse = await voucherApi.SendModel();
//Console.WriteLine($"UUID: {voucherResponse.UUID}, \nVoucher Number: {voucherResponse.VoucherNumber}");

#endregion


#region Serbest meslek makbuzu Ubl Modelini Xml'e çevirme 

//var voucherPath = await voucherApi.UblConvertXml();
//Console.WriteLine("\nXml oluşturuldu. Dosya yolu : " + voucherPath);

#endregion


#region Serbest meslek makbuzu Xml olarak gönderir

//voucherResponse = await voucherApi.SendXml();
//Console.WriteLine($"UUID: {voucherResponse.UUID}, \nVoucher Number: {voucherResponse.VoucherNumber}");
//Console.ReadLine();

#endregion

#endregion

