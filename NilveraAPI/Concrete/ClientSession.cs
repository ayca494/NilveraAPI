using NilveraAPI.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Concrete
{
    public class ClientSession : IClientSession
    {
        public string ApiKey => _apiKey;
        private string _apiKey;
        public void SetApiKey(string apiKey)
        {
            _apiKey = apiKey;
        }
    }
}
