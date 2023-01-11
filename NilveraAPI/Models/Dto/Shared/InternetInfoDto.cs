using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class InternetInfoDto
    {
        public string WebSite { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentMethodName { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string TransporterName { get; set; }
        public string TransporterRegisterNumber { get; set; }
        public DateTime? TransportDate { get; set; }
    }
}
