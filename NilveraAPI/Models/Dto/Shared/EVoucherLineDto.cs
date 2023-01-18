using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class EVoucherLineDto
    {
        public string Name { get; set; }
        public decimal GrossWage { get; set; }
        public decimal Price { get; set; }
        public decimal KDVPercent { get; set; }
        public decimal KDVTotal { get; set; }
        public List<TaxDto> Taxes { get; set; }
        public decimal GVWithholdingPercent { get; set; }
        public decimal GVWithholdingTotal { get; set; }
    }
}
