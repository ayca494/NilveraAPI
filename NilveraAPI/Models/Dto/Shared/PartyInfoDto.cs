using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class PartyInfoDto : AddressInfoDto
    {
        public string TaxNumber { get; set; }
        public string Name { get; set; }
        public string TaxOffice { get; set; }
        public List<IDTypeDto> PartyIdentifications { get; set; }
        public List<IDTypeDto> AgentPartyIdentifications { get; set; }
    }
}
