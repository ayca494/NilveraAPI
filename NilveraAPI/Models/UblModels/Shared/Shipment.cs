using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Shipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class Shipment
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("HandlingCode")]
        public DocumentCurrencyCode HandlingCode { get; set; }

        [XmlElement("HandlingInstructions")]
        public string HandlingInstructions { get; set; }

        [XmlElement("GrossWeightMeasure")]
        public BaseUnit GrossWeightMeasure { get; set; }

        [XmlElement("NetWeightMeasure")]
        public BaseUnit NetWeightMeasure { get; set; }

        [XmlElement("GrossVolumeMeasure")]
        public BaseUnit GrossVolumeMeasure { get; set; }

        [XmlElement("NetVolumeMeasure")]
        public BaseUnit NetVolumeMeasure { get; set; }

        [XmlElement("TotalGoodsItemQuantity")]
        public BaseUnit TotalGoodsItemQuantity { get; set; }

        [XmlElement("TotalTransportHandlingUnitQuantity")]
        public BaseUnit TotalTransportHandlingUnitQuantity { get; set; }

        [XmlElement("InsuranceValueAmount")]
        public BaseCurrency InsuranceValueAmount { get; set; }

        [XmlElement("DeclaredCustomsValueAmount")]
        public BaseCurrency DeclaredCustomsValueAmount { get; set; }

        [XmlElement("DeclaredForCarriageValueAmount")]
        public BaseCurrency DeclaredForCarriageValueAmount { get; set; }

        [XmlElement("DeclaredStatisticsValueAmount")]
        public BaseCurrency DeclaredStatisticsValueAmount { get; set; }

        [XmlElement("FreeOnBoardValueAmount")]
        public BaseCurrency FreeOnBoardValueAmount { get; set; }

        [XmlElement("SpecialInstructions")]
        public List<string> SpecialInstructions { get; set; }

        [XmlElement("Consignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Consignment> Consignment { get; set; }

        [XmlElement("GoodsItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<GoodsItem> GoodsItem { get; set; }

        [XmlElement("ShipmentStage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<ShipmentStage> ShipmentStage { get; set; }

        [XmlElement("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Delivery Delivery { get; set; }

        [XmlElement("TransportHandlingUnit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<TransportHandlingUnit> TransportHandlingUnit { get; set; }

        [XmlElement("ReturnAddress", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Address ReturnAddress { get; set; }

        [XmlElement("FirstArrivalPortLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Location FirstArrivalPortLocation { get; set; }

        [XmlElement("LastExitPortLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Location LastExitPortLocation { get; set; }
    }
}
