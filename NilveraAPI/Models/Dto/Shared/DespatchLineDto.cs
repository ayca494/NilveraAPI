using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class DespatchLineDto
    {
        public string DeliveredUnitType { get; set; }
        public string DeliveredUnitName { get; set; }
        public string Name { get; set; } //
        public string SellerCode { get; set; } //
        public string BuyerCode { get; set; } //
        public string Description { get; set; } //
        public decimal DeliveredQuantity { get; set; } //
        public decimal QuantityPrice { get; set; } //birimfiyat
        public decimal LineTotal { get; set; } //toplam tutar
        public string AdditionalItemIdentification { get; set; }
        public decimal OutstandingQuantity { get; set; }
        public string OutstandingUnitType { get; set; }
        public string OutstandingUnitName { get; set; }
        public string OutstandingReason { get; set; }
        public string ManufacturerCode { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
    }
}
