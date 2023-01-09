using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class ItemInstance
    {
        public IDType ProductTraceID { get; set; } 
        public string ManufactureDate { get; set; } 
        public string ManufactureTime { get; set; } 
        public string BestBeforeDate { get; set; } 
        public IDType RegistrationID { get; set; } 
        public IDType SerialID { get; set; } 
        public ItemProperty AdditionalItemProperty { get; set; } 
        public LotIdentification LotIdentification { get; set; }
    }
}
