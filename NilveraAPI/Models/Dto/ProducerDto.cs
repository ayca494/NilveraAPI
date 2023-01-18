using NilveraAPI.Models.Dto.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto
{
    public class ProducerDto
    {
        public ProducerInfoDto ProducerInfo { get; set; }
        public PartyInfoDto CompanyInfo { get; set; }
        public PartyInfoDto CustomerInfo { get; set; }
        public List<EProducerLineDto> ProducerLines { get; set; }
        public List<string> Notes { get; set; }
    }
}
