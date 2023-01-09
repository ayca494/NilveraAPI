using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    public class DocumentReference
    {
        public IDType ID { get; set; }
        public string IssueDate { get; set; }
        public string DocumentTypeCode { get; set; }
        public string DocumentType { get; set; }
        public string DocumentDescription { get; set; }
        public virtual Attachment Attachment { get; set; }
        public virtual Period ValidityPeriod { get; set; }
        public virtual Party IssuerParty { get; set; }
    }
}
