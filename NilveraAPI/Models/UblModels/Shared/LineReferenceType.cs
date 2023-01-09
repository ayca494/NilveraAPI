using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class LineReferenceType
    {
        public IDType LineID { get; set; }
        public DocumentCurrencyCode LineStatusCode { get; set; }
        public virtual DocumentReference DocumentReference { get; set; }
    }
}
