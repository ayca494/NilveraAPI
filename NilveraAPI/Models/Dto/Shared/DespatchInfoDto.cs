using NilveraAPI.Enums;
using NilveraAPI.Models.UblModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class DespatchInfoDto
    {
        public Guid UUID { get; set; }
        public DateTime IssueDate { get; set; }
        //public DateTime? IssueTime { get; set; }
        //public string DespatchAdviceTypeCode { get; set; }
        public string TemplateBase64String { get; set; }
        public Guid TemplateUUID { get; set; }
        public DateTime ActualDespatchDateTime { get; set; }
        //public decimal Total { get; set; }
        public decimal PayableAmount { get; set; }
        public string CurrencyCode { get; set; }
        public DespatchType? DespatchType { get; set; }
        public DespatchProfile? DespatchProfile { get; set; }
        public string DespatchSerieOrNumber { get; set; }

        public DateTime? MatbuIssueDate { get; set; }
        public string MatbuNumber { get; set; }
    }
}
