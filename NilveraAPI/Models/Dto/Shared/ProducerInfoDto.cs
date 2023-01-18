using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class ProducerInfoDto
    {
        public Guid UUID { get; set; }
        public Guid TemplateUUID { get; set; }
        public string TemplateBase64String { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string ProducerSerieOrNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? ExchangeRate { get; set; }
    }
}
