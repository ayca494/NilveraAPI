using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class OKCInfoDto
    {
        public string ID { get; set; }
        public DateTime? IssueDate { get; set; }
        public string Time { get; set; }
        public string ZNo { get; set; }
        public string EndPointID { get; set; }
        public string DocumentDescription { get; set; }
    }
}
