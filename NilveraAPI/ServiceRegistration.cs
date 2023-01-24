using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NilveraAPI.Abstract;
using NilveraAPI.Request;
using NilveraAPI.Request.E_Archive;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI
{
    public class ServiceRegistration
    {
        private static IServiceProvider _serviceProvider;
        public static IServiceProvider Services { get => _serviceProvider; }
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                                    .AddSingleton<IConfiguration>(instance => new ConfigurationBuilder()
             .SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
             .AddJsonFile("appsetting.json")
             .Build())
                                    .BuildServiceProvider();

            _serviceProvider = serviceProvider;

        }
    }
}