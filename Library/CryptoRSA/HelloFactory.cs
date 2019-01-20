using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public static class HelloFactory
    {
#if NETSTANDARD
        public static IHello GetThisPartyStarted(int val)
        {
            return new Hello(val);
        }
#endif
#if NETFRAMEWORK
        public static IHello GetThisPartyStarted(string mess)
        {
            return new Hello(mess);
        }
#endif

    }
}
