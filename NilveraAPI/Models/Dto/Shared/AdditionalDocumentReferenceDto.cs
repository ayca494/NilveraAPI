using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class AdditionalDocumentReferenceDto
    {
        public string ID { get; set; }
        public DateTime? IssueDate { get; set; }
        public string DocumentType { get; set; }
        public string DocumentTypeCode { get; set; }
        public string DocumentDescription { get; set; }
        public AttachmentDto Attachment { get; set; }
    }
}
