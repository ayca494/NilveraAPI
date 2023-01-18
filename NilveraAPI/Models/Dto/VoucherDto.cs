using NilveraAPI.Models.Dto.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto
{
    public class VoucherDto
    {
        public VoucherInfoDto VoucherInfo { get; set; }
        public PartyInfoDto CompanyInfo { get; set; }
        public PartyInfoDto CustomerInfo { get; set; }
        public List<EVoucherLineDto> VoucherLines { get; set; }
        public List<string> Notes { get; set; }
    }
}
