using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class ShipmentDetailDto
    {
        public ShipmentInfoDto ShipmentInfo { get; set; }
        public DeliveryDto Delivery { get; set; }
        public List<string> TransportEquipment { get; set; }
    }
}
