using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class Consignment
    {
        public IDType ID { get; set; }
        public BaseCurrency TotalInvoiceAmount { get; set; }
    }
}
