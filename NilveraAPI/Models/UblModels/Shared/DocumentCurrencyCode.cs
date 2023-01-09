using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class DocumentCurrencyCode
    {
        public string Name { get; set; }
        public string ListID { get; set; }
        public string ListAgencyName { get; set; }
        public string ListName { get; set; }
        public string ListVersionID { get; set; }
    }
}
