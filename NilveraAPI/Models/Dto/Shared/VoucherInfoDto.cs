using NilveraAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class VoucherInfoDto
    {
        public Guid UUID { get; set; }
        public Guid TemplateUUID { get; set; }
        public string TemplateBase64String { get; set; }
        public string VoucherSerieOrNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public string CurrencyCode { get; set; }
        public SendType? SendType { get; set; }
        public decimal? ExchangeRate { get; set; }
    }
}
