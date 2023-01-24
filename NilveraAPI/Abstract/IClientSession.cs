using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Abstract
{
    public interface IClientSession
    {
        public string ApiKey { get; }
        void SetApiKey(string apiKey);
    }
}
