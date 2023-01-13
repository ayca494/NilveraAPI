using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Manifest")]
    public class Manifest
    {
        private List<ManifestItem> _manifestItem;

        [XmlElement("NumberOfItems")]
        public int NumberOfItems { get; set; }

        [XmlElement("ManifestItem", Type = typeof(ManifestItem))]
        public List<ManifestItem> ManifestItems
        {
            get => _manifestItem;
            set => _manifestItem = value ?? new List<ManifestItem>();
        }
    }
}
