using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Package", Namespace = "")]
    public class EnvelopePackage
    {
        private List<PackageElement> _elements;

        [XmlElement("Elements", Type = typeof(PackageElement))]
        public virtual List<PackageElement> PackageElements
        {
            get => _elements;
            set => _elements = value ?? new List<PackageElement>();
        }
    }
}
