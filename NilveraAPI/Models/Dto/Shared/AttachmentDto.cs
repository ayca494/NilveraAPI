using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto.Shared
{
    public class AttachmentDto
    {
        public string Base64Data { get; set; }
        public string MimeCode { get; set; }
        public string FileName { get; set; }
    }
}
