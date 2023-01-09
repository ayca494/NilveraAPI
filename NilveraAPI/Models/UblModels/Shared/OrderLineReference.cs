using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class OrderLineReference
    {
        public IDType LineID { get; set; }

        public IDType SalesOrderLineID { get; set; }

        public string UUID { get; set; }

        public DocumentCurrencyCode LineStatusCode { get; set; }
        public virtual OrderReference OrderReference { get; set; }
    }
}
