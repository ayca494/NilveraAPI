using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class TaxDto
    {
        public string TaxCode { get; set; }
        public decimal? Total { get; set; }
        public decimal? Percent { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonDesc { get; set; }
    }
}
