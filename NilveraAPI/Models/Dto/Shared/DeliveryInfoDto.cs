using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class DeliveryInfoDto
    {
        public string GTIPNo { get; set; }
        public string DeliveryTermCode { get; set; }
        public string TransportModeCode { get; set; }
        public string PackageBrandName { get; set; }
        public string ProductTraceID { get; set; }
        public string PackageID { get; set; }
        public decimal? PackageQuantity { get; set; }
        public string PackageTypeCode { get; set; }
        public AddressInfoDto DeliveryAddress { get; set; }
    }
}
