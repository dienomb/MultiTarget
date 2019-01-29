// .NET Framework 4.5.1 implementation
using System;
using System.Configuration;

namespace Library
{
    public class Hello : IHello
    {
        private readonly string txt;
        public Hello(string cons)
        {
            txt = cons;
        }
        //string ver = AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName;
        public string SayHello()
        {
            return $"Hello from net451 ()";
        }

        public int SayHello(int number)
        {
            string strVal = ConfigurationManager.AppSettings["serviceUrl"];
            return number;
        }
    }
}
