using NilveraAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models
{
    public class ArchiveInvoiceModel
    {
        public ArchiveInvoiceDto ArchiveInvoice { get; set; }
        public string CustomerAlias { get; set; }
    }
}
