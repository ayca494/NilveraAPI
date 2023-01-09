using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class Item
    {
        public string Description { get; set; } 
        public string Name { get; set; } 
        public string Keyword { get; set; } 
        public string BrandName { get; set; } 
        public string ModelName { get; set; } 
        public PartyIdentification BuyersItemIdentification { get; set; } 
        public PartyIdentification SellersItemIdentification { get; set; } 
        public PartyIdentification ManufacturersItemIdentification { get; set; } 
        public List<PartyIdentification> AdditionalItemIdentification { get; set; } 
        public List<CommodityClassification> CommodityClassification { get; set; } 
        public List<ItemInstance> ItemInstance { get; set; }
    }
}
