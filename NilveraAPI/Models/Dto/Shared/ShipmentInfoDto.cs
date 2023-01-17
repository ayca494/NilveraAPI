using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class ShipmentInfoDto
    {
        public List<DriverPersonDto> DriverPerson { get; set; }
        public string LicensePlateID { get; set; }
    }
}
