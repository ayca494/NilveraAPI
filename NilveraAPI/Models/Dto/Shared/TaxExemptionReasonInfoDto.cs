using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class TaxExemptionReasonInfoDto
    {
        public string KDVExemptionReasonCode { get; set; }
        public string OTVExemptionReasonCode { get; set; }
        public string AccommodationTaxExemptionReasonCode { get; set; }
    }
}
