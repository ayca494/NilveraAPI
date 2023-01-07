using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class TouristInfoDto
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string CountryCode { get; set; }
        public string PassportNo { get; set; }
        public DateTime PassportDate { get; set; }
        public AddressInfoDto AddressInfo { get; set; }
        public FinancialAccountInfoDto FinancialAccountInfo { get; set; }
    }
}
