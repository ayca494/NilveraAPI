using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class PartyIdentification
    {
        public IDType ID { get; set; }
        public string SchemeID { get; set; }
    }
}
