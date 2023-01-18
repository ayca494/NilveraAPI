using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.CheckGlobalCompany
{
    public class GlobalCompanyInfoResponse
    {
        public string TaxNumber { get; set; }
        public string Title { get; set; }
        public DateTime FirstCreatedTime { get; set; }
        public DateTime CreationTime { get; set; }
        public string DocumentType { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
