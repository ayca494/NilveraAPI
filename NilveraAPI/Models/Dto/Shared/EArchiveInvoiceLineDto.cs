using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class EArchiveInvoiceLineDto
    {
        public string Index { get; set; }
        public string SellerCode { get; set; }
        public string BuyerCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public string UnitType { get; set; }
        public decimal Price { get; set; }
        public decimal AllowanceTotal { get; set; }
        public decimal KDVPercent { get; set; }
        public decimal KDVTotal { get; set; }
        public List<TaxDto> Taxes { get; set; }
        public string ManufacturerCode { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string Note { get; set; }
        public string? OzelMatrahReason { get; set; }
        public decimal? OzelMatrahTotal { get; set; }
        public AdditionalItemIdentificationDto AdditionalItemIdentification { get; set; }
    }
}
