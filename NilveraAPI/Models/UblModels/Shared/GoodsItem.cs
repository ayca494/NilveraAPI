using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("GoodsItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class GoodsItem
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("Description")]
        public List<string> Description { get; set; }

        [XmlElement("HazardousRiskIndicator")]
        public string HazardousRiskIndicator { get; set; }

        [XmlElement("DeclaredCustomsValueAmount")]
        public BaseCurrency DeclaredCustomsValueAmount { get; set; }

        [XmlElement("DeclaredForCarriageValueAmount")]
        public BaseCurrency DeclaredForCarriageValueAmount { get; set; }

        [XmlElement("DeclaredStatisticsValueAmount")]
        public BaseCurrency DeclaredStatisticsValueAmount { get; set; }

        [XmlElement("FreeOnBoardValueAmount")]
        public BaseCurrency FreeOnBoardValueAmount { get; set; }

        [XmlElement("InsuranceValueAmount")]
        public BaseCurrency InsuranceValueAmount { get; set; }

        [XmlElement("ValueAmount")]
        public BaseCurrency ValueAmount { get; set; }

        [XmlElement("GrossWeightMeasure")]
        public BaseUnit GrossWeightMeasure { get; set; }

        [XmlElement("NetWeightMeasure")]
        public BaseUnit NetWeightMeasure { get; set; }

        [XmlElement("ChargeableWeightMeasure")]
        public BaseUnit ChargeableWeightMeasure { get; set; }

        [XmlElement("GrossVolumeMeasure")]
        public BaseUnit GrossVolumeMeasure { get; set; }

        [XmlElement("NetVolumeMeasure")]
        public BaseUnit NetVolumeMeasure { get; set; }

        [XmlElement("Quantity")]
        public BaseUnit Quantity { get; set; }

        [XmlElement("RequiredCustomsID")]
        public IDType RequiredCustomsID { get; set; }

        [XmlElement("CustomsStatusCode")]
        public string CustomsStatusCode { get; set; }

        [XmlElement("CustomsImportClassifiedIndicator")]
        public bool? CustomsImportClassifiedIndicator { get; set; }

        public bool ShouldSerializeCustomsImportClassifiedIndicator()
        {
            return CustomsImportClassifiedIndicator.HasValue;
        }

        [XmlElement("ChargeableQuantity")]
        public BaseUnit ChargeableQuantity { get; set; }

        [XmlElement("ReturnableQuantity")]
        public BaseUnit ReturnableQuantity { get; set; }

        [XmlElement("TraceID")]
        public IDType TraceID { get; set; }

        [XmlElement("Item", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Item> Item { get; set; }

        [XmlElement("GoodsItemContainer", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<GoodsItemContainer> GoodsItemContainer { get; set; }

        [XmlElement("FreightAllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<AllowanceCharge> FreightAllowanceCharge { get; set; }

        [XmlElement("Temperature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Temperature> Temperature { get; set; }

        [XmlElement("ContainedGoodsItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<GoodsItem> ContainedGoodsItem { get; set; }

        [XmlElement("OriginAddress", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Address OriginAddress { get; set; }

        [XmlElement("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Delivery Delivery { get; set; }

        [XmlElement("Pickup", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Pickup Pickup { get; set; }

        [XmlElement("Despatch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DespatchModel Despatch { get; set; }

        [XmlElement("MeasurementDimension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Dimension> MeasurementDimension { get; set; }

        [XmlElement("ContainingPackage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Package> ContainingPackage { get; set; }

        [XmlElement("ShipmentDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReference ShipmentDocumentReference { get; set; }

        [XmlElement("MinimumTemperature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Temperature MinimumTemperature { get; set; }

        [XmlElement("MaximumTemperature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Temperature MaximumTemperature { get; set; }

        [XmlElement("InvoiceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public InvoiceLine InvoiceLine { get; set; }
    }
}
