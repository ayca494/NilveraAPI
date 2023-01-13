using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("UBLExtension")]
    public class UBLExtension
    {
        private ExtensionContent _extensionContent;

        [XmlElement("ExtensionContent")]
        public virtual ExtensionContent ExtensionContent
        {
            get => _extensionContent;
            set
            {
                if (value != null)
                {
                    _extensionContent = value;
                }
                else
                {
                    _extensionContent = new ExtensionContent();
                }
            }
        }
    }
}
