// .NET Standard 2.0 implementation
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.IO;
namespace Library
{
    public class Hello : IHello
    {
        private readonly int num;
        public Hello(int cons)
        {
            num = cons;
        }
        //string ver = Assembly.GetEntryAssembly()?.GetCustomAttribute<TargetFrameworkAttribute>()?.FrameworkName;
        public string SayHello()
        {
            return $"Hello from netstandard2_0 ()";
        }

        public string SayHello(string mess)
        {
            string strVal = ConfigurationManager.AppSettings["serviceUrl"];
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory()) // Directory where the json files are located
            .AddJsonFile("config.json", optional: false, reloadOnChange: true)
            .Build();
            string jsonservice = configuration["serviceUrl"];

            return mess;
        }
    }
}
