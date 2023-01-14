using NilveraAPI.Models.UblModels.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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



        
    }



}


