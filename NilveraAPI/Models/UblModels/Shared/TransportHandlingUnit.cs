using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("TransportHandlingUnit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportHandlingUnit
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("TransportHandlingUnitTypeCode")]
        public DocumentCurrencyCode TransportHandlingUnitTypeCode { get; set; }

        [XmlElement("HandlingCode")]
        public DocumentCurrencyCode HandlingCode { get; set; }

        [XmlElement("HandlingInstructions")]
        public string HandlingInstructions { get; set; }

        [XmlElement("HazardousRiskIndicator")]
        public bool? HazardousRiskIndicator { get; set; }

        public bool ShouldSerializeHazardousRiskIndicator()
        {
            return HazardousRiskIndicator.HasValue;
        }

        [XmlElement("TotalGoodsItemQuantity")]
        public BaseUnit TotalGoodsItemQuantity { get; set; }

        [XmlElement("TotalPackageQuantity")]
        public BaseUnit TotalPackageQuantity { get; set; }

        [XmlElement("DamageRemarks")]
        public List<string> DamageRemarks { get; set; }

        [XmlElement("TraceID")]
        public IDType TraceID { get; set; }

        [XmlElement("ActualPackage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Package> ActualPackage { get; set; }

        [XmlElement("TransportEquipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<TransportEquipment> TransportEquipment { get; set; }

        [XmlElement("TransportMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<TransportMeans> TransportMeans { get; set; }

        [XmlElement("HazardousGoodsTransit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<HazardousGoodsTransit> HazardousGoodsTransit { get; set; }

        [XmlElement("MeasurementDimension")]
        public List<Dimension> MeasurementDimension { get; set; }

        [XmlElement("MinimumTemperature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Temperature MinimumTemperature { get; set; }

        [XmlElement("MaximumTemperature")]
        public Temperature MaximumTemperature { get; set; }

        [XmlElement("FloorSpaceMeasurementDimension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Dimension FloorSpaceMeasurementDimension { get; set; }

        [XmlElement("PalletSpaceMeasurementDimension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Dimension PalletSpaceMeasurementDimension { get; set; }

        [XmlElement("ShipmentDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<DocumentReference> ShipmentDocumentReference { get; set; }

        [XmlElement("CustomsDeclaration", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<CustomsDeclaration> CustomsDeclaration { get; set; }
    }
}
