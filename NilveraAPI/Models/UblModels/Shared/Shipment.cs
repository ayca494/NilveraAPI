using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class Shipment
    { 
        public IDType ID { get; set; } 
        public DocumentCurrencyCode HandlingCode { get; set; } 
        public string HandlingInstructions { get; set; } 
        public BaseUnit GrossWeightMeasure { get; set; } 
        public BaseUnit NetWeightMeasure { get; set; } 
        public BaseUnit GrossVolumeMeasure { get; set; } 
        public BaseUnit NetVolumeMeasure { get; set; } 
        public BaseUnit TotalGoodsItemQuantity { get; set; } 
        public BaseUnit TotalTransportHandlingUnitQuantity { get; set; } 
        public BaseCurrency InsuranceValueAmount { get; set; } 
        public BaseCurrency DeclaredCustomsValueAmount { get; set; } 
        public BaseCurrency DeclaredForCarriageValueAmount { get; set; } 
        public BaseCurrency DeclaredStatisticsValueAmount { get; set; } 
        public BaseCurrency FreeOnBoardValueAmount { get; set; } 
        public List<string> SpecialInstructions { get; set; } 
        public List<Consignment> Consignment { get; set; } 
        public List<GoodsItem> GoodsItem { get; set; } 
        public List<ShipmentStage> ShipmentStage { get; set; } 
        public Delivery Delivery { get; set; } 
        public List<TransportHandlingUnit> TransportHandlingUnit { get; set; } 
        public Address ReturnAddress { get; set; } 
        public Location FirstArrivalPortLocation { get; set; } 
        public Location LastExitPortLocation { get; set; }
    }
}
