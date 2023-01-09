using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class Delivery
    {
        public IDType ID { get; set; }
        public BaseUnit Quantity { get; set; }
        public string ActualDeliveryDate { get; set; }
        public string ActualDeliveryTime { get; set; }
        public string LatestDeliveryDate { get; set; }
        public string LatestDeliveryTime { get; set; }
        public IDType TrackingID { get; set; }
        public Address DeliveryAddress { get; set; }
        public Location AlternativeDeliveryLocation { get; set; }
        public Period EstimatedDeliveryPeriod { get; set; }
        public Party CarrierParty { get; set; }
        public Party DeliveryParty { get; set; }
        public DespatchModel Despatch { get; set; }
        public List<DeliveryTerms> DeliveryTerms { get; set; }
        public Shipment Shipment { get; set; }
    }
}
