using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class DeliveryDto
    {
        public AddressInfoDto AddressInfo { get; set; }
        public CarrierInfoDto CarrierInfo { get; set; }
    }
}
