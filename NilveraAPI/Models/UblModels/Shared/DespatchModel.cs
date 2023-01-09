using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class DespatchModel
    {
        public IDType ID { get; set; }
        public string ActualDespatchDate { get; set; }
        public string ActualDespatchTime { get; set; }
        public string Instructions { get; set; }
        public Address DespatchAddress { get; set; }
        public Party DespatchParty { get; set; }
        public Contact Contact { get; set; }
        public Period EstimatedDespatchPeriod { get; set; }
    }
}
