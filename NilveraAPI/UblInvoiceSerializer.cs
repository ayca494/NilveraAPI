using NilveraAPI.Models.UblModels.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace NilveraAPI
{
    public class UblInvoiceSerializer
    {
        public readonly XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();

        public UblInvoiceSerializer()
        {
            xmlns.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            xmlns.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
            xmlns.Add("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2");
            xmlns.Add("ccts", "urn:un:unece:uncefact:documentation:2");
            xmlns.Add("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
            xmlns.Add("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
            xmlns.Add("ubltr", "urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents");
            xmlns.Add("ds", "http://www.w3.org/2000/09/xmldsig#");
            xmlns.Add("xades", "http://uri.etsi.org/01903/v1.3.2#");
            xmlns.Add("xsd", "http://www.w3.org/2001/XMLSchema");
            xmlns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            xmlns.Add("", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2");
        }
        public async Task<string> SerializeAsync<T>(T value, XmlSerializerNamespaces xmlns, string xslt = null) where T : class
        {
            return value == null ? null : Encoding.UTF8.GetString(await XmlSerializeToByteAsync<T>(value, xmlns, xslt));
        }
        private async Task<byte[]> XmlSerializeToByteAsync<T>(T value, XmlSerializerNamespaces xmlns, string xslt = null) where T : class
        {
            if (value == null)
            {
                return null;
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(memoryStream))
                {
                    if (!string.IsNullOrEmpty(xslt))
                    {
                        await xmlWriter.WriteProcessingInstructionAsync("xml-stylesheet", "type=\"text/xsl\" href=\"" + xslt + "\"");
                    }

                    xmlSerializer.Serialize(xmlWriter, value, xmlns);
                    return memoryStream.ToArray();
                }
            }
        }

        public string CleanXmlContent(string content)
        {
            string empty = string.Empty;
            int startIndex = content.IndexOf("<?");
            int num = 0;
            if (startIndex >= 0)
            {
                num = content.IndexOf("?>", startIndex);
            }

            return startIndex < 0 || num < 0 ? content : content.Substring(num + 2, content.Length - (num + 2));
        }


        public string LoadOrCreateXML(string content)
        {
            XDocument xDoc = new XDocument();
            string directory_path = AppDomain.CurrentDomain.BaseDirectory + "XML";
            string file_path = AppDomain.CurrentDomain.BaseDirectory + "XML\\Fatura.xml";

            // eğer bu klasör yoksa klasörü açacak
            if (Directory.Exists(directory_path) == false)
            {
                Directory.CreateDirectory(directory_path);
            }

            // eğer bu xml dosya yoksa temel bir xml dosyası oluşturacağız.
            if (File.Exists(file_path) == false)
            {
                // verdiğimiz xml dosya yolunda xml dosya oluşturuluyor.
                FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate);

                
                fs.Flush();
                fs.Close();

                // oluşturulan xml dosyasının okunabilmesi için gerekli olan şeyleri içerisine yazdık.
                File.AppendAllText(file_path, content);

                // xml dosyasını yükledik
                xDoc = XDocument.Load(file_path);
            }
            else
            {
                // zaten bir xml dosyası vardır ve onu yükledik.
                xDoc = XDocument.Load(file_path);
            }

            // xml dosyamızdaki verileri datagirdview de  gösterdik.
            return(file_path);
        }



    }



}


