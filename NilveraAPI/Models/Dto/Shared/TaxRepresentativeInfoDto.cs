using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class TaxRepresentativeInfoDto
    {
        public string RegisterNumber { get; set; }
        public string Alias { get; set; }
        public AddressInfoDto Address { get; set; }
    }
}
