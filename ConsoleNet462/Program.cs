using System;
using System.Configuration;
using Library;

namespace ConsoleNet462
{
    class Program
    {
        static void Main(string[] args)
        {
            string strVal = ConfigurationManager.AppSettings["serviceUrl"];
            IHello hi = HelloFactory.GetThisPartyStarted("text");
            Console.WriteLine(hi.SayHello(5));
            Console.ReadKey();
        }
    }
}
