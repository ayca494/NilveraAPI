using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class CorporateRegistrationScheme
    {
        public IDType ID { get; set; }
        public string Name { get; set; }
        public DocumentCurrencyCode CorporateRegistrationTypeCode { get; set; }
        public List<Address> JurisdictionRegionAddress { get; set; }
    }
}
