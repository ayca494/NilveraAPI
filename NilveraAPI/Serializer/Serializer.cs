using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace NilveraAPI.Serializer
{
    public static class Serializer
    {
        public static async Task<string> SerializeAsync<T>(T value, XmlSerializerNamespaces xmlns, string xslt = null) where T : class
        {
            return value == null ? null : Encoding.UTF8.GetString(await XmlSerializeToByteAsync(value, xmlns, xslt));
        }
        private static async Task<byte[]> XmlSerializeToByteAsync<T>(T value, XmlSerializerNamespaces xmlns, string xslt = null) where T : class
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

        public static string CleanXmlContent(string content)
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
        public static string LoadOrCreatePdf(string content)
        {
            string directory_path = AppDomain.CurrentDomain.BaseDirectory + "Dosyalar\\PDF";
            string file_path = AppDomain.CurrentDomain.BaseDirectory + "Dosyalar\\PDF\\Fatura.pdf";

            if (Directory.Exists(directory_path) == false)
            {
                Directory.CreateDirectory(directory_path);
            }

            FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate);
            fs.Flush();
            fs.Close();
            File.Delete(file_path);

            byte[] pdf = Convert.FromBase64String(content);

            File.WriteAllBytes(file_path, pdf);

            return file_path;
        }

        public static string LoadOrCreateHtml(string content)
        {
            string directory_path = AppDomain.CurrentDomain.BaseDirectory + "Dosyalar\\HTML";
            string file_path = AppDomain.CurrentDomain.BaseDirectory + "Dosyalar\\HTML\\Fatura.html";

            if (Directory.Exists(directory_path) == false)
            {
                Directory.CreateDirectory(directory_path);
            }

            FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate);
            fs.Flush();
            fs.Close();
            File.Delete(file_path);

            File.WriteAllText(file_path, content);

            return file_path;
        }

        public static string LoadOrCreateXml(string content)
        {
            string directory_path = AppDomain.CurrentDomain.BaseDirectory + "Dosyalar\\XML";
            string file_path = AppDomain.CurrentDomain.BaseDirectory + "Dosyalar\\XML\\Fatura.xml";

            if (Directory.Exists(directory_path) == false)
            {
                Directory.CreateDirectory(directory_path);
            }

            FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate);
            fs.Flush();
            fs.Close();
            File.Delete(file_path);

            File.WriteAllText(file_path, content);

            return file_path;
        }
    }
}
