using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class Contact
    {
        public string Telephone { get; set; }
        public string Telefax { get; set; }
        public string ElectronicMail { get; set; }
        public string Note { get; set; }
        public virtual List<Communication> OtherCommunications { get; set; }
    }
}
