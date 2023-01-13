using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Package", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class Package
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("Quantity")]
        public BaseUnit Quantity { get; set; }

        [XmlElement("ReturnableMaterialIndicator")]
        public bool? ReturnableMaterialIndicator { get; set; }

        public bool ShouldSerializeReturnableMaterialIndicator()
        {
            return ReturnableMaterialIndicator.HasValue;
        }

        [XmlElement("PackageLevelCode")]
        public DocumentCurrencyCode PackageLevelCode { get; set; }

        [XmlElement("PackagingTypeCode")]
        public string PackagingTypeCode { get; set; }

        [XmlElement("PackingMaterial")]
        public List<string> PackingMaterial { get; set; }

        [XmlElement("ContainedPackage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Package> ContainedPackage { get; set; }

        [XmlElement("GoodsItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<GoodsItem> GoodsItem { get; set; }

        [XmlElement("MeasurementDimension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Dimension> MeasurementDimension { get; set; }
    }
}
