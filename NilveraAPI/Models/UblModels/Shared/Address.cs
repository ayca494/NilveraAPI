using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class Address
    {
        public IDType ID { get; set; }
        public string Postbox { get; set; }
        public string Room { get; set; }
        public string StreetName { get; set; }
        public string BlockName { get; set; }
        public string BuildingName { get; set; }
        public string BuildingNumber { get; set; }
        public string CitySubdivisionName { get; set; }
        public string CityName { get; set; }
        public string PostalZone { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public virtual Country Country { get; set; }
    }
}
