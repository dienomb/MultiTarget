using System;
using Library;

namespace ConsoleNetCore2
{
    class Program
    {
        static void Main(string[] args)
        {
            IHello hi = HelloFactory.GetThisPartyStarted(1);
            Console.WriteLine(hi.SayHello("hola"));
            Console.ReadKey();
        }
    }
}
