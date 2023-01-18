using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class EProducerLineDto
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string UnitType { get; set; }
        public decimal Price { get; set; }
        public List<TaxDto> Taxes { get; set; }
        public decimal GVWithholdingPercent { get; set; }
        public decimal GVWithholdingAmount { get; set; }
    }
}
