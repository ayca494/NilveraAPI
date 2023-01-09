using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class OrderReference
    {
        public IDType ID { get; set; }

        public IDType SalesOrderID { get; set; }

        public string IssueDate { get; set; }

        public DocumentCurrencyCode OrderTypeCode { get; set; }
        public virtual DocumentReference DocumentReference { get; set; }
    }
}
