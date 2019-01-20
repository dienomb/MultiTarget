using System;
using Library;

namespace ConsoleNet451
{
    class Program
    {
        static void Main(string[] args)
        {
            IHello hi = HelloFactory.GetThisPartyStarted("text");
            Console.WriteLine(hi.SayHello(5));
            Console.ReadKey();
        }
    }
}
