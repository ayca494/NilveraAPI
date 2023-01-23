using NilveraAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Request
{
    public interface IInvoiceApi<T>
    {
        public Task<T> SendModel();
        public Task<string> UblConvertXml();
        public Task<T> SendXml();
    }
}
