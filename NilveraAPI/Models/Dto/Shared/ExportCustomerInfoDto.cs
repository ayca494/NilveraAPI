﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class ExportCustomerInfoDto
    {
        public string TaxNumber { get; set; }
        public string LegalRegistrationName { get; set; }

        public string PersonName { get; set; }
        public string PersonSurName { get; set; }

        public string Address { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string WebSite { get; set; }
    }
}
